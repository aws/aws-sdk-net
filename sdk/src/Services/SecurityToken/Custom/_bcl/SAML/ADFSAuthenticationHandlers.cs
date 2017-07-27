/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

namespace Amazon.SecurityToken.SAML
{
    /// <summary>
    /// Implementation of IAuthenticationController, allowing authentication calls against
    /// an AD FS endpoint.
    /// </summary>
    internal class AdfsAuthenticationController : IAuthenticationController
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
        public string Authenticate(Uri identityProvider, ICredentials credentials, string authenticationType, WebProxy proxySettings)
        {
            string responseStreamData = null;
            ImpersonationState impersonationState = null;

            try
            {
                if (credentials != null)
                {
                    var networkCredentials = credentials.GetCredential(identityProvider, authenticationType);
                    impersonationState = ImpersonationState.Impersonate(networkCredentials);
                }

                using (var response = QueryProvider(identityProvider, proxySettings))
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseStreamData = reader.ReadToEnd();
                    }
                }
            }
            catch (Exception e)
            {
                throw new AdfsAuthenticationControllerException(e.ToString(), e);
            }
            finally
            {
                if (impersonationState != null)
                    impersonationState.Dispose();
            }

            return responseStreamData;
        }


        private static HttpWebResponse QueryProvider(Uri identityProvider, WebProxy proxySettings)
        {
            var request = (HttpWebRequest)WebRequest.Create(identityProvider);
            request.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)";
            request.KeepAlive = true;
            request.PreAuthenticate = true;
            request.AllowAutoRedirect = true;
            request.CookieContainer = new CookieContainer();
            if (proxySettings != null)
                request.Proxy = proxySettings;
            request.UseDefaultCredentials = true;

            return (HttpWebResponse)request.GetResponse();
        }

    }

    /// <summary>
    /// Custom exception thrown when authentication failure is detected against
    /// a configured AD FS endpoint.
    /// </summary>
#if !PCL && !CORECLR
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



#if !PCL && !CORECLR
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
    internal class AdfsAuthenticationResponseParser : IAuthenticationResponseParser
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

            var reg = new Regex("SAMLResponse\\W+value\\=\\\"([^\\\"]+)\\\"");
            var matches = reg.Matches(authenticationResponse);
            foreach (Match m in matches)
            {
                var last = m.Groups[1].Value;
                samlAssertion = last;
            }

            return new SAMLAssertion(samlAssertion);
        }
    }

    /// <summary>
    /// Holds the temporary user impersonation state data, if needed across
    /// the SAML negotiation calls.
    /// </summary>
    internal class ImpersonationState : IDisposable
    {
        public IntPtr TokenHandle { get; private set; }
        public IntPtr DuplicatedTokenHandle { get; private set; }
        public WindowsImpersonationContext ImpersonationContext { get; private set; }

        private ImpersonationState()
        {
        }

        [SecuritySafeCritical]
        public static ImpersonationState Impersonate(NetworkCredential networkCredential)
        {
            const int logon32TypeNewCredentials = 9;
            const int logon32ProviderWinnt50 = 3;
            const int securityImpersonation = 2;

            var tokenHandle = IntPtr.Zero;
            var duplicatedTokenHandle = IntPtr.Zero;
            WindowsIdentity userIdentity;

            // Call LogonUser to obtain a handle to an access token.
            var returnValue = NativeMethods.LogonUser(networkCredential.UserName,
                                                        networkCredential.Domain,
                                                        networkCredential.Password,
                                                        logon32TypeNewCredentials,
                                                        logon32ProviderWinnt50,
                                                        ref tokenHandle);

            if (!returnValue)
            {
                throw new System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error());
            }

            returnValue = NativeMethods.DuplicateToken(tokenHandle, securityImpersonation, ref duplicatedTokenHandle);

            if (!returnValue)
            {
                NativeMethods.CloseHandle(tokenHandle);
                //Exception thrown in trying to duplicate token.
                return null;
            }

            // The token that is passed to the following constructor must be a primary token in order 
            // to use it for impersonation.
            userIdentity = new WindowsIdentity(duplicatedTokenHandle);

            return new ImpersonationState
            {
                TokenHandle = tokenHandle,
                DuplicatedTokenHandle = duplicatedTokenHandle,
                ImpersonationContext = userIdentity.Impersonate()
            };
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        [SecuritySafeCritical]
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (ImpersonationContext != null)
                    ImpersonationContext.Undo();

                if (TokenHandle != IntPtr.Zero)
                {
                    NativeMethods.CloseHandle(TokenHandle);
                    TokenHandle = IntPtr.Zero;
                }

                if (DuplicatedTokenHandle != IntPtr.Zero)
                {
                    NativeMethods.CloseHandle(DuplicatedTokenHandle);
                    DuplicatedTokenHandle = IntPtr.Zero;
                }
            }
        }
    }

    internal static class NativeMethods
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public extern static bool CloseHandle(IntPtr handle);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool LogonUser(String lpszUsername,
                                            String lpszDomain,
                                            String lpszPassword,
                                            int dwLogonType,
                                            int dwLogonProvider,
                                            ref IntPtr phToken);

        [DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public extern static bool DuplicateToken(IntPtr existingTokenHandle,
                                                 int securityImpersonationLevel,
                                                 ref IntPtr duplicateTokenHandle);
    }

}