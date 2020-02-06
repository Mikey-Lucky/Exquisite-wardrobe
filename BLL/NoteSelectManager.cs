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
     public class NoteSelectManager
    {
        INoteSelect iselect = DataAccess.CreateNoteSelect();
        //用户收藏或取消收藏视频
        public void NoteSelect(int userid, int noteid)
        {
            iselect.NoteSelect(userid, noteid);
        }
        //视频收藏总数
        public int noteselectnum(int noteid)
        {
            return iselect.noteselectnum(noteid);
        }
        //判断用户是否收藏视频
        public bool ifselect(int userid, int noteid)
        {
            return iselect.ifselect(userid, noteid);
        }
        //获取用户收藏视频列表
        public IEnumerable<NoteSelect> userselectnote(int userid)
        {
            return iselect.userselectnote(userid);
        }
    }
}
