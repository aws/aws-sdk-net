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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSubscriptionRequest Request Marshaller
    /// </summary>       
    public class CreateSubscriptionRequestRequestMarshaller : IMarshaller<IRequest, CreateSubscriptionRequestRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSubscriptionRequestRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSubscriptionRequestRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field DomainIdentifier set");
            request.AddPathResource("{domainIdentifier}", StringUtils.FromString(publicRequest.DomainIdentifier));
            request.ResourcePath = "/v2/domains/{domainIdentifier}/subscription-requests";
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
                if(publicRequest.IsSetRequestReason())
                {
                    context.Writer.WritePropertyName("requestReason");
                    context.Writer.Write(publicRequest.RequestReason);
                }

                if(publicRequest.IsSetSubscribedListings())
                {
                    context.Writer.WritePropertyName("subscribedListings");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSubscribedListingsListValue in publicRequest.SubscribedListings)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SubscribedListingInputMarshaller.Instance;
                        marshaller.Marshall(publicRequestSubscribedListingsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSubscribedPrincipals())
                {
                    context.Writer.WritePropertyName("subscribedPrincipals");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSubscribedPrincipalsListValue in publicRequest.SubscribedPrincipals)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SubscribedPrincipalInputMarshaller.Instance;
                        marshaller.Marshall(publicRequestSubscribedPrincipalsListValue, context);

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
        private static CreateSubscriptionRequestRequestMarshaller _instance = new CreateSubscriptionRequestRequestMarshaller();        

        internal static CreateSubscriptionRequestRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSubscriptionRequestRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}