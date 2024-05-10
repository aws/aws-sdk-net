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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AbortMultipartReadSetUpload Request Marshaller
    /// </summary>       
    public class AbortMultipartReadSetUploadRequestMarshaller : IMarshaller<IRequest, AbortMultipartReadSetUploadRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AbortMultipartReadSetUploadRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AbortMultipartReadSetUploadRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Omics");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-11-28";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetSequenceStoreId())
                throw new AmazonOmicsException("Request object does not have required field SequenceStoreId set");
            request.AddPathResource("{sequenceStoreId}", StringUtils.FromString(publicRequest.SequenceStoreId));
            if (!publicRequest.IsSetUploadId())
                throw new AmazonOmicsException("Request object does not have required field UploadId set");
            request.AddPathResource("{uploadId}", StringUtils.FromString(publicRequest.UploadId));
            request.ResourcePath = "/sequencestore/{sequenceStoreId}/upload/{uploadId}/abort";
            
            request.HostPrefix = $"control-storage-";

            return request;
        }
        private static AbortMultipartReadSetUploadRequestMarshaller _instance = new AbortMultipartReadSetUploadRequestMarshaller();        

        internal static AbortMultipartReadSetUploadRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AbortMultipartReadSetUploadRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}