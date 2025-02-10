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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Macie2.Model;
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
namespace Amazon.Macie2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateClassificationJob Request Marshaller
    /// </summary>       
    public class CreateClassificationJobRequestMarshaller : IMarshaller<IRequest, CreateClassificationJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateClassificationJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateClassificationJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Macie2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/jobs";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAllowListIds())
            {
                context.Writer.WritePropertyName("allowListIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAllowListIdsListValue in publicRequest.AllowListIds)
                {
                        context.Writer.WriteStringValue(publicRequestAllowListIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetCustomDataIdentifierIds())
            {
                context.Writer.WritePropertyName("customDataIdentifierIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCustomDataIdentifierIdsListValue in publicRequest.CustomDataIdentifierIds)
                {
                        context.Writer.WriteStringValue(publicRequestCustomDataIdentifierIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetInitialRun())
            {
                context.Writer.WritePropertyName("initialRun");
                context.Writer.WriteBooleanValue(publicRequest.InitialRun.Value);
            }

            if(publicRequest.IsSetJobType())
            {
                context.Writer.WritePropertyName("jobType");
                context.Writer.WriteStringValue(publicRequest.JobType);
            }

            if(publicRequest.IsSetManagedDataIdentifierIds())
            {
                context.Writer.WritePropertyName("managedDataIdentifierIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestManagedDataIdentifierIdsListValue in publicRequest.ManagedDataIdentifierIds)
                {
                        context.Writer.WriteStringValue(publicRequestManagedDataIdentifierIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetManagedDataIdentifierSelector())
            {
                context.Writer.WritePropertyName("managedDataIdentifierSelector");
                context.Writer.WriteStringValue(publicRequest.ManagedDataIdentifierSelector);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetS3JobDefinition())
            {
                context.Writer.WritePropertyName("s3JobDefinition");
                context.Writer.WriteStartObject();

                var marshaller = S3JobDefinitionMarshaller.Instance;
                marshaller.Marshall(publicRequest.S3JobDefinition, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSamplingPercentage())
            {
                context.Writer.WritePropertyName("samplingPercentage");
                context.Writer.WriteNumberValue(publicRequest.SamplingPercentage.Value);
            }

            if(publicRequest.IsSetScheduleFrequency())
            {
                context.Writer.WritePropertyName("scheduleFrequency");
                context.Writer.WriteStartObject();

                var marshaller = JobScheduleFrequencyMarshaller.Instance;
                marshaller.Marshall(publicRequest.ScheduleFrequency, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
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
        private static CreateClassificationJobRequestMarshaller _instance = new CreateClassificationJobRequestMarshaller();        

        internal static CreateClassificationJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateClassificationJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}