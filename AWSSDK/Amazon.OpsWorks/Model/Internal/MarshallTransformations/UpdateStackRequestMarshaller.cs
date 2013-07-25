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
    /// Update Stack Request Marshaller
    /// </summary>       
    internal class UpdateStackRequestMarshaller : IMarshaller<IRequest, UpdateStackRequest> 
    {
        

        public IRequest Marshall(UpdateStackRequest updateStackRequest) 
        {

            IRequest request = new DefaultRequest(updateStackRequest, "AmazonOpsWorks");
            string target = "OpsWorks_20130218.UpdateStack";
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
                
                if (updateStackRequest != null && updateStackRequest.IsSetStackId()) 
                {
                    writer.WritePropertyName("StackId");
                    writer.Write(updateStackRequest.StackId);
                }
                if (updateStackRequest != null && updateStackRequest.IsSetName()) 
                {
                    writer.WritePropertyName("Name");
                    writer.Write(updateStackRequest.Name);
                }
                if (updateStackRequest != null) 
                {
                    if (updateStackRequest.Attributes != null && updateStackRequest.Attributes.Count > 0)
                    {
                        writer.WritePropertyName("Attributes");
                        writer.WriteObjectStart();
                        foreach (string updateStackRequestAttributesKey in updateStackRequest.Attributes.Keys)
                        {
                            string attributesListValue;
                            bool attributesListValueHasValue = updateStackRequest.Attributes.TryGetValue(updateStackRequestAttributesKey, out attributesListValue);
                            writer.WritePropertyName(updateStackRequestAttributesKey);

                        writer.Write(attributesListValue);
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (updateStackRequest != null && updateStackRequest.IsSetServiceRoleArn()) 
                {
                    writer.WritePropertyName("ServiceRoleArn");
                    writer.Write(updateStackRequest.ServiceRoleArn);
                }
                if (updateStackRequest != null && updateStackRequest.IsSetDefaultInstanceProfileArn()) 
                {
                    writer.WritePropertyName("DefaultInstanceProfileArn");
                    writer.Write(updateStackRequest.DefaultInstanceProfileArn);
                }
                if (updateStackRequest != null && updateStackRequest.IsSetDefaultOs()) 
                {
                    writer.WritePropertyName("DefaultOs");
                    writer.Write(updateStackRequest.DefaultOs);
                }
                if (updateStackRequest != null && updateStackRequest.IsSetHostnameTheme()) 
                {
                    writer.WritePropertyName("HostnameTheme");
                    writer.Write(updateStackRequest.HostnameTheme);
                }
                if (updateStackRequest != null && updateStackRequest.IsSetDefaultAvailabilityZone()) 
                {
                    writer.WritePropertyName("DefaultAvailabilityZone");
                    writer.Write(updateStackRequest.DefaultAvailabilityZone);
                }
                if (updateStackRequest != null && updateStackRequest.IsSetCustomJson()) 
                {
                    writer.WritePropertyName("CustomJson");
                    writer.Write(updateStackRequest.CustomJson);
                }

                if (updateStackRequest != null) 
                {
                    StackConfigurationManager configurationManager = updateStackRequest.ConfigurationManager;
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
                if (updateStackRequest != null && updateStackRequest.IsSetUseCustomCookbooks()) 
                {
                    writer.WritePropertyName("UseCustomCookbooks");
                    writer.Write(updateStackRequest.UseCustomCookbooks);
                }

                if (updateStackRequest != null) 
                {
                    Source customCookbooksSource = updateStackRequest.CustomCookbooksSource;
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
                if (updateStackRequest != null && updateStackRequest.IsSetDefaultSshKeyName()) 
                {
                    writer.WritePropertyName("DefaultSshKeyName");
                    writer.Write(updateStackRequest.DefaultSshKeyName);
                }
                if (updateStackRequest != null && updateStackRequest.IsSetDefaultRootDeviceType()) 
                {
                    writer.WritePropertyName("DefaultRootDeviceType");
                    writer.Write(updateStackRequest.DefaultRootDeviceType);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
