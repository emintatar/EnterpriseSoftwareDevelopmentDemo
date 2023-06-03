using ConnectedServices.BankMainService;
using Core.CrossCuttingConcerns.Logging.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Adapters
{
    public class MainLoggerAdapter : ILogger
    {
        public void Log()
        {
            MainLogger mainLogger = new MainLogger();
            mainLogger.LogToMain();
        }
    }
}