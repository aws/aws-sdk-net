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
    /// Update Instance Request Marshaller
    /// </summary>       
    internal class UpdateInstanceRequestMarshaller : IMarshaller<IRequest, UpdateInstanceRequest> 
    {
        

        public IRequest Marshall(UpdateInstanceRequest updateInstanceRequest) 
        {

            IRequest request = new DefaultRequest(updateInstanceRequest, "AmazonOpsWorks");
            string target = "OpsWorks_20130218.UpdateInstance";
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
                
                if (updateInstanceRequest != null && updateInstanceRequest.IsSetInstanceId()) 
                {
                    writer.WritePropertyName("InstanceId");
                    writer.Write(updateInstanceRequest.InstanceId);
                }

                if (updateInstanceRequest != null && updateInstanceRequest.LayerIds != null && updateInstanceRequest.LayerIds.Count > 0) 
                {
                    List<string> layerIdsList = updateInstanceRequest.LayerIds;
                    writer.WritePropertyName("LayerIds");
                    writer.WriteArrayStart();

                    foreach (string layerIdsListValue in layerIdsList) 
                    { 
                        writer.Write(StringUtils.FromString(layerIdsListValue));
                    }

                    writer.WriteArrayEnd();
                }
                if (updateInstanceRequest != null && updateInstanceRequest.IsSetInstanceType()) 
                {
                    writer.WritePropertyName("InstanceType");
                    writer.Write(updateInstanceRequest.InstanceType);
                }
                if (updateInstanceRequest != null && updateInstanceRequest.IsSetAutoScalingType()) 
                {
                    writer.WritePropertyName("AutoScalingType");
                    writer.Write(updateInstanceRequest.AutoScalingType);
                }
                if (updateInstanceRequest != null && updateInstanceRequest.IsSetHostname()) 
                {
                    writer.WritePropertyName("Hostname");
                    writer.Write(updateInstanceRequest.Hostname);
                }
                if (updateInstanceRequest != null && updateInstanceRequest.IsSetOs()) 
                {
                    writer.WritePropertyName("Os");
                    writer.Write(updateInstanceRequest.Os);
                }
                if (updateInstanceRequest != null && updateInstanceRequest.IsSetAmiId()) 
                {
                    writer.WritePropertyName("AmiId");
                    writer.Write(updateInstanceRequest.AmiId);
                }
                if (updateInstanceRequest != null && updateInstanceRequest.IsSetSshKeyName()) 
                {
                    writer.WritePropertyName("SshKeyName");
                    writer.Write(updateInstanceRequest.SshKeyName);
                }
                if (updateInstanceRequest != null && updateInstanceRequest.IsSetArchitecture()) 
                {
                    writer.WritePropertyName("Architecture");
                    writer.Write(updateInstanceRequest.Architecture);
                }
                if (updateInstanceRequest != null && updateInstanceRequest.IsSetInstallUpdatesOnBoot()) 
                {
                    writer.WritePropertyName("InstallUpdatesOnBoot");
                    writer.Write(updateInstanceRequest.InstallUpdatesOnBoot);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
