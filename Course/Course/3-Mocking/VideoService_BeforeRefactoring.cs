using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace Course._3_Mocking
{
    /// <summary>
    /// 1 - Take a look about this class VideoService. The method ReadVideoTitle is tightly coupled to this class.
    /// We need to ensure the loosely-coupling, so we can develop the tests
    /// 2 - Go to VideoService class
    /// </summary>
    class VideoService_BeforeRefactoring
    {
        //video.txt
        public string ReadVideoTitle(string file)
        {
            var str = File.ReadAllText(file);
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
