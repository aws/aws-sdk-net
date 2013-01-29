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

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// List Jobs By Status Request Marshaller
    /// </summary>       
    internal class ListJobsByStatusRequestMarshaller : IMarshaller<IRequest, ListJobsByStatusRequest> 
    {
        

        public IRequest Marshall(ListJobsByStatusRequest listJobsByStatusRequest) 
        {

            IRequest request = new DefaultRequest(listJobsByStatusRequest, "AmazonElasticTranscoder");
            string target = "EtsCustomerService.ListJobsByStatus";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";

            request.HttpMethod = "GET";
              
            string uriResourcePath = "2012-09-25/jobsByStatus/{Status}?Ascending={Ascending};PageToken={PageToken}"; 
            if(listJobsByStatusRequest.IsSetStatus())
                uriResourcePath = uriResourcePath.Replace("{Status}", StringUtils.FromString(listJobsByStatusRequest.Status) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{Status}", "" ); 
            if(listJobsByStatusRequest.IsSetAscending())
                uriResourcePath = uriResourcePath.Replace("{Ascending}", StringUtils.FromString(listJobsByStatusRequest.Ascending) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{Ascending}", "" ); 
            if(listJobsByStatusRequest.IsSetPageToken())
                uriResourcePath = uriResourcePath.Replace("{PageToken}", StringUtils.FromString(listJobsByStatusRequest.PageToken) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{PageToken}", "" ); 
            
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
