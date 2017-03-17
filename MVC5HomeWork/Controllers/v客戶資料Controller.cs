using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC5HomeWork.Models;

namespace MVC5HomeWork.Controllers
{
    public class v客戶資料Controller : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: v客戶資料
        public ActionResult Index()
        {
            return View(db.v客戶資料.ToList());
        }

        // GET: v客戶資料/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            v客戶資料 v客戶資料 = db.v客戶資料.Find(id);
            if (v客戶資料 == null)
            {
                return HttpNotFound();
            }
            return View(v客戶資料);
        }

        // GET: v客戶資料/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: v客戶資料/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,客戶名稱,統一編號,電話,傳真,地址,Email,是否已刪除,銀行名稱,帳戶名稱,帳戶號碼,職稱,客戶聯絡人_姓名,客戶聯絡人_Email,客戶聯絡人_手機,客戶聯絡人_電話")] v客戶資料 v客戶資料)
        {
            if (ModelState.IsValid)
            {
                db.v客戶資料.Add(v客戶資料);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(v客戶資料);
        }

        // GET: v客戶資料/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            v客戶資料 v客戶資料 = db.v客戶資料.Find(id);
            if (v客戶資料 == null)
            {
                return HttpNotFound();
            }
            return View(v客戶資料);
        }

        // POST: v客戶資料/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,客戶名稱,統一編號,電話,傳真,地址,Email,是否已刪除,銀行名稱,帳戶名稱,帳戶號碼,職稱,客戶聯絡人_姓名,客戶聯絡人_Email,客戶聯絡人_手機,客戶聯絡人_電話")] v客戶資料 v客戶資料)
        {
            if (ModelState.IsValid)
            {
                db.Entry(v客戶資料).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(v客戶資料);
        }

        // GET: v客戶資料/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            v客戶資料 v客戶資料 = db.v客戶資料.Find(id);
            if (v客戶資料 == null)
            {
                return HttpNotFound();
            }
            return View(v客戶資料);
        }

        // POST: v客戶資料/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            v客戶資料 v客戶資料 = db.v客戶資料.Find(id);
            db.v客戶資料.Remove(v客戶資料);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
