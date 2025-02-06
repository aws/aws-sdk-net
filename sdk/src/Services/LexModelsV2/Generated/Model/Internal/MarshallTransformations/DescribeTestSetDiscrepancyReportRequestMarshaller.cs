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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
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
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeTestSetDiscrepancyReport Request Marshaller
    /// </summary>       
    public class DescribeTestSetDiscrepancyReportRequestMarshaller : IMarshaller<IRequest, DescribeTestSetDiscrepancyReportRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeTestSetDiscrepancyReportRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeTestSetDiscrepancyReportRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexModelsV2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-07";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetTestSetDiscrepancyReportId())
                throw new AmazonLexModelsV2Exception("Request object does not have required field TestSetDiscrepancyReportId set");
            request.AddPathResource("{testSetDiscrepancyReportId}", StringUtils.FromString(publicRequest.TestSetDiscrepancyReportId));
            request.ResourcePath = "/testsetdiscrepancy/{testSetDiscrepancyReportId}";

            return request;
        }
        private static DescribeTestSetDiscrepancyReportRequestMarshaller _instance = new DescribeTestSetDiscrepancyReportRequestMarshaller();        

        internal static DescribeTestSetDiscrepancyReportRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeTestSetDiscrepancyReportRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}