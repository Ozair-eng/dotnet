using project_web_form.context;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace project_web_form.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        db_testEntities dbObj = new db_testEntities();

        public ActionResult Student(tbl_student obj)
        {
            
                return View(obj);
        }
        [HttpPost]
        public ActionResult AddStudent(tbl_student model)
        {
            if (ModelState.IsValid)
            {
                tbl_student obj = new tbl_student();
                obj.ID = model.ID;
                obj.Name = model.Name;
                obj.Fname = model.Fname;
                obj.Email = model.Email;
                obj.Mobile = model.Mobile;
                obj.Descritipion = model.Descritipion;
                if(model.ID == 0)
                {
                    dbObj.tbl_student.Add(obj);
                    dbObj.SaveChanges();
                }
                else
                {
                    dbObj.Entry(obj).State = EntityState.Modified;
                    dbObj.SaveChanges();
                }
                
                
            }
            ModelState.Clear();

            return View("Student");
        }



        public ActionResult StudentList()
        {
            var res = dbObj.tbl_student.ToList();
            
            return View(res);
        }

        public ActionResult Delete(int id)
        {
            var res = dbObj.tbl_student.Where(x => x.ID == id).First();
            dbObj.tbl_student.Remove(res);
            
            dbObj.SaveChanges();

            var list = dbObj.tbl_student.ToList();

            return View("StudentList",list);
        }
    }
}