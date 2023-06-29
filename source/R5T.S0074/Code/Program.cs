using System;
using System.Threading.Tasks;


namespace R5T.S0074
{
    class Program
    {
        static async Task Main()
        {
            //await GitHubRepositoryScripts.Instance.Create_Repository();
            //await GitHubRepositoryScripts.Instance.Delete_Repository();
            //await GitHubRepositoryScripts.Instance.Get_Repository_IsPrivate_ByUrl();
            //await GitHubRepositoryScripts.Instance.Get_Repository_IsPrivate_ByDirectoryPath();
            await GitHubRepositoryScripts.Instance.Get_Repository_IsPrivate_ByPathInRepository();
        }
    }
}