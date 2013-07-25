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
    /// Create Stack Request Marshaller
    /// </summary>       
    internal class CreateStackRequestMarshaller : IMarshaller<IRequest, CreateStackRequest> 
    {
        

        public IRequest Marshall(CreateStackRequest createStackRequest) 
        {

            IRequest request = new DefaultRequest(createStackRequest, "AmazonOpsWorks");
            string target = "OpsWorks_20130218.CreateStack";
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
                
                if (createStackRequest != null && createStackRequest.IsSetName()) 
                {
                    writer.WritePropertyName("Name");
                    writer.Write(createStackRequest.Name);
                }
                if (createStackRequest != null && createStackRequest.IsSetRegion()) 
                {
                    writer.WritePropertyName("Region");
                    writer.Write(createStackRequest.Region);
                }
                if (createStackRequest != null) 
                {
                    if (createStackRequest.Attributes != null && createStackRequest.Attributes.Count > 0)
                    {
                        writer.WritePropertyName("Attributes");
                        writer.WriteObjectStart();
                        foreach (string createStackRequestAttributesKey in createStackRequest.Attributes.Keys)
                        {
                            string attributesListValue;
                            bool attributesListValueHasValue = createStackRequest.Attributes.TryGetValue(createStackRequestAttributesKey, out attributesListValue);
                            writer.WritePropertyName(createStackRequestAttributesKey);

                        writer.Write(attributesListValue);
                        }
                        writer.WriteObjectEnd();
                    }
                }
                if (createStackRequest != null && createStackRequest.IsSetServiceRoleArn()) 
                {
                    writer.WritePropertyName("ServiceRoleArn");
                    writer.Write(createStackRequest.ServiceRoleArn);
                }
                if (createStackRequest != null && createStackRequest.IsSetDefaultInstanceProfileArn()) 
                {
                    writer.WritePropertyName("DefaultInstanceProfileArn");
                    writer.Write(createStackRequest.DefaultInstanceProfileArn);
                }
                if (createStackRequest != null && createStackRequest.IsSetDefaultOs()) 
                {
                    writer.WritePropertyName("DefaultOs");
                    writer.Write(createStackRequest.DefaultOs);
                }
                if (createStackRequest != null && createStackRequest.IsSetHostnameTheme()) 
                {
                    writer.WritePropertyName("HostnameTheme");
                    writer.Write(createStackRequest.HostnameTheme);
                }
                if (createStackRequest != null && createStackRequest.IsSetDefaultAvailabilityZone()) 
                {
                    writer.WritePropertyName("DefaultAvailabilityZone");
                    writer.Write(createStackRequest.DefaultAvailabilityZone);
                }
                if (createStackRequest != null && createStackRequest.IsSetCustomJson()) 
                {
                    writer.WritePropertyName("CustomJson");
                    writer.Write(createStackRequest.CustomJson);
                }

                if (createStackRequest != null) 
                {
                    StackConfigurationManager configurationManager = createStackRequest.ConfigurationManager;
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
                if (createStackRequest != null && createStackRequest.IsSetUseCustomCookbooks()) 
                {
                    writer.WritePropertyName("UseCustomCookbooks");
                    writer.Write(createStackRequest.UseCustomCookbooks);
                }

                if (createStackRequest != null) 
                {
                    Source customCookbooksSource = createStackRequest.CustomCookbooksSource;
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
                if (createStackRequest != null && createStackRequest.IsSetDefaultSshKeyName()) 
                {
                    writer.WritePropertyName("DefaultSshKeyName");
                    writer.Write(createStackRequest.DefaultSshKeyName);
                }
                if (createStackRequest != null && createStackRequest.IsSetDefaultRootDeviceType()) 
                {
                    writer.WritePropertyName("DefaultRootDeviceType");
                    writer.Write(createStackRequest.DefaultRootDeviceType);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
