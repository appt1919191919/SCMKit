﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMKit.modules.github
{

    // TODO
    class RemovePAT
    {

        public static async Task execute(string credential, string url, string options, string system)
        {

            // Generate module header
            Console.WriteLine(library.Utils.GenerateHeader("removepat", credential, url, options, system));



            try
            {

                Console.WriteLine("");
                Console.WriteLine("[-] ERROR: This module is currently not supported for this system.");
                Console.WriteLine("");

            }

            catch (Exception ex)
            {

                Console.WriteLine("");
                Console.WriteLine("[-] ERROR: Could not remove PAT. Exception: " + ex.ToString());
                Console.WriteLine("");


            }

        }

    }
}
