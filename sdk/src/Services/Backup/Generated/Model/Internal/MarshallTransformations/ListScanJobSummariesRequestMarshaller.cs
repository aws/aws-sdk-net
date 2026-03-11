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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Backup.Model;
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
namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListScanJobSummaries Request Marshaller
    /// </summary>       
    public class ListScanJobSummariesRequestMarshaller : IMarshaller<IRequest, ListScanJobSummariesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListScanJobSummariesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListScanJobSummariesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetAccountId())
                request.Parameters.Add("AccountId", StringUtils.FromString(publicRequest.AccountId));
            
            if (publicRequest.IsSetAggregationPeriod())
                request.Parameters.Add("AggregationPeriod", StringUtils.FromString(publicRequest.AggregationPeriod));
            
            if (publicRequest.IsSetMalwareScanner())
                request.Parameters.Add("MalwareScanner", StringUtils.FromString(publicRequest.MalwareScanner));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetResourceType())
                request.Parameters.Add("ResourceType", StringUtils.FromString(publicRequest.ResourceType));
            
            if (publicRequest.IsSetScanResultStatus())
                request.Parameters.Add("ScanResultStatus", StringUtils.FromString(publicRequest.ScanResultStatus));
            
            if (publicRequest.IsSetState())
                request.Parameters.Add("State", StringUtils.FromString(publicRequest.State));
            request.ResourcePath = "/audit/scan-job-summaries";
            request.UseQueryString = true;

            return request;
        }
        private static ListScanJobSummariesRequestMarshaller _instance = new ListScanJobSummariesRequestMarshaller();        

        internal static ListScanJobSummariesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListScanJobSummariesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}