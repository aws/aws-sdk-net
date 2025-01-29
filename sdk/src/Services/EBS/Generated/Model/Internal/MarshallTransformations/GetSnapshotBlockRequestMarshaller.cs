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
    /// GetSnapshotBlock Request Marshaller
    /// </summary>       
    public class GetSnapshotBlockRequestMarshaller : IMarshaller<IRequest, GetSnapshotBlockRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSnapshotBlockRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetSnapshotBlockRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EBS");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-02";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetBlockIndex())
                throw new AmazonEBSException("Request object does not have required field BlockIndex set");
            request.AddPathResource("{blockIndex}", StringUtils.FromInt(publicRequest.BlockIndex));
            if (!publicRequest.IsSetSnapshotId())
                throw new AmazonEBSException("Request object does not have required field SnapshotId set");
            request.AddPathResource("{snapshotId}", StringUtils.FromString(publicRequest.SnapshotId));
            
            if (publicRequest.IsSetBlockToken())
                request.Parameters.Add("blockToken", StringUtils.FromString(publicRequest.BlockToken));
            request.ResourcePath = "/snapshots/{snapshotId}/blocks/{blockIndex}";
            request.UseQueryString = true;

            return request;
        }
        private static GetSnapshotBlockRequestMarshaller _instance = new GetSnapshotBlockRequestMarshaller();        

        internal static GetSnapshotBlockRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetSnapshotBlockRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}