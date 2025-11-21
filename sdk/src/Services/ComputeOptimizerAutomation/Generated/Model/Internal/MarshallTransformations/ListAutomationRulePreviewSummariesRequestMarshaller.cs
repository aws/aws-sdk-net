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
    /// ListAutomationRulePreviewSummaries Request Marshaller
    /// </summary>       
    public class ListAutomationRulePreviewSummariesRequestMarshaller : IMarshaller<IRequest, ListAutomationRulePreviewSummariesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListAutomationRulePreviewSummariesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListAutomationRulePreviewSummariesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ComputeOptimizerAutomation");
            string target = "ComputeOptimizerAutomationService.ListAutomationRulePreviewSummaries";
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
                if(publicRequest.IsSetCriteria())
                {
                    context.Writer.WritePropertyName("criteria");
                    context.Writer.WriteObjectStart();

                    var marshaller = CriteriaMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Criteria, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("maxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetOrganizationScope())
                {
                    context.Writer.WritePropertyName("organizationScope");
                    context.Writer.WriteObjectStart();

                    var marshaller = OrganizationScopeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OrganizationScope, context);

                    context.Writer.WriteObjectEnd();
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

                if(publicRequest.IsSetRuleType())
                {
                    context.Writer.WritePropertyName("ruleType");
                    context.Writer.Write(publicRequest.RuleType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListAutomationRulePreviewSummariesRequestMarshaller _instance = new ListAutomationRulePreviewSummariesRequestMarshaller();        

        internal static ListAutomationRulePreviewSummariesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListAutomationRulePreviewSummariesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}