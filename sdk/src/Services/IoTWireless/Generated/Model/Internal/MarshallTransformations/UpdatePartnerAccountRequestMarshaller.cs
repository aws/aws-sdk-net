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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTWireless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePartnerAccount Request Marshaller
    /// </summary>       
    public class UpdatePartnerAccountRequestMarshaller : IMarshaller<IRequest, UpdatePartnerAccountRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePartnerAccountRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdatePartnerAccountRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTWireless");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-22";            
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetPartnerAccountId())
                throw new AmazonIoTWirelessException("Request object does not have required field PartnerAccountId set");
            request.AddPathResource("{PartnerAccountId}", StringUtils.FromString(publicRequest.PartnerAccountId));
            
            if (publicRequest.IsSetPartnerType())
                request.Parameters.Add("partnerType", StringUtils.FromString(publicRequest.PartnerType));
            request.ResourcePath = "/partner-accounts/{PartnerAccountId}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetSidewalk())
                {
                    context.Writer.WritePropertyName("Sidewalk");
                    context.Writer.WriteObjectStart();

                    var marshaller = SidewalkUpdateAccountMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Sidewalk, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static UpdatePartnerAccountRequestMarshaller _instance = new UpdatePartnerAccountRequestMarshaller();        

        internal static UpdatePartnerAccountRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdatePartnerAccountRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}