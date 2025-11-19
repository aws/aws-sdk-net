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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListScanJobs Request Marshaller
    /// </summary>       
    public class ListScanJobsRequestMarshaller : IMarshaller<IRequest, ListScanJobsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListScanJobsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListScanJobsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetByAccountId())
                request.Parameters.Add("ByAccountId", StringUtils.FromString(publicRequest.ByAccountId));
            
            if (publicRequest.IsSetByBackupVaultName())
                request.Parameters.Add("ByBackupVaultName", StringUtils.FromString(publicRequest.ByBackupVaultName));
            
            if (publicRequest.IsSetByCompleteAfter())
                request.Parameters.Add("ByCompleteAfter", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ByCompleteAfter));
            
            if (publicRequest.IsSetByCompleteBefore())
                request.Parameters.Add("ByCompleteBefore", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ByCompleteBefore));
            
            if (publicRequest.IsSetByMalwareScanner())
                request.Parameters.Add("ByMalwareScanner", StringUtils.FromString(publicRequest.ByMalwareScanner));
            
            if (publicRequest.IsSetByRecoveryPointArn())
                request.Parameters.Add("ByRecoveryPointArn", StringUtils.FromString(publicRequest.ByRecoveryPointArn));
            
            if (publicRequest.IsSetByResourceArn())
                request.Parameters.Add("ByResourceArn", StringUtils.FromString(publicRequest.ByResourceArn));
            
            if (publicRequest.IsSetByResourceType())
                request.Parameters.Add("ByResourceType", StringUtils.FromString(publicRequest.ByResourceType));
            
            if (publicRequest.IsSetByScanResultStatus())
                request.Parameters.Add("ByScanResultStatus", StringUtils.FromString(publicRequest.ByScanResultStatus));
            
            if (publicRequest.IsSetByState())
                request.Parameters.Add("ByState", StringUtils.FromString(publicRequest.ByState));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/scan/jobs";
            request.UseQueryString = true;

            return request;
        }
        private static ListScanJobsRequestMarshaller _instance = new ListScanJobsRequestMarshaller();        

        internal static ListScanJobsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListScanJobsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}