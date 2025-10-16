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

#pragma warning disable CS0612,CS0618
namespace Amazon.BillingConductor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCustomLineItem Request Marshaller
    /// </summary>       
    public class CreateCustomLineItemRequestMarshaller : IMarshaller<IRequest, CreateCustomLineItemRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCustomLineItemRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCustomLineItemRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BillingConductor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/create-custom-line-item";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccountId())
                {
                    context.Writer.WritePropertyName("AccountId");
                    context.Writer.Write(publicRequest.AccountId);
                }

                if(publicRequest.IsSetBillingGroupArn())
                {
                    context.Writer.WritePropertyName("BillingGroupArn");
                    context.Writer.Write(publicRequest.BillingGroupArn);
                }

                if(publicRequest.IsSetBillingPeriodRange())
                {
                    context.Writer.WritePropertyName("BillingPeriodRange");
                    context.Writer.WriteObjectStart();

                    var marshaller = CustomLineItemBillingPeriodRangeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.BillingPeriodRange, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetChargeDetails())
                {
                    context.Writer.WritePropertyName("ChargeDetails");
                    context.Writer.WriteObjectStart();

                    var marshaller = CustomLineItemChargeDetailsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ChargeDetails, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetComputationRule())
                {
                    context.Writer.WritePropertyName("ComputationRule");
                    context.Writer.Write(publicRequest.ComputationRule);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetPresentationDetails())
                {
                    context.Writer.WritePropertyName("PresentationDetails");
                    context.Writer.WriteObjectStart();

                    var marshaller = PresentationObjectMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PresentationDetails, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if (publicRequest.IsSetClientToken()) 
            {
                request.Headers["X-Amzn-Client-Token"] = publicRequest.ClientToken;
            }

            return request;
        }
        private static CreateCustomLineItemRequestMarshaller _instance = new CreateCustomLineItemRequestMarshaller();        

        internal static CreateCustomLineItemRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCustomLineItemRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}