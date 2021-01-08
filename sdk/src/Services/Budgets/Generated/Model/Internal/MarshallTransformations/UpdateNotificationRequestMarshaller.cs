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
    /// UpdateNotification Request Marshaller
    /// </summary>       
    public class UpdateNotificationRequestMarshaller : IMarshaller<IRequest, UpdateNotificationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateNotificationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateNotificationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Budgets");
            string target = "AWSBudgetServiceGateway.UpdateNotification";
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

                if(publicRequest.IsSetBudgetName())
                {
                    context.Writer.WritePropertyName("BudgetName");
                    context.Writer.Write(publicRequest.BudgetName);
                }

                if(publicRequest.IsSetNewNotification())
                {
                    context.Writer.WritePropertyName("NewNotification");
                    context.Writer.WriteObjectStart();

                    var marshaller = NotificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NewNotification, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOldNotification())
                {
                    context.Writer.WritePropertyName("OldNotification");
                    context.Writer.WriteObjectStart();

                    var marshaller = NotificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OldNotification, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateNotificationRequestMarshaller _instance = new UpdateNotificationRequestMarshaller();        

        internal static UpdateNotificationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateNotificationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}