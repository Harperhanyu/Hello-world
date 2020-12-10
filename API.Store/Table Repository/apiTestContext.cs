using API.Store.DB_connection;
using API.Store.Model.API;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace API.Store.Table_Repository
{
    public class apiTestContext: DbConnectionObj,IapiTestContext
    {
        public apiTestContext(IDbConnection connection, IDbTransaction transaction)
            : base(connection, transaction)
        {
        }

        public bool Insert(apiTestModel insertObj)
        {
            string sql = @"INSERT into apiTest(uname,sex,phone) values(:uname,:sex,:phone)";
            int row = _Connection.Execute(sql, insertObj);
            if (row == 1)
                return true;
            else
                return false;
        }

        public bool Delete(string no)
        {
            string sql = @"delete from apiTest where userid=:StoreOutReasonNo;";

            int row = _Connection.Execute(sql, new { StoreOutReasonNo = no });
            if (row == 1)
                return true;
            else
                return false;
        }

        public IList<apiTestModel> Query(int uid)
        {
            string sql = @"SELECT * from apiTest
                                        WHERE userid= :no";

            return _Connection.Query<apiTestModel>(sql,new { no=uid},
                commandType: CommandType.Text).ToList();
        }

        public bool Modify(apiTestModel updateObj)
        {
            string sql = @"UPDATE apiTest
                                    set userid=:userid,   
                                            uname = :uname,
                                            sex = :sex,
                                            phone = :phone,
                                    WHERE userid = :userid";

            int row = _Connection.Execute(sql, updateObj);
            if (row == 1)
                return true;
            else
                return false;
        }
    }
}
