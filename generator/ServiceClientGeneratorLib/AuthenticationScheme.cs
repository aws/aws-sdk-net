using System.Collections.Generic;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Constants for the supported authentication schemes. 
    /// This class also contains collections of common combinations that are used for comparisons with the service models.
    /// </summary>
    public class AuthenticationScheme
    {
        public const string SigV4 = "aws.auth#sigv4";
        public static List<string> SigV4Schemes = new List<string>
        {
            SigV4,
        };

        public const string SigV4A = "aws.auth#sigv4a";
        public static List<string> SigV4ASchemes = new List<string>
        {
            SigV4A,
        };

        public static List<string> SigV4AndSigV4ASchemes = new List<string>
        {
            SigV4,
            SigV4A,
        };

        public const string Bearer = "smithy.api#httpBearerAuth";
        public static List<string> BearerSchemes = new List<string>
        {
            Bearer,
        };

        public const string NoAuth = "smithy.api#noAuth";
        public static List<string> NoAuthSchemes = new List<string>
        {
            NoAuth,
        };
    }
}
