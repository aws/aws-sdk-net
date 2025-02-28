/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;

using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Amazon.SecurityToken.SAML
{
    /// <summary>
    /// Implementation of IAuthenticationController, allowing authentication calls against
    /// an AD FS endpoint.
    /// </summary>
    internal partial class AdfsAuthenticationController : IAuthenticationController
    {
        /// <summary>
        /// Authenticates the user with the specified AD FS endpoint and 
        /// yields the SAML response data for subsequent parsing.
        /// </summary>
        /// <param name="identityProvider">
        /// The https endpoint of the federated identity provider.
        /// </param>
        /// <param name="credentials">
        /// Credentials for the call. If null, the user's default network credentials 
        /// will be used in a temporary impersonation context.
        /// </param>
        /// <param name="authenticationType">
        /// The authentication type to be used with the endpoint. Valid values are 'NTLM',
        /// 'Digest', 'Kerberos' and 'Negotiate'.
        /// </param>
        /// <param name="proxySettings">Null or configured proxy settings for the HTTPS call.</param>
        /// <returns>The response data from a successful authentication request.</returns>
        public string Authenticate(Uri identityProvider, ICredentials credentials, string authenticationType,
#if NETSTANDARD
            IWebProxy proxySettings)
#else
            WebProxy proxySettings)
#endif
        {
            try
            {
                return QueryProvider(identityProvider, proxySettings, credentials, authenticationType);
            }
            catch (Exception e)
            {
                throw new AdfsAuthenticationControllerException(e.ToString(), e);
            }
        }

        /// <summary>
        /// Authenticates the user with the specified AD FS endpoint and 
        /// yields the SAML response data for subsequent parsing.
        /// </summary>
        /// <param name="identityProvider">
        /// The https endpoint of the federated identity provider.
        /// </param>
        /// <param name="credentials">
        /// Credentials for the call. If null, the user's default network credentials 
        /// will be used in a temporary impersonation context.
        /// </param>
        /// <param name="authenticationType">
        /// The authentication type to be used with the endpoint. Valid values are 'NTLM',
        /// 'Digest', 'Kerberos' and 'Negotiate'.
        /// </param>
        /// <param name="proxySettings">Null or configured proxy settings for the HTTPS call.</param>
        /// <returns>The response data from a successful authentication request.</returns>
        public async Task<string> AuthenticateAsync(Uri identityProvider, ICredentials credentials, string authenticationType,
#if NETSTANDARD
            IWebProxy proxySettings)
#else
            WebProxy proxySettings)
