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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmailV2.Model;
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
namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
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
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmailV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-27";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetContactListName())
                throw new AmazonSimpleEmailServiceV2Exception("Request object does not have required field ContactListName set");
            request.AddPathResource("{ContactListName}", StringUtils.FromString(publicRequest.ContactListName));
            if (!publicRequest.IsSetEmailAddress())
                throw new AmazonSimpleEmailServiceV2Exception("Request object does not have required field EmailAddress set");
            request.AddPathResource("{EmailAddress}", StringUtils.FromString(publicRequest.EmailAddress));
            request.ResourcePath = "/v2/email/contact-lists/{ContactListName}/contacts/{EmailAddress}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAttributesData())
            {
                context.Writer.WritePropertyName("AttributesData");
                context.Writer.WriteStringValue(publicRequest.AttributesData);
            }

            if(publicRequest.IsSetTopicPreferences())
            {
                context.Writer.WritePropertyName("TopicPreferences");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTopicPreferencesListValue in publicRequest.TopicPreferences)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TopicPreferenceMarshaller.Instance;
                    marshaller.Marshall(publicRequestTopicPreferencesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetUnsubscribeAll())
            {
                context.Writer.WritePropertyName("UnsubscribeAll");
                context.Writer.WriteBooleanValue(publicRequest.UnsubscribeAll.Value);
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