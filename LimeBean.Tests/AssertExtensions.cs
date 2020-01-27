using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Xunit.Sdk;

namespace LimeBean.Tests {

    static class AssertExtensions {

        public static void Equivalent<T>(IEnumerable<T> expected, IEnumerable<T> actual) {
            if(!new HashSet<T>(actual).SetEquals(expected))
                throw new EqualException(expected, actual);
        }

        public static void WithCulture(string culture, Action action) {
            var backup = CultureInfo.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
            try {
                action();
            } finally {
                Thread.CurrentThread.CurrentCulture = backup;
            }
        }

    }

}
