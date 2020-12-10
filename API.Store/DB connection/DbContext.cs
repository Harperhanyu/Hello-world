using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace API.Store.DB_connection
{
    public class DbContext : IDbContext
    {
        protected IConnectionProvider _connectionProvider;
        protected IDbConnection _connection;
        protected IDbTransaction _transaction;

        protected bool _disposed;

        public DbContext(IConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;               //构造注入连接对象的接口20191008——ZMan
            _connection = _connectionProvider.CreateConnection();   //创建连接对象
            _connection.Open();
            _transaction = _connection.BeginTransaction();            //开启事务
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
            }
        }

        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }

        private void dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_transaction != null)
                    {
                        _transaction.Dispose();
                        _transaction = null;
                    }

                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }
                _disposed = true;
            }
        }
    }
}
