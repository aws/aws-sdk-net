using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ThirdParty.Json.LitJson;

namespace CredentialsVendor
{
    class Program
    {
        /// <summary>
        /// Time to preemptively refresh credentials.
        /// If the credentials are going to expire within this time, new credentials
        /// will be generated.
        /// </summary>
        private static TimeSpan ExpirePreemptTime = TimeSpan.FromMinutes(15);

        static int Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("No target credentials file passed, exiting");
                return 1;
            }

            var vendedCredentials = 0;
            foreach (var arg in args)
            {
                var credentialsFile = Path.GetFullPath(arg);
                // Only generate credentials if the credentials file is present
                if (!File.Exists(credentialsFile))
                {
                    Console.WriteLine("Credentials file {0} not present, skipping vending of credentials", credentialsFile);
                    continue;
                }

                Console.WriteLine("Attempting to retrieve existing credentials from {0}", credentialsFile);
                var credentials = FromJsonFile(credentialsFile);

                // Generate new credentials if no credentials are found or the found
                // credentials will expire within the preemptive period.
                var shouldRefreshCredentials =
                    credentials == null ||
                    (credentials.Expiration - DateTime.Now) < ExpirePreemptTime;
                if (shouldRefreshCredentials)
                {
                    Console.WriteLine("Credentials for {0} should be regenerated", credentialsFile);
                    credentials = GenerateNewCredentials();
                    if (credentials == null)
                    {
                        Console.WriteLine("Credentials for {0} could not be generated")
                    }
                    else
                    {
                        WriteToJsonFile(credentials, credentialsFile);
                        vendedCredentials++;
                    }
                }
                else
                    Console.WriteLine("Credentials for {0} not being regenerated");
            }

            Console.WriteLine("Vended credentials: {0}", vendedCredentials);
            return 0;
        }

        private static Credentials GenerateNewCredentials()
        {
            Console.WriteLine("Creating STS client...");
            try
            {
                using (var stsClient = new AmazonSecurityTokenServiceClient())
                {
                    Console.WriteLine("Retrieving session credentials...");
                    var credentials = stsClient.GetSessionToken().Credentials;

                    var expireTime = credentials.Expiration;
                    var lifetime = expireTime - DateTime.Now;
                    Console.WriteLine("Retrieved credentials that will expire after {0} (in {1})", expireTime, lifetime);

                    return credentials;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Failed during credentials retrieval: {0}");
                return null;
            }
        }

        private static Credentials FromJsonFile(string path)
        {
            try
            {
                var json = File.ReadAllText(path);
                return FromJson(json);
            }
            catch
            {
                return null;
            }
        }
        private static Credentials FromJson(string json)
        {
            var credentials = JsonMapper.ToObject<Credentials>(json);
            return credentials;
        }
        private static string ToJson(Credentials credentials)
        {
            using (var stringWriter = new StringWriter())
            {
                var writer = new JsonWriter(stringWriter);
                writer.PrettyPrint = true;
                JsonMapper.ToJson(credentials, writer);
                var json = stringWriter.ToString();
                return json;
            }
        }
        private static void WriteToJsonFile(Credentials credentials, string path)
        {
            Console.WriteLine("Generating JSON document for credentials");
            var json = ToJson(credentials);
            Console.WriteLine("Writing credentials to {0}", path);
            File.WriteAllText(path, json);
        }
    }
}
