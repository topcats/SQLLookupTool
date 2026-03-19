using System;
using static SQLLookupTool.Intelligence.MessageDelegates;

namespace SQLLookupTool.Interfaces
{
    internal interface ISqlSrv : IDisposable
    {

        /// <summary>
        /// Fired for a Result Line
        /// </summary>
        /// <param name="message">Result line</param>
        event ResultMessageEventHandler ResultMessage;

        /// <summary>
        /// Fired for an Error message
        /// </summary>
        /// <param name="category">Error category</param>
        /// <param name="message">Error Mssage</param>
        event ErrorMessageEventHandler ErrorMessage;

        /// <summary>
        /// Execute SQL Statement
        /// </summary>
        /// <remarks>results will go to events</remarks>
        /// <param name="sql">SQL to execute</param>
        void ExecuteStatement(string sql);
    }
}
