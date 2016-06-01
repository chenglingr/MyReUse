using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCDemo.Controllers
{
    public class ArticleController : Controller
    {
        private DAL.AccountContext db = new DAL.AccountContext();
        // GET: Article
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult IndexList()
        {
            return View();
        }
        public ActionResult MyIndexList()
        {
            return View();
        }
        [Authorize(Users = "admin@qq.com")]
        public ActionResult ArticleList()
        {
            return View();
        }
        // [Authorize(Users = "admin@qq.com")] 限定用户
        [Authorize]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)] //取消输入验证 --因为有内容有标签-得加这句
        public ActionResult Add(Models.Article art)
        {
            //topic、content 已从前边view里获取了，其他要赋值。
            art.createTime = DateTime.Now;
            art.lastClickTime = DateTime.Now;
            art.clickCount = 0;
            if (Session["UserID"] == null)
            {
                FormsAuthentication.SignOut();//清除假登陆状态
                return RedirectToAction("Login","Account");
            }
            else
            { 
                art.AccoutID = int.Parse(Session["UserID"].ToString());//获取作者id
                db.Articles.Add(art);//增加
                db.SaveChanges();//保y
                return RedirectToAction("MyIndexList"); 
            }
        }
        /*
               um.ready(function () {
                    var con = '@Html.Raw(Model.content)';
                    um.setContent(con);
                });
        */
    }
}