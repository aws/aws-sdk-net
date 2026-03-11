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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Synthetics.Model;
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
namespace Amazon.Synthetics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCanary Request Marshaller
    /// </summary>       
    public class CreateCanaryRequestMarshaller : IMarshaller<IRequest, CreateCanaryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCanaryRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCanaryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Synthetics");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-11";
            request.HttpMethod = "POST";

            request.ResourcePath = "/canary";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetArtifactConfig())
            {
                context.Writer.WritePropertyName("ArtifactConfig");
                context.Writer.WriteStartObject();

                var marshaller = ArtifactConfigInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.ArtifactConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetArtifactS3Location())
            {
                context.Writer.WritePropertyName("ArtifactS3Location");
                context.Writer.WriteStringValue(publicRequest.ArtifactS3Location);
            }

            if(publicRequest.IsSetBrowserConfigs())
            {
                context.Writer.WritePropertyName("BrowserConfigs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestBrowserConfigsListValue in publicRequest.BrowserConfigs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = BrowserConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequestBrowserConfigsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCode())
            {
                context.Writer.WritePropertyName("Code");
                context.Writer.WriteStartObject();

                var marshaller = CanaryCodeInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.Code, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExecutionRoleArn())
            {
                context.Writer.WritePropertyName("ExecutionRoleArn");
                context.Writer.WriteStringValue(publicRequest.ExecutionRoleArn);
            }

            if(publicRequest.IsSetFailureRetentionPeriodInDays())
            {
                context.Writer.WritePropertyName("FailureRetentionPeriodInDays");
                context.Writer.WriteNumberValue(publicRequest.FailureRetentionPeriodInDays.Value);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetProvisionedResourceCleanup())
            {
                context.Writer.WritePropertyName("ProvisionedResourceCleanup");
                context.Writer.WriteStringValue(publicRequest.ProvisionedResourceCleanup);
            }

            if(publicRequest.IsSetResourcesToReplicateTags())
            {
                context.Writer.WritePropertyName("ResourcesToReplicateTags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestResourcesToReplicateTagsListValue in publicRequest.ResourcesToReplicateTags)
                {
                        context.Writer.WriteStringValue(publicRequestResourcesToReplicateTagsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRunConfig())
            {
                context.Writer.WritePropertyName("RunConfig");
                context.Writer.WriteStartObject();

                var marshaller = CanaryRunConfigInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.RunConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRuntimeVersion())
            {
                context.Writer.WritePropertyName("RuntimeVersion");
                context.Writer.WriteStringValue(publicRequest.RuntimeVersion);
            }

            if(publicRequest.IsSetSchedule())
            {
                context.Writer.WritePropertyName("Schedule");
                context.Writer.WriteStartObject();

                var marshaller = CanaryScheduleInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.Schedule, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSuccessRetentionPeriodInDays())
            {
                context.Writer.WritePropertyName("SuccessRetentionPeriodInDays");
                context.Writer.WriteNumberValue(publicRequest.SuccessRetentionPeriodInDays.Value);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetVpcConfig())
            {
                context.Writer.WritePropertyName("VpcConfig");
                context.Writer.WriteStartObject();

                var marshaller = VpcConfigInputMarshaller.Instance;
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
        private static CreateCanaryRequestMarshaller _instance = new CreateCanaryRequestMarshaller();        

        internal static CreateCanaryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCanaryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}