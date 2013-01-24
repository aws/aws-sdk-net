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

using Amazon.StorageGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Cachedi S C S I Volume Request Marshaller
    /// </summary>       
    internal class CreateCachediSCSIVolumeRequestMarshaller : IMarshaller<IRequest, CreateCachediSCSIVolumeRequest> 
    {
        

        public IRequest Marshall(CreateCachediSCSIVolumeRequest createCachediSCSIVolumeRequest) 
        {

            IRequest request = new DefaultRequest(createCachediSCSIVolumeRequest, "AmazonStorageGateway");
            string target = "StorageGateway_20120630.CreateCachediSCSIVolume";
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
                
                if (createCachediSCSIVolumeRequest != null && createCachediSCSIVolumeRequest.IsSetGatewayARN()) 
                {
                    writer.WritePropertyName("GatewayARN");
                    writer.Write(createCachediSCSIVolumeRequest.GatewayARN);
                }
                if (createCachediSCSIVolumeRequest != null && createCachediSCSIVolumeRequest.IsSetVolumeSizeInBytes()) 
                {
                    writer.WritePropertyName("VolumeSizeInBytes");
                    writer.Write(createCachediSCSIVolumeRequest.VolumeSizeInBytes);
                }
                if (createCachediSCSIVolumeRequest != null && createCachediSCSIVolumeRequest.IsSetSnapshotId()) 
                {
                    writer.WritePropertyName("SnapshotId");
                    writer.Write(createCachediSCSIVolumeRequest.SnapshotId);
                }
                if (createCachediSCSIVolumeRequest != null && createCachediSCSIVolumeRequest.IsSetTargetName()) 
                {
                    writer.WritePropertyName("TargetName");
                    writer.Write(createCachediSCSIVolumeRequest.TargetName);
                }
                if (createCachediSCSIVolumeRequest != null && createCachediSCSIVolumeRequest.IsSetNetworkInterfaceId()) 
                {
                    writer.WritePropertyName("NetworkInterfaceId");
                    writer.Write(createCachediSCSIVolumeRequest.NetworkInterfaceId);
                }
                if (createCachediSCSIVolumeRequest != null && createCachediSCSIVolumeRequest.IsSetClientToken()) 
                {
                    writer.WritePropertyName("ClientToken");
                    writer.Write(createCachediSCSIVolumeRequest.ClientToken);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
