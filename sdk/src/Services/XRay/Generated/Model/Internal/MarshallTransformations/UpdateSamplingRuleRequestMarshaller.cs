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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.XRay.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.XRay.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSamplingRule Request Marshaller
    /// </summary>       
    public class UpdateSamplingRuleRequestMarshaller : IMarshaller<IRequest, UpdateSamplingRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSamplingRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSamplingRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.XRay");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-04-12";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/UpdateSamplingRule";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetSamplingRuleUpdate())
                {
                    context.Writer.WritePropertyName("SamplingRuleUpdate");
                    context.Writer.WriteObjectStart();

                    var marshaller = SamplingRuleUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SamplingRuleUpdate, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateSamplingRuleRequestMarshaller _instance = new UpdateSamplingRuleRequestMarshaller();        

        internal static UpdateSamplingRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSamplingRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}