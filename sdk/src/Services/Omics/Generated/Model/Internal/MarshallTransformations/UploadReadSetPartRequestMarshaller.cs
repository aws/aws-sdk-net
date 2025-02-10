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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Omics.Model;
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
namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UploadReadSetPart Request Marshaller
    /// </summary>       
    public class UploadReadSetPartRequestMarshaller : IMarshaller<IRequest, UploadReadSetPartRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UploadReadSetPartRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UploadReadSetPartRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Omics");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-11-28";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetSequenceStoreId())
                throw new AmazonOmicsException("Request object does not have required field SequenceStoreId set");
            request.AddPathResource("{sequenceStoreId}", StringUtils.FromString(publicRequest.SequenceStoreId));
            if (!publicRequest.IsSetUploadId())
                throw new AmazonOmicsException("Request object does not have required field UploadId set");
            request.AddPathResource("{uploadId}", StringUtils.FromString(publicRequest.UploadId));
            
            if (publicRequest.IsSetPartNumber())
                request.Parameters.Add("partNumber", StringUtils.FromInt(publicRequest.PartNumber));
            
            if (publicRequest.IsSetPartSource())
                request.Parameters.Add("partSource", StringUtils.FromString(publicRequest.PartSource));
            request.ResourcePath = "/sequencestore/{sequenceStoreId}/upload/{uploadId}/part";
            request.ContentStream =  publicRequest.Payload ?? new MemoryStream();
            if (!request.ContentStream.CanSeek)
            {
                throw new System.InvalidOperationException("Cannot determine stream length for the payload when content-length is required.");
            }
            if(request.ContentStream.CanSeek)
            {
                request.ContentStream.Seek(0, SeekOrigin.Begin);
            }
            request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] =
                request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "application/octet-stream";
            request.DisablePayloadSigning = true;
            request.UseQueryString = true;
            
            request.HostPrefix = $"storage-";

            return request;
        }
        private static UploadReadSetPartRequestMarshaller _instance = new UploadReadSetPartRequestMarshaller();        

        internal static UploadReadSetPartRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UploadReadSetPartRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}