/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glacier.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Upload Multipart Part Request Marshaller
    /// </summary>       
    internal class UploadMultipartPartRequestMarshaller : IMarshaller<IRequest, UploadMultipartPartRequest> 
    {
        

        public IRequest Marshall(UploadMultipartPartRequest uploadMultipartPartRequest) 
        {

            IRequest request = new DefaultRequest(uploadMultipartPartRequest, "AmazonGlacier");
            string target = "Glacier.UploadMultipartPart";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.HttpMethod = "PUT";
            if(uploadMultipartPartRequest.IsSetChecksum())
                request.Headers.Add("x-amz-sha256-tree-hash", StringUtils.FromString(uploadMultipartPartRequest.Checksum));

            
            if(uploadMultipartPartRequest.IsSetRange())
                request.Headers.Add("Content-Range", StringUtils.FromString(uploadMultipartPartRequest.Range));

            
              
            string uriResourcePath = "/{accountId}/vaults/{vaultName}/multipart-uploads/{uploadId}"; 
            if(uploadMultipartPartRequest.IsSetAccountId())
                uriResourcePath = uriResourcePath.Replace("{accountId}", StringUtils.FromString(uploadMultipartPartRequest.AccountId) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{accountId}", "" ); 
            if(uploadMultipartPartRequest.IsSetVaultName())
                uriResourcePath = uriResourcePath.Replace("{vaultName}", StringUtils.FromString(uploadMultipartPartRequest.VaultName) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{vaultName}", "" ); 
            if(uploadMultipartPartRequest.IsSetUploadId())
                uriResourcePath = uriResourcePath.Replace("{uploadId}", StringUtils.FromString(uploadMultipartPartRequest.UploadId) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{uploadId}", "" ); 
            
            if (uriResourcePath.Contains("?")) 
            {
                int queryPosition = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
                string queryString = uriResourcePath.Substring(queryPosition + 1);
                uriResourcePath    = uriResourcePath.Substring(0, queryPosition);
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
        
            request.ContentStream = uploadMultipartPartRequest.Body;
            request.Headers["Content-Type"] = "binary/octet-stream";
        

            return request;
        }
    }
}
