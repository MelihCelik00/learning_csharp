using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {

        int spaceIndex;
        
        Dictionary<string, int> phoneBook = new Dictionary<string, int>();
        
        int n = Convert.ToInt32(Console.ReadLine()); // This integer is about how many people you will add to your contacts(phoneBook) dictionary. 
        
        for(int i = 0;i < n;i++)
        {
            string person = Console.ReadLine();// when input is like "name number". 
            spaceIndex = person.IndexOf(" ");
            int phoneNumber = Convert.ToInt32(person.Substring(spaceIndex));//phone number splitted
            string name = person.Remove(spaceIndex);
            phoneBook.Add(name, phoneNumber);
        }
        
        for(int j = 0;j < n;j++)
        {
            string nameInput = Console.ReadLine();
            bool keyExists = phoneBook.ContainsKey(nameInput);
            
            if(keyExists)
            { 
                Console.WriteLine($"{nameInput}={phoneBook[nameInput]}");
            }else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
