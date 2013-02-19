/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create App Request Marshaller
    /// </summary>       
    internal class CreateAppRequestMarshaller : IMarshaller<IRequest, CreateAppRequest> 
    {
        

        public IRequest Marshall(CreateAppRequest createAppRequest) 
        {

            IRequest request = new DefaultRequest(createAppRequest, "AmazonOpsWorks");
            string target = "OpsWorks_20130218.CreateApp";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";

            
              
            string uriResourcePath = ""; 
            
            if (uriResourcePath.Contains("?")) 
            {
                string queryString = uriResourcePath.Substring(uriResourcePath.IndexOf("?") + 1);
                uriResourcePath    = uriResourcePath.Substring(0, uriResourcePath.IndexOf("?"));
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter())
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (createAppRequest != null && createAppRequest.IsSetStackId()) 
                {
                    writer.WritePropertyName("StackId");
                    writer.Write(createAppRequest.StackId);
                }
                if (createAppRequest != null && createAppRequest.IsSetName()) 
                {
                    writer.WritePropertyName("Name");
                    writer.Write(createAppRequest.Name);
                }
                if (createAppRequest != null && createAppRequest.IsSetDescription()) 
                {
                    writer.WritePropertyName("Description");
                    writer.Write(createAppRequest.Description);
                }
                if (createAppRequest != null && createAppRequest.IsSetType()) 
                {
                    writer.WritePropertyName("Type");
                    writer.Write(createAppRequest.Type);
                }

                if (createAppRequest != null) 
                {
                    Source appSource = createAppRequest.AppSource;
                    if (appSource != null)
                    {
                        writer.WritePropertyName("AppSource");
                        writer.WriteObjectStart();
                        if (appSource != null && appSource.IsSetType()) 
                        {
                            writer.WritePropertyName("Type");
                            writer.Write(appSource.Type);
                        }
                        if (appSource != null && appSource.IsSetUrl()) 
                        {
                            writer.WritePropertyName("Url");
                            writer.Write(appSource.Url);
                        }
                        if (appSource != null && appSource.IsSetUsername()) 
                        {
                            writer.WritePropertyName("Username");
                            writer.Write(appSource.Username);
                        }
                        if (appSource != null && appSource.IsSetPassword()) 
                        {
                            writer.WritePropertyName("Password");
                            writer.Write(appSource.Password);
                        }
                        if (appSource != null && appSource.IsSetSshKey()) 
                        {
                            writer.WritePropertyName("SshKey");
                            writer.Write(appSource.SshKey);
                        }
                        if (appSource != null && appSource.IsSetRevision()) 
                        {
                            writer.WritePropertyName("Revision");
                            writer.Write(appSource.Revision);
                        }
                        writer.WriteObjectEnd();
                    }
                }

                if (createAppRequest != null && createAppRequest.Domains != null && createAppRequest.Domains.Count > 0) 
                {
                    List<string> domainsList = createAppRequest.Domains;
                    writer.WritePropertyName("Domains");
                    writer.WriteArrayStart();

                    foreach (string domainsListValue in domainsList) 
                    { 
                        writer.Write(StringUtils.FromString(domainsListValue));
                    }

                    writer.WriteArrayEnd();
                }
                if (createAppRequest != null && createAppRequest.IsSetEnableSsl()) 
                {
                    writer.WritePropertyName("EnableSsl");
                    writer.Write(createAppRequest.EnableSsl);
                }

                if (createAppRequest != null) 
                {
                    SslConfiguration sslConfiguration = createAppRequest.SslConfiguration;
                    if (sslConfiguration != null)
                    {
                        writer.WritePropertyName("SslConfiguration");
                        writer.WriteObjectStart();
                        if (sslConfiguration != null && sslConfiguration.IsSetCertificate()) 
                        {
                            writer.WritePropertyName("Certificate");
                            writer.Write(sslConfiguration.Certificate);
                        }
                        if (sslConfiguration != null && sslConfiguration.IsSetPrivateKey()) 
                        {
                            writer.WritePropertyName("PrivateKey");
                            writer.Write(sslConfiguration.PrivateKey);
                        }
                        if (sslConfiguration != null && sslConfiguration.IsSetChain()) 
                        {
                            writer.WritePropertyName("Chain");
                            writer.Write(sslConfiguration.Chain);
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (createAppRequest != null) 
                {
                    if (createAppRequest.Attributes != null && createAppRequest.Attributes.Count > 0)
                    {
                        writer.WritePropertyName("Attributes");
                        writer.WriteObjectStart();
                        foreach (string createAppRequestAttributesKey in createAppRequest.Attributes.Keys)
                        {
                            string attributesListValue;
                            bool attributesListValueHasValue = createAppRequest.Attributes.TryGetValue(createAppRequestAttributesKey, out attributesListValue);
                            writer.WritePropertyName(createAppRequestAttributesKey);

                        writer.Write(attributesListValue);
                        }
                        writer.WriteObjectEnd();
                    }
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
