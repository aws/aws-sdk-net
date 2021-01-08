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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmailV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutDeliverabilityDashboardOption Request Marshaller
    /// </summary>       
    public class PutDeliverabilityDashboardOptionRequestMarshaller : IMarshaller<IRequest, PutDeliverabilityDashboardOptionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutDeliverabilityDashboardOptionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutDeliverabilityDashboardOptionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmailV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-27";            
            request.HttpMethod = "PUT";

            request.ResourcePath = "/v2/email/deliverability-dashboard";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDashboardEnabled())
                {
                    context.Writer.WritePropertyName("DashboardEnabled");
                    context.Writer.Write(publicRequest.DashboardEnabled);
                }

                if(publicRequest.IsSetSubscribedDomains())
                {
                    context.Writer.WritePropertyName("SubscribedDomains");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSubscribedDomainsListValue in publicRequest.SubscribedDomains)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DomainDeliverabilityTrackingOptionMarshaller.Instance;
                        marshaller.Marshall(publicRequestSubscribedDomainsListValue, context);

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
        private static PutDeliverabilityDashboardOptionRequestMarshaller _instance = new PutDeliverabilityDashboardOptionRequestMarshaller();        

        internal static PutDeliverabilityDashboardOptionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutDeliverabilityDashboardOptionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}