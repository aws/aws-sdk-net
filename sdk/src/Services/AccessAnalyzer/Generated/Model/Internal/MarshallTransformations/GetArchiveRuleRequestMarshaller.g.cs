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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.AccessAnalyzer.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetArchiveRule Request Marshaller
    /// </summary>
    public partial class GetArchiveRuleRequestMarshaller : IMarshaller<IRequest, GetArchiveRuleRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetArchiveRuleRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetArchiveRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AccessAnalyzer");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-01";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetAnalyzerName())
            {
                throw new AmazonAccessAnalyzerException("Request object does not have required field AnalyzerName set");
            }
            request.AddPathResource("{analyzerName}", StringUtils.FromString(publicRequest.AnalyzerName));

            if (!publicRequest.IsSetRuleName())
            {
                throw new AmazonAccessAnalyzerException("Request object does not have required field RuleName set");
            }
            request.AddPathResource("{ruleName}", StringUtils.FromString(publicRequest.RuleName));

            request.ResourcePath = "/analyzer/{analyzerName}/archive-rule/{ruleName}";

            return request;
        }

        private static readonly GetArchiveRuleRequestMarshaller _instance = new();

        internal static GetArchiveRuleRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetArchiveRuleRequestMarshaller Instance => _instance;
    }
}
