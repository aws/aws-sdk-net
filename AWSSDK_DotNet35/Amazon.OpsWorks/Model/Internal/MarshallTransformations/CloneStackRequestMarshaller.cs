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
using System.Globalization;
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
    /// Clone Stack Request Marshaller
    /// </summary>       
    internal class CloneStackRequestMarshaller : IMarshaller<IRequest, CloneStackRequest> 
    {
        

        public IRequest Marshall(CloneStackRequest cloneStackRequest) 
        {

            IRequest request = new DefaultRequest(cloneStackRequest, "AmazonOpsWorks");
            string target = "OpsWorks_20130218.CloneStack";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            
              
            string uriResourcePath = ""; 
            
            if (uriResourcePath.Contains("?")) 
            {
                int queryPosition = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
                string queryString = uriResourcePath.Substring(queryPosition + 1);
                uriResourcePath    = uriResourcePath.Substring(0, queryPosition);
        
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
            
             
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (cloneStackRequest != null && cloneStackRequest.IsSetSourceStackId()) 
                {
                    writer.WritePropertyName("SourceStackId");
                    writer.Write(cloneStackRequest.SourceStackId);
                }
                if (cloneStackRequest != null && cloneStackRequest.IsSetName()) 
                {
                    writer.WritePropertyName("Name");
                    writer.Write(cloneStackRequest.Name);
                }
                if (cloneStackRequest != null && cloneStackRequest.IsSetRegion()) 
                {
                    writer.WritePropertyName("Region");
                    writer.Write(cloneStackRequest.Region);
                }
                if (cloneStackRequest != null && cloneStackRequest.IsSetVpcId()) 
                {
                    writer.WritePropertyName("VpcId");
                    writer.Write(cloneStackRequest.VpcId);
                }
                if (cloneStackRequest != null) 
                {
                    if (cloneStackRequest.Attributes != null && cloneStackRequest.Attributes.Count > 0)
                    {
                        writer.WritePropertyName("Attributes");
                        writer.WriteObjectStart();
                        foreach (string cloneStackRequestAttributesKey in cloneStackRequest.Attributes.Keys)
                        {
                            string attributesListValue;
                            bool attributesListValueHasValue = cloneStackRequest.Attributes.TryGetValue(cloneStackRequestAttributesKey, out attributesListValue);
                            writer.WritePropertyName(cloneStackRequestAttributesKey);

                        writer.Write(attributesListValue);
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (cloneStackRequest != null && cloneStackRequest.IsSetServiceRoleArn()) 
                {
                    writer.WritePropertyName("ServiceRoleArn");
                    writer.Write(cloneStackRequest.ServiceRoleArn);
                }
                if (cloneStackRequest != null && cloneStackRequest.IsSetDefaultInstanceProfileArn()) 
                {
                    writer.WritePropertyName("DefaultInstanceProfileArn");
                    writer.Write(cloneStackRequest.DefaultInstanceProfileArn);
                }
                if (cloneStackRequest != null && cloneStackRequest.IsSetDefaultOs()) 
                {
                    writer.WritePropertyName("DefaultOs");
                    writer.Write(cloneStackRequest.DefaultOs);
                }
                if (cloneStackRequest != null && cloneStackRequest.IsSetHostnameTheme()) 
                {
                    writer.WritePropertyName("HostnameTheme");
                    writer.Write(cloneStackRequest.HostnameTheme);
                }
                if (cloneStackRequest != null && cloneStackRequest.IsSetDefaultAvailabilityZone()) 
                {
                    writer.WritePropertyName("DefaultAvailabilityZone");
                    writer.Write(cloneStackRequest.DefaultAvailabilityZone);
                }
                if (cloneStackRequest != null && cloneStackRequest.IsSetDefaultSubnetId()) 
                {
                    writer.WritePropertyName("DefaultSubnetId");
                    writer.Write(cloneStackRequest.DefaultSubnetId);
                }
                if (cloneStackRequest != null && cloneStackRequest.IsSetCustomJson()) 
                {
                    writer.WritePropertyName("CustomJson");
                    writer.Write(cloneStackRequest.CustomJson);
                }

                if (cloneStackRequest != null) 
                {
                    StackConfigurationManager configurationManager = cloneStackRequest.ConfigurationManager;
                    if (configurationManager != null)
                    {
                        writer.WritePropertyName("ConfigurationManager");
                        writer.WriteObjectStart();
                        if (configurationManager != null && configurationManager.IsSetName()) 
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(configurationManager.Name);
                        }
                        if (configurationManager != null && configurationManager.IsSetVersion()) 
                        {
                            writer.WritePropertyName("Version");
                            writer.Write(configurationManager.Version);
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (cloneStackRequest != null && cloneStackRequest.IsSetUseCustomCookbooks()) 
                {
                    writer.WritePropertyName("UseCustomCookbooks");
                    writer.Write(cloneStackRequest.UseCustomCookbooks);
                }

                if (cloneStackRequest != null) 
                {
                    Source customCookbooksSource = cloneStackRequest.CustomCookbooksSource;
                    if (customCookbooksSource != null)
                    {
                        writer.WritePropertyName("CustomCookbooksSource");
                        writer.WriteObjectStart();
                        if (customCookbooksSource != null && customCookbooksSource.IsSetType()) 
                        {
                            writer.WritePropertyName("Type");
                            writer.Write(customCookbooksSource.Type);
                        }
                        if (customCookbooksSource != null && customCookbooksSource.IsSetUrl()) 
                        {
                            writer.WritePropertyName("Url");
                            writer.Write(customCookbooksSource.Url);
                        }
                        if (customCookbooksSource != null && customCookbooksSource.IsSetUsername()) 
                        {
                            writer.WritePropertyName("Username");
                            writer.Write(customCookbooksSource.Username);
                        }
                        if (customCookbooksSource != null && customCookbooksSource.IsSetPassword()) 
                        {
                            writer.WritePropertyName("Password");
                            writer.Write(customCookbooksSource.Password);
                        }
                        if (customCookbooksSource != null && customCookbooksSource.IsSetSshKey()) 
                        {
                            writer.WritePropertyName("SshKey");
                            writer.Write(customCookbooksSource.SshKey);
                        }
                        if (customCookbooksSource != null && customCookbooksSource.IsSetRevision()) 
                        {
                            writer.WritePropertyName("Revision");
                            writer.Write(customCookbooksSource.Revision);
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (cloneStackRequest != null && cloneStackRequest.IsSetDefaultSshKeyName()) 
                {
                    writer.WritePropertyName("DefaultSshKeyName");
                    writer.Write(cloneStackRequest.DefaultSshKeyName);
                }
                if (cloneStackRequest != null && cloneStackRequest.IsSetClonePermissions()) 
                {
                    writer.WritePropertyName("ClonePermissions");
                    writer.Write(cloneStackRequest.ClonePermissions);
                }

                if (cloneStackRequest != null && cloneStackRequest.CloneAppIds != null && cloneStackRequest.CloneAppIds.Count > 0) 
                {
                    List<string> cloneAppIdsList = cloneStackRequest.CloneAppIds;
                    writer.WritePropertyName("CloneAppIds");
                    writer.WriteArrayStart();

                    foreach (string cloneAppIdsListValue in cloneAppIdsList) 
                    { 
                        writer.Write(StringUtils.FromString(cloneAppIdsListValue));
                    }

                    writer.WriteArrayEnd();
                }
                if (cloneStackRequest != null && cloneStackRequest.IsSetDefaultRootDeviceType()) 
                {
                    writer.WritePropertyName("DefaultRootDeviceType");
                    writer.Write(cloneStackRequest.DefaultRootDeviceType);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
