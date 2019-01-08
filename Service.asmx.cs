namespace SyncService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Web.Script.Serialization;
    using System.Web.Services;
   

    [ToolboxItem(false), WebService(Namespace = "http://tempuri.org/"), WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class WebService1 : WebService
    {
        public static decimal LtsTMs = 0M;
        public static string sMSs = "Unknow";
        public static string sNUs = "-1";
        public static string sERR = "00";
        public static string sTM = "0";

        public void AddAbnotma()
        {
            if (DBHelper.GetDtCount(sNUs) == "0")
            {
                DBHelper.AddAbnorma(this.GetPageAbt());
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

            return "";
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
        /// <summary>
        /// //增加上传与下载信息表以及系统时长扣除
        /// </summary>
        /// <returns></returns>
        public UpAndDown GetPaeg2(string snu,string sms,string stm,int sid)
        {
          
            decimal num = Convert.ToDecimal(stm);//光源上传的剩余时长
            decimal num2 = 0M;
            decimal reMaTime = DBHelper.GetReMaTime(snu);//数据库中充值+赠送的时长
            if (num < reMaTime)
            {
                num2 = reMaTime - num;
                if (DBHelper.IsSets(snu))//充值的话，使用时长为0
                {
                    num2 = 0M;
                }
                if (DBHelper.IsDelay(snu) != "0")//需要延时充值，使用时长为0
                {
                    num2 = 0M;
                }
                if (sms == "UnActive")//未激活，使用时长为0
                {
                    num2 = 0M;
                }
                LtsTMs = num2;
            }
            /*else if (((num > reMaTime) && !DBHelper.IsSets(snu)) && (DBHelper.GetDtCount(snu) == "0"))//如果光源剩余时长大于服务器剩余总时长（充值+赠送） && 光源未充值 && 
            {
              
 
            }*/
            return new UpAndDown
            {
                EquStaID = sid,
                EquNum = snu,
                IpAds = DBHelper.GetHostAddress(),
                TheTime = new decimal?(num2),
                UpTime = new decimal?(num),
                Date = new DateTime?(DBHelper.GetDate()),
                Rest = "成功",
                UseAmount = new decimal?(DBHelper.GetUseAmout(snu, num2)),
                Sta = sms
            };
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
                sTMP3= this.GetDate("sTMP3"),
                sTMP4 = this.GetDate("sTMP4"),
                sTMP5 = this.GetDate("sTMP5"),
                sTMP6 = this.GetDate("sTMP6"),
                sSRC1 = this.GetDate("sSRC1"),
                sSRC2 = this.GetDate("sSRC2"),
                sSRC3 = this.GetDate("sSRC3"),
                sSRC4 = this.GetDate("sSRC4"),
                sSRC5 = this.GetDate("sSRC5"),
                sSRC6 = this.GetDate("sSRC6"),
                sSRC7 = this.GetDate("sSRC7"),
                sSRC8 = this.GetDate("sSRC8"),
            };
        }

        public Abnorma GetPageAbt()
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
            switch (sERR)
            {
                case "01":
                    abnorma.ProDesc = "温度传感器未连接";
                    break;
                case "02":
                    abnorma.ProDesc = "设备温度异常";
                    break;
                case "03":
                    abnorma.ProDesc = "设备温度异常";
                    break;
                case "04":
                    abnorma.ProDesc = "水冷机未连接";
                    break;
                case "05":
                    abnorma.ProDesc = "箱门未关闭";
                    break;
                case "06":
                    abnorma.ProDesc = "驱动配置异常";
                    break;
                case "07":
                    abnorma.ProDesc = "驱动通信异常";
                    break;
                case "08":
                    abnorma.ProDesc = "驱动配置异常";
                    break;
                case "09":
                    abnorma.ProDesc = "红光电流异常";
                    break;
                case "10":
                    abnorma.ProDesc = "绿光电流异常";
                    break;
                case "11":
                    abnorma.ProDesc = "蓝光电流异常";
                    break;
                default:
                    abnorma.ProDesc = "";
                    break;

            }
            abnorma.Remark = "机器自报异常";
            abnorma.Serious = "否";
            abnorma.Solve = "未解决";
            abnorma.UpdateTime = new DateTime?(DBHelper.GetDate());
            abnorma.AbSta = "未关闭";
            DataSet set = DBHelper.SetClientAndEqu3(" and EquNum='" + sNUs + "'");
            string phones = "";
            if (set.Tables[0].Rows.Count >= 1)
            {
                string str2 = set.Tables[0].Rows[0]["ClientName"].ToString();
                string engineer = set.Tables[0].Rows[0]["Engineer"].ToString();
                string str4 = set.Tables[0].Rows[0]["NumBer"].ToString();
                string str5 = abnorma.ProDesc;
                string what = "您好，影院" + str2 + str4+"自报异常<"+ str5 + ">，请尽快处理！";
                string sql = "select username from V_Users_Roles where slug='manager'";
                
                DataSet manager_ds = DBHelper.GetDataSet(sql);
                for(int i = 0; i < manager_ds.Tables[0].Rows.Count; i++)
                {
                    phones = phones + manager_ds.Tables[0].Rows[i]["username"].ToString()+",";
                }
                DBHelper.SendMsg("", what, "", phones.TrimEnd(','), "2");

            }
            return abnorma;
        }

        public Abnorma GetPageAbts(string sNUs ,string num,string debug)
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
            abnorma.ProDesc = debug;
            abnorma.Livephotos = 0;
            abnorma.MainteDesc = "";
            abnorma.Remark = "光源剩余时长大于服务器时长(数值：" + num + ")";
            abnorma.Serious = "否";
            abnorma.Solve = "未解决";
            abnorma.UpdateTime = new DateTime?(DBHelper.GetDate());
            abnorma.AbSta = "未关闭";
                return abnorma;
        }

        [WebMethod(Description = "返回字符串3")]
        public void GetrLess(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                this.GetJson("success", 2);
            }
            else
            {
                this.GetJson("failure", 2);
            }
        }

        [WebMethod(Description = "返回字符串1")]
        public void GetString()
        {
            this.UpStaAndTime();
        }

        [WebMethod(Description = "返回字符串2")]
        public void GetSum(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                this.GetJson("success", 1);
            }
            else
            {
                this.GetJson("failure", 1);
            }
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        public static string IsActive(string str)
        {
            /*if (DBHelper.IsDelay(equnum) == "0")
            {
                return "Recharge";
            }
            else
            {
                return "Normal";
            }*/
            return str;
            
        }

        public  void IsSend(string sTM)
        {
            DataSet set = DBHelper.SetClientAndEqu3(" and EquNum='" + sNUs + "'");
            if (set.Tables[0].Rows.Count >= 1)
            {
                string str = set.Tables[0].Rows[0]["IsSend"].ToString();
                string str2 = set.Tables[0].Rows[0]["ClientName"].ToString();
                string phone = set.Tables[0].Rows[0]["Phone"].ToString();
                string agent= set.Tables[0].Rows[0]["Agent"].ToString();
                string seller = set.Tables[0].Rows[0]["Seller"].ToString();
                string str4 = set.Tables[0].Rows[0]["NumBer"].ToString();
                string str5 = set.Tables[0].Rows[0]["RemainTime"].ToString();
                decimal num = Convert.ToDecimal(str5);
                string str6 = str4 + "剩余时长仅有：" + str5 + "小时，";
                string what = "您好，您的影院" + str2 + str6 + "为避免影响您的使用，请尽快充值！";
                string[] ss=str.Split(',');//0,0,0,0分别代表500小时，200小时，100小时发送短信开关,代理发送开关,每当有充值设置为0，0，0，0
                //小于500大于200发送给客户、销售或代理商
                if (((ss[0] == "0") && (num <= 500M)) && ((num > 200M) && (sMSs != "UnActive")))
                {
                    /*DBHelper.SendMsg("", what, "", phone, "2");
                    if (!string.IsNullOrEmpty(seller))
                    {
                        DBHelper.SendMsg("", what, "", seller, "2");
                    }
                    if (!string.IsNullOrEmpty(agent))
                    {
                        DBHelper.SendMsg("", what, "", agent, "2");
                    }*/
                    DBHelper.ExecuteNonQuery(string.Format("Insert Into ShortMessage (phone, message, smt, remaintime,snu) values('{0}','{1}','{2}','{3}','{4}')", phone, what, sTM, str5,sNUs));
                    ss[0] = "1";
                    DBHelper.UpEquIsSend(sNUs, String.Join(",", ss));
                }
                //小于200大于100发送给客户、销售或代理商
                if (((ss[1] == "0") && (num <= 200M)) && ((num >= 100M) && (sMSs != "UnActive")))
                {
                    /*DBHelper.SendMsg("", what, "", phone, "2");
                    if (!string.IsNullOrEmpty(seller))
                    {
                        DBHelper.SendMsg("", what, "", seller, "2");
                    }
                    if (!string.IsNullOrEmpty(agent))
                    {
                        DBHelper.SendMsg("", what, "", agent, "2");
                    }*/
                    DBHelper.ExecuteNonQuery(string.Format("Insert Into ShortMessage (phone, message, smt, remaintime,snu) values('{0}','{1}','{2}','{3}','{4}')", phone, what, sTM, str5, sNUs));
                    ss[1] = "1";
                    DBHelper.UpEquIsSend(sNUs, String.Join(",", ss));
                }
                //小于100发送给客户
                if (((ss[2] == "0") && (num <= 100M)) && (sMSs != "UnActive"))
                {

                    //DBHelper.SendMsg("", what, "", phone, "2");
                    ss[2] = "1";
                    DBHelper.UpEquIsSend(sNUs, String.Join(",", ss));

                }
                //小于100发送给销售或代理
                if (((ss[3] == "0") && (num <= 100M)) && (sMSs != "UnActive"))
                {
                    /*if (!string.IsNullOrEmpty(seller))
                    {
                        DBHelper.SendMsg("", what, "", seller, "2");
                    }
                    if (!string.IsNullOrEmpty(agent))
                    {
                        DBHelper.SendMsg("", what, "", agent, "2");
                    }*/
                    DBHelper.ExecuteNonQuery(string.Format("Insert Into ShortMessage (phone, message, smt, remaintime,snu) values('{0}','{1}','{2}','{3}','{4}')", phone, what, sTM, str5, sNUs));
                    ss[3] = "1";
                    DBHelper.UpEquIsSend(sNUs, String.Join(",", ss));
                }
                if (((ss[3] == "1") && (num <= 100M)) && (sMSs != "UnActive"))
                {
                    //每天15：30设置记为0,目的是每天发送给销售或代理商
                    if (DateTime.Now.Hour == 4 && DateTime.Now.Minute == 05)
                    {
                        ss[3] = "0";
                        DBHelper.UpEquIsSend(sNUs, String.Join(",", ss));
                    }
                }

            }
        }

        public void Reset()
        {
            sNUs = "-1";
            LtsTMs = 0M;
            sMSs = "Unknow";
        }

        public void UpStaAndTime()
        {
            this.Reset();//重置页面数据
            EquStatus values = this.GetPage();
            sNUs= values.sNU;//获取光源编号
            sMSs = values.sMS;//获取光源状态 
            sERR = values.sERR;//获取光源错误码
            sTM= values.sTM;//获取光源时长

            RetValue retValues = new RetValue();//LeftTime Operating ServerTime Status
            int num = 0;//光源状态
            if (!string.IsNullOrWhiteSpace(sNUs) && (sNUs!= "0"))
            {       
                num = DBHelper.Add(values);//增加机器状态表数据
              
                if (num >= 1)//如果状态表数据记录增加成功
                {

                    UpAndDown upandown = this.GetPaeg2(values.sNU, values.sMS, values.sTM, num);

                    //num = DBHelper.AddUpDown(upandown);//增加上传与下载信息表
                }
                if (num >= 1)
                {
                    string equNum = values.sNU;
                    string str3 = values.sMS;
                    decimal num2 = Convert.ToDecimal(values.sTM);
                    if (values.sNU == equNum)
                    {
                        switch (DBHelper.IsPrest(values.sNU))
                        {
                            case "Y":
                                retValues.Operating = IsActive("Recharge");
                                break;

                            case "G":
                                retValues.Operating = IsActive("Recharge");
                                break;

                            case "F":
                                retValues.Operating = IsActive("Recharge");
                                break;

                            case "S":
                                DBHelper.UpSets(values.sNU);
                                retValues.Operating = "Settlement";
                                break;

                            case "N":
                                retValues.Operating = "Normal";
                                break;

                            default:
                                retValues.Operating = "UnKnow";
                                break;
                        }
                        /*
                        if ((sMSs == "UnActive") && DBHelper.IsBuys(values.sNU))
                        {
                            retValues.Operating = "Recharge";
                        }*/
                        //by wyb 2018-7-2
                        if (sMSs == "UnActive")
                        {
                            retValues.Operating = "Recharge";
                        }
                        decimal useTime = 0M;
                        decimal reMaTime = DBHelper.GetReMaTime(values.sNU);
                        if (num2 < reMaTime)
                        {
                            useTime = reMaTime - num2;
                            if (DBHelper.IsSets(values.sNU))
                            {
                                useTime = 0M;
                            }
                            if (DBHelper.IsDelay(values.sNU) != "0")
                            {
                                useTime = 0M;
                            }
                            if (str3 == "UnActive")
                            {
                                useTime = 0M;
                            }
                            LtsTMs = useTime;
                        }
                        DBHelper.GetReMaTime(values.sNU, useTime, values.sMS,values.sTM);//光源编号，使用时间，机器状态
                        if (DBHelper.IsDelay(values.sNU) == "0" && retValues.Operating == "Normal")
                        {
                            IsSend(values.sTM);
                        }
                        if ((!string.IsNullOrEmpty(sERR))&&sERR!="00")
                        {
                            this.AddAbnotma();
                        }
                    }
                }
            }
            if ((num >= 1))
            {
                retValues.Status = "success";
                retValues.LeftTime = DBHelper.GetReMaTime(values.sNU);
                DBHelper.GetIsEnabled(values.sNU);
                retValues.ServerTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                if (DBHelper.GetIsEnabled(values.sNU) == "N")
                {
                    retValues.Operating = "Lock";
                }
            }
            else
            {
                retValues.Status = "failure";
                retValues.Operating = "Normal";
                retValues.ServerTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                retValues.LeftTime = 0M;
            }
           
            this.GetJson(retValues);      
        }
    }
}

