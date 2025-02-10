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
 * Do not modify this file. This file is generated from the ebs-2019-11-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EBS.Model;
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
namespace Amazon.EBS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListSnapshotBlocks Request Marshaller
    /// </summary>       
    public class ListSnapshotBlocksRequestMarshaller : IMarshaller<IRequest, ListSnapshotBlocksRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListSnapshotBlocksRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListSnapshotBlocksRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EBS");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-02";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetSnapshotId())
                throw new AmazonEBSException("Request object does not have required field SnapshotId set");
            request.AddPathResource("{snapshotId}", StringUtils.FromString(publicRequest.SnapshotId));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("pageToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetStartingBlockIndex())
                request.Parameters.Add("startingBlockIndex", StringUtils.FromInt(publicRequest.StartingBlockIndex));
            request.ResourcePath = "/snapshots/{snapshotId}/blocks";
            request.UseQueryString = true;

            return request;
        }
        private static ListSnapshotBlocksRequestMarshaller _instance = new ListSnapshotBlocksRequestMarshaller();        

        internal static ListSnapshotBlocksRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListSnapshotBlocksRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}