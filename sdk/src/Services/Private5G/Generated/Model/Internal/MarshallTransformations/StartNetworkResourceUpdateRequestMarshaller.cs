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
    /// StartNetworkResourceUpdate Request Marshaller
    /// </summary>       
    public class StartNetworkResourceUpdateRequestMarshaller : IMarshaller<IRequest, StartNetworkResourceUpdateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartNetworkResourceUpdateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartNetworkResourceUpdateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Private5G");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-12-03";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/network-resources/update";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetNetworkResourceArn())
                {
                    context.Writer.WritePropertyName("networkResourceArn");
                    context.Writer.Write(publicRequest.NetworkResourceArn);
                }

                if(publicRequest.IsSetReturnReason())
                {
                    context.Writer.WritePropertyName("returnReason");
                    context.Writer.Write(publicRequest.ReturnReason);
                }

                if(publicRequest.IsSetShippingAddress())
                {
                    context.Writer.WritePropertyName("shippingAddress");
                    context.Writer.WriteObjectStart();

                    var marshaller = AddressMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ShippingAddress, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetUpdateType())
                {
                    context.Writer.WritePropertyName("updateType");
                    context.Writer.Write(publicRequest.UpdateType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartNetworkResourceUpdateRequestMarshaller _instance = new StartNetworkResourceUpdateRequestMarshaller();        

        internal static StartNetworkResourceUpdateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartNetworkResourceUpdateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}