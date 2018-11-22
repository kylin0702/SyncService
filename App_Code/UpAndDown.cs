namespace SyncService
{
    using System;

    public class UpAndDown
    {
        private DateTime? _date;
        private string _equnum;
        private int? _equstaid;
        private int _id;
        private string _ipads;
        private string _rest;
        private string _sta;
        private decimal? _thetime;
        private decimal? _uptime;
        private decimal? _useamount;

        public DateTime? Date
        {
            get
            {
                return this._date;
            }
            set
            {
                this._date = value;
            }
        }

        public string EquNum
        {
            get
            {
                return this._equnum;
            }
            set
            {
                this._equnum = value;
            }
        }

        public int? EquStaID
        {
            get
            {
                return this._equstaid;
            }
            set
            {
                this._equstaid = value;
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

        public string IpAds
        {
            get
            {
                return this._ipads;
            }
            set
            {
                this._ipads = value;
            }
        }

        public string Rest
        {
            get
            {
                return this._rest;
            }
            set
            {
                this._rest = value;
            }
        }

        public string Sta
        {
            get
            {
                return this._sta;
            }
            set
            {
                this._sta = value;
            }
        }

        public decimal? TheTime
        {
            get
            {
                return this._thetime;
            }
            set
            {
                this._thetime = value;
            }
        }

        public decimal? UpTime
        {
            get
            {
                return this._uptime;
            }
            set
            {
                this._uptime = value;
            }
        }

        public decimal? UseAmount
        {
            get
            {
                return this._useamount;
            }
            set
            {
                this._useamount = value;
            }
        }
    }
}

