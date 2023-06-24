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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PI.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PI.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetDimensionKeyDetails Request Marshaller
    /// </summary>       
    public class GetDimensionKeyDetailsRequestMarshaller : IMarshaller<IRequest, GetDimensionKeyDetailsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDimensionKeyDetailsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetDimensionKeyDetailsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PI");
            string target = "PerformanceInsightsv20180227.GetDimensionKeyDetails";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-02-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetGroup())
                {
                    context.Writer.WritePropertyName("Group");
                    context.Writer.Write(publicRequest.Group);
                }

                if(publicRequest.IsSetGroupIdentifier())
                {
                    context.Writer.WritePropertyName("GroupIdentifier");
                    context.Writer.Write(publicRequest.GroupIdentifier);
                }

                if(publicRequest.IsSetIdentifier())
                {
                    context.Writer.WritePropertyName("Identifier");
                    context.Writer.Write(publicRequest.Identifier);
                }

                if(publicRequest.IsSetRequestedDimensions())
                {
                    context.Writer.WritePropertyName("RequestedDimensions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRequestedDimensionsListValue in publicRequest.RequestedDimensions)
                    {
                            context.Writer.Write(publicRequestRequestedDimensionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetServiceType())
                {
                    context.Writer.WritePropertyName("ServiceType");
                    context.Writer.Write(publicRequest.ServiceType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetDimensionKeyDetailsRequestMarshaller _instance = new GetDimensionKeyDetailsRequestMarshaller();        

        internal static GetDimensionKeyDetailsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDimensionKeyDetailsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}