﻿using System.Linq;
using System.Windows.Forms;

namespace MyApplication
{
	internal static class Program
	{
        //private static Form startupForm;

        static Program()
		{
		}

		[System.STAThread]
		internal static void Main()
		{
			// **************************************************
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			// **************************************************

			// **************************************************
			// **************************************************
			// **************************************************
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

                // **************************************************
                // **************************************************

                // **************************************************
                //var users =
                //	databaseContext.Users
                //	.ToList()
                //	;

                //int userCount = users.Count;
                // **************************************************

                // **************************************************
                //int userCount =
                //    databaseContext.Users
                //    .Count();
                // **************************************************

                // **************************************************
                bool hasAnyUser =
					databaseContext.Users
					.Any();
				// **************************************************

				if (hasAnyUser == false)
				{
					Models.User adminUser = new Models.User
					{
						IsAdmin = true,
						IsActive = true,

                        Username = "Dariush",
                        Password = "1234512345",
                        FullName = "Mr. Dariush Tasdighi"

                        //Username = "Behzad",
                        //Password = "1234512345",
                        //FullName = "Mr. Behzad Shakeri"
                    };

					databaseContext.Users.Add(adminUser);

					databaseContext.SaveChanges();
				}
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);

				return;
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
            // **************************************************
            // **************************************************
            // **************************************************

            // **************************************************
            //System.Windows.Forms.Application.Run(new StartupForm());

            //#region Runing Startup Form and then Disposing!
            //StartupForm startupForm = new StartupForm();

            //System.Windows.Forms.Application.Run(startupForm);

            //if (startupForm != null)
            //{
            //	if (startupForm.IsDisposed == false)
            //	{
            //		startupForm.Dispose();
            //	}

            //	startupForm = null;
            //}
            //#endregion /Runing Startup Form and then Disposing!
            // **************************************************

            #region Runing LoginForm and then Disposing!
            LoginForm loginForm = new LoginForm();

            System.Windows.Forms.Application.Run(loginForm);

            if (loginForm != null)
            {
                if (loginForm.IsDisposed == false)
                {
                    loginForm.Dispose();
                }

                loginForm = null;
            }
            #endregion /Runing LoginForm and then Disposing!


            //#region Runing LoginForm and then Disposing!
            //MainForm MainForm = new MainForm();

            //Application.Run(MainForm);

            //if (MainForm != null)
            //{
            //    if (MainForm.IsDisposed == false)
            //    {
            //        MainForm.Dispose();
            //    }

            //    MainForm = null;
            //}
            //#endregion /Runing LoginForm and then Disposing!
        }
    }
}
