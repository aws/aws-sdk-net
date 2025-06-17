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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAutomationRuleV2 Request Marshaller
    /// </summary>       
    public class UpdateAutomationRuleV2RequestMarshaller : IMarshaller<IRequest, UpdateAutomationRuleV2Request> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAutomationRuleV2Request)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAutomationRuleV2Request publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityHub");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-10-26";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetIdentifier())
                throw new AmazonSecurityHubException("Request object does not have required field Identifier set");
            request.AddPathResource("{Identifier}", StringUtils.FromString(publicRequest.Identifier));
            request.ResourcePath = "/automationrulesv2/{Identifier}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActions())
                {
                    context.Writer.WritePropertyName("Actions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestActionsListValue in publicRequest.Actions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AutomationRulesActionV2Marshaller.Instance;
                        marshaller.Marshall(publicRequestActionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCriteria())
                {
                    context.Writer.WritePropertyName("Criteria");
                    context.Writer.WriteObjectStart();

                    var marshaller = CriteriaMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Criteria, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetRuleName())
                {
                    context.Writer.WritePropertyName("RuleName");
                    context.Writer.Write(publicRequest.RuleName);
                }

                if(publicRequest.IsSetRuleOrder())
                {
                    context.Writer.WritePropertyName("RuleOrder");
                    if(StringUtils.IsSpecialFloatValue(publicRequest.RuleOrder))
                    {
                        context.Writer.Write(StringUtils.FromSpecialFloatValue(publicRequest.RuleOrder));
                    }
                    else
                    {
                        context.Writer.Write(publicRequest.RuleOrder);
                    }
                }

                if(publicRequest.IsSetRuleStatus())
                {
                    context.Writer.WritePropertyName("RuleStatus");
                    context.Writer.Write(publicRequest.RuleStatus);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAutomationRuleV2RequestMarshaller _instance = new UpdateAutomationRuleV2RequestMarshaller();        

        internal static UpdateAutomationRuleV2RequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAutomationRuleV2RequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}