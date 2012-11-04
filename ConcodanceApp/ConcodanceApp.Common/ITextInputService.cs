namespace ConcodanceApp.Common
{
    public interface ITextInputService
    {
        string FileLocation { get; set; }
        string ReadTextFile();
    }
}