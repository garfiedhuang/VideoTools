using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Garfield.VideoTools
{
    /*************
    orignal.flv : 要处理的原始视频文件(最好是绝对路径)
    -y : 覆盖已有文件(注意，加水印不可覆盖原始文件，否则只能生成1秒的视频)
    -b：视频的码率 这里设置1024k 基本可满足无损处理 如不设置-b参数则默认为200k 视频会非常模糊
    -acodec copy : 保持音频质量不变
    -f mp4 : 表示转换的视频格式
 
    -i water.png : 水印图片路径
    overlay = 10:10 : 水印距离视频的左上角坐标
    其他位置参数：
    右上角：main_w-overlay_w-10:10
    左下角：10:main_h-overlay_h-10
    右下角：main_w-overlay_w-10:main_h-overlay_h-10

    newFile.mp4 要保存的文件路径
    **************/

    public class FFmpegHelper
    {
        /// <summary>
        /// 视频处理器ffmpeg.exe的位置
        /// </summary>
        public string FFmpegPath { get; set; }

        /// <summary>
        /// 调用ffmpeg.exe 执行命令
        /// </summary>
        /// <param name="Parameters">命令参数</param>
        /// <returns>返回执行结果</returns>
        public string RunProcess(string Parameters)
        {
            //创建一个ProcessStartInfo对象 并设置相关属性
            var oInfo = new ProcessStartInfo(FFmpegPath, Parameters);
            oInfo.UseShellExecute = false;
            oInfo.CreateNoWindow = true;
            oInfo.RedirectStandardOutput = true;
            oInfo.RedirectStandardError = true;
            oInfo.RedirectStandardInput = true;

            //创建一个字符串和StreamReader 用来获取处理结果
            string output = null;
            StreamReader srOutput = null;

            try
            {
                //调用ffmpeg开始处理命令
                var proc = Process.Start(oInfo);

                //proc.WaitForExit();

                ////获取输出流
                //srOutput = proc.StandardError;

                ////转换成string
                //output = srOutput.ReadToEnd();

                //关闭处理程序
                proc.Close();
            }
            catch (Exception)
            {
                output = string.Empty;
            }
            finally
            {
                //释放资源
                if (srOutput != null)
                {
                    srOutput.Close();
                    srOutput.Dispose();
                }
            }
            return output;
        }

    }
    public class Parameters
    {
        public string InputDirectory { get; set; }
        public string OutputDirectory { get; set; }
        public string WaterPath { get; set; }
        public List<WaterDrection> WaterDrections { get; set; }
        public WaterLocation Location { get; set; }
        public bool IsGenerateThumbnail { get; set; }
        public List<string> SoureFiles { get; set; }
    }

    public enum WaterDrection
    {
        TopLeftCorner=0,
        TopRightCorner=1,
        BottomLeftCorner=2,
        BottomRightCorner=3
    }

    public class WaterLocation
    {
        public float X { get; set; }
        public float Y { get; set; }
    }
}
