using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMusicCenter.Models.DataAccessPostgreSqlProvider;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NewCenter;
using System.Windows.Forms;

namespace WebMusicCenter.Controllers
{
    public class UploadController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoUpload(IFormFile file)
        {
            using (var stream = file.OpenReadStream())
            {
                var xs = new XmlSerializer(typeof(CompletingForm));
                var form = (CompletingForm)xs.Deserialize(stream);


                using (var db = new MusicCenterDbContext())
                {
                    var dbs = new DbCompletingForm()
                    {
                        FormName = form.FormName,
                        Name = form.Name,
                        Surname = form.Surname,
                        Patronymic = form.Patronymic,
                        ContactDetails = form.ContactDetails,
                        Create = form.Create,
                        Photo = form.Photo,
                    };
                    dbs.Description = new List<DbProblemDescription>();
                    foreach (var problem in form.ProblemDescription)
                    {
                        dbs.Description.Add(new DbProblemDescription()
                        {
                            ModelOfInstrument = problem.ModelOfInstrument,
                            FullDescription = problem.FullDescription,
                        });
                    }

                    db.CompletingForms.Add(dbs);
                    db.SaveChanges();
                }
               return View(form);
            }
        }

        public ActionResult Image(int id)
        {
            using (var db = new MusicCenterDbContext())
            {
                return base.File(db.CompletingForms.Find(id).Photo, "image/jpeg");
            }
        }

        public ActionResult List()
        {
            List<DbCompletingForm> list;
            using (var db = new MusicCenterDbContext())
            {;
                list = db.CompletingForms.Include(s => s.Description).ToList();
            }

            return View(list);
        }

        //public ActionResult Print(int id)
        //{
        //    using (var db = new MusicCenterDbContext())
        //    {
        //        var form = db.CompletingForms.Include(s1 => s1.Description).First(s1 => s1.Id == id);
        //        IWorkbook workbook =
        //            new XSSFWorkbook(System.IO.File.OpenRead("template.xlsx"));

        //        var sheet = workbook.GetSheetAt(0);

        //        sheet.GetRow(1).Cells[1].SetCellValue(form.Name);

        //        for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++)
        //        {
        //            IRow row = sheet.GetRow(i);
        //            if (row == null) continue;
        //            if (row.Cells.All(d => d.CellType == CellType.Blank)) continue;
        //            var lastCellNum = row.LastCellNum;
        //            for (int j = row.FirstCellNum; j < lastCellNum; j++)
        //            {
        //                var cell = row.GetCell(j);
        //                if (cell != null)
        //                {
        //                    if (cell.StringCellValue == "$PropRow")
        //                    {
        //                        row = sheet.CopyRow(i, i + 1);
        //                        i++;
        //                        cell = row.GetCell(j) ?? row.CreateCell(j);
        //                        cell.SetCellValue("Тип инструмента");
        //                        row.CreateCell(j + 1).SetCellValue(form.InstrumentType.ToString()); row = sheet.CreateRow(i++);

        //                        break;
        //                    }

        //                    if (cell.StringCellValue == "$Problem")
        //                    {
        //                        foreach (var problem in form.Description)
        //                        {
        //                            row = sheet.GetRow(i);
        //                            cell = row.GetCell(j);
        //                            cell.SetCellValue(problem.ModelOfInstrument);
        //                            cell = row.GetCell(j + 1) ?? row.CreateCell(j + 1);
        //                            cell.SetCellValue(problem.FullDescription);
        //                            cell = row.GetCell(j + 2) ?? row.CreateCell(j + 2);
        //                            if (problem != form.Description.Last())
        //                                row = sheet.CopyRow(i, i + 1);
        //                            i++;
        //                        }
        //                        break;
        //                    }
        //                }
        //            }
        //        }

        //        var ms = new MemoryStream();
        //        workbook.Write(ms);

        //        ms.Position = 0;

        //        return base.File(ms, "application/octet-stream", "form" + id + ".xlsx");
        //    }
        //}

        public static string ToStringMaster(List<string> master)
        {

            string str = "";
            foreach (var e in master)
            {
                str = str + e;
                str += ", ";
            }

            return str;
        }
    }
}