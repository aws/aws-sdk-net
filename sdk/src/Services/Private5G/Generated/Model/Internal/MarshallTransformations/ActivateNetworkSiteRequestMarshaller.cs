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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Private5G.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Private5G.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ActivateNetworkSite Request Marshaller
    /// </summary>       
    public class ActivateNetworkSiteRequestMarshaller : IMarshaller<IRequest, ActivateNetworkSiteRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ActivateNetworkSiteRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ActivateNetworkSiteRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Private5G");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-12-03";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/network-sites/activate";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                if(publicRequest.IsSetCommitmentConfiguration())
                {
                    context.Writer.WritePropertyName("commitmentConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = CommitmentConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CommitmentConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNetworkSiteArn())
                {
                    context.Writer.WritePropertyName("networkSiteArn");
                    context.Writer.Write(publicRequest.NetworkSiteArn);
                }

                if(publicRequest.IsSetShippingAddress())
                {
                    context.Writer.WritePropertyName("shippingAddress");
                    context.Writer.WriteObjectStart();

                    var marshaller = AddressMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ShippingAddress, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ActivateNetworkSiteRequestMarshaller _instance = new ActivateNetworkSiteRequestMarshaller();        

        internal static ActivateNetworkSiteRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ActivateNetworkSiteRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}