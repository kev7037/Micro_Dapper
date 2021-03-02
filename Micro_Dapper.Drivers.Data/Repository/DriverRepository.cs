using Dapper;
using Micro_Dapper.Drivers.Domain.Interfaces;
using Micro_Dapper.Drivers.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micro_Dapper.Drivers.Data.Repository
{
    public class DriverRepository : IDriverRepository
    {
        private readonly string ConnectionString = $"";

        public async Task<IEnumerable<Driver>> GetAllDrivers()
        {
            IEnumerable<Driver> DriversList = new List<Driver>();
            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionString))
                {
                    DynamicParameters param = new DynamicParameters();

                    string Sp = "[dbo].[Stp_GetAllDrivers]";

                    DriversList = await connection.QueryAsync<Driver>(Sp, null, commandType: CommandType.StoredProcedure);

                }
            }
            catch (Exception e)
            {
                string msg = e.Message;
            }
            

            return DriversList;
        }
        public IEnumerable<Driver> GetDriverByParam(Driver driver) => throw new NotImplementedException();
    }
}
