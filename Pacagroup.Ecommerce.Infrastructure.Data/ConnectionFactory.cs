﻿using Microsoft.Extensions.Configuration;
using Pacagroup.Ecommerce.Transversal.Common;
using System.Data;
using System.Data.SqlClient;

namespace Pacagroup.Ecommerce.Infrastructure.Data
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection GetConnection
        {
            get
            {
                SqlConnection sqlConnection = new SqlConnection();
                if (sqlConnection == null) return null;
                sqlConnection.ConnectionString = _configuration.GetConnectionString("Connection");
                sqlConnection.Open();
                return sqlConnection;
            }
        }
    }
}