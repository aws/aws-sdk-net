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

/*
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFleet Request Marshaller
    /// </summary>       
    public class UpdateFleetRequestMarshaller : IMarshaller<IRequest, UpdateFleetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFleetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            string target = "PhotonAdminProxyService.UpdateFleet";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAttributesToDelete())
            {
                context.Writer.WritePropertyName("AttributesToDelete");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAttributesToDeleteListValue in publicRequest.AttributesToDelete)
                {
                        context.Writer.WriteStringValue(publicRequestAttributesToDeleteListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetComputeCapacity())
            {
                context.Writer.WritePropertyName("ComputeCapacity");
                context.Writer.WriteStartObject();

                var marshaller = ComputeCapacityMarshaller.Instance;
                marshaller.Marshall(publicRequest.ComputeCapacity, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDeleteVpcConfig())
            {
                context.Writer.WritePropertyName("DeleteVpcConfig");
                context.Writer.WriteBooleanValue(publicRequest.DeleteVpcConfig.Value);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDisconnectTimeoutInSeconds())
            {
                context.Writer.WritePropertyName("DisconnectTimeoutInSeconds");
                context.Writer.WriteNumberValue(publicRequest.DisconnectTimeoutInSeconds.Value);
            }

            if(publicRequest.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("DisplayName");
                context.Writer.WriteStringValue(publicRequest.DisplayName);
            }

            if(publicRequest.IsSetDomainJoinInfo())
            {
                context.Writer.WritePropertyName("DomainJoinInfo");
                context.Writer.WriteStartObject();

                var marshaller = DomainJoinInfoMarshaller.Instance;
                marshaller.Marshall(publicRequest.DomainJoinInfo, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEnableDefaultInternetAccess())
            {
                context.Writer.WritePropertyName("EnableDefaultInternetAccess");
                context.Writer.WriteBooleanValue(publicRequest.EnableDefaultInternetAccess.Value);
            }

            if(publicRequest.IsSetIamRoleArn())
            {
                context.Writer.WritePropertyName("IamRoleArn");
                context.Writer.WriteStringValue(publicRequest.IamRoleArn);
            }

            if(publicRequest.IsSetIdleDisconnectTimeoutInSeconds())
            {
                context.Writer.WritePropertyName("IdleDisconnectTimeoutInSeconds");
                context.Writer.WriteNumberValue(publicRequest.IdleDisconnectTimeoutInSeconds.Value);
            }

            if(publicRequest.IsSetImageArn())
            {
                context.Writer.WritePropertyName("ImageArn");
                context.Writer.WriteStringValue(publicRequest.ImageArn);
            }

            if(publicRequest.IsSetImageName())
            {
                context.Writer.WritePropertyName("ImageName");
                context.Writer.WriteStringValue(publicRequest.ImageName);
            }

            if(publicRequest.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.WriteStringValue(publicRequest.InstanceType);
            }

            if(publicRequest.IsSetMaxConcurrentSessions())
            {
                context.Writer.WritePropertyName("MaxConcurrentSessions");
                context.Writer.WriteNumberValue(publicRequest.MaxConcurrentSessions.Value);
            }

            if(publicRequest.IsSetMaxSessionsPerInstance())
            {
                context.Writer.WritePropertyName("MaxSessionsPerInstance");
                context.Writer.WriteNumberValue(publicRequest.MaxSessionsPerInstance.Value);
            }

            if(publicRequest.IsSetMaxUserDurationInSeconds())
            {
                context.Writer.WritePropertyName("MaxUserDurationInSeconds");
                context.Writer.WriteNumberValue(publicRequest.MaxUserDurationInSeconds.Value);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetPlatform())
            {
                context.Writer.WritePropertyName("Platform");
                context.Writer.WriteStringValue(publicRequest.Platform);
            }

            if(publicRequest.IsSetSessionScriptS3Location())
            {
                context.Writer.WritePropertyName("SessionScriptS3Location");
                context.Writer.WriteStartObject();

                var marshaller = S3LocationMarshaller.Instance;
                marshaller.Marshall(publicRequest.SessionScriptS3Location, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetStreamView())
            {
                context.Writer.WritePropertyName("StreamView");
                context.Writer.WriteStringValue(publicRequest.StreamView);
            }

            if(publicRequest.IsSetUsbDeviceFilterStrings())
            {
                context.Writer.WritePropertyName("UsbDeviceFilterStrings");
                context.Writer.WriteStartArray();
                foreach(var publicRequestUsbDeviceFilterStringsListValue in publicRequest.UsbDeviceFilterStrings)
                {
                        context.Writer.WriteStringValue(publicRequestUsbDeviceFilterStringsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetVpcConfig())
            {
                context.Writer.WritePropertyName("VpcConfig");
                context.Writer.WriteStartObject();

                var marshaller = VpcConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.VpcConfig, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateFleetRequestMarshaller _instance = new UpdateFleetRequestMarshaller();        

        internal static UpdateFleetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFleetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}