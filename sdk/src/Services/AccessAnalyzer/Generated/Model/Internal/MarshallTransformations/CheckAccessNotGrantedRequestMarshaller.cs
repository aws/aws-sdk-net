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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AccessAnalyzer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CheckAccessNotGranted Request Marshaller
    /// </summary>       
    public class CheckAccessNotGrantedRequestMarshaller : IMarshaller<IRequest, CheckAccessNotGrantedRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CheckAccessNotGrantedRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CheckAccessNotGrantedRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AccessAnalyzer");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/policy/check-access-not-granted";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccess())
                {
                    context.Writer.WritePropertyName("access");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAccessListValue in publicRequest.Access)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AccessMarshaller.Instance;
                        marshaller.Marshall(publicRequestAccessListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPolicyDocument())
                {
                    context.Writer.WritePropertyName("policyDocument");
                    context.Writer.Write(publicRequest.PolicyDocument);
                }

                if(publicRequest.IsSetPolicyType())
                {
                    context.Writer.WritePropertyName("policyType");
                    context.Writer.Write(publicRequest.PolicyType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CheckAccessNotGrantedRequestMarshaller _instance = new CheckAccessNotGrantedRequestMarshaller();        

        internal static CheckAccessNotGrantedRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CheckAccessNotGrantedRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}