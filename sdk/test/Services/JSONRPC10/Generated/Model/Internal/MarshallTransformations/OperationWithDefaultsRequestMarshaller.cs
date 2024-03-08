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
 * Do not modify this file. This file is generated from the json-rpc-10-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.JSONRPC10.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.JSONRPC10.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OperationWithDefaults Request Marshaller
    /// </summary>       
    public class OperationWithDefaultsRequestMarshaller : IMarshaller<IRequest, OperationWithDefaultsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((OperationWithDefaultsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(OperationWithDefaultsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.JSONRPC10");
            string target = "JsonRpc10.OperationWithDefaults";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-14";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientOptionalDefaults())
                {
                    context.Writer.WritePropertyName("clientOptionalDefaults");
                    context.Writer.WriteObjectStart();

                    var marshaller = ClientOptionalDefaultsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ClientOptionalDefaults, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDefaults())
                {
                    context.Writer.WritePropertyName("defaults");
                    context.Writer.WriteObjectStart();

                    var marshaller = DefaultsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Defaults, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOtherTopLevelDefault())
                {
                    context.Writer.WritePropertyName("otherTopLevelDefault");
                    context.Writer.Write(publicRequest.OtherTopLevelDefault);
                }

                if(publicRequest.IsSetTopLevelDefault())
                {
                    context.Writer.WritePropertyName("topLevelDefault");
                    context.Writer.Write(publicRequest.TopLevelDefault);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static OperationWithDefaultsRequestMarshaller _instance = new OperationWithDefaultsRequestMarshaller();        

        internal static OperationWithDefaultsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OperationWithDefaultsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}