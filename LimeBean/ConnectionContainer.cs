using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LimeBean {

    abstract class ConnectionContainer  {
        public abstract IDbConnection Connection { get; }

        public virtual void Dispose() {         
        }

        internal class SimpleImpl : ConnectionContainer {
            IDbConnection _conn;

            public SimpleImpl(IDbConnection conn) {
                _conn = conn;
            }

            public override IDbConnection Connection { 
                get { return _conn; } 
            }
        }

        internal class LazyImpl : ConnectionContainer {
            IDbConnection _conn;
            string _connectionString;
            Func<IDbConnection> _factory;

            public LazyImpl(string connectionString, Func<IDbConnection> factory) {
                _connectionString = connectionString;
                _factory = factory;
            }

            public override IDbConnection Connection {
                get {
                    if(_conn == null) {
                        _conn = _factory();                        
                        _conn.ConnectionString = _connectionString;
                        _conn.Open();
                        _factory = null;
                        _connectionString = null;
                    }
                    return _conn; 
                }
            }

            public sealed override void Dispose() {
                if(_conn != null)
                    _conn.Dispose();
            }
        }

    }

}
