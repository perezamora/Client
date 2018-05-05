using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppMVCStudent.Common.Logic.Logger
{
    public class ALog4NetLogger : ILogger
    {
        private readonly ILog _log;

        public ALog4NetLogger()
        {
            this._log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        }

        public void Debug(object message)
        {
            this._log.Debug(message);
        }

        public void Error(object message)
        {
            this._log.Error(message);
        }

        public void Fatal(object message)
        {
            this._log.Fatal(message);
        }

        public void Info(object message)
        {
            this._log.Info(message);
        }

        public void Warn(object message)
        {
            this._log.Warn(message);
        }
    }
}
