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
    /// ListJobs Request Marshaller
    /// </summary>       
    public class ListJobsRequestMarshaller : IMarshaller<IRequest, ListJobsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListJobsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListJobsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glacier");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-06-01";            
            request.HttpMethod = "GET";

            request.AddPathResource("{accountId}", publicRequest.IsSetAccountId() ? StringUtils.FromString(publicRequest.AccountId) : string.Empty);
            if (!publicRequest.IsSetVaultName())
                throw new AmazonGlacierException("Request object does not have required field VaultName set");
            request.AddPathResource("{vaultName}", StringUtils.FromString(publicRequest.VaultName));
            
            if (publicRequest.IsSetCompleted())
                request.Parameters.Add("completed", Amazon.Runtime.Internal.Util.StringUtils.FromBool(publicRequest.Completed));
            
            if (publicRequest.IsSetLimit())
                request.Parameters.Add("limit", Amazon.Runtime.Internal.Util.StringUtils.FromInt(publicRequest.Limit));
            
            if (publicRequest.IsSetMarker())
                request.Parameters.Add("marker", StringUtils.FromString(publicRequest.Marker));
            
            if (publicRequest.IsSetStatuscode())
                request.Parameters.Add("statuscode", StringUtils.FromString(publicRequest.Statuscode));
            request.ResourcePath = "/{accountId}/vaults/{vaultName}/jobs";
            request.MarshallerVersion = 2;
            request.UseQueryString = true;

            return request;
        }
        private static ListJobsRequestMarshaller _instance = new ListJobsRequestMarshaller();        

        internal static ListJobsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListJobsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}