using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YACS5e
{
    public class User
    {
        private int _id;
        private bool _masterPermission;
        private string _login;
        /// <summary>
        /// some kind of hash
        /// </summary>
        private string _password;
        /// <summary>
        /// epoch
        /// </summary>
        private string _lastUpdate;

        /// <param name="password">raw passwd</param>
        public User(string login, string password)
        {
            throw new System.NotImplementedException();
        }

        public int id
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string lasUpdate
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int login
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string password
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public bool masterPermission
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void synchronize()
        {
            throw new System.NotImplementedException();
        }

        /// <param name="oldPasswd">raw passwd</param>
        public void updatePassword(string oldPasswd)
        {
            throw new System.NotImplementedException();
        }

        private string hashPasswd(string rawPass)
        {
            throw new System.NotImplementedException();
        }
    }
}