﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace MVCDemo.Models
{
    public class Article
    {
        [DisplayName("编号")]
        public int ID { get; set; }
        [DisplayName("主题"),Required(ErrorMessage = "请输入标题")]
        public string topic { get; set; }
        [DisplayName("内容"), Required(ErrorMessage = "请输入内容")]
        public string content { get; set; }
        [DisplayName("创建时间")]
        public DateTime createTime { get; set; }
        [DisplayName("点击量")]
        public int clickCount { get; set; }
        [DisplayName("最后点击时间")]
        public DateTime lastClickTime { get; set; }
        [DisplayName("用户编号")]
        public int?AccoutID { get; set;} 
        public virtual Account Account { get; set; }
    }
}