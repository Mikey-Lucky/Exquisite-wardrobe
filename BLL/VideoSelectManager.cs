using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALFactory;
using IDAL;
using Models;

namespace BLL
{
    public class VideoSelectManager
    {
        IVideoSelect iselect = DataAccess.CreateVideoSelect();
        //用户收藏或取消收藏视频
        public void VideoSelect(int userid, int videoid)
        {
            iselect.VideoSelect(userid, videoid);
        }
        //视频收藏总数
        public int videoselectnum(int videoid)
        {
            return iselect.videoselectnum(videoid);
        }
        //判断用户是否收藏视频
        public bool ifselect(int userid,int videoid)
        {
            return iselect.ifselect(userid, videoid);
        }
        //获取用户收藏视频列表
        public IEnumerable<VideoSelect> userselectvideo(int userid)
        {
            return iselect.userselectvideo(userid);
        }
    }
}
