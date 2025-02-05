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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DeviceFarm.Model;
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
namespace Amazon.DeviceFarm.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateRemoteAccessSession Request Marshaller
    /// </summary>       
    public class CreateRemoteAccessSessionRequestMarshaller : IMarshaller<IRequest, CreateRemoteAccessSessionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRemoteAccessSessionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateRemoteAccessSessionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DeviceFarm");
            string target = "DeviceFarm_20150623.CreateRemoteAccessSession";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-06-23";
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
            if(publicRequest.IsSetClientId())
            {
                context.Writer.WritePropertyName("clientId");
                context.Writer.WriteStringValue(publicRequest.ClientId);
            }

            if(publicRequest.IsSetConfiguration())
            {
                context.Writer.WritePropertyName("configuration");
                context.Writer.WriteStartObject();

                var marshaller = CreateRemoteAccessSessionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Configuration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDeviceArn())
            {
                context.Writer.WritePropertyName("deviceArn");
                context.Writer.WriteStringValue(publicRequest.DeviceArn);
            }

            if(publicRequest.IsSetInstanceArn())
            {
                context.Writer.WritePropertyName("instanceArn");
                context.Writer.WriteStringValue(publicRequest.InstanceArn);
            }

            if(publicRequest.IsSetInteractionMode())
            {
                context.Writer.WritePropertyName("interactionMode");
                context.Writer.WriteStringValue(publicRequest.InteractionMode);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetProjectArn())
            {
                context.Writer.WritePropertyName("projectArn");
                context.Writer.WriteStringValue(publicRequest.ProjectArn);
            }

            if(publicRequest.IsSetRemoteDebugEnabled())
            {
                context.Writer.WritePropertyName("remoteDebugEnabled");
                context.Writer.WriteBooleanValue(publicRequest.RemoteDebugEnabled.Value);
            }

            if(publicRequest.IsSetRemoteRecordAppArn())
            {
                context.Writer.WritePropertyName("remoteRecordAppArn");
                context.Writer.WriteStringValue(publicRequest.RemoteRecordAppArn);
            }

            if(publicRequest.IsSetRemoteRecordEnabled())
            {
                context.Writer.WritePropertyName("remoteRecordEnabled");
                context.Writer.WriteBooleanValue(publicRequest.RemoteRecordEnabled.Value);
            }

            if(publicRequest.IsSetSkipAppResign())
            {
                context.Writer.WritePropertyName("skipAppResign");
                context.Writer.WriteBooleanValue(publicRequest.SkipAppResign.Value);
            }

            if(publicRequest.IsSetSshPublicKey())
            {
                context.Writer.WritePropertyName("sshPublicKey");
                context.Writer.WriteStringValue(publicRequest.SshPublicKey);
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
        private static CreateRemoteAccessSessionRequestMarshaller _instance = new CreateRemoteAccessSessionRequestMarshaller();        

        internal static CreateRemoteAccessSessionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateRemoteAccessSessionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}