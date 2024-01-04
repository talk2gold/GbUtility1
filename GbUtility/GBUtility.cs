namespace GbUtility
{
  
        public static class orclUtil
        {
            public static string getOracleDate(DateTime arg)
            {
                string ret = "";
                ret = "to_date('" + arg.ToString("yyyyMMdd") + "','YYYYMMDD')";
                return ret;
            }

            public static string getOracleString(string argstr)
            {
                string ret = "";

                if (argstr is null || argstr.Equals("") || argstr.ToUpper().Equals("NULL"))
                {
                    ret = "null";
                }
                else
                {
                    ret = "'" + argstr.Replace("'", "''") + "'";
                }
                return ret;
            }
        }
 
}