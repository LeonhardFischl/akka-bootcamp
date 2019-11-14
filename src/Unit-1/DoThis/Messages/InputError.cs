namespace WinTail.Messages
{
    public abstract class InputError
    {
        public string Reason { get; }

        protected InputError(string reason)
        {
            Reason = reason;
        }
    }
}
