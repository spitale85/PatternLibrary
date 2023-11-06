namespace AdapterPattern.Sms
{
    public interface ITextSender
    {
        void Notify(string yoNumber, string message);

    }
}
