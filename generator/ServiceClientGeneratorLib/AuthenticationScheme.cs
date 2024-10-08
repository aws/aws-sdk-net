namespace ServiceClientGenerator
{
    /// <summary>
    /// Constants for the supported authentication schemes.
    /// </summary>
    public class AuthenticationScheme
    {
        public const string SigV4 = "aws.auth#sigv4";
        public const string SigV4A = "aws.auth#sigv4a";
        public const string Bearer = "smithy.api#httpBearerAuth"; 
        public const string NoAuth = "smithy.api#noAuth";
    }
}
