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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComputeOptimizerAutomation.Model;
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
namespace Amazon.ComputeOptimizerAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAutomationRule Request Marshaller
    /// </summary>       
    public class CreateAutomationRuleRequestMarshaller : IMarshaller<IRequest, CreateAutomationRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAutomationRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAutomationRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ComputeOptimizerAutomation");
            string target = "ComputeOptimizerAutomationService.CreateAutomationRule";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-09-22";
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
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetCriteria())
            {
                context.Writer.WritePropertyName("criteria");
                context.Writer.WriteStartObject();

                var marshaller = CriteriaMarshaller.Instance;
                marshaller.Marshall(publicRequest.Criteria, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetOrganizationConfiguration())
            {
                context.Writer.WritePropertyName("organizationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = OrganizationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.OrganizationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPriority())
            {
                context.Writer.WritePropertyName("priority");
                context.Writer.WriteStringValue(publicRequest.Priority);
            }

            if(publicRequest.IsSetRecommendedActionTypes())
            {
                context.Writer.WritePropertyName("recommendedActionTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRecommendedActionTypesListValue in publicRequest.RecommendedActionTypes)
                {
                        context.Writer.WriteStringValue(publicRequestRecommendedActionTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRuleType())
            {
                context.Writer.WritePropertyName("ruleType");
                context.Writer.WriteStringValue(publicRequest.RuleType);
            }

            if(publicRequest.IsSetSchedule())
            {
                context.Writer.WritePropertyName("schedule");
                context.Writer.WriteStartObject();

                var marshaller = ScheduleMarshaller.Instance;
                marshaller.Marshall(publicRequest.Schedule, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetStatus())
            {
                context.Writer.WritePropertyName("status");
                context.Writer.WriteStringValue(publicRequest.Status);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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
        private static CreateAutomationRuleRequestMarshaller _instance = new CreateAutomationRuleRequestMarshaller();        

        internal static CreateAutomationRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAutomationRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}