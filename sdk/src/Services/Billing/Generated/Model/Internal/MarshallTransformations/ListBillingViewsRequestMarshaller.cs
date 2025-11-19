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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Billing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Billing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListBillingViews Request Marshaller
    /// </summary>       
    public class ListBillingViewsRequestMarshaller : IMarshaller<IRequest, ListBillingViewsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListBillingViewsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListBillingViewsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Billing");
            string target = "AWSBilling.ListBillingViews";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-09-07";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActiveTimeRange())
                {
                    context.Writer.WritePropertyName("activeTimeRange");
                    context.Writer.WriteObjectStart();

                    var marshaller = ActiveTimeRangeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ActiveTimeRange, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetArns())
                {
                    context.Writer.WritePropertyName("arns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestArnsListValue in publicRequest.Arns)
                    {
                            context.Writer.Write(publicRequestArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetBillingViewTypes())
                {
                    context.Writer.WritePropertyName("billingViewTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestBillingViewTypesListValue in publicRequest.BillingViewTypes)
                    {
                            context.Writer.Write(publicRequestBillingViewTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("maxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNames())
                {
                    context.Writer.WritePropertyName("names");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNamesListValue in publicRequest.Names)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = StringSearchMarshaller.Instance;
                        marshaller.Marshall(publicRequestNamesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetOwnerAccountId())
                {
                    context.Writer.WritePropertyName("ownerAccountId");
                    context.Writer.Write(publicRequest.OwnerAccountId);
                }

                if(publicRequest.IsSetSourceAccountId())
                {
                    context.Writer.WritePropertyName("sourceAccountId");
                    context.Writer.Write(publicRequest.SourceAccountId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListBillingViewsRequestMarshaller _instance = new ListBillingViewsRequestMarshaller();        

        internal static ListBillingViewsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListBillingViewsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}