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
    /// List Jobs Request Marshaller
    /// </summary>       
    internal class ListJobsRequestMarshaller : IMarshaller<IRequest, ListJobsRequest> 
    {
        

        public IRequest Marshall(ListJobsRequest listJobsRequest) 
        {

            IRequest request = new DefaultRequest(listJobsRequest, "AmazonGlacier");
            string target = "Glacier.ListJobs";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";

            request.HttpMethod = "GET";
              
            string uriResourcePath = "/{accountId}/vaults/{vaultName}/jobs?marker={marker};limit={limit};completed={completed};statuscode={statuscode}"; 
            if(listJobsRequest.IsSetAccountId())
                uriResourcePath = uriResourcePath.Replace("{accountId}", StringUtils.FromString(listJobsRequest.AccountId) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{accountId}", "" ); 
            if(listJobsRequest.IsSetVaultName())
                uriResourcePath = uriResourcePath.Replace("{vaultName}", StringUtils.FromString(listJobsRequest.VaultName) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{vaultName}", "" ); 
            if(listJobsRequest.IsSetLimit())
                uriResourcePath = uriResourcePath.Replace("{limit}", StringUtils.FromInt(listJobsRequest.Limit) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{limit}", "" ); 
            if(listJobsRequest.IsSetMarker())
                uriResourcePath = uriResourcePath.Replace("{marker}", StringUtils.FromString(listJobsRequest.Marker) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{marker}", "" ); 
            if(listJobsRequest.IsSetStatuscode())
                uriResourcePath = uriResourcePath.Replace("{statuscode}", StringUtils.FromString(listJobsRequest.Statuscode) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{statuscode}", "" ); 
            if(listJobsRequest.IsSetCompleted())
                uriResourcePath = uriResourcePath.Replace("{completed}", StringUtils.FromBool(listJobsRequest.Completed) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{completed}", "" ); 
            
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
            
        
            request.UseQueryString = true;
        

            return request;
        }
    }
}
