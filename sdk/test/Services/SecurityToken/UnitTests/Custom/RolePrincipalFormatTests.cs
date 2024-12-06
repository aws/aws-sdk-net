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
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Reflection;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class RolePrincipalFormatTests
    {
        //Documented format
        string samlResponseDocumentedFormat = "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiPz4NCjxuczA6UmVzcG9uc2UgeG1sbnM6bnMwPSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6cHJvdG9jb2wiIHhtbG5zOm5zMT0idXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOmFzc2VydGlvbiIgeG1sbnM6eHNpPSJodHRwOi8vd3d3LnczLm9yZy8yMDAxL1hNTFNjaGVtYS1pbnN0YW5jZSIgRGVzdGluYXRpb249Imh0dHBzOi8vc2lnbmluLmF3cy5hbWF6b24uY29tL3NhbWwiIFZlcnNpb249IjIuMCI+DQogICA8bnMxOklzc3VlciBGb3JtYXQ9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDphdHRybmFtZS1mb3JtYXQ6dXJpIj51cm46bWFjZTpmaWVyeWxhYi5jb206c2FtbDpmaWVyeWxhYjppZHA8L25zMTpJc3N1ZXI+DQogICA8bnMwOlN0YXR1cz4NCiAgICAgIDxuczA6U3RhdHVzQ29kZSBWYWx1ZT0idXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOnN0YXR1czpTdWNjZXNzIiAvPg0KICAgPC9uczA6U3RhdHVzPg0KICAgPG5zMTpBc3NlcnRpb24gSUQ9ImlkLWRleE1rSmh5OVZnakwzaXpFIiBJc3N1ZUluc3RhbnQ9IjIwMTktMDEtMDNUMTU6MTA6MzVaIiBWZXJzaW9uPSIyLjAiPg0KICAgICAgPG5zMTpJc3N1ZXIgRm9ybWF0PSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6YXR0cm5hbWUtZm9ybWF0OnVyaSI+dXJuOm1hY2U6ZmllcnlsYWIuY29tOnNhbWw6ZmllcnlsYWI6aWRwPC9uczE6SXNzdWVyPiAgICAgIA0KICAgICAgPG5zMTpTdWJqZWN0Pg0KICAgICAgICAgPG5zMTpOYW1lSUQgRm9ybWF0PSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6bmFtZWlkLWZvcm1hdDpwZXJzaXN0ZW50Ij5qb2VsPC9uczE6TmFtZUlEPg0KICAgICAgICAgPG5zMTpTdWJqZWN0Q29uZmlybWF0aW9uIE1ldGhvZD0idXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOmNtOmJlYXJlciI+DQogICAgICAgICAgICA8bnMxOlN1YmplY3RDb25maXJtYXRpb25EYXRhIE5vdE9uT3JBZnRlcj0iMjAxOS0wMS0wM1QxNjoxMDozNVoiIFJlY2lwaWVudD0iaHR0cHM6Ly9zaWduaW4uYXdzLmFtYXpvbi5jb20vc2FtbCIgLz4NCiAgICAgICAgIDwvbnMxOlN1YmplY3RDb25maXJtYXRpb24+DQogICAgICA8L25zMTpTdWJqZWN0Pg0KICAgICAgPG5zMTpDb25kaXRpb25zIE5vdEJlZm9yZT0iMjAxOS0wMS0wM1QxNToxMDozNVoiIE5vdE9uT3JBZnRlcj0iMjAxOS0wMS0wM1QxNjoxMDozNVoiPg0KICAgICAgICAgPG5zMTpBdWRpZW5jZVJlc3RyaWN0aW9uPg0KICAgICAgICAgICAgPG5zMTpBdWRpZW5jZT51cm46YW1hem9uOndlYnNlcnZpY2VzPC9uczE6QXVkaWVuY2U+DQogICAgICAgICA8L25zMTpBdWRpZW5jZVJlc3RyaWN0aW9uPg0KICAgICAgPC9uczE6Q29uZGl0aW9ucz4NCiAgICAgIDxuczE6QXV0aG5TdGF0ZW1lbnQgQXV0aG5JbnN0YW50PSIyMDE5LTAxLTAzVDE1OjEwOjM1WiIgU2Vzc2lvbkluZGV4PSJpZC1oNFJMTVBpaUNqcE9lS3R5byI+DQogICAgICAgICA8bnMxOkF1dGhuQ29udGV4dD4NCiAgICAgICAgICAgIDxuczE6QXV0aG5Db250ZXh0Q2xhc3NSZWY+dXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOmFjOmNsYXNzZXM6dW5zcGVjaWZpZWQ8L25zMTpBdXRobkNvbnRleHRDbGFzc1JlZj4NCiAgICAgICAgIDwvbnMxOkF1dGhuQ29udGV4dD4NCiAgICAgIDwvbnMxOkF1dGhuU3RhdGVtZW50Pg0KICAgICAgPG5zMTpBdHRyaWJ1dGVTdGF0ZW1lbnQ+DQogICAgICAgICA8bnMxOkF0dHJpYnV0ZSBOYW1lPSJodHRwczovL2F3cy5hbWF6b24uY29tL1NBTUwvQXR0cmlidXRlcy9Sb2xlIiBOYW1lRm9ybWF0PSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6YXR0cm5hbWUtZm9ybWF0OnVyaSI+DQogICAgICAgICAgICA8bnMxOkF0dHJpYnV0ZVZhbHVlIHhzaTp0eXBlPSJ4czpzdHJpbmciPmFybjphd3M6aWFtOjoxMTE6cm9sZS9Sb2xlTmFtZSxhcm46YXdzOmlhbTo6MTExOnNhbWwtcHJvdmlkZXIvU0FNTDwvbnMxOkF0dHJpYnV0ZVZhbHVlPg0KICAgICAgICAgPC9uczE6QXR0cmlidXRlPg0KICAgICAgICAgPG5zMTpBdHRyaWJ1dGUgTmFtZT0iaHR0cHM6Ly9hd3MuYW1hem9uLmNvbS9TQU1ML0F0dHJpYnV0ZXMvUm9sZVNlc3Npb25OYW1lIiBOYW1lRm9ybWF0PSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6YXR0cm5hbWUtZm9ybWF0OnVyaSI+DQogICAgICAgICAgICA8bnMxOkF0dHJpYnV0ZVZhbHVlIHhzaTp0eXBlPSJ4czpzdHJpbmciPnRlc3Q8L25zMTpBdHRyaWJ1dGVWYWx1ZT4NCiAgICAgICAgIDwvbnMxOkF0dHJpYnV0ZT4NCiAgICAgIDwvbnMxOkF0dHJpYnV0ZVN0YXRlbWVudD4NCiAgIDwvbnMxOkFzc2VydGlvbj4NCjwvbnMwOlJlc3BvbnNlPg==";
        
        //SDK backwards compatible format
        string samlResponseBackwardsCompatibleFormat = "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiPz4NCjxuczA6UmVzcG9uc2UgeG1sbnM6bnMwPSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6cHJvdG9jb2wiIHhtbG5zOm5zMT0idXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOmFzc2VydGlvbiIgeG1sbnM6eHNpPSJodHRwOi8vd3d3LnczLm9yZy8yMDAxL1hNTFNjaGVtYS1pbnN0YW5jZSIgRGVzdGluYXRpb249Imh0dHBzOi8vc2lnbmluLmF3cy5hbWF6b24uY29tL3NhbWwiIFZlcnNpb249IjIuMCI+DQogICA8bnMxOklzc3VlciBGb3JtYXQ9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDphdHRybmFtZS1mb3JtYXQ6dXJpIj51cm46bWFjZTpmaWVyeWxhYi5jb206c2FtbDpmaWVyeWxhYjppZHA8L25zMTpJc3N1ZXI+DQogICA8bnMwOlN0YXR1cz4NCiAgICAgIDxuczA6U3RhdHVzQ29kZSBWYWx1ZT0idXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOnN0YXR1czpTdWNjZXNzIiAvPg0KICAgPC9uczA6U3RhdHVzPg0KICAgPG5zMTpBc3NlcnRpb24gSUQ9ImlkLWRleE1rSmh5OVZnakwzaXpFIiBJc3N1ZUluc3RhbnQ9IjIwMTktMDEtMDNUMTU6MTA6MzVaIiBWZXJzaW9uPSIyLjAiPg0KICAgICAgPG5zMTpJc3N1ZXIgRm9ybWF0PSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6YXR0cm5hbWUtZm9ybWF0OnVyaSI+dXJuOm1hY2U6ZmllcnlsYWIuY29tOnNhbWw6ZmllcnlsYWI6aWRwPC9uczE6SXNzdWVyPiAgICAgIA0KICAgICAgPG5zMTpTdWJqZWN0Pg0KICAgICAgICAgPG5zMTpOYW1lSUQgRm9ybWF0PSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6bmFtZWlkLWZvcm1hdDpwZXJzaXN0ZW50Ij5qb2VsPC9uczE6TmFtZUlEPg0KICAgICAgICAgPG5zMTpTdWJqZWN0Q29uZmlybWF0aW9uIE1ldGhvZD0idXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOmNtOmJlYXJlciI+DQogICAgICAgICAgICA8bnMxOlN1YmplY3RDb25maXJtYXRpb25EYXRhIE5vdE9uT3JBZnRlcj0iMjAxOS0wMS0wM1QxNjoxMDozNVoiIFJlY2lwaWVudD0iaHR0cHM6Ly9zaWduaW4uYXdzLmFtYXpvbi5jb20vc2FtbCIgLz4NCiAgICAgICAgIDwvbnMxOlN1YmplY3RDb25maXJtYXRpb24+DQogICAgICA8L25zMTpTdWJqZWN0Pg0KICAgICAgPG5zMTpDb25kaXRpb25zIE5vdEJlZm9yZT0iMjAxOS0wMS0wM1QxNToxMDozNVoiIE5vdE9uT3JBZnRlcj0iMjAxOS0wMS0wM1QxNjoxMDozNVoiPg0KICAgICAgICAgPG5zMTpBdWRpZW5jZVJlc3RyaWN0aW9uPg0KICAgICAgICAgICAgPG5zMTpBdWRpZW5jZT51cm46YW1hem9uOndlYnNlcnZpY2VzPC9uczE6QXVkaWVuY2U+DQogICAgICAgICA8L25zMTpBdWRpZW5jZVJlc3RyaWN0aW9uPg0KICAgICAgPC9uczE6Q29uZGl0aW9ucz4NCiAgICAgIDxuczE6QXV0aG5TdGF0ZW1lbnQgQXV0aG5JbnN0YW50PSIyMDE5LTAxLTAzVDE1OjEwOjM1WiIgU2Vzc2lvbkluZGV4PSJpZC1oNFJMTVBpaUNqcE9lS3R5byI+DQogICAgICAgICA8bnMxOkF1dGhuQ29udGV4dD4NCiAgICAgICAgICAgIDxuczE6QXV0aG5Db250ZXh0Q2xhc3NSZWY+dXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOmFjOmNsYXNzZXM6dW5zcGVjaWZpZWQ8L25zMTpBdXRobkNvbnRleHRDbGFzc1JlZj4NCiAgICAgICAgIDwvbnMxOkF1dGhuQ29udGV4dD4NCiAgICAgIDwvbnMxOkF1dGhuU3RhdGVtZW50Pg0KICAgICAgPG5zMTpBdHRyaWJ1dGVTdGF0ZW1lbnQ+DQogICAgICAgICA8bnMxOkF0dHJpYnV0ZSBOYW1lPSJodHRwczovL2F3cy5hbWF6b24uY29tL1NBTUwvQXR0cmlidXRlcy9Sb2xlIiBOYW1lRm9ybWF0PSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6YXR0cm5hbWUtZm9ybWF0OnVyaSI+DQogICAgICAgICAgICA8bnMxOkF0dHJpYnV0ZVZhbHVlIHhzaTp0eXBlPSJ4czpzdHJpbmciPmFybjphd3M6aWFtOjoxMTE6c2FtbC1wcm92aWRlci9TQU1MLGFybjphd3M6aWFtOjoxMTE6cm9sZS9Sb2xlTmFtZTwvbnMxOkF0dHJpYnV0ZVZhbHVlPg0KICAgICAgICAgPC9uczE6QXR0cmlidXRlPg0KICAgICAgICAgPG5zMTpBdHRyaWJ1dGUgTmFtZT0iaHR0cHM6Ly9hd3MuYW1hem9uLmNvbS9TQU1ML0F0dHJpYnV0ZXMvUm9sZVNlc3Npb25OYW1lIiBOYW1lRm9ybWF0PSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6YXR0cm5hbWUtZm9ybWF0OnVyaSI+DQogICAgICAgICAgICA8bnMxOkF0dHJpYnV0ZVZhbHVlIHhzaTp0eXBlPSJ4czpzdHJpbmciPnRlc3Q8L25zMTpBdHRyaWJ1dGVWYWx1ZT4NCiAgICAgICAgIDwvbnMxOkF0dHJpYnV0ZT4NCiAgICAgIDwvbnMxOkF0dHJpYnV0ZVN0YXRlbWVudD4NCiAgIDwvbnMxOkFzc2VydGlvbj4NCjwvbnMwOlJlc3BvbnNlPg==";
        
        string roleArn = "arn:aws:iam::111:role/RoleName";
        string providerArn = "arn:aws:iam::111:saml-provider/SAML";
        
        [TestMethod]
        [TestCategory("SecurityToken")]
        public void EnsureRolePrincipalARNFormat_Documented()
        {
            TestRolePrincipalARNFormats(samlResponseDocumentedFormat, $"{roleArn},{providerArn}");            
        }

        [TestMethod]
        [TestCategory("SecurityToken")]
        public void EnsureRolePrincipalARNFormat_BackwardsCompatible()
        {
            TestRolePrincipalARNFormats(samlResponseBackwardsCompatibleFormat, $"{providerArn},{roleArn}");            
        }

        [TestMethod]
        [TestCategory("SecurityToken")]
        public void EnsureRolePrincipalARNFormat_Mixed1()
        {
            TestRolePrincipalARNFormats(samlResponseBackwardsCompatibleFormat, $"{roleArn},{providerArn}");                        
        }

        [TestMethod]
        [TestCategory("SecurityToken")]
        public void EnsureRolePrincipalARNFormat_Mixed2()
        {
            TestRolePrincipalARNFormats(samlResponseDocumentedFormat, $"{providerArn},{roleArn}");
        }

        private void TestRolePrincipalARNFormats(string samlResponseFormat, string principalAndRoleArns)
        {
            var constructorInfo = typeof(Amazon.SecurityToken.SAML.SAMLAssertion).GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new[] { typeof(string) }, null);
            var samlAssertion = (Amazon.SecurityToken.SAML.SAMLAssertion)constructorInfo.Invoke(new object[] { samlResponseFormat });
                        
            var mockTokenService = new Mock<IAmazonSecurityTokenService>();
            mockTokenService.Setup(foo => foo.AssumeRoleWithSAML(It.IsAny<AssumeRoleWithSAMLRequest>()))
                .Returns((AssumeRoleWithSAMLRequest request) =>
                {
                    Assert.AreEqual(request.RoleArn, roleArn);
                    Assert.AreEqual(request.PrincipalArn, providerArn);

                    return new AssumeRoleWithSAMLResponse
                    {
                        Subject = "TestSubject",
                        Credentials = new Credentials("Test", "Test", "Test", DateTime.UtcNow)
                    };
                });
                            
            var roleCreds = samlAssertion.GetRoleCredentials(mockTokenService.Object, principalAndRoleArns, TimeSpan.FromSeconds(900));
            Assert.IsNotNull(roleCreds);
        }
    }
}
 