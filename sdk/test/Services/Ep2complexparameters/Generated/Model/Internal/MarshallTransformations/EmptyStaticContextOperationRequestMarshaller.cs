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
 * Do not modify this file. This file is generated from the ep2-complex-parameters-2022-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Ep2complexparameters.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Ep2complexparameters.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EmptyStaticContextOperation Request Marshaller
    /// </summary>       
    public class EmptyStaticContextOperationRequestMarshaller : IMarshaller<IRequest, EmptyStaticContextOperationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((EmptyStaticContextOperationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(EmptyStaticContextOperationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Ep2complexparameters");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-08-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            var content = "{}";
            request.Content = System.Text.Encoding.UTF8.GetBytes(content);

            return request;
        }
        private static EmptyStaticContextOperationRequestMarshaller _instance = new EmptyStaticContextOperationRequestMarshaller();        

        internal static EmptyStaticContextOperationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EmptyStaticContextOperationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}