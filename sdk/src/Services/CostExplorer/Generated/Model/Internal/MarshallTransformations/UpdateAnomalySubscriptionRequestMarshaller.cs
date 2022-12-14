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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAnomalySubscription Request Marshaller
    /// </summary>       
    public class UpdateAnomalySubscriptionRequestMarshaller : IMarshaller<IRequest, UpdateAnomalySubscriptionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAnomalySubscriptionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAnomalySubscriptionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CostExplorer");
            string target = "AWSInsightsIndexService.UpdateAnomalySubscription";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-25";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetFrequency())
                {
                    context.Writer.WritePropertyName("Frequency");
                    context.Writer.Write(publicRequest.Frequency);
                }

                if(publicRequest.IsSetMonitorArnList())
                {
                    context.Writer.WritePropertyName("MonitorArnList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMonitorArnListListValue in publicRequest.MonitorArnList)
                    {
                            context.Writer.Write(publicRequestMonitorArnListListValue);
                    }
                    context.Writer.WriteArrayEnd();
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

                if(publicRequest.IsSetSubscriptionArn())
                {
                    context.Writer.WritePropertyName("SubscriptionArn");
                    context.Writer.Write(publicRequest.SubscriptionArn);
                }

                if(publicRequest.IsSetSubscriptionName())
                {
                    context.Writer.WritePropertyName("SubscriptionName");
                    context.Writer.Write(publicRequest.SubscriptionName);
                }

                if(publicRequest.IsSetThreshold())
                {
                    context.Writer.WritePropertyName("Threshold");
                    context.Writer.Write(publicRequest.Threshold);
                }

                if(publicRequest.IsSetThresholdExpression())
                {
                    context.Writer.WritePropertyName("ThresholdExpression");
                    context.Writer.WriteObjectStart();

                    var marshaller = ExpressionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ThresholdExpression, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAnomalySubscriptionRequestMarshaller _instance = new UpdateAnomalySubscriptionRequestMarshaller();        

        internal static UpdateAnomalySubscriptionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAnomalySubscriptionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}