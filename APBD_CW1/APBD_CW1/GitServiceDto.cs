using System.Runtime.Serialization;

namespace APBD_CW1;

[DataContract]
public class GitServiceDto
{
    [DataMember]
    public string RepoName { get; set; }
    
    [DataMember]
    public string BranchName { get; set; }
    
}