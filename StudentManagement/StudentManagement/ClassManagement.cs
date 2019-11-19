using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class ClassManagement
    {
        public Class[] GetClasses()
        {
            var db = new OOPCSYukiEntities1();
            return db.Classes.ToArray();
        }

        public void AddClass(string name,string description)
        {
            var newClass = new Class();
            newClass.Name = name;
            newClass.Description = description;

            var db = new OOPCSYukiEntities1();
            db.Classes.Add(newClass);
            db.SaveChanges();
        }

        public void EditClass(int id,string name, string description)
        {
            var db = new OOPCSYukiEntities1();
            var oldClass = db.Classes.Find(id);

            oldClass.Name = name;
            oldClass.Description = description;
            db.Entry(oldClass).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteClass( int id )
        {
            var db = new OOPCSYukiEntities1();
            var @class = db.Classes.Find(id);
            db.Classes.Remove(@class);
            //db.Entry(@class).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        public Class GetClass(int id)
        {
            var db = new OOPCSYukiEntities1();
            return db.Classes.Find(id);
        }
    }
}
