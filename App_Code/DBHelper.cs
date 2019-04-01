namespace SyncService
{
    using System;
    using System.Data;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.IO;
    using System.Net;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Web;

    public class DBHelper
    {
        
        
        public static string conn = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["conn"].ToString();
        #region 光源信息存储到数据库
        /// <summary>
        /// 增加机器状态表数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static void Add(EquStatus model)
        {
            StringBuilder builder = new StringBuilder();
            StringBuilder builder2 = new StringBuilder();
            StringBuilder builder3 = new StringBuilder();
            if (model.sNU != null)
            {
                builder2.Append("sNU,");
                builder3.Append("'" + model.sNU + "',");
            }
            if (model.sMT != null)
            {
                builder2.Append("sMT,");
                builder3.Append("'" + model.sMT + "',");
            }
            if (model.sMS != null)
            {
                builder2.Append("sMS,");
                builder3.Append("'" + model.sMS + "',");
            }
            if (model.sTM != null)
            {
                builder2.Append("sTM,");
                builder3.Append("'" + model.sTM + "',");
            }
            if (model.sLI != null)
            {
                builder2.Append("sLI,");
                builder3.Append("'" + model.sLI + "',");
            }
            if (model.sURT1 != null)
            {
                builder2.Append("sURT1,");
                builder3.Append("'" + model.sURT1 + "',");
            }
            if (model.sURL != null)
            {
                builder2.Append("sURL,");
                builder3.Append("'" + model.sURL + "',");
            }
            if (model.sURC1 != null)
            {
                builder2.Append("sURC1,");
                builder3.Append("'" + model.sURC1 + "',");
            }
            if (model.sURC2 != null)
            {
                builder2.Append("sURC2,");
                builder3.Append("'" + model.sURC2 + "',");
            }
            if (model.sURC3 != null)
            {
                builder2.Append("sURC3,");
                builder3.Append("'" + model.sURC3 + "',");
            }
            if (model.sURC4 != null)
            {
                builder2.Append("sURC4,");
                builder3.Append("'" + model.sURC4 + "',");
            }
            if (model.sURC5 != null)
            {
                builder2.Append("sURC5,");
                builder3.Append("'" + model.sURC5 + "',");
            }
            if (model.sURC6 != null)
            {
                builder2.Append("sURC6,");
                builder3.Append("'" + model.sURC6 + "',");
            }
            if (model.sURC7 != null)
            {
                builder2.Append("sURC7,");
                builder3.Append("'" + model.sURC7 + "',");
            }
            if (model.sURC8 != null)
            {
                builder2.Append("sURC8,");
                builder3.Append("'" + model.sURC8 + "',");
            }
            if (model.sURC9 != null)
            {
                builder2.Append("sURC9,");
                builder3.Append("'" + model.sURC9 + "',");
            }
            if (model.sURC10 != null)
            {
                builder2.Append("sURC10,");
                builder3.Append("'" + model.sURC10 + "',");
            }
            if (model.sURC11 != null)
            {
                builder2.Append("sURC11,");
                builder3.Append("'" + model.sURC11 + "',");
            }
            if (model.sURC12 != null)
            {
                builder2.Append("sURC12,");
                builder3.Append("'" + model.sURC12 + "',");
            }
            if (model.sURC13 != null)
            {
                builder2.Append("sURC13,");
                builder3.Append("'" + model.sURC13 + "',");
            }
            if (model.sURC14 != null)
            {
                builder2.Append("sURC14,");
                builder3.Append("'" + model.sURC14 + "',");
            }
            if (model.sURC15 != null)
            {
                builder2.Append("sURC15,");
                builder3.Append("'" + model.sURC15 + "',");
            }
            if (model.sUGT1 != null)
            {
                builder2.Append("sUGT1,");
                builder3.Append("'" + model.sUGT1 + "',");
            }
            if (model.sUGL != null)
            {
                builder2.Append("sUGL,");
                builder3.Append("'" + model.sUGL + "',");
            }
            if (model.sUGC1 != null)
            {
                builder2.Append("sUGC1,");
                builder3.Append("'" + model.sUGC1 + "',");
            }
            if (model.sUGC2 != null)
            {
                builder2.Append("sUGC2,");
                builder3.Append("'" + model.sUGC2 + "',");
            }
            if (model.sUGC3 != null)
            {
                builder2.Append("sUGC3,");
                builder3.Append("'" + model.sUGC3 + "',");
            }
            if (model.sUGC4 != null)
            {
                builder2.Append("sUGC4,");
                builder3.Append("'" + model.sUGC4 + "',");
            }
            if (model.sUGC5 != null)
            {
                builder2.Append("sUGC5,");
                builder3.Append("'" + model.sUGC5 + "',");
            }
            if (model.sUGC6 != null)
            {
                builder2.Append("sUGC6,");
                builder3.Append("'" + model.sUGC6 + "',");
            }
            if (model.sUGC7 != null)
            {
                builder2.Append("sUGC7,");
                builder3.Append("'" + model.sUGC7 + "',");
            }
            if (model.sUGC8 != null)
            {
                builder2.Append("sUGC8,");
                builder3.Append("'" + model.sUGC8 + "',");
            }
            if (model.sUGC9 != null)
            {
                builder2.Append("sUGC9,");
                builder3.Append("'" + model.sUGC9 + "',");
            }
            if (model.sUGC10 != null)
            {
                builder2.Append("sUGC10,");
                builder3.Append("'" + model.sUGC10 + "',");
            }
            if (model.sUGC11 != null)
            {
                builder2.Append("sUGC11,");
                builder3.Append("'" + model.sUGC11 + "',");
            }
            if (model.sUGC12 != null)
            {
                builder2.Append("sUGC12,");
                builder3.Append("'" + model.sUGC12 + "',");
            }
            if (model.sUGC13 != null)
            {
                builder2.Append("sUGC13,");
                builder3.Append("'" + model.sUGC13 + "',");
            }
            if (model.sUGC14 != null)
            {
                builder2.Append("sUGC14,");
                builder3.Append("'" + model.sUGC14 + "',");
            }
            if (model.sUGC15 != null)
            {
                builder2.Append("sUGC15,");
                builder3.Append("'" + model.sUGC15 + "',");
            }
            if (model.sUBT != null)
            {
                builder2.Append("sUBT,");
                builder3.Append("'" + model.sUBT + "',");
            }
            if (model.sUBL != null)
            {
                builder2.Append("sUBL,");
                builder3.Append("'" + model.sUBL + "',");
            }
            if (model.sUBC1 != null)
            {
                builder2.Append("sUBC1,");
                builder3.Append("'" + model.sUBC1 + "',");
            }
            if (model.sUBC2 != null)
            {
                builder2.Append("sUBC2,");
                builder3.Append("'" + model.sUBC2 + "',");
            }
            if (model.sUBC3 != null)
            {
                builder2.Append("sUBC3,");
                builder3.Append("'" + model.sUBC3 + "',");
            }
            if (model.sUBC4 != null)
            {
                builder2.Append("sUBC4,");
                builder3.Append("'" + model.sUBC4 + "',");
            }
            if (model.sDRT1 != null)
            {
                builder2.Append("sDRT1,");
                builder3.Append("'" + model.sDRT1 + "',");
            }
            if (model.sDRL != null)
            {
                builder2.Append("sDRL,");
                builder3.Append("'" + model.sDRL + "',");
            }
            if (model.sDRC1 != null)
            {
                builder2.Append("sDRC1,");
                builder3.Append("'" + model.sDRC1 + "',");
            }
            if (model.sDRC2 != null)
            {
                builder2.Append("sDRC2,");
                builder3.Append("'" + model.sDRC2 + "',");
            }
            if (model.sDRC3 != null)
            {
                builder2.Append("sDRC3,");
                builder3.Append("'" + model.sDRC3 + "',");
            }
            if (model.sDRC4 != null)
            {
                builder2.Append("sDRC4,");
                builder3.Append("'" + model.sDRC4 + "',");
            }
            if (model.sDRC5 != null)
            {
                builder2.Append("sDRC5,");
                builder3.Append("'" + model.sDRC5 + "',");
            }
            if (model.sDRC6 != null)
            {
                builder2.Append("sDRC6,");
                builder3.Append("'" + model.sDRC6 + "',");
            }
            if (model.sDRC7 != null)
            {
                builder2.Append("sDRC7,");
                builder3.Append("'" + model.sDRC7 + "',");
            }
            if (model.sDRC8 != null)
            {
                builder2.Append("sDRC8,");
                builder3.Append("'" + model.sDRC8 + "',");
            }
            if (model.sDRC9 != null)
            {
                builder2.Append("sDRC9,");
                builder3.Append("'" + model.sDRC9 + "',");
            }
            if (model.sDRC10 != null)
            {
                builder2.Append("sDRC10,");
                builder3.Append("'" + model.sDRC10 + "',");
            }
            if (model.sDRC11 != null)
            {
                builder2.Append("sDRC11,");
                builder3.Append("'" + model.sDRC11 + "',");
            }
            if (model.sDRC12 != null)
            {
                builder2.Append("sDRC12,");
                builder3.Append("'" + model.sDRC12 + "',");
            }
            if (model.sDRC13 != null)
            {
                builder2.Append("sDRC13,");
                builder3.Append("'" + model.sDRC13 + "',");
            }
            if (model.sDRC14 != null)
            {
                builder2.Append("sDRC14,");
                builder3.Append("'" + model.sDRC14 + "',");
            }
            if (model.sDRC15 != null)
            {
                builder2.Append("sDRC15,");
                builder3.Append("'" + model.sDRC15 + "',");
            }
            if (model.sDGT1 != null)
            {
                builder2.Append("sDGT1,");
                builder3.Append("'" + model.sDGT1 + "',");
            }
            if (model.sDGL != null)
            {
                builder2.Append("sDGL,");
                builder3.Append("'" + model.sDGL + "',");
            }
            if (model.sDGC1 != null)
            {
                builder2.Append("sDGC1,");
                builder3.Append("'" + model.sDGC1 + "',");
            }
            if (model.sDGC2 != null)
            {
                builder2.Append("sDGC2,");
                builder3.Append("'" + model.sDGC2 + "',");
            }
            if (model.sDGC3 != null)
            {
                builder2.Append("sDGC3,");
                builder3.Append("'" + model.sDGC3 + "',");
            }
            if (model.sDGC4 != null)
            {
                builder2.Append("sDGC4,");
                builder3.Append("'" + model.sDGC4 + "',");
            }
            if (model.sDGC5 != null)
            {
                builder2.Append("sDGC5,");
                builder3.Append("'" + model.sDGC5 + "',");
            }
            if (model.sDGC6 != null)
            {
                builder2.Append("sDGC6,");
                builder3.Append("'" + model.sDGC6 + "',");
            }
            if (model.sDGC7 != null)
            {
                builder2.Append("sDGC7,");
                builder3.Append("'" + model.sDGC7 + "',");
            }
            if (model.sDGC8 != null)
            {
                builder2.Append("sDGC8,");
                builder3.Append("'" + model.sDGC8 + "',");
            }
            if (model.sDGC9 != null)
            {
                builder2.Append("sDGC9,");
                builder3.Append("'" + model.sDGC9 + "',");
            }
            if (model.sDGC10 != null)
            {
                builder2.Append("sDGC10,");
                builder3.Append("'" + model.sDGC10 + "',");
            }
            if (model.sDGC11 != null)
            {
                builder2.Append("sDGC11,");
                builder3.Append("'" + model.sDGC11 + "',");
            }
            if (model.sDGC12 != null)
            {
                builder2.Append("sDGC12,");
                builder3.Append("'" + model.sDGC12 + "',");
            }
            if (model.sDGC13 != null)
            {
                builder2.Append("sDGC13,");
                builder3.Append("'" + model.sDGC13 + "',");
            }
            if (model.sDGC14 != null)
            {
                builder2.Append("sDGC14,");
                builder3.Append("'" + model.sDGC14 + "',");
            }
            if (model.sDGC15 != null)
            {
                builder2.Append("sDGC15,");
                builder3.Append("'" + model.sDGC15 + "',");
            }
            if (model.sDBT != null)
            {
                builder2.Append("sDBT,");
                builder3.Append("'" + model.sDBT + "',");
            }
            if (model.sDBL != null)
            {
                builder2.Append("sDBL,");
                builder3.Append("'" + model.sDBL + "',");
            }
            if (model.sDBC1 != null)
            {
                builder2.Append("sDBC1,");
                builder3.Append("'" + model.sDBC1 + "',");
            }
            if (model.sDBC2 != null)
            {
                builder2.Append("sDBC2,");
                builder3.Append("'" + model.sDBC2 + "',");
            }
            if (model.sDBC3 != null)
            {
                builder2.Append("sDBC3,");
                builder3.Append("'" + model.sDBC3 + "',");
            }
            if (model.sDBC4 != null)
            {
                builder2.Append("sDBC4,");
                builder3.Append("'" + model.sDBC4 + "',");
            }
            if (model.sERR != null)
            {
                builder2.Append("sERR,");
                builder3.Append("'" + model.sERR + "',");
            }
            if (model.sTMP1 != null)
            {
                builder2.Append("sTMP1,");
                builder3.Append("'" + model.sTMP1 + "',");
            }
            if (model.sTMP2 != null)
            {
                builder2.Append("sTMP2,");
                builder3.Append("'" + model.sTMP2 + "',");
            }
            if (model.sTMP3 != null)
            {
                builder2.Append("sTMP3,");
                builder3.Append("'" + model.sTMP3 + "',");
            }
            if (model.sTMP4 != null)
            {
                builder2.Append("sTMP4,");
                builder3.Append("'" + model.sTMP4 + "',");
            }
            if (model.sTMP5 != null)
            {
                builder2.Append("sTMP5,");
                builder3.Append("'" + model.sTMP5 + "',");
            }
            if (model.sTMP6 != null)
            {
                builder2.Append("sTMP6,");
                builder3.Append("'" + model.sTMP6 + "',");
            }
            if (model.sSCR1 != null)
            {
                builder2.Append("sSCR1,");
                builder3.Append("'" + model.sSCR1 + "',");
            }
            if (model.sSCR2 != null)
            {
                builder2.Append("sSCR2,");
                builder3.Append("'" + model.sSCR2 + "',");
            }
            if (model.sSCR3 != null)
            {
                builder2.Append("sSCR3,");
                builder3.Append("'" + model.sSCR3 + "',");
            }
            if (model.sSCR4 != null)
            {
                builder2.Append("sSCR4,");
                builder3.Append("'" + model.sSCR4 + "',");
            }
            if (model.sSCR5 != null)
            {
                builder2.Append("sSCR5,");
                builder3.Append("'" + model.sSCR5 + "',");
            }
            if (model.sSCR6 != null)
            {
                builder2.Append("sSCR6,");
                builder3.Append("'" + model.sSCR6 + "',");
            }
            if (model.sSCR7 != null)
            {
                builder2.Append("sSCR7,");
                builder3.Append("'" + model.sSCR7 + "',");
            }
            if (model.sSCR8 != null)
            {
                builder2.Append("sSCR8");
                builder3.Append("'" + model.sSCR8 + "'");
            }
            builder.Append("insert into EquStatus(");
            builder.Append(builder2.ToString());
            builder.Append(")");
            builder.Append(" values (");
            builder.Append(builder3.ToString());
            builder.Append(")");
            ExecuteNonQuery(builder.ToString());
        }
        #endregion
        public static int ExecuteNonQuery(string sql)
        {
            int num;
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    num = new SqlCommand(sql, connection).ExecuteNonQuery();
                }
            }
            catch
            {
                num = 0;
            }
            return num;
        }
        public static DataSet GetClientAnID(string EquNUm)
        {
            return GetDataSet("select ID,ClientID from Equipment where EquNum='" + EquNUm + "'");
        }

        private static string GetContentFromUrll(string _requestUrl)
        {
            string str = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_requestUrl);
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8"));
            str = reader.ReadToEnd();
            response.Close();
            reader.Close();
            return str;
        }

        public static DataSet GetDataSet(string sql)
        {
            try
            {
                SqlConnection selectConnection = new SqlConnection(conn);
                selectConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, selectConnection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "table");
                selectConnection.Close();
                return dataSet;
            }
            catch (OleDbException)
            {
                return null;
            }
        }

        public static DateTime GetDate()
        {
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            return currentTime;
        }


        public static string GetHostAddress()
        {
            string userHostAddress = HttpContext.Current.Request.UserHostAddress;
            if (string.IsNullOrEmpty(userHostAddress))
            {
                userHostAddress = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            if (!string.IsNullOrEmpty(userHostAddress) && IsIP(userHostAddress))
            {
                return userHostAddress;
            }
            return "127.0.0.1";
        }


        public static bool IsEuqNum(string EquNum)
        {
            DataSet dataSet = GetDataSet("select  COUNT(*) from Equipment where EquNum='" + EquNum + "'");
            if (dataSet.Tables[0].Rows.Count < 1)
            {
                return false;
            }
            if (dataSet.Tables[0].Rows[0][0].ToString() == "0")
            {
                return false;
            }
            return true;
        }
        #region 光源充值后重置充值时长以及IsPre字段
        /// <summary>
        /// 光源充值后重置充值时长以及IsPre字段
        /// </summary>
        /// <returns>如果成功返回true</returns>
        public static void UpdateEquTime(string EquNum, Decimal ReMaTime)
        {
            string sql = "update Equipment set Precharge=0,IsPre='N'," + "RemainTime =" + ReMaTime + " where EquNum = '" + EquNum + "'";
            ExecuteNonQuery(sql);
        }
        #endregion
        public static bool IsIP(string ip)
        {
            return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }
        public static void SendMsg(string who, string what, string how, string Phone, string sta)
        {
            string str = Phone;
            string str2 = "";
            if (sta == "0")
            {
                str2 = "您好，管理员" + who + "正在" + what + " ,验证码为 " + how + " 【中科创激光】";
            }
            if (sta == "1")
            {
                str2 = "您好， " + who + "您的账号为: " + what + " ,密码为 " + how + "【中科创激光】";
            }
            if (sta == "2")
            {
                str2 = what + "【中科创激光】";
            }
            if ((str != "") && (str2 != ""))
            {
                try
                {
                    GetContentFromUrll(" http://61.143.63.169:8080/GateWay/Services.asmx/DirectSend?UserID=999595&Account=admin&Password=FW9NQ9&Phones=" + str + ";&Content=" + str2 + "&SendTime=&SendType=1&PostFixNumber=");
                }
                catch
                {
                }
            }
        }
        public static bool UpEquIsSend(string EquNum, string Sta)
        {
            string[] textArray1 = new string[] { "Update Equipment set IsSend='", Sta, "' where EquNum='", EquNum, "'" };
            return (ExecuteNonQuery(string.Concat(textArray1)) >= 1);
        }
        #region 通过光源编号查看光源是否锁定
        /// <summary>
        /// 光源是否锁定
        /// </summary>
        /// <param name="EquNum">光源编号</param>
        /// <returns>加入锁定返回true</returns>
        public static bool IsLocked(string EquNum)
        {
            DataSet ds = GetDataSet("select IsEnabled from Equipment where EquNum ='" + EquNum + "'");
            if (ds.Tables[0].Rows.Count >= 1)
            {
                if (ds.Tables[0].Rows[0]["IsEnabled"].ToString() == "N")
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
        public static DataSet GetEquInfo(string equnum)
        {
            DataSet ds = GetDataSet("select *,Equipment.ID as EquID from Equipment inner join Client on(Equipment.ClientID=Client.ID) where EquNum = '" + equnum + "'");
            return ds;
        }
        /// <summary>
        /// 光源结算
        /// </summary>
        /// <param name="EquNum"></param>
        /// <returns></returns>
        //public static int UpSets(string EquNum)
        //{
        //    UpAndDown model = new UpAndDown {
        //        EquStaID = new int?(GetAddID()),
        //        EquNum = EquNum,
        //        IpAds = GetHostAddress(),
        //        TheTime = new decimal?(GetReMaTimes(EquNum)),
        //        UpTime = 0,
        //        Date = new DateTime?(GetDate()),
        //        Rest = "成功",
        //        Sta = "Settlement"
        //    };
        //    AddUpDown(model);
        //    return ExecuteNonQuery("update Equipment set IsPre='N',Precharge='0',PreGift='0',GiftTime='0',RemainTime='0'  WHERE  EquNum='" + EquNum + "'");
        //}
        public static string GetDtCount(string EquID)
        {
            DataSet ds = GetDataSet("select top 1 ProDesc from Abnorma where EquID='" + EquID + "' order by ID desc");
            if(ds.Tables[0].Rows.Count>0)
            {
                return ds.Tables[0].Rows[0][0].ToString();
            }
            return "00";
        }
        public static bool AddAbnorma(Abnorma model)
        {
            StringBuilder builder1 = new StringBuilder();
            builder1.Append("insert into Abnorma(");
            builder1.Append("ClientID,EquID,ProDesc,Livephotos,MainteDesc,Livephotos2,Remark,Serious,Solve,AbSta,UpdateTime");
            builder1.Append(")");
            builder1.Append(" values (");
            builder1.Append(model.ClientID + ",");
            builder1.Append(model.EquID + ",");
            builder1.Append("'" + model.ProDesc + "',");
            builder1.Append(model.Livephotos + ",");
            builder1.Append("'" + model.MainteDesc + "',");
            builder1.Append("'" + model.Livephotos2 + "',");
            builder1.Append("'" + model.Remark + "',");
            builder1.Append("'" + model.Serious + "',");
            builder1.Append("'" + model.Solve + "',");
            builder1.Append("'" + model.AbSta + "',");
            builder1.Append("'" + model.UpdateTime + "'");
            builder1.Append(")");
            builder1.Append(";select @@IDENTITY");
            return (ExecuteNonQuery(builder1.ToString()) >= 1);
        }
    }
}

