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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BillingConductor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.BillingConductor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchDisassociateResourcesFromCustomLineItem Request Marshaller
    /// </summary>       
    public class BatchDisassociateResourcesFromCustomLineItemRequestMarshaller : IMarshaller<IRequest, BatchDisassociateResourcesFromCustomLineItemRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchDisassociateResourcesFromCustomLineItemRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchDisassociateResourcesFromCustomLineItemRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BillingConductor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-30";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/batch-disassociate-resources-from-custom-line-item";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBillingPeriodRange())
                {
                    context.Writer.WritePropertyName("BillingPeriodRange");
                    context.Writer.WriteObjectStart();

                    var marshaller = CustomLineItemBillingPeriodRangeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.BillingPeriodRange, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetResourceArns())
                {
                    context.Writer.WritePropertyName("ResourceArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestResourceArnsListValue in publicRequest.ResourceArns)
                    {
                            context.Writer.Write(publicRequestResourceArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTargetArn())
                {
                    context.Writer.WritePropertyName("TargetArn");
                    context.Writer.Write(publicRequest.TargetArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static BatchDisassociateResourcesFromCustomLineItemRequestMarshaller _instance = new BatchDisassociateResourcesFromCustomLineItemRequestMarshaller();        

        internal static BatchDisassociateResourcesFromCustomLineItemRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchDisassociateResourcesFromCustomLineItemRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}