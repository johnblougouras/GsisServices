using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GsisServicesLib.Greek
{
 
    public class CallServiceViewModel : NotificationObject, IDataErrorInfo
    {

        private string _userName;
        private string _password;
        private string _authVatNumber;
        private string _searchForVatNumber;



        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value, null); }
        }

        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value, null); }
        }

        public string AuthVatNumber
        {
            get { return _authVatNumber; }
            set { SetProperty(ref _authVatNumber, value, null); }
        }


        public string SearchForVatNumber
        {
            get { return _searchForVatNumber; }
            set { SetProperty(ref _searchForVatNumber, value, null); }
        }

        public string Error => throw new NotImplementedException();

        public string GetError()
        {
            var validationErrors=  GetValidationErrors();

            return string.Join (Environment.NewLine, validationErrors);

        }

        public List<string> GetValidationErrors()
        {

            var list = new List<string>();

                if (string.IsNullOrEmpty(UserName))
                list.Add("Please enter a userName");
        
                if (string.IsNullOrEmpty(Password))
                list.Add("Please enter a password");


            if (string.IsNullOrEmpty(AuthVatNumber))
                list.Add("Please enter a auth vatNumber");

            if (string.IsNullOrEmpty(SearchForVatNumber))
                list.Add("Please enter a vatNumer to search for.");

            return list;

        }

        public bool IsValid()
        {
            var validationErrors = GetValidationErrors();
            return validationErrors.Count == 0;
        }


        public string this[string columnName]
        {
            get
            {
              
                if (columnName == "UserName")
                {
                    if (string.IsNullOrEmpty(UserName))
                        return "Please enter a userName";
                }

                if (columnName == "Password")
                {
                    if (string.IsNullOrEmpty(Password))
                        return "Please enter a password";
                }

                if (columnName == "AuthVatNumber")
                {
                    if (string.IsNullOrEmpty(AuthVatNumber))
                        return "Please enter a vatNumber";
                }
                if (columnName == "SearchForVatNumber")
                {
                    if (string.IsNullOrEmpty(SearchForVatNumber))
                        return "Please enter a vatNumer to search for.";
                }
                
                return string.Empty;
            }
        }





    }
}
