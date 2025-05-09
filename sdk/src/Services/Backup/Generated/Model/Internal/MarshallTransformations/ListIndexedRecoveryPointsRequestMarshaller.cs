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
    /// ListIndexedRecoveryPoints Request Marshaller
    /// </summary>       
    public class ListIndexedRecoveryPointsRequestMarshaller : IMarshaller<IRequest, ListIndexedRecoveryPointsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListIndexedRecoveryPointsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListIndexedRecoveryPointsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetCreatedAfter())
                request.Parameters.Add("createdAfter", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.CreatedAfter));
            
            if (publicRequest.IsSetCreatedBefore())
                request.Parameters.Add("createdBefore", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.CreatedBefore));
            
            if (publicRequest.IsSetIndexStatus())
                request.Parameters.Add("indexStatus", StringUtils.FromString(publicRequest.IndexStatus));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetResourceType())
                request.Parameters.Add("resourceType", StringUtils.FromString(publicRequest.ResourceType));
            
            if (publicRequest.IsSetSourceResourceArn())
                request.Parameters.Add("sourceResourceArn", StringUtils.FromString(publicRequest.SourceResourceArn));
            request.ResourcePath = "/indexes/recovery-point/";
            request.UseQueryString = true;

            return request;
        }
        private static ListIndexedRecoveryPointsRequestMarshaller _instance = new ListIndexedRecoveryPointsRequestMarshaller();        

        internal static ListIndexedRecoveryPointsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListIndexedRecoveryPointsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}