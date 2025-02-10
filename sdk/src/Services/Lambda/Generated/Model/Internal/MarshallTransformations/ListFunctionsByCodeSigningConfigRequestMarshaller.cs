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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
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
namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListFunctionsByCodeSigningConfig Request Marshaller
    /// </summary>       
    public class ListFunctionsByCodeSigningConfigRequestMarshaller : IMarshaller<IRequest, ListFunctionsByCodeSigningConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListFunctionsByCodeSigningConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListFunctionsByCodeSigningConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetCodeSigningConfigArn())
                throw new AmazonLambdaException("Request object does not have required field CodeSigningConfigArn set");
            request.AddPathResource("{CodeSigningConfigArn}", StringUtils.FromString(publicRequest.CodeSigningConfigArn));
            
            if (publicRequest.IsSetMarker())
                request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
            
            if (publicRequest.IsSetMaxItems())
                request.Parameters.Add("MaxItems", StringUtils.FromInt(publicRequest.MaxItems));
            request.ResourcePath = "/2020-04-22/code-signing-configs/{CodeSigningConfigArn}/functions";
            request.UseQueryString = true;

            return request;
        }
        private static ListFunctionsByCodeSigningConfigRequestMarshaller _instance = new ListFunctionsByCodeSigningConfigRequestMarshaller();        

        internal static ListFunctionsByCodeSigningConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListFunctionsByCodeSigningConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}