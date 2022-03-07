using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace InventarioApp
{
    class LoadJson
    {
        public string server; // field
        public string Server { get { return server;} set { server=value;} }// property

        public string db; // field
        public string Db { get { return db; } set { db=value; } }

        

    }
}