#endif
        {
            try
            {
                return await QueryProviderAsync(identityProvider, proxySettings, credentials, authenticationType).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                throw new AdfsAuthenticationControllerException(e.ToString(), e);
            }
        }

        private static string QueryProvider(Uri identityProvider, IWebProxy proxySettings, ICredentials credentials, string authenticationType)
        {
            var uri = identityProvider;
            var cookieContainer = new CookieContainer();
            int redirectionsCount = 0;
            string responseData = null;
            var connectionGroup = Guid.NewGuid().ToString(); //This is to avoid having multiple users sharing the same connection
                                                             //if they authenticate against the same endpoint.
            while (responseData == null)
            {
                HttpWebResponse response = null;

                try
                {
                    HttpWebRequest request = null;
                    WebException webRequestException = null;
                    try
                    {
                        request = CreateRequest(proxySettings, credentials, authenticationType, uri, cookieContainer, connectionGroup);
                        response = (HttpWebResponse)request.GetResponse();
                    }
                    catch (WebException e)
                    {
                        webRequestException = e;
                        response = (HttpWebResponse)e.Response;
                    }

                    Uri redirectedUri = null;
                    if (response != null)
                    {
                        const int minRedirectStatusCode = 300;
                        const int maxRedirectStatusCode = 399;

                        int statusCode = (int)response.StatusCode;

                        if (statusCode >= minRedirectStatusCode &&
                            statusCode <= maxRedirectStatusCode &&
                            redirectionsCount++ < request.MaximumAutomaticRedirections)
                        {
                            var location = response.Headers[HttpResponseHeader.Location];
                            if (location != null)
                            {
                                redirectedUri = new Uri(uri, location);
                            }
                        }
                    }

                    if (redirectedUri != null)
                    {
                        uri = redirectedUri;
                    }
                    else if (webRequestException != null)
                    {
                        throw webRequestException;
                    }
                    else
                    {
                        using (var reader = new StreamReader(response.GetResponseStream()))
                        {
                            responseData = reader.ReadToEnd();
                        }
                    }
                }
                finally
                {
                    response?.Close();
                    response?.Dispose();
                }
            }

            return responseData;
        }

        private static async Task<string> QueryProviderAsync(Uri identityProvider, IWebProxy proxySettings, ICredentials credentials, string authenticationType)
        {
            var uri = identityProvider;
            var cookieContainer = new CookieContainer();
            int redirectionsCount = 0;
            string responseData = null;
            var connectionGroup = Guid.NewGuid().ToString(); //This is to avoid having multiple users sharing the same connection
                                                             //if they authenticate against the same endpoint.
            while (responseData == null)
            {
                HttpWebResponse response = null;

                try
                {
                    HttpWebRequest request = null;
                    WebException webRequestException = null;
                    try
                    {
                        request = CreateRequest(proxySettings, credentials, authenticationType, uri, cookieContainer, connectionGroup);
                        response = (HttpWebResponse)(await request.GetResponseAsync().ConfigureAwait(false));
                    }
                    catch (WebException e)
                    {
                        webRequestException = e;
                        response = (HttpWebResponse)e.Response;
                    }

                    Uri redirectedUri = null;
                    if (response != null)
                    {
                        const int minRedirectStatusCode = 300;
                        const int maxRedirectStatusCode = 399;

                        int statusCode = (int)response.StatusCode;

                        if (statusCode >= minRedirectStatusCode &&
                            statusCode <= maxRedirectStatusCode &&
                            redirectionsCount++ < request.MaximumAutomaticRedirections)
                        {
                            var location = response.Headers[HttpResponseHeader.Location];
                            if (location != null)
                            {
                                redirectedUri = new Uri(uri, location);
                            }
                        }
                    }

                    if (redirectedUri != null)
                    {
                        uri = redirectedUri;
                    }
                    else if (webRequestException != null)
                    {
                        throw webRequestException;
                    }
                    else
                    {
                        using (var reader = new StreamReader(response.GetResponseStream()))
                        {
                            responseData = await reader.ReadToEndAsync().ConfigureAwait(false);
                        }
                    }
                }
                finally
                {
                    response?.Close();
                    response?.Dispose();
                }
            }

            return responseData;
        }

        private static HttpWebRequest CreateRequest(IWebProxy proxySettings, ICredentials credentials, string authenticationType, Uri uri, CookieContainer cookieContainer, string connectionGroup)
        {
#pragma warning disable SYSLIB0014 // Disable obsolete warning for WebRequest.Create because we can't switch to HttpClient while we still target .NET Framework 3.5
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
#pragma warning disable SYSLIB0014
            request.CookieContainer = cookieContainer;
            request.ConnectionGroupName = connectionGroup;
            request.KeepAlive = true; //KeepAlive = false doesn't work on .NET Core 2.1+
            request.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";
            request.AllowAutoRedirect = false; // Handling redirection manually to avoid 401 errors
            if (proxySettings != null)
            {
                request.Proxy = proxySettings;
            }
            if (credentials != null)
            {
                request.Credentials = credentials?.GetCredential(uri, authenticationType);
            }
            else
            {
                request.UseDefaultCredentials = true;
            }

            return request;
        }
    }

    /// <summary>
    /// Custom exception thrown when authentication failure is detected against
    /// a configured AD FS endpoint.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public class AdfsAuthenticationControllerException : Exception
    {
        /// <summary>
        /// Initializes a new exception instance.
        /// </summary>
        /// <param name="message"></param>
        public AdfsAuthenticationControllerException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new exception instance.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public AdfsAuthenticationControllerException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new exception instance.
        /// </summary>
        /// <param name="innerException"></param>
        public AdfsAuthenticationControllerException(Exception innerException)
            : base(innerException.Message, innerException)
        {
        }

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the AdfsAuthenticationControllerException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected AdfsAuthenticationControllerException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }

    /// <summary>
    /// Implementation of IAuthenticationResponseParser, allowing parsing of the responses for 
    /// successful authentication calls against AD FS endpoints.
    /// </summary>
    internal partial class AdfsAuthenticationResponseParser : IAuthenticationResponseParser
    {
        /// <summary>
        /// Parses the authentication response (html) and extracts the SAML response (xml)
        /// for further parsing.
        /// </summary>
        /// <param name="authenticationResponse">
        /// The HTML response data from the successful authentication call.
        /// </param>
        /// <returns>
        /// Assertion instance containing the data needed to support credential generation.
        /// </returns>
        public SAMLAssertion Parse(string authenticationResponse)
        {
            var samlAssertion = string.Empty;

            var matches = SamlResponseRegex().Matches(authenticationResponse);
            foreach (Match m in matches)
            {
                var last = m.Groups[1].Value;
                samlAssertion = last;
            }

            return new SAMLAssertion(samlAssertion);
        }

        private const string SamlResponseRegexPattern = "SAMLResponse\\W+value\\=\\\"([^\\\"]+)\\\"";

#if NET8_0_OR_GREATER
        [GeneratedRegex(SamlResponseRegexPattern)]
        private static partial Regex SamlResponseRegex();
#else
        private static Regex SamlResponseRegex() => _samlResponseRegex;
        private static readonly Regex _samlResponseRegex = new Regex(SamlResponseRegexPattern);
#endif
    }
}