namespace SyncService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Web.Script.Serialization;
    using System.Web.Services;

    [ToolboxItem(false), WebService(Namespace = "http://intela.com.cn"), WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class WebService : System.Web.Services.WebService
    {
        private string _clientName;//客户名
        private decimal _clientTime;//客户端时长
        private string _equNum;//光源编号
        private string _number;//厅号
        private string _isSend;//是否发送短信
        private string _clientPhone;//客户手机号码
        private string _agent;//代理手机号码
        private string _seller;//销售手机号码
        private string _engineer;//工程师手机号码
        private string _isDelay;
        private string _equID;
        private string _clientID;
        private decimal _reMaTime;
        private decimal _reChargeTime;
        private string _isReCharge;
        private string _sMS;
        private string _sERR;
        private string _proDesc;
        public static string isSendToClient = System.Web.Configuration.WebConfigurationManager.AppSettings["sendtoclient"];
        public static string isSendToAgent = System.Web.Configuration.WebConfigurationManager.AppSettings["sendtoagent"];
        public static string isSendToSeller = System.Web.Configuration.WebConfigurationManager.AppSettings["sendtoseller"];

        public string ProDesc
        {
            get { return _proDesc; }
            set { _proDesc = value; }
        }

        public string sERR
        {
            get { return _sERR; }
            set { _sERR = value; }
        }

        public string sMS
        {
            get { return _sMS; }
            set { _sMS = value; }
        }

        public string IsReCharge
        {
            get { return _isReCharge; }
            set { _isReCharge = value; }
        }

        public decimal ReChargeTime
        {
            get { return _reChargeTime; }
            set { _reChargeTime = value; }
        }

        public decimal ReMaTime
        {
            get { return _reMaTime; }
            set { _reMaTime = value; }
        }

        public string ClientID
        {
            get { return _clientID; }
            set { _clientID = value; }
        }

        public string EquID
        {
            get { return _equID; }
            set { _equID = value; }
        }

        public string IsDelay
        {
            get { return _isDelay; }
            set { _isDelay = value; }
        }

        public string Engineer
        {
            get { return _engineer; }
            set { _engineer = value; }
        }

        public string Seller
        {
        get { return _seller; }
        set { _seller = value; }
        }

        public string Agent
        {
            get { return _agent; }
            set { _agent = value; }
        }

        public string ClientPhone
        {
            get { return _clientPhone; }
            set { _clientPhone = value; }
        }

        public string IsSend
        {
            get { return _isSend; }
            set { _isSend = value; }
        }

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string EquNum
        {
            get { return _equNum; }
            set { _equNum = value; }
        }

        public decimal ClientTime
        {
            get { return _clientTime; }
            set { _clientTime = value; }
        }

        public string ClientName
        {
            get { return _clientName; }
            set { _clientName = value; }
        }
        public void AddAbnotma(string ClientID, string EquID, string ProDesc)
        {
            if (DBHelper.GetDtCount(EquID) != ProDesc)
            {
                DBHelper.AddAbnorma(this.GetPageAbt(ClientID, EquID, ProDesc));
            }
        }

        public string GetDate(string sta)
        {
            if (base.Context.Request[sta] != null)
            {
                string str = base.Server.UrlDecode(base.Context.Request[sta].ToString());
                if (!string.IsNullOrWhiteSpace(str))
                {
                    return str;
                }
            }
            return "0";
        }

        public void GetJson(RetValue RetValues)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string s = "";
            s = serializer.Serialize(RetValues);
            base.Context.Response.ContentType = "text/json";
            base.Context.Response.Write(s);
            base.Context.Response.End();
        }
        public void GetJson(string str, int st)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string s = "";
            switch (st)
            {
                case 0:
                    {
                        Class1 class2 = new Class1
                        {
                            Status = str
                        };
                        s = serializer.Serialize(class2);
                        break;
                    }
                case 1:
                    {
                        List<Class1> list3 = new List<Class1>();
                        Class1 item = new Class1
                        {
                            Status = str
                        };
                        list3.Add(item);
                        List<Class1> list = list3;
                        s = serializer.Serialize(list);
                        break;
                    }
                case 2:
                    {
                        List<Class1> list4 = new List<Class1>();
                        Class1 class5 = new Class1
                        {
                            Status = str
                        };
                        list4.Add(class5);
                        List<Class1> list2 = list4;
                        Class2 class3 = new Class2
                        {
                            clt = list2
                        };
                        s = serializer.Serialize(class3);
                        break;
                    }
                default:
                    s = str;
                    break;
            }
            base.Context.Response.ContentType = "text/json";
            base.Context.Response.Write(s);
            base.Context.Response.End();
        }

        public EquStatus GetPage()
        {
            return new EquStatus
            {
                sNU = this.GetDate("sNU"),
                sMT = this.GetDate("sMT"),
                sMS = this.GetDate("sMS"),
                sTM = this.GetDate("sTM"),
                sLI = this.GetDate("sLI"),
                sURT1 = this.GetDate("sURT1"),
                sURL = this.GetDate("sURL"),
                sURC1 = this.GetDate("sURC1"),
                sURC2 = this.GetDate("sURC2"),
                sURC3 = this.GetDate("sURC3"),
                sURC4 = this.GetDate("sURC4"),
                sURC5 = this.GetDate("sURC5"),
                sURC6 = this.GetDate("sURC6"),
                sURC7 = this.GetDate("sURC7"),
                sURC8 = this.GetDate("sURC8"),
                sURC9 = this.GetDate("sURC9"),
                sURC10 = this.GetDate("sURC10"),
                sURC11 = this.GetDate("sURC11"),
                sURC12 = this.GetDate("sURC12"),
                sURC13 = this.GetDate("sURC13"),
                sURC14 = this.GetDate("sURC14"),
                sURC15 = this.GetDate("sURC15"),
                sUGT1 = this.GetDate("sUGT1"),
                sUGL = this.GetDate("sUGL"),
                sUGC1 = this.GetDate("sUGC1"),
                sUGC2 = this.GetDate("sUGC2"),
                sUGC3 = this.GetDate("sUGC3"),
                sUGC4 = this.GetDate("sUGC4"),
                sUGC5 = this.GetDate("sUGC5"),
                sUGC6 = this.GetDate("sUGC6"),
                sUGC7 = this.GetDate("sUGC7"),
                sUGC8 = this.GetDate("sUGC8"),
                sUGC9 = this.GetDate("sUGC9"),
                sUGC10 = this.GetDate("sUGC10"),
                sUGC11 = this.GetDate("sUGC11"),
                sUGC12 = this.GetDate("sUGC12"),
                sUGC13 = this.GetDate("sUGC13"),
                sUGC14 = this.GetDate("sUGC14"),
                sUGC15 = this.GetDate("sUGC15"),
                sUBT = this.GetDate("sUBT"),
                sUBL = this.GetDate("sUBL"),
                sUBC1 = this.GetDate("sUBC1"),
                sUBC2 = this.GetDate("sUBC2"),
                sUBC3 = this.GetDate("sUBC3"),
                sUBC4 = this.GetDate("sUBC4"),
                sDRT1 = this.GetDate("sDRT1"),
                sDRL = this.GetDate("sDRL"),
                sDRC1 = this.GetDate("sDRC1"),
                sDRC2 = this.GetDate("sDRC2"),
                sDRC3 = this.GetDate("sDRC3"),
                sDRC4 = this.GetDate("sDRC4"),
                sDRC5 = this.GetDate("sDRC5"),
                sDRC6 = this.GetDate("sDRC6"),
                sDRC7 = this.GetDate("sDRC7"),
                sDRC8 = this.GetDate("sDRC8"),
                sDRC9 = this.GetDate("sDRC9"),
                sDRC10 = this.GetDate("sDRC10"),
                sDRC11 = this.GetDate("sDRC11"),
                sDRC12 = this.GetDate("sDRC12"),
                sDRC13 = this.GetDate("sDRC13"),
                sDRC14 = this.GetDate("sDRC14"),
                sDRC15 = this.GetDate("sDRC15"),
                sDGT1 = this.GetDate("sDGT1"),
                sDGL = this.GetDate("sDGL"),
                sDGC1 = this.GetDate("sDGC1"),
                sDGC2 = this.GetDate("sDGC2"),
                sDGC3 = this.GetDate("sDGC3"),
                sDGC4 = this.GetDate("sDGC4"),
                sDGC5 = this.GetDate("sDGC5"),
                sDGC6 = this.GetDate("sDGC6"),
                sDGC7 = this.GetDate("sDGC7"),
                sDGC8 = this.GetDate("sDGC8"),
                sDGC9 = this.GetDate("sDGC9"),
                sDGC10 = this.GetDate("sDGC10"),
                sDGC11 = this.GetDate("sDGC11"),
                sDGC12 = this.GetDate("sDGC12"),
                sDGC13 = this.GetDate("sDGC13"),
                sDGC14 = this.GetDate("sDGC14"),
                sDGC15 = this.GetDate("sDGC15"),
                sDBT = this.GetDate("sDBT"),
                sDBL = this.GetDate("sDBL"),
                sDBC1 = this.GetDate("sDBC1"),
                sDBC2 = this.GetDate("sDBC2"),
                sDBC3 = this.GetDate("sDBC3"),
                sDBC4 = this.GetDate("sDBC4"),
                sERR = this.GetDate("sERR"),
                sTMP1 = this.GetDate("sTMP1"),
                sTMP2 = this.GetDate("sTMP2"),
                sTMP3 = this.GetDate("sTMP3"),
                sTMP4 = this.GetDate("sTMP4"),
                sTMP5 = this.GetDate("sTMP5"),
                sTMP6 = this.GetDate("sTMP6"),
                sSCR1 = this.GetDate("sSCR1"),
                sSCR2 = this.GetDate("sSCR2"),
                sSCR3 = this.GetDate("sSCR3"),
                sSCR4 = this.GetDate("sSCR4"),
                sSCR5 = this.GetDate("sSCR5"),
                sSCR6 = this.GetDate("sSCR6"),
                sSCR7 = this.GetDate("sSCR7"),
                sSCR8 = this.GetDate("sSCR8")
            };
        }

        public Abnorma GetPageAbt(string ClientID, string EquID, string ProDesc)
        {
            Abnorma abnorma = new Abnorma
            {
                EquID = 0,
                ClientID = 0
            };
            abnorma.ClientID = Convert.ToInt32(ClientID);
            abnorma.EquID = Convert.ToInt32(EquID);
            abnorma.ProDesc = ProDesc;
            abnorma.Livephotos = 0;
            abnorma.MainteDesc = "";
            abnorma.Remark = "机器自报异常";
            abnorma.Serious = "否";
            abnorma.Solve = "未解决";
            abnorma.UpdateTime = new DateTime?(DBHelper.GetDate());
            abnorma.AbSta = "未关闭";
            return abnorma;
        }

        public Abnorma GetPageAbts(string sNUs, string num)
        {
            Abnorma abnorma = new Abnorma
            {
                EquID = 0,
                ClientID = 0
            };
            DataSet clientAnID = DBHelper.GetClientAnID(sNUs);
            if (clientAnID.Tables[0].Rows.Count >= 1)
            {
                abnorma.EquID = Convert.ToInt32(clientAnID.Tables[0].Rows[0]["ID"].ToString());
                abnorma.ClientID = Convert.ToInt32(clientAnID.Tables[0].Rows[0]["ClientID"].ToString());
            }
            abnorma.ProDesc = "";
            abnorma.Livephotos = 0;
            abnorma.MainteDesc = "";
            abnorma.Remark = "光源剩余时长大于服务器时长(数值：" + num + ")";
            abnorma.Serious = "否";
            abnorma.Solve = "未解决";
            abnorma.UpdateTime = new DateTime?(DBHelper.GetDate());
            abnorma.AbSta = "未关闭";
            return abnorma;
        }

        //[WebMethod(Description = "返回字符串3")]
        //public void GetrLess(string str)
        //{
        //    if (!string.IsNullOrWhiteSpace(str))
        //    {
        //        this.GetJson("success", 2);
        //    }
        //    else
        //    {
        //        this.GetJson("failure", 2);
        //    }
        //}
        #region 上传服务
        [WebMethod(Description = "上传服务")]
        public void GetString()
        {
            UpStaAndTime();
        }
        #endregion

        public static string IsActive(string str)
        {
            return str;
        }
        #region 发送短信
        public void Send(decimal ClientTime, string ClientName, string EquNum, string Number, string IsSend, string ClientPhone, string Agent, string Seller, string Engineer)
        {
            string number = Number + "剩余时长：" + ClientTime + "小时,";
            string toclient = "您好，您的影院[" + ClientName + "]" + number + "为避免影响您的使用，请及时续费！";
            string toagent = "您好，您的客户[" + ClientName + "]" + number + "为了客户的正常使用，请提醒客户及时续费!";
            string toseller = "您好，你的客户[" + ClientName + "]" + number + "为了客户的正常使用，请提醒客户及时续费!";
            char[] separator = new char[] { ',' };
            string[] strArray = IsSend.ToString().Split(separator);
            if ((strArray[2] == "0") && (ClientTime <= 100M))
            {
                if(isSendToClient == "yes")
                {
                    DBHelper.SendMsg("", toclient, "", ClientPhone, "2");
                }
                DBHelper.ExecuteNonQuery(string.Format("Insert Into ShortMessage (phone, message, smt, remaintime,snu) values('{0}','{1}','{2}','{3}','{4}')", new object[] { ClientPhone, toclient, ClientTime, ClientTime, EquNum }));
                if (!string.IsNullOrEmpty(Seller))
                {
                    if(isSendToSeller == "yes")
                    {
                        DBHelper.SendMsg("", toseller, "", Seller, "2");
                    }
                    DBHelper.ExecuteNonQuery(string.Format("Insert Into ShortMessage (phone, message, smt, remaintime,snu) values('{0}','{1}','{2}','{3}','{4}')", new object[] { Seller, toseller, ClientTime, ClientTime, EquNum }));
                }
                if (!string.IsNullOrEmpty(Agent))
                {
                    if(isSendToAgent == "yes")
                    {
                        DBHelper.SendMsg("", toagent, "", Agent, "2");
                    }
                    DBHelper.ExecuteNonQuery(string.Format("Insert Into ShortMessage (phone, message, smt, remaintime,snu) values('{0}','{1}','{2}','{3}','{4}')", new object[] { Agent, toagent, ClientTime, ClientTime, EquNum }));
                }
                strArray[2] = "1";
                strArray[3] = "1";
                DBHelper.UpEquIsSend(EquNum, string.Join(",", strArray));
            }
            if ((strArray[3] == "0") && (ClientTime <= 100M))
            {
                if(isSendToClient == "yes")
                {
                    DBHelper.SendMsg("", toclient, "", ClientPhone, "2");
                }
                DBHelper.ExecuteNonQuery(string.Format("Insert Into ShortMessage (phone, message, smt, remaintime,snu) values('{0}','{1}','{2}','{3}','{4}')", new object[] { ClientPhone, toclient, ClientTime, ClientTime, EquNum }));
                if (!string.IsNullOrEmpty(Seller))
                {
                    if(isSendToSeller == "yes")
                    {
                        DBHelper.SendMsg("", toseller, "", Seller, "2");
                    }
                    DBHelper.ExecuteNonQuery(string.Format("Insert Into ShortMessage (phone, message, smt, remaintime,snu) values('{0}','{1}','{2}','{3}','{4}')", new object[] { Seller, toseller, ClientTime, ClientTime, EquNum }));
                }
                if (!string.IsNullOrEmpty(Agent))
                {
                    if(isSendToAgent == "yes")
                    {
                        DBHelper.SendMsg("", toagent, "", Agent, "2");
                    }   
                    DBHelper.ExecuteNonQuery(string.Format("Insert Into ShortMessage (phone, message, smt, remaintime,snu) values('{0}','{1}','{2}','{3}','{4}')", new object[] { Agent, toagent, ClientTime, ClientTime, EquNum }));
                }
                strArray[3] = "1";
                DBHelper.UpEquIsSend(EquNum, string.Join(",", strArray));
            }
            if ((((strArray[3] == "1") && (ClientTime <= 100M)) && (DateTime.Now.Hour == 9)) && (DateTime.Now.Minute == 5))
            {
                strArray[3] = "0";
                DBHelper.UpEquIsSend(EquNum, string.Join(",", strArray));
            }
            if ((strArray[1] == "0") && (ClientTime <= 200M) && (ClientTime > 100M))
            {
                if(isSendToClient == "yes")
                {
                    DBHelper.SendMsg("", toclient, "", ClientPhone, "2");
                }
                DBHelper.ExecuteNonQuery(string.Format("Insert Into ShortMessage (phone, message, smt, remaintime,snu) values('{0}','{1}','{2}','{3}','{4}')", new object[] { ClientPhone, toclient, ClientTime, ClientTime, EquNum }));
                if (!string.IsNullOrEmpty(Seller))
                {
                    if(isSendToSeller == "yes")
                    {
                        DBHelper.SendMsg("", toseller, "", Seller, "2");
                    }
                    DBHelper.ExecuteNonQuery(string.Format("Insert Into ShortMessage (phone, message, smt, remaintime,snu) values('{0}','{1}','{2}','{3}','{4}')", new object[] { Seller, toseller, ClientTime, ClientTime, EquNum }));
                }
                if (!string.IsNullOrEmpty(Agent))
                {
                    if(isSendToAgent == "yes")
                    {
                        DBHelper.SendMsg("", toagent, "", Agent, "2");
                    }
                    DBHelper.ExecuteNonQuery(string.Format("Insert Into ShortMessage (phone, message, smt, remaintime,snu) values('{0}','{1}','{2}','{3}','{4}')", new object[] { Agent, toagent, ClientTime, ClientTime, EquNum }));
                }
                strArray[1] = "1";
                DBHelper.UpEquIsSend(EquNum, string.Join(",", strArray));
            }
            if ((strArray[0] == "0") && (ClientTime <= 500M) && (ClientTime > 200M))
            {
                if(isSendToClient == "yes")
                {
                    DBHelper.SendMsg("", toclient, "", ClientPhone, "2");
                }
                DBHelper.ExecuteNonQuery(string.Format("Insert Into ShortMessage (phone, message, smt, remaintime,snu) values('{0}','{1}','{2}','{3}','{4}')", new object[] { ClientPhone, toclient, ClientTime, ClientTime, EquNum }));

                if (!string.IsNullOrEmpty(Seller))
                {
                    if(isSendToSeller == "yes")
                    {
                        DBHelper.SendMsg("", toseller, "", Seller, "2");
                    }
                    DBHelper.ExecuteNonQuery(string.Format("Insert Into ShortMessage (phone, message, smt, remaintime,snu) values('{0}','{1}','{2}','{3}','{4}')", new object[] { Seller, toseller, ClientTime, ClientTime, EquNum }));
                }
                if (!string.IsNullOrEmpty(Agent))
                {
                    if(isSendToAgent == "yes")
                    {
                        DBHelper.SendMsg("", toagent, "", Agent, "2");
                    }
                    DBHelper.ExecuteNonQuery(string.Format("Insert Into ShortMessage (phone, message, smt, remaintime,snu) values('{0}','{1}','{2}','{3}','{4}')", new object[] { Agent, toagent, ClientTime, ClientTime, EquNum }));
                }
                strArray[0] = "1";
                DBHelper.UpEquIsSend(EquNum, string.Join(",", strArray));
            }
        }
        #endregion
        public static void UpStaAndTime()
        {
            WebService service = new WebService();//新建webservice对象
            EquStatus Equstatus = service.GetPage();
            service.ClientTime = Convert.ToDecimal(Equstatus.sTM);//客户端上传的时长
            //decimal ClientTime = Convert.ToDecimal(Equstatus.sTM);
            service.EquNum = Equstatus.sNU;//光源编号
            //string EquNum = Equstatus.sNU;
            //string sMS = Equstatus.sMS;//机器状态
            service.sMS = Equstatus.sMS;
            //string sERR = Equstatus.sERR;//光源错误代码
            service.sERR = Equstatus.sERR;
            RetValue retValues = new RetValue();//LeftTime Operating ServerTime Status          
            if (!string.IsNullOrWhiteSpace(service.EquNum) && (service.EquNum != "0"))
            {
                if (DBHelper.IsLocked(service.EquNum))
                {
                    DBHelper.Add(Equstatus);
                    retValues.Operating = "Lock";
                    retValues.LeftTime = Convert.ToDecimal(service.ClientTime);
                    retValues.Status = "Success";
                    retValues.ServerTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    service.GetJson(retValues);
                    return;
                }
                if (DBHelper.IsEuqNum(service.EquNum))
                {
                    DataSet ds = DBHelper.GetEquInfo(service.EquNum);//获取该光源相应信息
                    service.IsDelay = ds.Tables[0].Rows[0]["IsDelay"].ToString();//充值后的延时操作
                    service.IsSend = ds.Tables[0].Rows[0]["IsSend"].ToString();//是否已发送短信
                    service.EquID = ds.Tables[0].Rows[0]["EquID"].ToString();//光源ID
                    service.Number = ds.Tables[0].Rows[0]["Number"].ToString();//厅号
                    service.ClientID = ds.Tables[0].Rows[0]["ClientID"].ToString();//客户ID
                    service.ClientName = ds.Tables[0].Rows[0]["ClientName"].ToString();//客户名
                    service.ClientPhone = ds.Tables[0].Rows[0]["Phone"].ToString();//客户手机号码
                    service.Agent = ds.Tables[0].Rows[0]["agent"].ToString();//代理商手机号码
                    service.Engineer = ds.Tables[0].Rows[0]["engineer"].ToString();//工程师手机号码
                    service.Seller = ds.Tables[0].Rows[0]["seller"].ToString();//销售人员手机号码
                    service.ReMaTime = Convert.ToDecimal(ds.Tables[0].Rows[0]["RemainTime"].ToString());//数据库内该光源总剩余时长
                    service.ReChargeTime = Convert.ToDecimal(ds.Tables[0].Rows[0]["Precharge"].ToString());//要充值的时长
                    service.IsReCharge = ds.Tables[0].Rows[0]["IsPre"].ToString();//是否需要充值
                    if (service.sERR != "00" && service.sERR != "0" && !string.IsNullOrEmpty(service.sERR))
                    {
                        service.ProDesc = "";
                        switch (service.sERR)
                        {
                            case "01":
                                service.ProDesc = "温度传感器未连接";
                                break;
                            case "02":
                                service.ProDesc = "设备温度异常";
                                break;
                            case "03":
                                service.ProDesc = "设备温度严重异常";
                                break;
                            case "04":
                                service.ProDesc = "水冷机未连接";
                                break;
                            case "05":
                                service.ProDesc = "光传感器未连接";
                                break;
                            case "06":
                                service.ProDesc = "箱门未关闭";
                                break;
                            case "07":
                                service.ProDesc = "驱动配置异常";
                                break;
                            case "08":
                                service.ProDesc = "驱动通信异常";
                                break;
                            case "09":
                                service.ProDesc = "红光电流异常";
                                break;
                            case "10":
                                service.ProDesc = "绿光电流异常";
                                break;
                            case "11":
                                service.ProDesc = "蓝光电流异常";
                                break;
                            default:
                                break;

                        }
                        service.AddAbnotma(service.ClientID, service.EquID, service.ProDesc);
                    }
                    service.Send(service.ClientTime, service.ClientName, service.EquNum, service.Number, service.IsSend, service.ClientPhone, service.Agent, service.Seller, service.Engineer);
                    switch (service.IsReCharge)
                    {
                        case "Y":
                            retValues.Operating = IsActive("Recharge");
                            if (service.ClientTime <= service.ReMaTime)//如果客户端时长小于等于服务器剩余总时长(此为正常情况)
                            {
                                retValues.LeftTime = service.ReChargeTime + service.ClientTime;//返回时长为客户端时长+充值时长
                                retValues.ServerTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                                retValues.Status = IsActive("Success");
                                DBHelper.UpdateEquTime(service.EquNum, retValues.LeftTime);
                                Equstatus.sTM = Convert.ToInt32(retValues.LeftTime).ToString();
                                DBHelper.Add(Equstatus);
                                DBHelper.ExecuteNonQuery(string.Concat(new string[] { "update Equipment set EquStatus='", service.sMS, "' WHERE EquNum='", service.EquNum, "'" }));
                                DBHelper.ExecuteNonQuery(string.Concat(new object[] { "update Equipment set ReviewTime='", DBHelper.GetDate(), "' WHERE EquNum='", service.EquNum, "'" }));
                                if (retValues.LeftTime > 500M)
                                {
                                    DBHelper.UpEquIsSend(service.EquNum, "1,1,1,1");
                                }
                                else if (retValues.LeftTime <= 500M && retValues.LeftTime > 200M)
                                {
                                    DBHelper.UpEquIsSend(service.EquNum, "0,1,1,1");
                                }
                                else if (retValues.LeftTime <= 200M && retValues.LeftTime > 100M)
                                {
                                    DBHelper.UpEquIsSend(service.EquNum, "1,0,1,1");
                                }
                                else
                                {
                                    DBHelper.UpEquIsSend(service.EquNum, "1,1,0,0");
                                }

                                service.GetJson(retValues);
                                return;

                            }
                            else//客户端时长大于服务器端时长
                            {
                                retValues.LeftTime = service.ReMaTime + service.ReChargeTime;//返回时长为 服务器端剩余总时长+充值时长
                                retValues.ServerTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                                retValues.Status = IsActive("Success");
                                DBHelper.UpdateEquTime(service.EquNum, retValues.LeftTime);
                                Equstatus.sTM = Convert.ToInt32(retValues.LeftTime).ToString();
                                DBHelper.Add(Equstatus);
                                DBHelper.ExecuteNonQuery(string.Concat(new string[] { "update Equipment set EquStatus='", service.sMS, "' WHERE EquNum='", service.EquNum, "'" }));
                                DBHelper.ExecuteNonQuery(string.Concat(new object[] { "update Equipment set ReviewTime='", DBHelper.GetDate(), "' WHERE EquNum='", service.EquNum, "'" }));
                                if (retValues.LeftTime <= 500M && retValues.LeftTime > 200M)
                                {
                                    DBHelper.UpEquIsSend(service.EquNum, "0,0,0,0");
                                }
                                else if (retValues.LeftTime <= 200M && retValues.LeftTime > 100M)
                                {
                                    DBHelper.UpEquIsSend(service.EquNum, "1,0,0,0");
                                }
                                else
                                {
                                    DBHelper.UpEquIsSend(service.EquNum, "1,1,0,0");
                                }
                                service.GetJson(retValues);
                                return;
                            }

                        case "N":
                            if (service.IsDelay == "2")
                            {

                                retValues.LeftTime = service.ReMaTime;
                                retValues.Operating = "Normal";
                                retValues.ServerTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                                retValues.Status = "Success";
                                Equstatus.sTM = Convert.ToInt32(service.ReMaTime).ToString();
                                //DBHelper.Add(Equstatus);
                                DBHelper.ExecuteNonQuery(string.Concat(new string[] { "update Equipment set EquStatus='", service.sMS, "' WHERE EquNum='", service.EquNum, "'" }));
                                DBHelper.ExecuteNonQuery(string.Concat(new object[] { "update Equipment set ReviewTime='", DBHelper.GetDate(), "' WHERE EquNum='", service.EquNum, "'" }));
                                DBHelper.ExecuteNonQuery("update Equipment set  IsDelay='0" + "'  where EquNum='" + service.EquNum + "'");
                                service.GetJson(retValues);
                                return;
                            }
                            if (service.ReMaTime >= service.ClientTime)//正常情况
                            {
                                retValues.Operating = "Normal";
                                retValues.Status = IsActive("Success");
                                retValues.ServerTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                                retValues.LeftTime = service.ClientTime;
                                Equstatus.sTM = Convert.ToInt32(retValues.LeftTime).ToString();
                                DBHelper.Add(Equstatus);
                                DBHelper.UpdateEquTime(service.EquNum, retValues.LeftTime);
                                DBHelper.ExecuteNonQuery(string.Concat(new string[] { "update Equipment set EquStatus='", service.sMS, "' WHERE EquNum='", service.EquNum, "'" }));
                                DBHelper.ExecuteNonQuery(string.Concat(new object[] { "update Equipment set ReviewTime='", DBHelper.GetDate(), "' WHERE EquNum='", service.EquNum, "'" }));
                                service.GetJson(retValues);
                                return;
                            }
                            else//如果客户端时长>服务端时长
                            {
                                retValues.Operating = "Normal";
                                retValues.Status = IsActive("Success");
                                retValues.ServerTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                                retValues.LeftTime = service.ClientTime;//返回客户端的时长
                                DBHelper.Add(Equstatus);
                                //DBHelper.UpdateEquTime(service.EquNum, service.ReMaTime);
                                DBHelper.ExecuteNonQuery(string.Concat(new string[] { "update Equipment set EquStatus='", service.sMS, "' WHERE EquNum='", service.EquNum, "'" }));
                                DBHelper.ExecuteNonQuery(string.Concat(new object[] { "update Equipment set ReviewTime='", DBHelper.GetDate(), "' WHERE EquNum='", service.EquNum, "'" }));
                                service.GetJson(retValues);
                                return;
                            }


                        default:
                            retValues.Operating = "UnKnow";
                            DBHelper.Add(Equstatus);
                            DBHelper.ExecuteNonQuery(string.Concat(new string[] { "update Equipment set EquStatus='", service.sMS, "' WHERE EquNum='", service.EquNum, "'" }));
                            DBHelper.ExecuteNonQuery(string.Concat(new object[] { "update Equipment set ReviewTime='", DBHelper.GetDate(), "' WHERE EquNum='", service.EquNum, "'" }));
                            break;
                    }
                }
                else
                {
                    retValues.Operating = "Please Leave This Page!";
                    retValues.ServerTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                    retValues.LeftTime = Decimal.Zero;
                    retValues.Status = "Failure";
                    service.GetJson(retValues);
                    return;
                }

            }
            else
            {
                //this.GetJson();
                //return;
                retValues.Status = "Failure";
                retValues.Operating = "Please Leave This Page!";
                retValues.ServerTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                retValues.LeftTime = Decimal.Zero;
                service.GetJson(retValues);
                return;
            }

        }

    }
}

