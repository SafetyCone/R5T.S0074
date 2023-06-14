using System;
using System.Threading.Tasks;

using R5T.L0038;
using R5T.T0132;
using R5T.T0186.Extensions;


namespace R5T.S0074
{
    [FunctionalityMarker]
    public partial interface IGitHubRepositoryScripts : IFunctionalityMarker
    {
        public async Task Delete_Repository()
        {
            /// Inputs.
            var repositoryName =
                Instances.Values.Sample_RepositoryName
                ;
            var repositoryOwnerName =
                Instances.OwnerNames.SafetyCone
                ;


            /// Run.
            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation
            );

            async Task ApplicationContextOperation(
                IApplicationContext applicationContext)
            {
                await Instances.GitHubRepositoryOperations.Delete_Repository(
                    repositoryName.Value.ToGitHubRepositoryName(),
                    repositoryOwnerName,
                    applicationContext.TextOutput);
            }
        }

        public async Task Create_Repository()
        {
            /// Inputs.
            var repositoryName =
                Instances.Values.Sample_RepositoryName
                ;
            var repositoryDescription =
                Instances.Values.Sample_RepositoryDescription
                ;
            var repositoryOwnerName =
                Instances.OwnerNames.SafetyCone
                ;


            /// Run.
            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation
            );

            async Task ApplicationContextOperation(
                IApplicationContext applicationContext)
            {
                await Instances.GitHubRepositoryOperations.Create_Repository(
                    repositoryName.Value.ToGitHubRepositoryName(),
                    repositoryDescription,
                    repositoryOwnerName,
                    applicationContext.TextOutput);
            }
        }
    }
}
