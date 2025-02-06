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
 * Do not modify this file. This file is generated from the trustedadvisor-2022-09-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TrustedAdvisor.Model;
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
namespace Amazon.TrustedAdvisor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListChecks Request Marshaller
    /// </summary>       
    public class ListChecksRequestMarshaller : IMarshaller<IRequest, ListChecksRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListChecksRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListChecksRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TrustedAdvisor");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-09-15";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetAwsService())
                request.Parameters.Add("awsService", StringUtils.FromString(publicRequest.AwsService));
            
            if (publicRequest.IsSetLanguage())
                request.Parameters.Add("language", StringUtils.FromString(publicRequest.Language));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetPillar())
                request.Parameters.Add("pillar", StringUtils.FromString(publicRequest.Pillar));
            
            if (publicRequest.IsSetSource())
                request.Parameters.Add("source", StringUtils.FromString(publicRequest.Source));
            request.ResourcePath = "/v1/checks";
            request.UseQueryString = true;

            return request;
        }
        private static ListChecksRequestMarshaller _instance = new ListChecksRequestMarshaller();        

        internal static ListChecksRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListChecksRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}