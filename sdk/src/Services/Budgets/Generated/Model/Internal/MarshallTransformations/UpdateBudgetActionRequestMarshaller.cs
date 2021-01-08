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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Budgets.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Budgets.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateBudgetAction Request Marshaller
    /// </summary>       
    public class UpdateBudgetActionRequestMarshaller : IMarshaller<IRequest, UpdateBudgetActionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateBudgetActionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateBudgetActionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Budgets");
            string target = "AWSBudgetServiceGateway.UpdateBudgetAction";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-10-20";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccountId())
                {
                    context.Writer.WritePropertyName("AccountId");
                    context.Writer.Write(publicRequest.AccountId);
                }

                if(publicRequest.IsSetActionId())
                {
                    context.Writer.WritePropertyName("ActionId");
                    context.Writer.Write(publicRequest.ActionId);
                }

                if(publicRequest.IsSetActionThreshold())
                {
                    context.Writer.WritePropertyName("ActionThreshold");
                    context.Writer.WriteObjectStart();

                    var marshaller = ActionThresholdMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ActionThreshold, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetApprovalModel())
                {
                    context.Writer.WritePropertyName("ApprovalModel");
                    context.Writer.Write(publicRequest.ApprovalModel);
                }

                if(publicRequest.IsSetBudgetName())
                {
                    context.Writer.WritePropertyName("BudgetName");
                    context.Writer.Write(publicRequest.BudgetName);
                }

                if(publicRequest.IsSetDefinition())
                {
                    context.Writer.WritePropertyName("Definition");
                    context.Writer.WriteObjectStart();

                    var marshaller = DefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Definition, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExecutionRoleArn())
                {
                    context.Writer.WritePropertyName("ExecutionRoleArn");
                    context.Writer.Write(publicRequest.ExecutionRoleArn);
                }

                if(publicRequest.IsSetNotificationType())
                {
                    context.Writer.WritePropertyName("NotificationType");
                    context.Writer.Write(publicRequest.NotificationType);
                }

                if(publicRequest.IsSetSubscribers())
                {
                    context.Writer.WritePropertyName("Subscribers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSubscribersListValue in publicRequest.Subscribers)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SubscriberMarshaller.Instance;
                        marshaller.Marshall(publicRequestSubscribersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateBudgetActionRequestMarshaller _instance = new UpdateBudgetActionRequestMarshaller();        

        internal static UpdateBudgetActionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateBudgetActionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}