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
        /// <summary>
        /// 增加机器状态表数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static int Add(EquStatus model)
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
            if (model.sSRC1 != null)
            {
                builder2.Append("sSRC1,");
                builder3.Append("'" + model.sSRC1 + "',");
            }
            if (model.sSRC2 != null)
            {
                builder2.Append("sSRC2,");
                builder3.Append("'" + model.sSRC2 + "',");
            }
            if (model.sSRC3 != null)
            {
                builder2.Append("sSRC3,");
                builder3.Append("'" + model.sSRC3 + "',");
            }
            if (model.sSRC4 != null)
            {
                builder2.Append("sSRC4,");
                builder3.Append("'" + model.sSRC4 + "',");
            }
            if (model.sSRC5 != null)
            {
                builder2.Append("sSRC5,");
                builder3.Append("'" + model.sSRC5 + "',");
            }
            if (model.sSRC6 != null)
            {
                builder2.Append("sSRC6,");
                builder3.Append("'" + model.sSRC6+ "',");
            }
            if (model.sSRC7 != null)
            {
                builder2.Append("sSRC7,");
                builder3.Append("'" + model.sSRC7 + "',");
            }
            if (model.sSRC8 != null)
            {
                builder2.Append("sSRC8,");
                builder3.Append("'" + model.sSRC8 + "',");
            }
            builder.Append("insert into EquStatus(");
            builder.Append(builder2.ToString().Remove(builder2.Length - 1));
            builder.Append(")");
            builder.Append(" values (");
            builder.Append(builder3.ToString().Remove(builder3.Length - 1));
            builder.Append(")");
            builder.Append(";select @@IDENTITY");
            return ExecuteScalar(builder.ToString());
        }

        public static bool AddAbnorma(Abnorma model)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("insert into Abnorma(");
            builder.Append("ClientID,EquID,ProDesc,Livephotos,MainteDesc,Livephotos2,Remark,Serious,Solve,AbSta,UpdateTime");
            builder.Append(")");
            builder.Append(" values (");
            builder.Append(model.ClientID + ",");
            builder.Append(model.EquID + ",");
            builder.Append("'" + model.ProDesc + "',");
            builder.Append(model.Livephotos + ",");
            builder.Append("'" + model.MainteDesc + "',");
            builder.Append("'" + model.Livephotos2 + "',");
            builder.Append("'" + model.Remark + "',");
            builder.Append("'" + model.Serious + "',");
            builder.Append("'" + model.Solve + "',");
            builder.Append("'" + model.AbSta + "',");
            builder.Append("'" + model.UpdateTime + "'");
            builder.Append(")");
            builder.Append(";select @@IDENTITY");
            return (ExecuteNonQuery(builder.ToString()) >= 1);
        }

        public static int AddUpDown(UpAndDown model)
        {
            StringBuilder builder = new StringBuilder();
            StringBuilder builder2 = new StringBuilder();
            StringBuilder builder3 = new StringBuilder();
            if (model.EquStaID.HasValue)
            {
                builder2.Append("EquStaID,");
                builder3.Append(model.EquStaID + ",");
            }
            if (model.EquNum != null)
            {
                builder2.Append("EquNum,");
                builder3.Append("'" + model.EquNum + "',");
            }
            if (model.IpAds != null)
            {
                builder2.Append("IpAds,");
                builder3.Append("'" + model.IpAds + "',");
            }
            if (model.TheTime.HasValue)
            {
                builder2.Append("TheTime,");
                builder3.Append(model.TheTime + ",");
            }
            if (model.UpTime.HasValue)
            {
                builder2.Append("UpTime,");
                builder3.Append(model.UpTime + ",");
            }
            if (model.Date.HasValue)
            {
                builder2.Append("Date,");
                builder3.Append("'" + model.Date + "',");
            }
            if (model.Rest != null)
            {
                builder2.Append("Rest,");
                builder3.Append("'" + model.Rest + "',");
            }
            if (model.UseAmount.HasValue)
            {
                builder2.Append("UseAmount,");
                builder3.Append("'" + model.UseAmount + "',");
            }
            if (model.Sta != null)
            {
                builder2.Append("Sta,");
                builder3.Append("'" + model.Sta + "',");
            }
            builder.Append("insert into UpAndDown(");
            builder.Append(builder2.ToString().Remove(builder2.Length - 1));
            builder.Append(")");
            builder.Append(" values (");
            builder.Append(builder3.ToString().Remove(builder3.Length - 1));
            builder.Append(")");
            return ExecuteNonQuery(builder.ToString());
        }

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
       //返回主键 by wyb 2018-6-26
        public static int ExecuteScalar(string sql)
        {
            int num;
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    num =  Convert.ToInt32(new SqlCommand(sql, connection).ExecuteScalar());
                }
            }
            catch
            {
                num = 0;
            }
            return num;
        }

        public static int GetAddID()
        {
            string sql = "select max(ID) from EquStatus";
            DataSet dataSet = GetDataSet(sql);
            if (dataSet.Tables[0].Rows.Count >= 1)
            {
                string str2 = dataSet.Tables[0].Rows[0][0].ToString();
                if (!string.IsNullOrWhiteSpace(str2))
                {
                    return Convert.ToInt32(str2);
                }
            }
            return 0;
        }

        public static DataSet GetClientAnID(string EquNUm)
        {
            return GetDataSet("select ID,ClientID from Equipment where EquNum='" + EquNUm + "'");
        }

        private static string GetContentFromUrll(string _requestUrl)
        {
            string str = "";
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(_requestUrl);
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

        public static string GetDtCount(string EquNUm)
        {
            string sql = "select ID from Equipment where EquNum='" + EquNUm + "' and EquStatus!='UnActive' ";
            DataSet dataSet1 = GetDataSet(sql);
            if ((dataSet1 == null) || (dataSet1.Tables[0].Rows.Count != 1))//如果光源不在系统里或者光源编号重复
            {
                return "1";
            }
            else
            {
                //如果sERR的本次和上一次不一样，写入异常表
                DataSet dataSet2 = GetDataSet("select top 2 sERR from Equstatus where sNU='" + EquNUm + "' order by ID desc");
                if (dataSet2.Tables[0].Rows[0]["sERR"].ToString()== dataSet2.Tables[0].Rows[1]["sERR"].ToString())
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
         
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

        public static string GetIsEnabled(string EquNUm)
        {
            DataSet dataSet = GetDataSet("select IsEnabled from Equipment WHERE EquNum='" + EquNUm + "'");
            if (dataSet.Tables[0].Rows.Count >= 1)
            {
                string str2 = dataSet.Tables[0].Rows[0][0].ToString();
                if (!string.IsNullOrWhiteSpace(str2))
                {
                    return str2;
                }
            }
            return "Y";
        }

        public static decimal GetReMaTime(string EquNUm)
        {
            DataSet dataSet = GetDataSet("select *, (GiftTime+RemainTime) ReMaTime from Equipment WHERE EquNum='" + EquNUm + "'");
            if (dataSet.Tables[0].Rows.Count >= 1)
            {
                string str2 = dataSet.Tables[0].Rows[0]["ReMaTime"].ToString();
                if (!string.IsNullOrWhiteSpace(str2))
                {
                    return Convert.ToDecimal(Math.Round(Convert.ToDecimal(str2), 0).ToString());
                }
            }
            return 0M;
        }

        public static bool GetReMaTime(string EquNUm, decimal UseTime, string sMSs,string sTM)
        {
            if (!IsEuqNum(EquNUm))//EquNUm 光源编号，UseTime 使用时间，sMSs 机器状态
            {
                return false;
            }
            string sql = "select *, (GiftTime+RemainTime) ReMaTime from Equipment WHERE EquNum='" + EquNUm + "'";
            string str2 = "";
            string str4 = "";
            DataSet dataSet = GetDataSet(sql);
            if (dataSet.Tables[0].Rows.Count >= 1)
            {
                string str5 = dataSet.Tables[0].Rows[0]["ReMaTime"].ToString();
                string str6 = dataSet.Tables[0].Rows[0]["GiftTime"].ToString();
                string str7 = dataSet.Tables[0].Rows[0]["IsPre"].ToString();
                //EquNUm 光源编号，
                //UseTime 使用时间，
                //sMSs 机器状态
                //num 赠送时长
                //num2 总时长
                decimal num = Convert.ToDecimal(str6);
                decimal num2 = Convert.ToDecimal(str5);
                if (num <= 0M)//如果赠送时长小于等于0小时，剩余时长的充值时长-使用时长
                {
                    str2 = string.Concat(new object[] { "update Equipment set RemainTime=RemainTime-", UseTime, " where EquNum='", EquNUm, "'" });
                }
                /*else if (UseTime > num)//如果使用时长大于赠送时长，剩余时长=充值时长-（使用时长-赠送时长）
                {
                    decimal num3 = UseTime - num;
                    str2 = string.Concat(new object[] { "update Equipment  mainTime=RemainTime-", num3, ",GiftTime=0 where EquNum='", EquNUm, "'" });
                }
                else//否则赠送时长=赠送时长-使用时长
                {
                    str2 = string.Concat(new object[] { "update Equipment set GiftTime=GiftTime-", UseTime, " where EquNum='", EquNUm, "'" });
                }*/
                if (UseTime > num2)//如果使用时长大于剩余时长，不执行操作
                {
                    str2 = "";
                }
                if (sMSs == "UnActive")//如果机器未激活，不执行操作
                {
                    str2 = "";
                }
                /*if (IsBuys(EquNUm))//如果光源已购买，不执行操作
                {
                    str2 = "";
                }*/
                if (str7 == "S")//如果光源已经结算，不执行操作
                {
                    str2 = "";
                }
                string str8 = IsDelay(EquNUm);//光源充值操作状态
                if (str8 != "0")//如果光源未充值
                {
                    switch (str8)
                    {
                        case "2"://2次（充值赠送操作）
                           
                            str8 = "1";
                            break;

                        case "1"://1次充值或赠送操作
                            str8 = "0";
                            break;

                        case "0":
                            break;

                        default:
                            str8 = "0";
                            break;
                    }
                
                    ExecuteNonQuery("update Equipment set  IsDelay='" + str8 + "'  where EquNum='" + EquNUm + "'");

                    str2 = "";
                }
                 if (((str7 == "Y") || (str7 == "G")) || (str7 == "F"))
                //if (str7 == "Y"&&str8=="0")   //by wyb 只用Y表示充值,str8为delay
                {
                   
                    string str10 = "RemainTime=RemainTime";       
                    string str12 = str7;
                    if (str12 != null)
                    {
                        if (str12 == "Y")
                        {
                            if (GetReMaTime(EquNUm) >= decimal.Parse(sTM)){
                                str10 = "RemainTime=("+ sTM + "+Precharge)";// Y 充值操作

                            }
                            else
                            {
                                str10 = "RemainTime=(RemainTime+Precharge)";// Y 充值操作
                            }
                          
                        }
                        else if (str12 == "G")
                        {
                            str10 = "GiftTime=(GiftTime+PreGift)";//G 赠送操作
                        }
                        else if (str12 == "F")
                        {
                            str10 = "RemainTime=(RemainTime+Precharge),GiftTime=(GiftTime+PreGift)";//既有充值也有赠送
                        }
                    }
                    //str4 = "update Equipment Set " + str10 + ",Precharge='0',PreGift='0',Ispre='N', IsDelay='2' where EquNum='" + EquNUm + "' and RemainTime is not null";
                   
                    str4 = "update Equipment Set " + str10 + ",Precharge='0',PreGift='0',Ispre='N' where EquNum='" + EquNUm + "' and RemainTime is not null";//by wyb 2018-12-29 在管理系统直接更新IsDelay值
                    int num4 = 0;
                    if (GetIsEnabled(EquNUm) == "Y")
                    {
                        num4 = ExecuteNonQuery(str4);
                        decimal RemainTime_Updated = GetReMaTime(EquNUm);
                        string isend_val = "";//余额不足发送短信值 
                        if (RemainTime_Updated >= 500)
                        {
                            isend_val = "0,0,0,0";

                        }
                        else if (RemainTime_Updated < 500 & RemainTime_Updated >= 200)
                        {
                            isend_val = "1,0,0,0";

                        }
                        else if (RemainTime_Updated < 200 & RemainTime_Updated >= 100)
                        {
                            isend_val = "1,1,0,0";
                        }
                        else
                        {
                            isend_val = "1,1,1,1";
                        }
                        //更新短信标志
                        ExecuteNonQuery("update Equipment Set IsSend='" + isend_val + "' where EquNum='" + EquNUm + "' and RemainTime is not null");
                    }
                }
            }
            ExecuteNonQuery("update Equipment set EquStatus='" + sMSs + "' WHERE EquNum='" + EquNUm + "'");
            ExecuteNonQuery("update Equipment set ReviewTime='" + GetDate() + "' WHERE EquNum='" + EquNUm + "'");
            if (str2 == "")
            {
                return false;
            }
            return (ExecuteNonQuery(str2) >= 1);
        }

        public static decimal GetReMaTimes(string EquNUm)
        {
            DataSet dataSet = GetDataSet("select *, (GiftTime+RemainTime+Precharge+PreGift) ReMaTime from Equipment WHERE EquNum='" + EquNUm + "'");
            if (dataSet.Tables[0].Rows.Count >= 1)
            {
                string str2 = dataSet.Tables[0].Rows[0]["ReMaTime"].ToString();
                if (!string.IsNullOrWhiteSpace(str2))
                {
                    return Convert.ToDecimal(Math.Round(Convert.ToDecimal(str2), 0).ToString());
                }
            }
            return 0M;
        }

        public static decimal GetReTime(string EquNUm, decimal UseTime)
        {
            DataSet dataSet = GetDataSet(string.Concat(new object[] { "select *, (GiftTime+RemainTime-", UseTime, ") ReMaTime from Equipment WHERE EquNum='", EquNUm, "'" }));
            if (dataSet.Tables[0].Rows.Count >= 1)
            {
                string str2 = dataSet.Tables[0].Rows[0]["ReMaTime"].ToString();
                if (!string.IsNullOrWhiteSpace(str2))
                {
                    return Convert.ToDecimal(str2);
                }
            }
            return 0M;
        }

        public static decimal GetUpTime(string EquNUm)
        {
            DataSet dataSet = GetDataSet("select UpTime from  UpAndDown where EquNum ='" + EquNUm + "' ORDER BY ID DESC");
            if (dataSet.Tables[0].Rows.Count >= 1)
            {
                string str2 = dataSet.Tables[0].Rows[0][0].ToString();
                if (!string.IsNullOrWhiteSpace(str2))
                {
                    return Convert.ToDecimal(str2);
                }
            }
            return 0M;
        }

        public static decimal GetUseAmout(string EquNUm, decimal LtsTM)
        {
            DataSet dataSet = GetDataSet("select EquTypeID,GiftTime from Equipment where EquNum='" + EquNUm + "'");
            string str2 = "0";
            decimal num = 0M;
            decimal num2 = LtsTM;
            if (dataSet.Tables[0].Rows.Count >= 1)
            {
                str2 = dataSet.Tables[0].Rows[0]["EquTypeID"].ToString();
                num = Convert.ToDecimal(dataSet.Tables[0].Rows[0]["GiftTime"].ToString());
                if (num >= LtsTM)
                {
                    num2 = 0M;
                }
                else if (num == 0M)
                {
                    num2 = LtsTM;
                }
                else
                {
                    num2 = LtsTM - num;
                }
            }
            DataSet set2 = GetDataSet("select Price from EquType where ID='" + str2 + "'");
            if (set2.Tables[0].Rows.Count >= 1)
            {
                return (Convert.ToDecimal(set2.Tables[0].Rows[0][0].ToString()) * num2);
            }
            return 0M;
        }

        public static bool IsBuys(string EquNum)
        {
            DataSet dataSet = GetDataSet("select ISBuy from Equipment where EquNum='" + EquNum + "'");
            if (dataSet.Tables[0].Rows.Count < 1)
            {
                return false;
            }
            return (dataSet.Tables[0].Rows[0][0].ToString() == "是");
        }

        public static string IsDelay(string EquNum)
        {
            DataSet dataSet = GetDataSet("select IsDelay from Equipment where EquNum='" + EquNum + "'");
            if (dataSet.Tables[0].Rows.Count >= 1)
            {
                return dataSet.Tables[0].Rows[0][0].ToString();
            }
            return "0";
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

        public static bool IsIP(string ip)
        {
            return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }

        public static string IsPrest(string EquNum)
        {
            string str = "N";
            DataSet dataSet = GetDataSet("select IsPre from Equipment WHERE EquNum='" + EquNum + "'");
            if (dataSet.Tables[0].Rows.Count >= 1)
            {
                str = dataSet.Tables[0].Rows[0]["IsPre"].ToString();
            }
            return str;
        }

        public static bool IsSets(string EquNum)
        {
            DataSet dataSet = GetDataSet("select COUNT(*) from Equipment WHERE IsPre='S' AND  EquNum='" + EquNum + "'");
            if (dataSet.Tables[0].Rows.Count < 1)
            {
                return false;
            }
            string str2 = dataSet.Tables[0].Rows[0][0].ToString();
            if (string.IsNullOrWhiteSpace(str2))
            {
                return false;
            }
            if (str2 == "0")
            {
                return false;
            }
            return true;
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
                    GetContentFromUrll(" http://61.143.63.169:8080/Services.asmx/DirectSend?UserID=999595&Account=admin&Password=FW9NQ9&Phones=" + str + ";&Content=" + str2 + "&SendTime=&SendType=1&PostFixNumber=");
                }
                catch
                {
                }
            }
        }

        public static DataSet SetClientAndEqu3(string str)
        {
            return GetDataSet("select IsSend,ClientName,NumBer,(GiftTime+RemainTime) RemainTime,Phone,Agent,Seller,Engineer from Client,Equipment where Client.ID=Equipment.ClientID " + str);
        }

        public static bool UpEquIsSend(string EquNum, string Sta)
        {
            return (ExecuteNonQuery("Update Equipment set IsSend='" + Sta + "' where EquNum='" + EquNum + "'") >= 1);
        }

        public static int UpSets(string EquNum)
        {
            /*UpAndDown model = new UpAndDown {
                EquStaID = new int?(GetAddID()),
                EquNum = EquNum,
                IpAds = GetHostAddress(),
                TheTime = new decimal?(GetReMaTimes(EquNum)),
                UpTime = 0,
                Date = new DateTime?(GetDate()),
                Rest = "成功",
                Sta = "Settlement"
            };
            AddUpDown(model);*/
            return ExecuteNonQuery("update Equipment set IsPre='N',Precharge='0',PreGift='0',GiftTime='0',RemainTime='0'  WHERE  EquNum='" + EquNum + "'");
        }

        public static string IPAddress
        {
            get
            {
                string str;
                HttpRequest request = HttpContext.Current.Request;
                if (request.ServerVariables["HTTP_X_FORWARDED_FOR"] != "")
                {
                    str = request.ServerVariables["REMOTE_ADDR"];
                }
                else
                {
                    str = request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                }
                if ((str != null) && (str != ""))
                {
                    return str;
                }
                return request.UserHostAddress;
            }
        }
    }
}

