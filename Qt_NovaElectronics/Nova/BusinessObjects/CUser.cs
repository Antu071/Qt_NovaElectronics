using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nova.BusinessObjects
{
    public class CUser
    {
        private int m_iUserID;
        private int m_iShiftId;
        private string m_sUserName;
        private string m_sUserPassword;
        private string m_sUserFirstName;
        private string m_sUserLastName;
        private string m_sEmail;

        private bool m_bIsLoggedIn;
        private bool m_bRefund;
        private bool m_bAdmin;
        private bool m_bDiscount;

        private string m_sEnteredBy;
        private DateTime m_dtEnteredTime;
        private string m_sUpdatedBy;
        private DateTime m_dtUpdatedTime;
        private DateTime m_dtDeactivatedTime;
        private int m_iUserLoginId;
        private string m_userterminal;
        private bool m_HasSuperAdminRight;

        public CUser()
        { }
        public CUser(int iUserID, int iShiftId, string sUserName, string sUserPassword, string sUserFirstName, string sUserLastName, string sEmail, bool bIsLoggedIn, bool bRefund, bool bAdmin, bool bDiscount, string sEnteredBy, DateTime dtEnteredTime, string sUpdatedBy, DateTime dtUpdatedTime, DateTime dtDeactivatedTime, int iUserLoginId, string userTerminal, bool bHasSuperAdminRight)
        {
            this.m_iUserID = iUserID;
            this.m_iShiftId = iShiftId;
            this.m_sUserName = sUserName;
            this.m_sUserPassword = sUserPassword;
            this.m_sUserFirstName = sUserFirstName;
            this.m_sUserLastName = sUserLastName;
            this.m_sEmail = sEmail;

            this.m_bIsLoggedIn = bIsLoggedIn;
            this.m_bRefund = bRefund;
            this.m_bAdmin = bAdmin;
            this.m_bDiscount = bDiscount;


            this.m_sEnteredBy = sEnteredBy;
            this.m_dtEnteredTime = dtEnteredTime;
            this.m_sUpdatedBy = sUpdatedBy;
            this.m_dtUpdatedTime = dtUpdatedTime;
            this.m_dtDeactivatedTime = dtDeactivatedTime;
            this.m_iUserLoginId = iUserLoginId;
            this.m_userterminal = userTerminal;
            this.m_HasSuperAdminRight = bHasSuperAdminRight;
        }
        public int UserID
        {
            get
            {
                return m_iUserID;
            }
            set
            {
                m_iUserID = value;
            }
        }
        public int ShiftId
        {
            get
            {
                return m_iShiftId;
            }
            set
            {
                m_iShiftId = value;
            }
        }

        public string UserName
        {
            get
            {
                return m_sUserName;
            }
            set
            {
                m_sUserName = value;
            }
        }

        public string UserPassword
        {
            get
            {
                return m_sUserPassword;
            }
            set
            {
                m_sUserPassword = value;
            }
        }

        public string UserFirstName
        {
            get
            {
                return m_sUserFirstName;
            }
            set
            {
                m_sUserFirstName = value;
            }
        }

        public string UserLastName
        {
            get
            {
                return m_sUserLastName;
            }
            set
            {
                m_sUserLastName = value;
            }
        }

        public string Email
        {
            get
            {
                return m_sEmail;
            }
            set
            {
                m_sEmail = value;
            }
        }

        public bool IsLoggedIn
        {
            get
            {
                return m_bIsLoggedIn;
            }
            set
            {
                m_bIsLoggedIn = value;
            }
        }

        public bool Refund
        {
            get
            {
                return m_bRefund;
            }
            set
            {
                m_bRefund = value;
            }
        }

        public bool Admin
        {
            get
            {
                return m_bAdmin;
            }
            set
            {
                m_bAdmin = value;
            }
        }

        public bool Discount
        {
            get
            {
                return m_bDiscount;
            }
            set
            {
                m_bDiscount = value;
            }
        }

        public string EnteredBy
        {
            get
            {
                return m_sEnteredBy;
            }
            set
            {
                m_sEnteredBy = value;
            }
        }

        public DateTime EnteredTime
        {
            get
            {
                return m_dtEnteredTime;
            }
            set
            {
                m_dtEnteredTime = value;
            }

        }

        public string UpdatedBy
        {
            get
            {
                return m_sUpdatedBy;
            }
            set
            {
                m_sUpdatedBy = value;
            }
        }

        public DateTime UpdatedTime
        {
            get
            {
                return m_dtUpdatedTime;
            }
            set
            {
                m_dtUpdatedTime = value;
            }
        }

        public DateTime DeactivatedTime
        {
            get
            {
                return m_dtDeactivatedTime;
            }
            set
            {
                m_dtDeactivatedTime = value;
            }
        }

        public int UserLoginId
        {
            get
            {
                return m_iUserLoginId;
            }
            set
            {
                m_iUserLoginId = value;
            }
        }
        public string userTerminal
        {
            get
            {
                return m_userterminal;
            }
            set
            {
                m_userterminal = value;
            }
        }
        public bool HasSuperAdminRight
        {
            get
            {
                return m_HasSuperAdminRight;
            }
            set
            {
                m_HasSuperAdminRight = value;
            }
        }

    }
}

