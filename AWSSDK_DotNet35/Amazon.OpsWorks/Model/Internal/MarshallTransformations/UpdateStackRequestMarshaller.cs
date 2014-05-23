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
    /// UpdateStack Request Marshaller
    /// </summary>       
    public class UpdateStackRequestMarshaller : IMarshaller<IRequest, UpdateStackRequest> 
    {
        public IRequest Marshall(UpdateStackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorks");
            string target = "OpsWorks_20130218.UpdateStack";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest.IsSetAttributes())
                {
                    writer.WritePropertyName("Attributes");
                    writer.WriteObjectStart();
                    foreach (var publicRequestAttributesKvp in publicRequest.Attributes)
                    {
                        writer.WritePropertyName(publicRequestAttributesKvp.Key);
                        var publicRequestAttributesValue = publicRequestAttributesKvp.Value;

                        writer.Write(publicRequestAttributesValue);
                    }
                    writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetChefConfiguration())
                {
                    writer.WritePropertyName("ChefConfiguration");
                    writer.WriteObjectStart();
                    if(publicRequest.ChefConfiguration.IsSetBerkshelfVersion())
                    {
                        writer.WritePropertyName("BerkshelfVersion");
                        writer.Write(publicRequest.ChefConfiguration.BerkshelfVersion);
                    }

                    if(publicRequest.ChefConfiguration.IsSetManageBerkshelf())
                    {
                        writer.WritePropertyName("ManageBerkshelf");
                        writer.Write(publicRequest.ChefConfiguration.ManageBerkshelf);
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetConfigurationManager())
                {
                    writer.WritePropertyName("ConfigurationManager");
                    writer.WriteObjectStart();
                    if(publicRequest.ConfigurationManager.IsSetName())
                    {
                        writer.WritePropertyName("Name");
                        writer.Write(publicRequest.ConfigurationManager.Name);
                    }

                    if(publicRequest.ConfigurationManager.IsSetVersion())
                    {
                        writer.WritePropertyName("Version");
                        writer.Write(publicRequest.ConfigurationManager.Version);
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCustomCookbooksSource())
                {
                    writer.WritePropertyName("CustomCookbooksSource");
                    writer.WriteObjectStart();
                    if(publicRequest.CustomCookbooksSource.IsSetPassword())
                    {
                        writer.WritePropertyName("Password");
                        writer.Write(publicRequest.CustomCookbooksSource.Password);
                    }

                    if(publicRequest.CustomCookbooksSource.IsSetRevision())
                    {
                        writer.WritePropertyName("Revision");
                        writer.Write(publicRequest.CustomCookbooksSource.Revision);
                    }

                    if(publicRequest.CustomCookbooksSource.IsSetSshKey())
                    {
                        writer.WritePropertyName("SshKey");
                        writer.Write(publicRequest.CustomCookbooksSource.SshKey);
                    }

                    if(publicRequest.CustomCookbooksSource.IsSetType())
                    {
                        writer.WritePropertyName("Type");
                        writer.Write(publicRequest.CustomCookbooksSource.Type);
                    }

                    if(publicRequest.CustomCookbooksSource.IsSetUrl())
                    {
                        writer.WritePropertyName("Url");
                        writer.Write(publicRequest.CustomCookbooksSource.Url);
                    }

                    if(publicRequest.CustomCookbooksSource.IsSetUsername())
                    {
                        writer.WritePropertyName("Username");
                        writer.Write(publicRequest.CustomCookbooksSource.Username);
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCustomJson())
                {
                    writer.WritePropertyName("CustomJson");
                    writer.Write(publicRequest.CustomJson);
                }

                if(publicRequest.IsSetDefaultAvailabilityZone())
                {
                    writer.WritePropertyName("DefaultAvailabilityZone");
                    writer.Write(publicRequest.DefaultAvailabilityZone);
                }

                if(publicRequest.IsSetDefaultInstanceProfileArn())
                {
                    writer.WritePropertyName("DefaultInstanceProfileArn");
                    writer.Write(publicRequest.DefaultInstanceProfileArn);
                }

                if(publicRequest.IsSetDefaultOs())
                {
                    writer.WritePropertyName("DefaultOs");
                    writer.Write(publicRequest.DefaultOs);
                }

                if(publicRequest.IsSetDefaultRootDeviceType())
                {
                    writer.WritePropertyName("DefaultRootDeviceType");
                    writer.Write(publicRequest.DefaultRootDeviceType);
                }

                if(publicRequest.IsSetDefaultSshKeyName())
                {
                    writer.WritePropertyName("DefaultSshKeyName");
                    writer.Write(publicRequest.DefaultSshKeyName);
                }

                if(publicRequest.IsSetDefaultSubnetId())
                {
                    writer.WritePropertyName("DefaultSubnetId");
                    writer.Write(publicRequest.DefaultSubnetId);
                }

                if(publicRequest.IsSetHostnameTheme())
                {
                    writer.WritePropertyName("HostnameTheme");
                    writer.Write(publicRequest.HostnameTheme);
                }

                if(publicRequest.IsSetName())
                {
                    writer.WritePropertyName("Name");
                    writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetServiceRoleArn())
                {
                    writer.WritePropertyName("ServiceRoleArn");
                    writer.Write(publicRequest.ServiceRoleArn);
                }

                if(publicRequest.IsSetStackId())
                {
                    writer.WritePropertyName("StackId");
                    writer.Write(publicRequest.StackId);
                }

                if(publicRequest.IsSetUseCustomCookbooks())
                {
                    writer.WritePropertyName("UseCustomCookbooks");
                    writer.Write(publicRequest.UseCustomCookbooks);
                }

                if(publicRequest.IsSetUseOpsworksSecurityGroups())
                {
                    writer.WritePropertyName("UseOpsworksSecurityGroups");
                    writer.Write(publicRequest.UseOpsworksSecurityGroups);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}