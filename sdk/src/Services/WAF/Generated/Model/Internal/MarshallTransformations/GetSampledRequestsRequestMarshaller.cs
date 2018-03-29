/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAF.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WAF.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetSampledRequests Request Marshaller
    /// </summary>       
    public class GetSampledRequestsRequestMarshaller : IMarshaller<IRequest, GetSampledRequestsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSampledRequestsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetSampledRequestsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WAF");
            string target = "AWSWAF_20150824.GetSampledRequests";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetMaxItems())
                {
                    context.Writer.WritePropertyName("MaxItems");
                    context.Writer.Write(publicRequest.MaxItems);
                }

                if(publicRequest.IsSetRuleId())
                {
                    context.Writer.WritePropertyName("RuleId");
                    context.Writer.Write(publicRequest.RuleId);
                }

                if(publicRequest.IsSetTimeWindow())
                {
                    context.Writer.WritePropertyName("TimeWindow");
                    context.Writer.WriteObjectStart();

                    var marshaller = TimeWindowMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TimeWindow, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetWebAclId())
                {
                    context.Writer.WritePropertyName("WebAclId");
                    context.Writer.Write(publicRequest.WebAclId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetSampledRequestsRequestMarshaller _instance = new GetSampledRequestsRequestMarshaller();        

        internal static GetSampledRequestsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetSampledRequestsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}