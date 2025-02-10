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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetGeneratedPolicy Request Marshaller
    /// </summary>       
    public class GetGeneratedPolicyRequestMarshaller : IMarshaller<IRequest, GetGeneratedPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetGeneratedPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetGeneratedPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AccessAnalyzer");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-01";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetJobId())
                throw new AmazonAccessAnalyzerException("Request object does not have required field JobId set");
            request.AddPathResource("{jobId}", StringUtils.FromString(publicRequest.JobId));
            
            if (publicRequest.IsSetIncludeResourcePlaceholders())
                request.Parameters.Add("includeResourcePlaceholders", StringUtils.FromBool(publicRequest.IncludeResourcePlaceholders));
            
            if (publicRequest.IsSetIncludeServiceLevelTemplate())
                request.Parameters.Add("includeServiceLevelTemplate", StringUtils.FromBool(publicRequest.IncludeServiceLevelTemplate));
            request.ResourcePath = "/policy/generation/{jobId}";
            request.UseQueryString = true;

            return request;
        }
        private static GetGeneratedPolicyRequestMarshaller _instance = new GetGeneratedPolicyRequestMarshaller();        

        internal static GetGeneratedPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetGeneratedPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}