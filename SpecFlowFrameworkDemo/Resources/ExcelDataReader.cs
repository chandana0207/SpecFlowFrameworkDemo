using Dapper;

using System.Configuration;
using System.Data.OleDb;
using System.Linq;


namespace SpecFlowFrameworkDemo.Resources
{
    public class ExcelDataReader
    {
        public static string TestDataFileConnection()
        {
            string filenamenew = System.IO.Directory.GetParent(@"../../../").FullName;
            string fileName = filenamenew + "\\Resources\\TestDataSheet.xlsx";
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", fileName);
            return con;
        }

        public static UserData GetTestData(string sheetname, string keyname)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [{0}$] where key='{1}'", sheetname, keyname);
                var value = connection.Query<UserData>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }


        public static WorkItemDates GetWorkItemDates(string sheetname, string keyname)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [WorkItemDates$] where EnterUserDates='Dates'", sheetname, keyname);
                var value = connection.Query<WorkItemDates>(query).FirstOrDefault();
                connection.Close();
                return value;
            }

        }



        public static ProgrammeDetails GetProgrammeDetails(string sheetname, string keyname)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [{0}$] where EnterProgrammeDetails='ProgrammeDetails'", sheetname, keyname);
                var value = connection.Query<ProgrammeDetails>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        
        }




    }
}
