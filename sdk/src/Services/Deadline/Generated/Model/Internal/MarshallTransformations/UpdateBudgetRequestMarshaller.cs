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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateBudget Request Marshaller
    /// </summary>       
    public class UpdateBudgetRequestMarshaller : IMarshaller<IRequest, UpdateBudgetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateBudgetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateBudgetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Deadline");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-10-12";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetBudgetId())
                throw new AmazonDeadlineException("Request object does not have required field BudgetId set");
            request.AddPathResource("{budgetId}", StringUtils.FromString(publicRequest.BudgetId));
            if (!publicRequest.IsSetFarmId())
                throw new AmazonDeadlineException("Request object does not have required field FarmId set");
            request.AddPathResource("{farmId}", StringUtils.FromString(publicRequest.FarmId));
            request.ResourcePath = "/2023-10-12/farms/{farmId}/budgets/{budgetId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActionsToAdd())
                {
                    context.Writer.WritePropertyName("actionsToAdd");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestActionsToAddListValue in publicRequest.ActionsToAdd)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = BudgetActionToAddMarshaller.Instance;
                        marshaller.Marshall(publicRequestActionsToAddListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetActionsToRemove())
                {
                    context.Writer.WritePropertyName("actionsToRemove");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestActionsToRemoveListValue in publicRequest.ActionsToRemove)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = BudgetActionToRemoveMarshaller.Instance;
                        marshaller.Marshall(publicRequestActionsToRemoveListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetApproximateDollarLimit())
                {
                    context.Writer.WritePropertyName("approximateDollarLimit");
                    if(StringUtils.IsSpecialFloatValue(publicRequest.ApproximateDollarLimit))
                    {
                        context.Writer.Write(StringUtils.FromSpecialFloatValue(publicRequest.ApproximateDollarLimit));
                    }
                    else
                    {
                        context.Writer.Write(publicRequest.ApproximateDollarLimit);
                    }
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDisplayName())
                {
                    context.Writer.WritePropertyName("displayName");
                    context.Writer.Write(publicRequest.DisplayName);
                }

                if(publicRequest.IsSetSchedule())
                {
                    context.Writer.WritePropertyName("schedule");
                    context.Writer.WriteObjectStart();

                    var marshaller = BudgetScheduleMarshaller.Instance;
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

        
            if (publicRequest.IsSetClientToken()) 
            {
                request.Headers["X-Amz-Client-Token"] = publicRequest.ClientToken;
            }
            
            request.HostPrefix = $"management.";

            return request;
        }
        private static UpdateBudgetRequestMarshaller _instance = new UpdateBudgetRequestMarshaller();        

        internal static UpdateBudgetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateBudgetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}