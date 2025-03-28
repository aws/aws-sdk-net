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
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using Amazon.Runtime;
using Amazon.SecurityToken.Model;

namespace Amazon.SecurityToken.SAML
{
    /// <summary>
    /// Contains the parsed SAML response data following successful user
    /// authentication against a federated endpoint. We only parse out the
    /// data we need to support generation of temporary AWS credentials.
    /// </summary>
    public class SAMLAssertion
    {
        const string AssertionNamespace = "urn:oasis:names:tc:SAML:2.0:assertion";
        const string RoleXPath = "//response:Attribute[@Name='https://aws.amazon.com/SAML/Attributes/Role']";

        /// <summary>
        /// The full SAML assertion parsed from the identity provider's
        /// response.
        /// </summary>
        public string AssertionDocument { get; private set; }

        /// <summary>
        /// The collection of roles available to the authenticated user.
        /// he parsed friendly role name is used to key the entries.
        /// </summary>
        public IDictionary<string, string> RoleSet { get; private set; }

        /// <summary>
        /// Retrieves a set of temporary credentials for the specified role, valid for the specified timespan.
        /// If the SAML authentication data yield more than one role, a valid role name must be specified.
        /// </summary>
        /// <param name="stsClient">The STS client to use when making the AssumeRoleWithSAML request.</param>
        /// <param name="principalAndRoleArns">
        /// The arns of the principal and role as returned in the SAML assertion.
        /// </param>
        /// <param name="duration">The valid timespan for the credentials.</param>
        /// <returns>Temporary session credentials for the specified or default role for the user.</returns>
        public SAMLImmutableCredentials GetRoleCredentials(
            IAmazonSecurityTokenService stsClient, string principalAndRoleArns, TimeSpan duration)
        {
            string roleArn = null;
            string principalArn = null;

            var swappedPrincipalAndRoleArns = string.Empty;
            if (!string.IsNullOrEmpty(principalAndRoleArns))
            {
                var roleComponents = principalAndRoleArns.Split(',');
                if(roleComponents.Count() != 2)
                {
                    throw new ArgumentException("Unknown or invalid principal and role arns format.");
                }

                swappedPrincipalAndRoleArns = roleComponents.Last() + "," + roleComponents.First();
            }

            foreach (var s in RoleSet.Values)
            {
                if (s.Equals(principalAndRoleArns, StringComparison.OrdinalIgnoreCase) || s.Equals(swappedPrincipalAndRoleArns, StringComparison.OrdinalIgnoreCase))
                {
                    var roleComponents = s.Split(',');
                    if (IsSamlProvider(roleComponents.First()))
                    {
                        //Backwards compatible format -- arn:...:saml-provider/SAML,arn:...:role/RoleName
                        principalArn = roleComponents.First();
                        roleArn = roleComponents.Last();
                    }
                    else
                    {
                        //Documented format -- arn:...:role/RoleName,arn:...:saml-provider/SAML
                        roleArn = roleComponents.First();
                        principalArn = roleComponents.Last();
                    }
                    
                    break;
                }
            }

            if (string.IsNullOrEmpty(roleArn) || string.IsNullOrEmpty(principalArn))
                throw new ArgumentException("Unknown or invalid role specified.");

            var assumeSamlRequest = new AssumeRoleWithSAMLRequest
            {
                SAMLAssertion = AssertionDocument,
                RoleArn = roleArn,
                PrincipalArn = principalArn,
                DurationSeconds = (int)duration.TotalSeconds
            };

#if NETSTANDARD
            //In the NetStandard SDK flavor the sync operations are internal only.
            var response = ((AmazonSecurityTokenServiceClient)stsClient).AssumeRoleWithSAML(assumeSamlRequest);
#else
            var response =  stsClient.AssumeRoleWithSAML(assumeSamlRequest);
#endif
            return new SAMLImmutableCredentials(response.Credentials.GetCredentials(), 
                                                response.Credentials.Expiration.GetValueOrDefault().ToUniversalTime(),
                                                response.Subject,
                                                response.AssumedRoleUser != null ? Arn.Parse(response.AssumedRoleUser.Arn).AccountId : null);
        }

