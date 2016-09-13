using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

namespace WebServiceTest
{
    public class Class1
    {
        private DateTime? _CreateTs = new DateTime?();
        private string _CreateUser = "";
        private DateTime? _EditTs = new DateTime?();
        private string _EditUser = "";

        public DateTime? CreateTs
        {
            set
            {
                _CreateTs = value;
            }
            get
            {
                return _CreateTs;
            }
        }

        public string CreateUser
        {
            set
            {
                _CreateUser = value;
            }
            get
            {
                return _CreateUser;
            }
        }

        public DateTime? EditTs
        {
            set
            {
                _EditTs = value;
            }
            get
            {
                return _EditTs;
            }
        }

        public string EditUser
        {
            set
            {
                _EditUser = value;
            }
            get
            {
                return _EditUser;
            }
        }
    }
}
