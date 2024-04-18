using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mya.Models
{
    internal class Event
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string? Photo { get; set; }
        //public string Source => GetSource();
        //private string GetSource()
        //{
        //    List<String> extensions = new List<string>
        //    {
        //        ".png", ".jpg", ".jpeg"
        //    };
        //    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "Events", Id.ToString());

        //    foreach (string ext in extensions)
        //    {
        //        if (File.Exists(path + ext))
        //        {
        //            return path + ext;
        //        }
        //    }
        //    return null;
        //}
    }
}
