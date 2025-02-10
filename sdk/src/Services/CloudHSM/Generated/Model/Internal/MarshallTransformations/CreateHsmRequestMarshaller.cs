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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudHSM.Model;
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
namespace Amazon.CloudHSM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateHsm Request Marshaller
    /// </summary>       
    public class CreateHsmRequestMarshaller : IMarshaller<IRequest, CreateHsmRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateHsmRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateHsmRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudHSM");
            string target = "CloudHsmFrontendService.CreateHsm";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-05-30";
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
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            if(publicRequest.IsSetEniIp())
            {
                context.Writer.WritePropertyName("EniIp");
                context.Writer.WriteStringValue(publicRequest.EniIp);
            }

            if(publicRequest.IsSetExternalId())
            {
                context.Writer.WritePropertyName("ExternalId");
                context.Writer.WriteStringValue(publicRequest.ExternalId);
            }

            if(publicRequest.IsSetIamRoleArn())
            {
                context.Writer.WritePropertyName("IamRoleArn");
                context.Writer.WriteStringValue(publicRequest.IamRoleArn);
            }

            if(publicRequest.IsSetSshKey())
            {
                context.Writer.WritePropertyName("SshKey");
                context.Writer.WriteStringValue(publicRequest.SshKey);
            }

            if(publicRequest.IsSetSubnetId())
            {
                context.Writer.WritePropertyName("SubnetId");
                context.Writer.WriteStringValue(publicRequest.SubnetId);
            }

            if(publicRequest.IsSetSubscriptionType())
            {
                context.Writer.WritePropertyName("SubscriptionType");
                context.Writer.WriteStringValue(publicRequest.SubscriptionType);
            }

            if(publicRequest.IsSetSyslogIp())
            {
                context.Writer.WritePropertyName("SyslogIp");
                context.Writer.WriteStringValue(publicRequest.SyslogIp);
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
        private static CreateHsmRequestMarshaller _instance = new CreateHsmRequestMarshaller();        

        internal static CreateHsmRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateHsmRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}