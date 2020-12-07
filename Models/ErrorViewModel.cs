/* Ryan Clayson
 * NETD 3202 - Lab 5
 * December 6, 2020
 * This ASP.NET Core application is designed to allow the user to enter an NBA Player and add it to a database
 * Added Login Functionality, Registration for new user
 */
using System;

namespace NETD3202_Lab5_RyanClayson.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
