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
 * Do not modify this file. This file is generated from the backupstorage-2018-04-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BackupStorage.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BackupStorage.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListObjects Request Marshaller
    /// </summary>       
    public class ListObjectsRequestMarshaller : IMarshaller<IRequest, ListObjectsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListObjectsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListObjectsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BackupStorage");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-10";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetStorageJobId())
                throw new AmazonBackupStorageException("Request object does not have required field StorageJobId set");
            request.AddPathResource("{jobId}", StringUtils.FromString(publicRequest.StorageJobId));
            
            if (publicRequest.IsSetCreatedAfter())
                request.Parameters.Add("created-after", StringUtils.FromDateTimeToISO8601(publicRequest.CreatedAfter));
            
            if (publicRequest.IsSetCreatedBefore())
                request.Parameters.Add("created-before", StringUtils.FromDateTimeToISO8601(publicRequest.CreatedBefore));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("max-results", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("next-token", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetStartingObjectName())
                request.Parameters.Add("starting-object-name", StringUtils.FromString(publicRequest.StartingObjectName));
            
            if (publicRequest.IsSetStartingObjectPrefix())
                request.Parameters.Add("starting-object-prefix", StringUtils.FromString(publicRequest.StartingObjectPrefix));
            request.ResourcePath = "/restore-jobs/{jobId}/objects/list";
            request.UseQueryString = true;

            return request;
        }
        private static ListObjectsRequestMarshaller _instance = new ListObjectsRequestMarshaller();        

        internal static ListObjectsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListObjectsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618