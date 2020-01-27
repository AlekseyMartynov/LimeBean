using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LimeBean {
    using Row = IDictionary<string, object>;

    interface IDatabaseAccess : ITransactionSupport {
        event Action<IDbCommand> QueryExecuting;
        int CacheCapacity { get; set; }        

        int Exec(string sql, params object[] parameters);

        IEnumerable<T> ColIterator<T>(string sql, params object[] parameters);
        IEnumerable<Row> RowsIterator(string sql, params object[] parameters);

        T Cell<T>(bool useCache, string sql, params object[] parameters);
        T[] Col<T>(bool useCache, string sql, params object[] parameters);
        Row Row(bool useCache, string sql, params object[] parameters);
        Row[] Rows(bool useCache, string sql, params object[] parameters);
    }

}
