namespace SyncService
{
    using System;

    [Serializable]
    public class Abnorma
    {
        private string _absta;
        private int _clientid;
        private int _equid;
        private int _id;
        private int? _livephotos;
        private string _livephotos2;
        private string _maintedesc;
        private string _prodesc;
        private string _remark;
        private string _serious;
        private string _solve;
        private DateTime? _updatetime;

        public string AbSta
        {
            get
            {
                return this._absta;
            }
            set
            {
                this._absta = value;
            }
        }

        public int ClientID
        {
            get
            {
                return this._clientid;
            }
            set
            {
                this._clientid = value;
            }
        }

        public int EquID
        {
            get
            {
                return this._equid;
            }
            set
            {
                this._equid = value;
            }
        }

        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        public int? Livephotos
        {
            get
            {
                return this._livephotos;
            }
            set
            {
                this._livephotos = value;
            }
        }

        public string Livephotos2
        {
            get
            {
                return this._livephotos2;
            }
            set
            {
                this._livephotos2 = value;
            }
        }

        public string MainteDesc
        {
            get
            {
                return this._maintedesc;
            }
            set
            {
                this._maintedesc = value;
            }
        }

        public string ProDesc
        {
            get
            {
                return this._prodesc;
            }
            set
            {
                this._prodesc = value;
            }
        }

        public string Remark
        {
            get
            {
                return this._remark;
            }
            set
            {
                this._remark = value;
            }
        }

        public string Serious
        {
            get
            {
                return this._serious;
            }
            set
            {
                this._serious = value;
            }
        }

        public string Solve
        {
            get
            {
                return this._solve;
            }
            set
            {
                this._solve = value;
            }
        }

        public DateTime? UpdateTime
        {
            get
            {
                return this._updatetime;
            }
            set
            {
                this._updatetime = value;
            }
        }
    }
}

