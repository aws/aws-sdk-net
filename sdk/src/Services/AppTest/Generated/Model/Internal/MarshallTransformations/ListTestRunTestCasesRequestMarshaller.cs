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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppTest.Model;
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
namespace Amazon.AppTest.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListTestRunTestCases Request Marshaller
    /// </summary>       
    public class ListTestRunTestCasesRequestMarshaller : IMarshaller<IRequest, ListTestRunTestCasesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListTestRunTestCasesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListTestRunTestCasesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppTest");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-12-06";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetTestRunId())
                throw new AmazonAppTestException("Request object does not have required field TestRunId set");
            request.AddPathResource("{testRunId}", StringUtils.FromString(publicRequest.TestRunId));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/testruns/{testRunId}/testcases";
            request.UseQueryString = true;

            return request;
        }
        private static ListTestRunTestCasesRequestMarshaller _instance = new ListTestRunTestCasesRequestMarshaller();        

        internal static ListTestRunTestCasesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListTestRunTestCasesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}