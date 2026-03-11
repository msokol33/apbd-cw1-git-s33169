namespace APBD_CW1;

public interface IGitService
{
    public IList<string> GetCommits(string uri);
}