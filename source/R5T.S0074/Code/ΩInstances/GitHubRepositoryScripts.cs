using System;


namespace R5T.S0074
{
    public class GitHubRepositoryScripts : IGitHubRepositoryScripts
    {
        #region Infrastructure

        public static IGitHubRepositoryScripts Instance { get; } = new GitHubRepositoryScripts();


        private GitHubRepositoryScripts()
        {
        }

        #endregion
    }
}
