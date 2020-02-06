using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Models;

namespace DAL
{
    public class SqlNoteSelect : INoteSelect
    {
        yichuEntities db = DbContextFactory.CreateDbContext();
        public void NoteSelect(int userid, int noteid)
        {
            NoteSelect select = db.NoteSelect.Where(b => b.UserID == userid && b.NoteID == noteid).FirstOrDefault();
            if (select != null)
            {
                db.NoteSelect.Remove(select);
                db.SaveChanges();
            }
            else
            {
                NoteSelect select1 = new NoteSelect();
                select1.NoteID = noteid;
                select1.UserID = userid;
                select1.Time = DateTime.Now;
                db.NoteSelect.Add(select1);
                db.SaveChanges();
            }
        }
        public int noteselectnum(int noteid)
        {
            int selectnum = db.NoteSelect.Where(v => v.NoteID == noteid).Count();
            return selectnum;
        }
        public bool ifselect(int userid, int noteid)
        {
            NoteSelect select = db.NoteSelect.Where(a => a.UserID == userid && a.NoteID == noteid).FirstOrDefault();
            if (select != null)
            {
                return true;
            }
            else return false;
        }
        public IEnumerable<NoteSelect> userselectnote(int userid)
        {
            var selectnote = db.NoteSelect.Where(l => l.UserID == userid);
            return selectnote;
        }
    }
}
