using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    public class Article:ICloneable
    {
        private readonly ISaveManager _saveManager;
        public Article(ISaveManager saveManager)
        {
            _saveManager= saveManager;
            CreatedDate= DateTime.Now;
        }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }=DateTime.Now;

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void Save()
        {
            _saveManager.Save(this);
        }
    }
}
