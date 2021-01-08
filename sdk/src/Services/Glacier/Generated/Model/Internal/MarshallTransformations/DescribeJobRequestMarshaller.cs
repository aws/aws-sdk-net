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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glacier.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeJob Request Marshaller
    /// </summary>       
    public class DescribeJobRequestMarshaller : IMarshaller<IRequest, DescribeJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glacier");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-06-01";            
            request.HttpMethod = "GET";

            request.AddPathResource("{accountId}", publicRequest.IsSetAccountId() ? StringUtils.FromString(publicRequest.AccountId) : string.Empty);
            if (!publicRequest.IsSetJobId())
                throw new AmazonGlacierException("Request object does not have required field JobId set");
            request.AddPathResource("{jobId}", StringUtils.FromString(publicRequest.JobId));
            if (!publicRequest.IsSetVaultName())
                throw new AmazonGlacierException("Request object does not have required field VaultName set");
            request.AddPathResource("{vaultName}", StringUtils.FromString(publicRequest.VaultName));
            request.ResourcePath = "/{accountId}/vaults/{vaultName}/jobs/{jobId}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static DescribeJobRequestMarshaller _instance = new DescribeJobRequestMarshaller();        

        internal static DescribeJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}