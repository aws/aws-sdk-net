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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
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
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateContact Request Marshaller
    /// </summary>       
    public class UpdateContactRequestMarshaller : IMarshaller<IRequest, UpdateContactRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateContactRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateContactRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetContactId())
                throw new AmazonConnectException("Request object does not have required field ContactId set");
            request.AddPathResource("{ContactId}", StringUtils.FromString(publicRequest.ContactId));
            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            request.ResourcePath = "/contacts/{InstanceId}/{ContactId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCustomerEndpoint())
            {
                context.Writer.WritePropertyName("CustomerEndpoint");
                context.Writer.WriteStartObject();

                var marshaller = EndpointMarshaller.Instance;
                marshaller.Marshall(publicRequest.CustomerEndpoint, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetQueueInfo())
            {
                context.Writer.WritePropertyName("QueueInfo");
                context.Writer.WriteStartObject();

                var marshaller = QueueInfoInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.QueueInfo, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetReferences())
            {
                context.Writer.WritePropertyName("References");
                context.Writer.WriteStartObject();
                foreach (var publicRequestReferencesKvp in publicRequest.References)
                {
                    context.Writer.WritePropertyName(publicRequestReferencesKvp.Key);
                    var publicRequestReferencesValue = publicRequestReferencesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ReferenceMarshaller.Instance;
                    marshaller.Marshall(publicRequestReferencesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSegmentAttributes())
            {
                context.Writer.WritePropertyName("SegmentAttributes");
                context.Writer.WriteStartObject();
                foreach (var publicRequestSegmentAttributesKvp in publicRequest.SegmentAttributes)
                {
                    context.Writer.WritePropertyName(publicRequestSegmentAttributesKvp.Key);
                    var publicRequestSegmentAttributesValue = publicRequestSegmentAttributesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = SegmentAttributeValueMarshaller.Instance;
                    marshaller.Marshall(publicRequestSegmentAttributesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSystemEndpoint())
            {
                context.Writer.WritePropertyName("SystemEndpoint");
                context.Writer.WriteStartObject();

                var marshaller = EndpointMarshaller.Instance;
                marshaller.Marshall(publicRequest.SystemEndpoint, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUserInfo())
            {
                context.Writer.WritePropertyName("UserInfo");
                context.Writer.WriteStartObject();

                var marshaller = UserInfoMarshaller.Instance;
                marshaller.Marshall(publicRequest.UserInfo, context);

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
        private static UpdateContactRequestMarshaller _instance = new UpdateContactRequestMarshaller();        

        internal static UpdateContactRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateContactRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}