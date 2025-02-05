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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
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
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyEventSubscription Request Marshaller
    /// </summary>       
    public class ModifyEventSubscriptionRequestMarshaller : IMarshaller<IRequest, ModifyEventSubscriptionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyEventSubscriptionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyEventSubscriptionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DatabaseMigrationService");
            string target = "AmazonDMSv20160101.ModifyEventSubscription";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-01-01";
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
            if(publicRequest.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.WriteBooleanValue(publicRequest.Enabled.Value);
            }

            if(publicRequest.IsSetEventCategories())
            {
                context.Writer.WritePropertyName("EventCategories");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEventCategoriesListValue in publicRequest.EventCategories)
                {
                        context.Writer.WriteStringValue(publicRequestEventCategoriesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSnsTopicArn())
            {
                context.Writer.WritePropertyName("SnsTopicArn");
                context.Writer.WriteStringValue(publicRequest.SnsTopicArn);
            }

            if(publicRequest.IsSetSourceType())
            {
                context.Writer.WritePropertyName("SourceType");
                context.Writer.WriteStringValue(publicRequest.SourceType);
            }

            if(publicRequest.IsSetSubscriptionName())
            {
                context.Writer.WritePropertyName("SubscriptionName");
                context.Writer.WriteStringValue(publicRequest.SubscriptionName);
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
        private static ModifyEventSubscriptionRequestMarshaller _instance = new ModifyEventSubscriptionRequestMarshaller();        

        internal static ModifyEventSubscriptionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyEventSubscriptionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}