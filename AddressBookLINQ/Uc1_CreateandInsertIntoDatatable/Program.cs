// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using Uc1_CreateandInsertIntoDatatable;

namespace LINQ_AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LINQ AddressBookSystem!");
            //Create Object for DataTable
            ContactDataManager contactDataManager = new ContactDataManager();
            ContactDataManager contactDataManagers = new ContactDataManager();
            DataTableManager dataTableManger = new DataTableManager();
            dataTableManger.CreateDataTable();

            //Insert Values into Table
            contactDataManager.FirstName = "Sonali";
            contactDataManager.LastName = "Varma";
            contactDataManager.PhoneNumber = 9842905050;
            contactDataManager.Email = "sonali@gmail.com";
            contactDataManager.Address = "4,B Block,Ajmer";
            contactDataManager.City = "Rajastan";
            contactDataManager.State = "TN";
            contactDataManager.zip = 600072;
            dataTableManger.InsertintoDataTable(contactDataManager);

            //Insert Values into Table
            contactDataManagers.FirstName = "Raksha";
            contactDataManagers.LastName = "Parthiban";
            contactDataManagers.PhoneNumber = 7742905050;
            contactDataManagers.Email = "Raksha@gmail.com";
            contactDataManagers.Address = "sasthri street,ambattur";
            contactDataManagers.City = "chennai";
            contactDataManagers.State = "TN";
            contactDataManagers.zip = 123001;
            dataTableManger.InsertintoDataTable(contactDataManagers);
            dataTableManger.Display();
        }
    }
}