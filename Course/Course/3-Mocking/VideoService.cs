using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Course._3_Mocking
{
    /// <summary>
    /// 1 - Understand how this class had been refactored
    /// 2 - Implement the unit tests for ReadVideoTitle
    /// 3 - Implement the unit tests for GetUnprocessedVideosAsCsv
    /// 4 - Go to InstallerHelper class
    /// </summary>
    public class VideoService
    {
        private IFileReader _fileReader;
        private IVideoRepository _repository;

        public VideoService(IFileReader fileReader = null, IVideoRepository repository = null)
        {
            _fileReader = fileReader ?? new FileReader();
            _repository = repository ?? new VideoRepository();
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

            var videos = _repository.GetUnprocessedVideos();
            foreach (var v in videos)
                videoIds.Add(v.Id);

            return string.Join(",", videoIds);
        }
    }
}