        /// <summary>
        /// Retrieves a set of temporary credentials for the specified role, valid for the specified timespan.
        /// If the SAML authentication data yield more than one role, a valid role name must be specified.
        /// </summary>
        /// <param name="stsClient">The STS client to use when making the AssumeRoleWithSAML request.</param>
        /// <param name="principalAndRoleArns">
        /// The arns of the principal and role as returned in the SAML assertion.
        /// </param>
        /// <param name="duration">The valid timespan for the credentials.</param>
        /// <returns>Temporary session credentials for the specified or default role for the user.</returns>
        public async Task<SAMLImmutableCredentials> GetRoleCredentialsAsync(
            IAmazonSecurityTokenService stsClient, string principalAndRoleArns, TimeSpan duration)
        {
            string roleArn = null;
            string principalArn = null;

            var swappedPrincipalAndRoleArns = string.Empty;
            if (!string.IsNullOrEmpty(principalAndRoleArns))
            {
                var roleComponents = principalAndRoleArns.Split(',');
                if (roleComponents.Count() != 2)
                {
                    throw new ArgumentException("Unknown or invalid principal and role arns format.");
                }

                swappedPrincipalAndRoleArns = roleComponents.Last() + "," + roleComponents.First();
            }

            foreach (var s in RoleSet.Values)
            {
                if (s.Equals(principalAndRoleArns, StringComparison.OrdinalIgnoreCase) || s.Equals(swappedPrincipalAndRoleArns, StringComparison.OrdinalIgnoreCase))
                {
                    var roleComponents = s.Split(',');
                    if (IsSamlProvider(roleComponents.First()))
                    {
                        //Backwards compatible format -- arn:...:saml-provider/SAML,arn:...:role/RoleName
                        principalArn = roleComponents.First();
                        roleArn = roleComponents.Last();
                    }
                    else
                    {
                        //Documented format -- arn:...:role/RoleName,arn:...:saml-provider/SAML
                        roleArn = roleComponents.First();
                        principalArn = roleComponents.Last();
                    }

                    break;
                }
            }

            if (string.IsNullOrEmpty(roleArn) || string.IsNullOrEmpty(principalArn))
                throw new ArgumentException("Unknown or invalid role specified.");

            var assumeSamlRequest = new AssumeRoleWithSAMLRequest
            {
                SAMLAssertion = AssertionDocument,
                RoleArn = roleArn,
                PrincipalArn = principalArn,
                DurationSeconds = (int)duration.TotalSeconds
            };

            var response = await stsClient.AssumeRoleWithSAMLAsync(assumeSamlRequest).ConfigureAwait(false);

            return new SAMLImmutableCredentials(response.Credentials.GetCredentials(),
                                                response.Credentials.Expiration.GetValueOrDefault().ToUniversalTime(),
                                                response.Subject);
        }

        /// <summary>
        /// Constructs a new SAML assertion wrapper based on a successful authentication
        /// response and extracts the role data contained in the assertion. 
        /// </summary>
        /// <param name="assertion"></param>
        internal SAMLAssertion(string assertion)
        {
            AssertionDocument = assertion;
            RoleSet = ExtractRoleData();
        }

        /// <summary>
        /// Parses the role data out of the assertion using xpath queries. We additionally
        /// parse the role ARNs to extract friendly role names that can be used in UI
        /// prompts in tooling.
        /// </summary>
        /// <returns>Dictionary of friendly role names to role arn mappings.</returns>
        private IDictionary<string, string> ExtractRoleData()
        {
            var doc = new XmlDocument();
            //var sw = new StringWriter(CultureInfo.InvariantCulture);
            var decoded = Convert.FromBase64String(AssertionDocument);
            var deflated = Encoding.UTF8.GetString(decoded);

            doc.LoadXml(deflated);
            //using (var tw = new XmlTextWriter(sw) { Formatting = Formatting.Indented })
            //{
            //    doc.WriteTo(tw);
            //}

            var nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("response", AssertionNamespace);
            var roleAttributeNodes = doc.DocumentElement.SelectNodes(RoleXPath, nsmgr);

            var discoveredRoles = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            if (roleAttributeNodes != null && roleAttributeNodes.Count > 0)
            {
                var roleNodes = roleAttributeNodes[0].ChildNodes;

                // we use this in case we encounter a provider that does allow duplicate
                // role definitions (unlikely)
                var seenRoles = new HashSet<string>(StringComparer.Ordinal);
                foreach (XmlNode roleNode in roleNodes)
                {
                    if (!string.IsNullOrEmpty(roleNode.InnerText))
                    {
                        var chunks = roleNode.InnerText.Split(new[] { ',' }, 3);
                        var samlRole = chunks[0] + ',' + chunks[1];
                        if (!seenRoles.Contains(samlRole))
                        {
                            var roleName = string.Empty;
                            if (IsSamlProvider(chunks[1]))
                            {
                                //Documented format -- arn:...:role/RoleName,arn:...:saml-provider/SAML
                                roleName = ExtractRoleName(chunks[0]);
                            }
                            else
                            {
                                //Backwards compatible format -- arn:...:saml-provider/SAML,arn:...:role/RoleName
                                roleName = ExtractRoleName(chunks[1]);
                            }

                            discoveredRoles.Add(roleName, samlRole);

                            seenRoles.Add(samlRole);
                        }
                    }
                }
            }

            return discoveredRoles;
        }

        private static bool IsSamlProvider(string chunk)
        {
            return chunk.IndexOf(":saml-provider", StringComparison.OrdinalIgnoreCase) != -1;
        }

        private static string ExtractRoleName(string chunk)
        {
            // It is possible to configure the same role name across different accounts
            // so we must take account number into consideration to get the friendly name
            // to avoid duplicate keys

            //Example chunk format: arn:aws:iam::account-number:role/role-name1
            var roleNameStart = chunk.LastIndexOf("::", StringComparison.Ordinal);
            string roleName;
            if (roleNameStart >= 0)
                roleName = chunk.Substring(roleNameStart + 2);
            else
                roleName = chunk;

            return roleName;
        }
    }
}
