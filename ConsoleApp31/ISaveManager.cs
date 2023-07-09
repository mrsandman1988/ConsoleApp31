using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    public interface ISaveManager
    {
        public void Save(Article article);
    }

    public class SQLSaveManager : ISaveManager
    {
        public void Save(Article article)
        {
            //article save sql db
        }
    }
    public class MongoSaveManager : ISaveManager
    {
        public void Save(Article article)
        {
            // logic  for save to mongo db
        }
    }

    

}
