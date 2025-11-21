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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ComputeOptimizerAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAutomationRule Request Marshaller
    /// </summary>       
    public class UpdateAutomationRuleRequestMarshaller : IMarshaller<IRequest, UpdateAutomationRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAutomationRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAutomationRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ComputeOptimizerAutomation");
            string target = "ComputeOptimizerAutomationService.UpdateAutomationRule";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-09-22";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetCriteria())
                {
                    context.Writer.WritePropertyName("criteria");
                    context.Writer.WriteObjectStart();

                    var marshaller = CriteriaMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Criteria, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetOrganizationConfiguration())
                {
                    context.Writer.WritePropertyName("organizationConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = OrganizationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OrganizationConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPriority())
                {
                    context.Writer.WritePropertyName("priority");
                    context.Writer.Write(publicRequest.Priority);
                }

                if(publicRequest.IsSetRecommendedActionTypes())
                {
                    context.Writer.WritePropertyName("recommendedActionTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRecommendedActionTypesListValue in publicRequest.RecommendedActionTypes)
                    {
                            context.Writer.Write(publicRequestRecommendedActionTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRuleArn())
                {
                    context.Writer.WritePropertyName("ruleArn");
                    context.Writer.Write(publicRequest.RuleArn);
                }

                if(publicRequest.IsSetRuleRevision())
                {
                    context.Writer.WritePropertyName("ruleRevision");
                    context.Writer.Write(publicRequest.RuleRevision);
                }

                if(publicRequest.IsSetRuleType())
                {
                    context.Writer.WritePropertyName("ruleType");
                    context.Writer.Write(publicRequest.RuleType);
                }

                if(publicRequest.IsSetSchedule())
                {
                    context.Writer.WritePropertyName("schedule");
                    context.Writer.WriteObjectStart();

                    var marshaller = ScheduleMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Schedule, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("status");
                    context.Writer.Write(publicRequest.Status);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAutomationRuleRequestMarshaller _instance = new UpdateAutomationRuleRequestMarshaller();        

        internal static UpdateAutomationRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAutomationRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}