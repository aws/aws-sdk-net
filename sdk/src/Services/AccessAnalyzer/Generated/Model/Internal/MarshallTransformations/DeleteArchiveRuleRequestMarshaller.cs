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
using ThirdParty.Json.LitJson;

namespace Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteArchiveRule Request Marshaller
    /// </summary>       
    public class DeleteArchiveRuleRequestMarshaller : IMarshaller<IRequest, DeleteArchiveRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteArchiveRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteArchiveRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AccessAnalyzer");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-01";            
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetAnalyzerName())
                throw new AmazonAccessAnalyzerException("Request object does not have required field AnalyzerName set");
            request.AddPathResource("{analyzerName}", StringUtils.FromString(publicRequest.AnalyzerName));
            if (!publicRequest.IsSetRuleName())
                throw new AmazonAccessAnalyzerException("Request object does not have required field RuleName set");
            request.AddPathResource("{ruleName}", StringUtils.FromString(publicRequest.RuleName));
            
            if (publicRequest.IsSetClientToken())
                request.Parameters.Add("clientToken", StringUtils.FromString(publicRequest.ClientToken));
            request.ResourcePath = "/analyzer/{analyzerName}/archive-rule/{ruleName}";
            request.MarshallerVersion = 2;
            request.UseQueryString = true;

            return request;
        }
        private static DeleteArchiveRuleRequestMarshaller _instance = new DeleteArchiveRuleRequestMarshaller();        

        internal static DeleteArchiveRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteArchiveRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}