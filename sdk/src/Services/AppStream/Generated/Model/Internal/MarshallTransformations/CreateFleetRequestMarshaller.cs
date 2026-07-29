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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFleet Request Marshaller
    /// </summary>       
    public class CreateFleetRequestMarshaller : IMarshaller<IRequest, CreateFleetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFleetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/PhotonAdminProxyService/operation/CreateFleet";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetComputeCapacity())
                {
                    context.Writer.WriteTextString("ComputeCapacity");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ComputeCapacityMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ComputeCapacity, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetDisableIMDSV1())
                {
                    context.Writer.WriteTextString("DisableIMDSV1");
                    context.Writer.WriteBoolean(publicRequest.DisableIMDSV1.Value);
                }
                if (publicRequest.IsSetDisconnectTimeoutInSeconds())
                {
                    context.Writer.WriteTextString("DisconnectTimeoutInSeconds");
                    context.Writer.WriteInt32(publicRequest.DisconnectTimeoutInSeconds.Value);
                }
                if (publicRequest.IsSetDisplayName())
                {
                    context.Writer.WriteTextString("DisplayName");
                    context.Writer.WriteTextString(publicRequest.DisplayName);
                }
                if (publicRequest.IsSetDomainJoinInfo())
                {
                    context.Writer.WriteTextString("DomainJoinInfo");
                    context.Writer.WriteStartMap(null);

                    var marshaller = DomainJoinInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DomainJoinInfo, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetEnableDefaultInternetAccess())
                {
                    context.Writer.WriteTextString("EnableDefaultInternetAccess");
                    context.Writer.WriteBoolean(publicRequest.EnableDefaultInternetAccess.Value);
                }
                if (publicRequest.IsSetFleetType())
                {
                    context.Writer.WriteTextString("FleetType");
                    context.Writer.WriteTextString(publicRequest.FleetType);
                }
                if (publicRequest.IsSetIamRoleArn())
                {
                    context.Writer.WriteTextString("IamRoleArn");
                    context.Writer.WriteTextString(publicRequest.IamRoleArn);
                }
                if (publicRequest.IsSetIdleDisconnectTimeoutInSeconds())
                {
                    context.Writer.WriteTextString("IdleDisconnectTimeoutInSeconds");
                    context.Writer.WriteInt32(publicRequest.IdleDisconnectTimeoutInSeconds.Value);
                }
                if (publicRequest.IsSetImageArn())
                {
                    context.Writer.WriteTextString("ImageArn");
                    context.Writer.WriteTextString(publicRequest.ImageArn);
                }
                if (publicRequest.IsSetImageName())
                {
                    context.Writer.WriteTextString("ImageName");
                    context.Writer.WriteTextString(publicRequest.ImageName);
                }
                if (publicRequest.IsSetInstanceType())
                {
                    context.Writer.WriteTextString("InstanceType");
                    context.Writer.WriteTextString(publicRequest.InstanceType);
                }
                if (publicRequest.IsSetMaxConcurrentSessions())
                {
                    context.Writer.WriteTextString("MaxConcurrentSessions");
                    context.Writer.WriteInt32(publicRequest.MaxConcurrentSessions.Value);
                }
                if (publicRequest.IsSetMaxSessionsPerInstance())
                {
                    context.Writer.WriteTextString("MaxSessionsPerInstance");
                    context.Writer.WriteInt32(publicRequest.MaxSessionsPerInstance.Value);
                }
                if (publicRequest.IsSetMaxUserDurationInSeconds())
                {
                    context.Writer.WriteTextString("MaxUserDurationInSeconds");
                    context.Writer.WriteInt32(publicRequest.MaxUserDurationInSeconds.Value);
                }
                if (publicRequest.IsSetName())
                {
                    context.Writer.WriteTextString("Name");
                    context.Writer.WriteTextString(publicRequest.Name);
                }
                if (publicRequest.IsSetPlatform())
                {
                    context.Writer.WriteTextString("Platform");
                    context.Writer.WriteTextString(publicRequest.Platform);
                }
                if (publicRequest.IsSetRootVolumeConfig())
                {
                    context.Writer.WriteTextString("RootVolumeConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = VolumeConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RootVolumeConfig, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetSessionScriptS3Location())
                {
                    context.Writer.WriteTextString("SessionScriptS3Location");
                    context.Writer.WriteStartMap(null);

                    var marshaller = S3LocationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SessionScriptS3Location, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetStreamView())
                {
                    context.Writer.WriteTextString("StreamView");
                    context.Writer.WriteTextString(publicRequest.StreamView);
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("Tags");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WriteTextString(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.WriteTextString(publicRequestTagsValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetUsbDeviceFilterStrings())
                {
                    context.Writer.WriteTextString("UsbDeviceFilterStrings");
                    context.Writer.WriteStartArray(publicRequest.UsbDeviceFilterStrings.Count);
                    foreach(var publicRequestUsbDeviceFilterStringsListValue in publicRequest.UsbDeviceFilterStrings)
                    {
                            context.Writer.WriteTextString(publicRequestUsbDeviceFilterStringsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetVpcConfig())
                {
                    context.Writer.WriteTextString("VpcConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = VpcConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VpcConfig, context);

                    context.Writer.WriteEndMap();
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                // Encode directly into a pooled buffer instead of allocating a new byte[] per request.
                // The buffer is pre-sized to writer.BytesWritten so it's rented at the right size up front,
                // avoiding the default-size rent followed by a resize+return.
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
            return request;
        }
        private static CreateFleetRequestMarshaller _instance = new CreateFleetRequestMarshaller();        

        internal static CreateFleetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFleetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}