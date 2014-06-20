/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Globalization;
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
    /// ListJobsByStatus Request Marshaller
    /// </summary>       
    public class ListJobsByStatusRequestMarshaller : IMarshaller<IRequest, ListJobsByStatusRequest> 
    {
        public IRequest Marshall(ListJobsByStatusRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticTranscoder");
            string target = ".ListJobsByStatus";
            request.Headers["X-Amz-Target"] = target;

            request.HttpMethod = "GET";

            string uriResourcePath = "/2012-09-25/jobsByStatus/{Status}";
            uriResourcePath = uriResourcePath.Replace("{Status}", publicRequest.Status ?? string.Empty);
            var queryStringBuilder = new StringBuilder(uriResourcePath);
            queryStringBuilder.Append("?");
            
            if (publicRequest.IsSetAscending())
                queryStringBuilder.AppendFormat("{0}={1};", "Ascending", StringUtils.FromString(publicRequest.Ascending));
            
            if (publicRequest.IsSetPageToken())
                queryStringBuilder.AppendFormat("{0}={1};", "PageToken", StringUtils.FromString(publicRequest.PageToken));
            // Remove the last character ';'
            queryStringBuilder.Remove(queryStringBuilder.Length - 1, 1);
            uriResourcePath = queryStringBuilder.ToString();
            AddQueryParameters(request,uriResourcePath);    
            request.ResourcePath = uriResourcePath;
            request.UseQueryString = true;
            return request;
        }

        private static void AddQueryParameters(IRequest request, string uriResourcePath)
        {            
            int queryIndex = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
            string queryString = uriResourcePath.Substring(queryIndex + 1);

            uriResourcePath = uriResourcePath.Substring(0, queryIndex);

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

    }
}