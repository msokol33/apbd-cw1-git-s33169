namespace APBD_CW1;

public class GitService : IGitService
{
    public GitService()
    {
        
    }
    public IList<string> GetCommits(string uri)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("https://github.com/msokol33/apbd-cw1-git-s33169/commits/main/");
        client.DefaultRequestHeaders.Accept.Clear();
        var response =  client.GetAsync("");
        response.Result.EnsureSuccessStatusCode();
        var result = response.Result.Content.ReadAsStringAsync().Result;
        return result.Split('\n').ToList();
    }
}