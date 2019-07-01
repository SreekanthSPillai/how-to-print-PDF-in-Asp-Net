using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace how_to_print_PDF_in_Asp_Net.Models
{
    public static class TemplateGenerator
    {
        public static string GetHTMLString()
        {
            var sb = new StringBuilder();
            sb.Append(@"<html>
                <head>
                </head>
                <body>
                  <div id=teste><div>
                </body>");
            sb.Append(@"<script>
                var xhttp = new XMLHttpRequest();
                xhttp.onreadystatechange = function() {                                         document.getElementById('teste')
        .innerHTML=this.response;
                };
                xhttp.open('GET', 'file:\\\C:/somefile.txt, true);
                xhttp.send();
              </script>
            </html>");
            return sb.ToString();
        }
    }
}