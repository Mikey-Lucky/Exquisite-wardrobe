using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
    public interface IVideoSelect
    {
        //对视频收藏表进行增删操作
        void VideoSelect(int userid, int videoid);
        //视频被收藏的总量
        int videoselectnum(int videoid);
        //判断用户是否收藏过改视频
        bool ifselect(int userid, int videoid);
        //通过用户id找到用户的喜欢视频列表
        IEnumerable<VideoSelect> userselectvideo(int userid);
    }
}
