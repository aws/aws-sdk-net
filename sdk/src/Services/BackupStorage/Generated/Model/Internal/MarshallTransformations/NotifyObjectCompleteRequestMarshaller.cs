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

namespace Amazon.BackupStorage.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NotifyObjectComplete Request Marshaller
    /// </summary>       
    public class NotifyObjectCompleteRequestMarshaller : IMarshaller<IRequest, NotifyObjectCompleteRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((NotifyObjectCompleteRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(NotifyObjectCompleteRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BackupStorage");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-10";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetBackupJobId())
                throw new AmazonBackupStorageException("Request object does not have required field BackupJobId set");
            request.AddPathResource("{jobId}", StringUtils.FromString(publicRequest.BackupJobId));
            if (!publicRequest.IsSetUploadId())
                throw new AmazonBackupStorageException("Request object does not have required field UploadId set");
            request.AddPathResource("{uploadId}", StringUtils.FromString(publicRequest.UploadId));
            
            if (publicRequest.IsSetMetadataBlobChecksum())
                request.Parameters.Add("metadata-checksum", StringUtils.FromString(publicRequest.MetadataBlobChecksum));
            
            if (publicRequest.IsSetMetadataBlobChecksumAlgorithm())
                request.Parameters.Add("metadata-checksum-algorithm", StringUtils.FromString(publicRequest.MetadataBlobChecksumAlgorithm));
            
            if (publicRequest.IsSetMetadataBlobLength())
                request.Parameters.Add("metadata-blob-length", StringUtils.FromLong(publicRequest.MetadataBlobLength));
            
            if (publicRequest.IsSetMetadataString())
                request.Parameters.Add("metadata-string", StringUtils.FromString(publicRequest.MetadataString));
            
            if (publicRequest.IsSetObjectChecksum())
                request.Parameters.Add("checksum", StringUtils.FromString(publicRequest.ObjectChecksum));
            
            if (publicRequest.IsSetObjectChecksumAlgorithm())
                request.Parameters.Add("checksum-algorithm", StringUtils.FromString(publicRequest.ObjectChecksumAlgorithm));
            request.ResourcePath = "/backup-jobs/{jobId}/object/{uploadId}/complete";
            request.ContentStream =  publicRequest.MetadataBlob ?? new MemoryStream();
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
            request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "binary/octet-stream"; 
            if (request.ContentStream != null && request.ContentStream.Length == 0)
            {
                request.Headers.Remove(Amazon.Util.HeaderKeys.ContentTypeHeader);
            }
            request.UseQueryString = true;

            return request;
        }
        private static NotifyObjectCompleteRequestMarshaller _instance = new NotifyObjectCompleteRequestMarshaller();        

        internal static NotifyObjectCompleteRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NotifyObjectCompleteRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}