using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Lyrics.com.Models
{
    public static class DBAccess
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Lyrics_App"].ConnectionString.ToString();
        }

    }
}