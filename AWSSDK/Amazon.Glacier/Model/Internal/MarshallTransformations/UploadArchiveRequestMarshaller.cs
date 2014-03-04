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
    /// Upload Archive Request Marshaller
    /// </summary>       
    internal class UploadArchiveRequestMarshaller : IMarshaller<IRequest, UploadArchiveRequest> 
    {
        

        public IRequest Marshall(UploadArchiveRequest uploadArchiveRequest) 
        {

            IRequest request = new DefaultRequest(uploadArchiveRequest, "AmazonGlacier");
            string target = "Glacier.UploadArchive";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";

            request.HttpMethod = "POST";
            if(uploadArchiveRequest.IsSetArchiveDescription())
                request.Headers.Add("x-amz-archive-description", StringUtils.FromString(uploadArchiveRequest.ArchiveDescription));

            
            if(uploadArchiveRequest.IsSetChecksum())
                request.Headers.Add("x-amz-sha256-tree-hash", StringUtils.FromString(uploadArchiveRequest.Checksum));

            
              
            string uriResourcePath = "/{accountId}/vaults/{vaultName}/archives"; 
            if(uploadArchiveRequest.IsSetVaultName())
                uriResourcePath = uriResourcePath.Replace("{vaultName}", StringUtils.FromString(uploadArchiveRequest.VaultName) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{vaultName}", "" ); 
            if(uploadArchiveRequest.IsSetAccountId())
                uriResourcePath = uriResourcePath.Replace("{accountId}", StringUtils.FromString(uploadArchiveRequest.AccountId) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{accountId}", "" ); 
            
            if (uriResourcePath.Contains("?")) 
            {
                string queryString = uriResourcePath.Substring(uriResourcePath.IndexOf("?") + 1);
                uriResourcePath    = uriResourcePath.Substring(0, uriResourcePath.IndexOf("?"));
        
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
            
        
            request.ContentStream = uploadArchiveRequest.Body;
            request.Headers["Content-Type"] = "binary/octet-stream";
        

            return request;
        }
    }
}
