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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WellArchitected.Model;
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
namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateWorkload Request Marshaller
    /// </summary>       
    public class UpdateWorkloadRequestMarshaller : IMarshaller<IRequest, UpdateWorkloadRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateWorkloadRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateWorkloadRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WellArchitected");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-31";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetWorkloadId())
                throw new AmazonWellArchitectedException("Request object does not have required field WorkloadId set");
            request.AddPathResource("{WorkloadId}", StringUtils.FromString(publicRequest.WorkloadId));
            request.ResourcePath = "/workloads/{WorkloadId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccountIds())
            {
                context.Writer.WritePropertyName("AccountIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAccountIdsListValue in publicRequest.AccountIds)
                {
                        context.Writer.WriteStringValue(publicRequestAccountIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetApplications())
            {
                context.Writer.WritePropertyName("Applications");
                context.Writer.WriteStartArray();
                foreach(var publicRequestApplicationsListValue in publicRequest.Applications)
                {
                        context.Writer.WriteStringValue(publicRequestApplicationsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetArchitecturalDesign())
            {
                context.Writer.WritePropertyName("ArchitecturalDesign");
                context.Writer.WriteStringValue(publicRequest.ArchitecturalDesign);
            }

            if(publicRequest.IsSetAwsRegions())
            {
                context.Writer.WritePropertyName("AwsRegions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAwsRegionsListValue in publicRequest.AwsRegions)
                {
                        context.Writer.WriteStringValue(publicRequestAwsRegionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDiscoveryConfig())
            {
                context.Writer.WritePropertyName("DiscoveryConfig");
                context.Writer.WriteStartObject();

                var marshaller = WorkloadDiscoveryConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.DiscoveryConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("Environment");
                context.Writer.WriteStringValue(publicRequest.Environment);
            }

            if(publicRequest.IsSetImprovementStatus())
            {
                context.Writer.WritePropertyName("ImprovementStatus");
                context.Writer.WriteStringValue(publicRequest.ImprovementStatus);
            }

            if(publicRequest.IsSetIndustry())
            {
                context.Writer.WritePropertyName("Industry");
                context.Writer.WriteStringValue(publicRequest.Industry);
            }

            if(publicRequest.IsSetIndustryType())
            {
                context.Writer.WritePropertyName("IndustryType");
                context.Writer.WriteStringValue(publicRequest.IndustryType);
            }

            if(publicRequest.IsSetIsReviewOwnerUpdateAcknowledged())
            {
                context.Writer.WritePropertyName("IsReviewOwnerUpdateAcknowledged");
                context.Writer.WriteBooleanValue(publicRequest.IsReviewOwnerUpdateAcknowledged.Value);
            }

            if(publicRequest.IsSetJiraConfiguration())
            {
                context.Writer.WritePropertyName("JiraConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = WorkloadJiraConfigurationInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.JiraConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNonAwsRegions())
            {
                context.Writer.WritePropertyName("NonAwsRegions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNonAwsRegionsListValue in publicRequest.NonAwsRegions)
                {
                        context.Writer.WriteStringValue(publicRequestNonAwsRegionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNotes())
            {
                context.Writer.WritePropertyName("Notes");
                context.Writer.WriteStringValue(publicRequest.Notes);
            }

            if(publicRequest.IsSetPillarPriorities())
            {
                context.Writer.WritePropertyName("PillarPriorities");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPillarPrioritiesListValue in publicRequest.PillarPriorities)
                {
                        context.Writer.WriteStringValue(publicRequestPillarPrioritiesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetReviewOwner())
            {
                context.Writer.WritePropertyName("ReviewOwner");
                context.Writer.WriteStringValue(publicRequest.ReviewOwner);
            }

            if(publicRequest.IsSetWorkloadName())
            {
                context.Writer.WritePropertyName("WorkloadName");
                context.Writer.WriteStringValue(publicRequest.WorkloadName);
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
        private static UpdateWorkloadRequestMarshaller _instance = new UpdateWorkloadRequestMarshaller();        

        internal static UpdateWorkloadRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateWorkloadRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}