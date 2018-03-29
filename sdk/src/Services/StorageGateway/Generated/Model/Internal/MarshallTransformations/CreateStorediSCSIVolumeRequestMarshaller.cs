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

/*
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// CreateStorediSCSIVolume Request Marshaller
    /// </summary>       
    public class CreateStorediSCSIVolumeRequestMarshaller : IMarshaller<IRequest, CreateStorediSCSIVolumeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateStorediSCSIVolumeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateStorediSCSIVolumeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.StorageGateway");
            string target = "StorageGateway_20130630.CreateStorediSCSIVolume";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDiskId())
                {
                    context.Writer.WritePropertyName("DiskId");
                    context.Writer.Write(publicRequest.DiskId);
                }

                if(publicRequest.IsSetGatewayARN())
                {
                    context.Writer.WritePropertyName("GatewayARN");
                    context.Writer.Write(publicRequest.GatewayARN);
                }

                if(publicRequest.IsSetNetworkInterfaceId())
                {
                    context.Writer.WritePropertyName("NetworkInterfaceId");
                    context.Writer.Write(publicRequest.NetworkInterfaceId);
                }

                if(publicRequest.IsSetPreserveExistingData())
                {
                    context.Writer.WritePropertyName("PreserveExistingData");
                    context.Writer.Write(publicRequest.PreserveExistingData);
                }

                if(publicRequest.IsSetSnapshotId())
                {
                    context.Writer.WritePropertyName("SnapshotId");
                    context.Writer.Write(publicRequest.SnapshotId);
                }

                if(publicRequest.IsSetTargetName())
                {
                    context.Writer.WritePropertyName("TargetName");
                    context.Writer.Write(publicRequest.TargetName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateStorediSCSIVolumeRequestMarshaller _instance = new CreateStorediSCSIVolumeRequestMarshaller();        

        internal static CreateStorediSCSIVolumeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateStorediSCSIVolumeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}