using System;


namespace R5T.S0074
{
    public static class Instances
    {
        public static L0038.IApplicationContextOperator ApplicationContextOperator => L0038.ApplicationContextOperator.Instance;
        public static O0017.IGitHubRepositoryOperations GitHubRepositoryOperations => O0017.GitHubRepositoryOperations.Instance;
        public static O0023.IGitOperations GitOperations => O0023.GitOperations.Instance;
        public static Z0043.IOwnerNames OwnerNames => Z0043.OwnerNames.Instance;
        public static IPaths Paths => S0074.Paths.Instance;
        public static Z0046.IUrls Urls => Z0046.Urls.Instance;
        public static IValues Values => S0074.Values.Instance;
    }
}