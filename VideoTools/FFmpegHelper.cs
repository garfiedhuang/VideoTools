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
            //oInfo.FileName = "cmd.exe";
            oInfo.UseShellExecute = false;//是否使用操作系统shell启动
            oInfo.CreateNoWindow = true;//不显示程序窗口
            oInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            oInfo.RedirectStandardError = true;//重定向标准错误输入
            oInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息

            //创建一个字符串和StreamReader 用来获取处理结果
            string output = null;
            StreamReader srOutput = null;

            try
            {
                //调用ffmpeg开始处理命令
                var proc = Process.Start(oInfo);
                proc.StandardInput.AutoFlush = true;

                //获取输出流
                srOutput = proc.StandardError;

                //转换成string
                output = srOutput.ReadToEnd();

                //关闭处理程序
                proc.WaitForExit();
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

        /// <summary>
        /// 生成视频缩略图
        /// </summary>
        /// <param name="frameIndex"></param>
        /// <param name="thubWidth"></param>
        /// <param name="thubHeight"></param>
        /// <param name="thubImagePath"></param>
        /// <returns></returns>
        public string GenThupImageCmd(int frameIndex, int thubWidth, int thubHeight, string thubImagePath)
        {
            //int frameIndex = 10;//为帧处在的秒数  
            //int thubWidth = 80;//为缩略图的宽度  
            //int thubHeight = 80; //为缩略图的高度  
            //string thubImagePath = @"E:\2\2.jpg";//为生成的缩略图所在的路径  
            string command = string.Format(" -ss {0} -vframes 1 -r 1 -ac 1 -ab 2 -s {1}*{2} -f image2 \"{3}\"", frameIndex, thubWidth, thubHeight, thubImagePath);

            return command;
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
