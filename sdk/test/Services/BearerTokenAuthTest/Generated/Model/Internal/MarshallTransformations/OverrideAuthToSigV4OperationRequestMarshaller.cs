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
#pragma warning disable CS0612,CS0618
namespace Amazon.BearerTokenAuthTest.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OverrideAuthToSigV4Operation Request Marshaller
    /// </summary>       
    public class OverrideAuthToSigV4OperationRequestMarshaller : IMarshaller<IRequest, OverrideAuthToSigV4OperationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((OverrideAuthToSigV4OperationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(OverrideAuthToSigV4OperationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BearerTokenAuthTest");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-03-21";
            request.HttpMethod = "GET";

            request.ResourcePath = "/overide-auth-to-sigv4";
        
            if (publicRequest.IsSetTestId()) 
            {
                request.Headers["x-amz-test-id"] = publicRequest.TestId;
            }

            return request;
        }
        private static OverrideAuthToSigV4OperationRequestMarshaller _instance = new OverrideAuthToSigV4OperationRequestMarshaller();        

        internal static OverrideAuthToSigV4OperationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OverrideAuthToSigV4OperationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}