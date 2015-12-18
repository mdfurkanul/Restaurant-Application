using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Restaurant_Application
{
    class FileReadWrite
    {
        // 1 user email
        // 2 login or not
        // 3 seat or not
        // 4 table with date and time thats means unique
        // 5 countdown show or not
        public string getTableValueString() {
            try {
                StreamReader strm = null;
                strm = new StreamReader(global::Restaurant_Application.Properties.Resources.tableno);
                return strm.ReadLine();
            }catch(Exception e){
                return "null=="+e;
            }
            
        }
        public void putTableValueString(string strValue)
        {
            try
            {
                StreamWriter putTxt = new StreamWriter(global::Restaurant_Application.Properties.Resources.tableno, false);
                putTxt.WriteLine(strValue);
                putTxt.Close();
            }
            catch (Exception e)
            {
               // return "null==" + e;
            }

        }
        public string getEmailValueString()
        {
            try
            {
                using (StreamReader strm = new StreamReader(global::Restaurant_Application.Properties.Resources.email))
                {
                    return strm.ReadLine();
                }
            }
            catch (Exception e)
            {
                return "null==" + e;
            }

        }
        public void putEmailValueString(string strValue)
        {

            using(StreamWriter putTxt = new StreamWriter(global::Restaurant_Application.Properties.Resources.email, false))
            {
                putTxt.WriteLine(strValue);
            }


        }
        public string getLoginValueString()
        {
            try
            {
                using (StreamReader strm = new StreamReader(global::Restaurant_Application.Properties.Resources.Login))
                {
                    return strm.ReadLine();
                }
            }
            catch (Exception e)
            {
                return "null==" + e;
            }

        }
        public void putLoginValueString(string str)
        {
            
        
            using(StreamWriter p_Txt = new StreamWriter(global::Restaurant_Application.Properties.Resources.Login, false))
            {
                p_Txt.WriteLine(str);
            }

        }
        public string getOrderIDValueString()
        {
            try
            {
                using (StreamReader strm = new StreamReader(global::Restaurant_Application.Properties.Resources.orderID))
                {
                    return strm.ReadLine();
                }
            }
            catch (Exception e)
            {
                return "null==" + e;
            }

        }
        public void putOrderIDValueString(string str)
        {


            using (StreamWriter p_Txt = new StreamWriter(global::Restaurant_Application.Properties.Resources.orderID, false))
            {
                p_Txt.WriteLine(str);
            }

        }
    }
}
