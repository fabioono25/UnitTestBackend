using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Course._3_Mocking
{
    /// <summary>
    /// 1 - Understand how this class has been refactored
    /// 2 - Implement the unit tests for ReadVideoTitle
    /// 3 - Implement the unit tests for GetUnprocessedVideosAsCsv
    /// 4 - Go to InstallerHelper class
    /// </summary>
    public class VideoService
    {
        private IFileReader _fileReader;

        public VideoService(IFileReader fileReader = null)
        {
            _fileReader = fileReader;
        }

        public string ReadVideoTitle(string file)
        {
            var str = _fileReader.Read(file);
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video.";
            return video.Title;
        }

        public string GetUnprocessedVideosAsCsv()
        {
            var videoIds = new List<int>();

            using (var context = new VideoContext())
            {
                var videos =
                    (from video in context.Videos
                     where !video.IsProcessed
                     select video).ToList();

                foreach (var v in videos)
                    videoIds.Add(v.Id);

                return String.Join(",", videoIds);
            }
        }
    }
}
