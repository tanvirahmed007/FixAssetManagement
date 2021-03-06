using FixAssetManagement.Data;
using FixAssetManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FixAssetManagement.Controllers
{
    public class FixAssetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FixAssetsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            count();
            var Result = _context.FixAssets
                ./*OrderBy(x=>x.EmployeeName).*/ToList();

            

            return View(Result);
            
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        [ValidateAntiForgeryToken]
        public IActionResult Create(FixAsset model)
        {
            UploadImage(model);
            if (ModelState.IsValid)
            {
                _context.FixAssets.Add(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _context.FixAssets.Where(x => x.EmployeeId == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(FixAsset Model)
        {
            var data = _context.FixAssets.Where(x => x.EmployeeId == Model.EmployeeId).FirstOrDefault();
            if (data != null)
            {
                data.YearOfPurchase = Model.YearOfPurchase;
                data.HistoricalCost = Model.HistoricalCost;
                data.PurchaseOrder = Model.PurchaseOrder;
                data.UserName = Model.UserName;
                data.Location = Model.Location;
                data.Specification = Model.Specification;
                
                data.Rate = Model.Rate;
                data.AccumulatedBalance = Model.AccumulatedBalance;
                _context.SaveChanges();
            }

            return RedirectToAction("index");
        }

        

        public IActionResult Delete(int? Id)
        {
            
            var Result = _context.FixAssets.Find(Id);
            if(Result != null)
            {
                _context.FixAssets.Remove(Result);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        private void UploadImage(FixAsset model)
        {
            var file = HttpContext.Request.Form.Files;
            if (file.Count() > 0)
            {
                string ImageName = Guid.NewGuid().ToString() + Path.GetExtension(file[0].FileName);
                var fileStream = new FileStream(Path.Combine(@"wwwroot/", "Images", ImageName), FileMode.Create);
                file[0].CopyTo(fileStream);
                model.ImageUser = ImageName;
            }

            else if (model.ImageUser == null && model.EmployeeId == null)
            {
                model.ImageUser = "DefaultImg.jpg";
            }
            else
            {
                model.ImageUser = model.ImageUser;
            }
        }

        //count the inputs
        public void count()
        {
            ViewBag.displayCount = _context.FixAssets.ToList();
            ViewBag.Count = _context.FixAssets.Count();
        }

        //for details
        public ActionResult Detail(int id)
        {
            var data = _context.FixAssets.Where(x => x.EmployeeId == id).FirstOrDefault();
            return View(data);
        }






    }
}
