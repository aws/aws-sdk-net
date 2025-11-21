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
    /// PutSnapshotBlock Request Marshaller
    /// </summary>       
    public class PutSnapshotBlockRequestMarshaller : IMarshaller<IRequest, PutSnapshotBlockRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutSnapshotBlockRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutSnapshotBlockRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EBS");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-02";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetBlockIndex())
                throw new AmazonEBSException("Request object does not have required field BlockIndex set");
            request.AddPathResource("{blockIndex}", StringUtils.FromInt(publicRequest.BlockIndex));
            if (!publicRequest.IsSetSnapshotId())
                throw new AmazonEBSException("Request object does not have required field SnapshotId set");
            request.AddPathResource("{snapshotId}", StringUtils.FromString(publicRequest.SnapshotId));
            request.ResourcePath = "/snapshots/{snapshotId}/blocks/{blockIndex}";
            request.ContentStream =  publicRequest.BlockData ?? new MemoryStream();
            if (request.ContentStream.CanSeek)
            {
                request.ContentStream.Seek(0, SeekOrigin.Begin);
                request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] =  
                    request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                request.Headers[Amazon.Util.HeaderKeys.TransferEncodingHeader] = "chunked";
            }
            request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "application/octet-stream";
        
            if (publicRequest.IsSetChecksum()) 
            {
                request.Headers["x-amz-Checksum"] = publicRequest.Checksum;
            }
        
            if (publicRequest.IsSetChecksumAlgorithm()) 
            {
                request.Headers["x-amz-Checksum-Algorithm"] = publicRequest.ChecksumAlgorithm;
            }
        
            if (publicRequest.IsSetDataLength()) 
            {
                request.Headers["x-amz-Data-Length"] = StringUtils.FromInt(publicRequest.DataLength);
            }
        
            if (publicRequest.IsSetProgress()) 
            {
                request.Headers["x-amz-Progress"] = StringUtils.FromInt(publicRequest.Progress);
            }
            request.DisablePayloadSigning = true;

            return request;
        }
        private static PutSnapshotBlockRequestMarshaller _instance = new PutSnapshotBlockRequestMarshaller();        

        internal static PutSnapshotBlockRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutSnapshotBlockRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}