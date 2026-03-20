
namespace SQLLookupTool.Intelligence
{
    internal static class MessageDelegates
    {
        public delegate void ResultMessageEventHandler(string message);
        public delegate void ErrorMessageEventHandler(string category, string message);
    }
}
