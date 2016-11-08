using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Escort.Models
{
    public class MyHelper
    {

        public static string GetEmail(string userId)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var user = db.Users.Where(t => t.Id == userId).FirstOrDefault();
                if (user != null)
                {
                    return user.Email;
                }
            }
            return "";
        }

        public static string GenerateOTP()
        {
            string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string small_alphabets = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "1234567890";
            int length = 6; // password length
            string pwType = "1"; //Alphanumeric

            string characters = numbers;
            if (pwType == "1")
            {
                characters += alphabets + small_alphabets + numbers;
            }

            string otp = string.Empty;
            for (int i = 0; i < length; i++)
            {
                string character = string.Empty;
                do
                {
                    int index = new Random().Next(0, characters.Length);
                    character = characters.ToCharArray()[index].ToString();
                } while (otp.IndexOf(character) != -1);
                otp += character;
            }
            return otp;
        }




    }
}