using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
    public interface INoteSelect
    {
        //对笔记收藏表进行增删操作
        void NoteSelect(int userid, int noteid);
        //笔记被收藏的总量
        int noteselectnum(int noteid);
        //判断用户是否收藏过该笔记
        bool ifselect(int userid, int noteid);
        //通过用户id找到用户的喜欢笔记列表
        IEnumerable<NoteSelect> userselectnote(int userid);
    }
}
