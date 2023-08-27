//using Microsoft.EntityFrameworkCore.Internal;
using EHR.Core.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Application.Data
{
    public class DatabaseContext
    {
        private readonly IConfiguration _config;
        private readonly string _connectionString;

        public DatabaseContext(IConfiguration config)
        {
            _config= config;
            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        public IDbConnection createConnection()
        {
            return new SqlConnection(_connectionString);
        } 
    }
}
