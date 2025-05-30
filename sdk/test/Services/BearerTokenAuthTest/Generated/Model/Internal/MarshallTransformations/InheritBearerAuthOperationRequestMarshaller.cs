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
 * Do not modify this file. This file is generated from the bearer-token-auth-test-2022-03-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BearerTokenAuthTest.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.BearerTokenAuthTest.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InheritBearerAuthOperation Request Marshaller
    /// </summary>       
    public class InheritBearerAuthOperationRequestMarshaller : IMarshaller<IRequest, InheritBearerAuthOperationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InheritBearerAuthOperationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InheritBearerAuthOperationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BearerTokenAuthTest");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-03-21";
            request.HttpMethod = "GET";

            request.ResourcePath = "/inherit-bearer-auth";
        
            if (publicRequest.IsSetTestId()) 
            {
                request.Headers["x-amz-test-id"] = publicRequest.TestId;
            }

            return request;
        }
        private static InheritBearerAuthOperationRequestMarshaller _instance = new InheritBearerAuthOperationRequestMarshaller();        

        internal static InheritBearerAuthOperationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InheritBearerAuthOperationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}