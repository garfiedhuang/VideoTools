using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com.Garfield.VideoTools
{
    public partial class MainForm : Form
    {
        private Parameters FFMpegParameters;
        private string FFMpegPath;
        public MainForm()
        {
            InitializeComponent();
            FFMpegParameters = new Parameters();
            FFMpegParameters.InputDirectory = System.Configuration.ConfigurationManager.AppSettings["InputDirectory"];
            FFMpegParameters.OutputDirectory = System.Configuration.ConfigurationManager.AppSettings["OutputDirectory"];

            this.txtVideoInputDirectory.Text = FFMpegParameters.InputDirectory;
            this.txtVideoOutputDirectory.Text = FFMpegParameters.OutputDirectory;

            FFMpegParameters.WaterDrections = new List<WaterDrection>();
            FFMpegParameters.WaterDrections.Add(WaterDrection.TopLeftCorner);
            FFMpegParameters.Location = new WaterLocation()
            {
                X = Convert.ToSingle(System.Configuration.ConfigurationManager.AppSettings["WaterLocationX"]),
                Y = Convert.ToSingle(System.Configuration.ConfigurationManager.AppSettings["WaterLocationY"])
            };

            this.txtWaterX.Text = FFMpegParameters.Location.X.ToString();
            this.txtWaterY.Text = FFMpegParameters.Location.Y.ToString();

            FFMpegPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, System.Configuration.ConfigurationManager.AppSettings["FFmpegPath"]);

            this.openFileDialog1.Filter = "水印图片|*.png;*.jpg;*.jpeg";
            this.openFileDialog1.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "water");
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.FilterIndex = 1;
        }

        private void btnSelectVideoInputDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                var result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.txtVideoInputDirectory.Text = folderBrowserDialog1.SelectedPath;
                    FFMpegParameters.InputDirectory = folderBrowserDialog1.SelectedPath;
                    var outputPath = Path.Combine(folderBrowserDialog1.SelectedPath, "output");
                    this.txtVideoOutputDirectory.Text = outputPath;
                    FFMpegParameters.OutputDirectory = outputPath;
                }
            }
            catch (Exception ex)
            {
                WriteLog(ex.Message);
            }
        }

        private void btnSelectVideoOutputDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                var result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.txtVideoOutputDirectory.Text = folderBrowserDialog1.SelectedPath;
                    FFMpegParameters.OutputDirectory = folderBrowserDialog1.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                WriteLog(ex.Message);
            }
        }

        private void btnOpenDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                string path = this.txtVideoOutputDirectory.Text.Trim();
                if (string.IsNullOrEmpty(path)) throw new Exception("输出目录不能为空！");
                var result = System.Diagnostics.Process.Start("explorer.exe", path);

                //关闭处理程序
                result.Close();
            }
            catch (Exception ex)
            {
                WriteLog(ex.Message);
            }
        }

        private void btnSelectWaterPicture_Click(object sender, EventArgs e)
        {
            try
            {
                var result = this.openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.txtWaterPicture.Text = openFileDialog1.FileName;
                    FFMpegParameters.WaterPath = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                WriteLog(ex.Message);
            }
        }

        private void chkTopLeftCorner_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTopLeftCorner.Checked && !FFMpegParameters.WaterDrections.Contains(WaterDrection.TopLeftCorner))
            {
                FFMpegParameters.WaterDrections.Add(WaterDrection.TopLeftCorner);
            }
            else
            {
                FFMpegParameters.WaterDrections.Remove(WaterDrection.TopLeftCorner);
            }
        }

        private void chkTopRightCorner_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTopRightCorner.Checked && !FFMpegParameters.WaterDrections.Contains(WaterDrection.TopRightCorner))
            {
                FFMpegParameters.WaterDrections.Add(WaterDrection.TopRightCorner);
            }
            else
            {
                FFMpegParameters.WaterDrections.Remove(WaterDrection.TopRightCorner);
            }
        }

        private void chkBottomLeftCorner_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBottomLeftCorner.Checked && !FFMpegParameters.WaterDrections.Contains(WaterDrection.BottomLeftCorner))
            {
                FFMpegParameters.WaterDrections.Add(WaterDrection.BottomLeftCorner);
            }
            else
            {
                FFMpegParameters.WaterDrections.Remove(WaterDrection.BottomLeftCorner);
            }
        }

        private void chkBottomRightCorner_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBottomRightCorner.Checked && !FFMpegParameters.WaterDrections.Contains(WaterDrection.BottomRightCorner))
            {
                FFMpegParameters.WaterDrections.Add(WaterDrection.BottomRightCorner);
            }
            else
            {
                FFMpegParameters.WaterDrections.Remove(WaterDrection.BottomRightCorner);
            }
        }

        private void chkIsGenerateThumbnail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsGenerateThumbnail.Checked)
            {
                FFMpegParameters.IsGenerateThumbnail = true;
            }
            else
            {
                FFMpegParameters.IsGenerateThumbnail = false;
            }
        }

        private void txtWaterX_TextChanged(object sender, EventArgs e)
        {
            FFMpegParameters.Location.X = Convert.ToSingle(this.txtWaterX.Text.Trim());
        }

        private void txtWaterY_TextChanged(object sender, EventArgs e)
        {
            FFMpegParameters.Location.Y = Convert.ToSingle(this.txtWaterY.Text.Trim());
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var result = CheckParameters();
            if (!string.IsNullOrEmpty(result))
            {
                WriteLog(result);
            }
            else
            {
                //组装ffmpeg命令

                //适合同时转换格式和加水印
                //-i orignal.flv - i water.png - filter_complex \"overlay=10:10\" -y -b 1024k -acodec copy -f mp4

                //适合只加水印，不做格式转换
                //- i orignal.flv - i water.png - filter_complex \"overlay=10:10\" -b 1024k -acodec copy

                //ffmpeg命令添加文字水印
                //ffmpeg - i input.flv - vf "drawtext=fontfile=simhei.ttf: text='雷':x=100:y=10:fontsize=24:fontcolor=yellow:shadowy=2" drawtext.mp4

                //使用这些变量，我们可以将水印定位在视频的中心，如下所示：
                //ffmpeg - i birds.mp4 - i watermark.png
                //  - filter_complex "overlay=x=(main_w-overlay_w)/2:y=(main_h-overlay_h)/2" birds2.mp4
                //   如果我们想要为剪辑添加品牌或水印，但不覆盖现有视频，我们可以使用pad过滤器为剪辑添加一些填充，然后将我们的水印放在填充上，如下所示：
                //ffmpeg - i birds.mp4 - i watermark2.png
                //  - filter_complex "pad=height=ih+40:color=#71cbf4,overlay=(main_w-overlay_w)/2:main_h-overlay_h"
                //birds3.mp4
                //一旦你开始得到这个的概念之后，你甚至可以让你的水印动起来！
                //ffmpeg - i birds.mp4 - i watermark.png
                //  - filter_complex "overlay='if(gte(t,1), -w+(t-1)*200, NAN)':(main_h-overlay_h)/2" birds4.mp4

                FFmpegHelper mpeg = new FFmpegHelper();
                mpeg.FFmpegPath = FFMpegPath;
                foreach (var file in FFMpegParameters.SoureFiles)
                {
                    try
                    {
                        var outputPath = Path.Combine(FFMpegParameters.OutputDirectory, Path.GetFileName(file));
                        var location = $"{FFMpegParameters.Location.X}:{FFMpegParameters.Location.Y}";
                        var waterLocation = string.Empty;
                        var waterPicture = string.Empty;

                        if (FFMpegParameters.WaterDrections.Count == 2)
                        {
                            waterLocation = $"[0:v][1:v]overlay={location}/1[bkg];[bkg][2:v]overlay=main_w-overlay_w-{location}";
                            waterPicture = $"-i {FFMpegParameters.WaterPath.Replace("water.png", "black_water.png")} -i {FFMpegParameters.WaterPath} ";
                        }
                        else
                        {
                            waterLocation = $"overlay=main_w-overlay_w-{location}";
                            waterPicture = $"-i {FFMpegParameters.WaterPath}";
                        }
                        var cmd = $"-i {file} {waterPicture} -filter_complex \"{waterLocation}\" {outputPath}";
                        //var cmd = $"-i {file} -i {FFMpegParameters.WaterPath} -filter_complex \"pad=height=ih+40:color=#71cbf4,overlay={FFMpegParameters.Location.X}:{FFMpegParameters.Location.Y}\" {outputPath}";
                        //var cmd = $"-i {file} -i {FFMpegParameters.WaterPath} -filter_complex \"overlay={FFMpegParameters.Location.X}:{FFMpegParameters.Location.Y}\" -b 1024k -acodec copy {outputPath}";
                        WriteLog($"FFMpegPath：{ FFMpegPath}");
                        WriteLog($"视频路径：{ file}");
                        WriteLog($"输出目录：{FFMpegParameters.OutputDirectory}");
                        WriteLog($"输出文件路径：{outputPath}");
                        WriteLog($"FFMpeg命令：{cmd}");
                        WriteLog($"FFMpeg命令执行开始时间：{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:fff")}");
                        result = mpeg.RunProcess(cmd);
                        WriteLog($"FFMpeg命令执行结束时间：{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:fff")}");
                        if (!string.IsNullOrEmpty(result)) WriteLog(result);
                        WriteLog("====================================================");
                    }
                    catch (Exception ex)
                    {
                        WriteLog(ex.Message);
                        break;
                    }
                }
            }
        }

        private string CheckParameters()
        {
            if (string.IsNullOrEmpty(FFMpegParameters.InputDirectory))
            {
                return "视频目录不能为空！";
            }
            else
            {
                if (!Directory.Exists(FFMpegParameters.InputDirectory))
                {
                    return "视频目录不存在！";
                }
                else
                {
                    FFMpegParameters.SoureFiles = new List<string>();
                    var files = FileHelper.GetFileNames(FFMpegParameters.InputDirectory, "*.mp4", false);
                    if (files == null || files.Length == 0) return "视频目录下未找到mp4格式的视频文件！";
                    FFMpegParameters.SoureFiles.AddRange(files.ToList());
                }
            }

            if (string.IsNullOrEmpty(FFMpegParameters.OutputDirectory))
            {
                return "输出目录不存在！";
            }
            else
            {
                if (!FileHelper.IsExistDirectory(FFMpegParameters.OutputDirectory))
                {
                    FileHelper.CreateDirectory(FFMpegParameters.OutputDirectory);
                }
                else
                {
                    //清空output下的所有文件
                    FileHelper.ClearDirectory(FFMpegParameters.OutputDirectory);
                }
            }

            if (string.IsNullOrEmpty(FFMpegParameters.WaterPath))
            {
                return "水印图片不存在！";
            }

            if (FFMpegParameters.WaterDrections == null || FFMpegParameters.WaterDrections.Count == 0)
            {
                return "请选择水印位置！";
            }
            return "";
        }

        private void WriteLog(string message)
        {
            this.rtbOutputLog.Text = this.rtbOutputLog.Text.Insert(0, $"{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:fff")} {message}" + Environment.NewLine);
        }
    }
}
