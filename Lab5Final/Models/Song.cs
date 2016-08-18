using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5Final.Models
{
    public class Song
    {

        public Song()
        {

        }

        public virtual int SongId { get; set; }
        [Display(Name = "Name:")]
        public virtual string SongName { get; set; }
        public virtual decimal Duration { get; set; }


    }
}