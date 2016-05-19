﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary
{
    public class Config
    {
        public int ConnectionTimeOut { get; set; }
        public string ConnectionString { get; set; }

        public Config()
        {
            ConnectionTimeOut = 300;
            ConnectionString =
                "Data Source=SRVGALDB2;Initial Catalog=GalAMM_test;Integrated Security=True";
        }
    }
}
