using System;
using System.Threading.Tasks;

using R5T.L0038;
using R5T.T0132;
using R5T.T0180;
using R5T.T0186.Extensions;
using R5T.T0200;


namespace R5T.S0074
{
    [FunctionalityMarker]
    public partial interface IGitHubRepositoryScripts : IFunctionalityMarker
    {
        /// <summary>
        /// Given the path of a file in a local Git clone of a remote GitHub repository, is the remote GitHub repository private?
        /// </summary>
        public async Task Get_Repository_IsPrivate_ByPathInRepository()
        {
            /// Inputs.
            var path =
                Instances.Paths.Example_DirectoryWithinRepositoryDirectoryPath
                ;


            /// Run.
            var isPrivate = await Instances.GitHubRepositoryOperations.Is_Private(path);

            Console.WriteLine($"{isPrivate}: is private\n\t{path}");
        }

        public async Task Get_Repository_IsPrivate_ByDirectoryPath()
        {
            /// Inputs.
            var repositoryDirectoryPath =
                Instances.Paths.Example_RepositoryDirectoryPath
                ;


            /// Run.
            var isPrivate = await Instances.GitHubRepositoryOperations.Is_Private(repositoryDirectoryPath);

            Console.WriteLine($"{isPrivate}: is private\n\t{repositoryDirectoryPath}");
        }

        public async Task Get_Repository_IsPrivate_ByUrl()
        {
            /// Inputs.
            var repositoryUrl =
                Instances.Urls.Example_GitHubRepositoryUrl
                ;


            /// Run.
            var isPrivate = await Instances.GitHubRepositoryOperations.Is_Private(repositoryUrl);

            Console.WriteLine($"{isPrivate}: is private\n\t{repositoryUrl}");
        }

        public void Get_RepositoryUrl()
        {
            /// Inputs.
            var repositoryDirectoryPath =
                Instances.Paths.Example_RepositoryDirectoryPath
                ;


            /// Run.
            var repositoryUrl = Instances.GitOperations.Get_RepositoryUrl(repositoryDirectoryPath);

            Console.WriteLine($"{repositoryDirectoryPath}\n=>\n{repositoryUrl}");
        }

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
