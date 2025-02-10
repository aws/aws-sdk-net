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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudTrail.Model;
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
namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEventDataStore Request Marshaller
    /// </summary>       
    public class UpdateEventDataStoreRequestMarshaller : IMarshaller<IRequest, UpdateEventDataStoreRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEventDataStoreRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateEventDataStoreRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudTrail");
            string target = "com.amazonaws.cloudtrail.v20131101.CloudTrail_20131101.UpdateEventDataStore";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-11-01";
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
            if(publicRequest.IsSetAdvancedEventSelectors())
            {
                context.Writer.WritePropertyName("AdvancedEventSelectors");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAdvancedEventSelectorsListValue in publicRequest.AdvancedEventSelectors)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AdvancedEventSelectorMarshaller.Instance;
                    marshaller.Marshall(publicRequestAdvancedEventSelectorsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetBillingMode())
            {
                context.Writer.WritePropertyName("BillingMode");
                context.Writer.WriteStringValue(publicRequest.BillingMode);
            }

            if(publicRequest.IsSetEventDataStore())
            {
                context.Writer.WritePropertyName("EventDataStore");
                context.Writer.WriteStringValue(publicRequest.EventDataStore);
            }

            if(publicRequest.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(publicRequest.KmsKeyId);
            }

            if(publicRequest.IsSetMultiRegionEnabled())
            {
                context.Writer.WritePropertyName("MultiRegionEnabled");
                context.Writer.WriteBooleanValue(publicRequest.MultiRegionEnabled.Value);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetOrganizationEnabled())
            {
                context.Writer.WritePropertyName("OrganizationEnabled");
                context.Writer.WriteBooleanValue(publicRequest.OrganizationEnabled.Value);
            }

            if(publicRequest.IsSetRetentionPeriod())
            {
                context.Writer.WritePropertyName("RetentionPeriod");
                context.Writer.WriteNumberValue(publicRequest.RetentionPeriod.Value);
            }

            if(publicRequest.IsSetTerminationProtectionEnabled())
            {
                context.Writer.WritePropertyName("TerminationProtectionEnabled");
                context.Writer.WriteBooleanValue(publicRequest.TerminationProtectionEnabled.Value);
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
        private static UpdateEventDataStoreRequestMarshaller _instance = new UpdateEventDataStoreRequestMarshaller();        

        internal static UpdateEventDataStoreRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateEventDataStoreRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}