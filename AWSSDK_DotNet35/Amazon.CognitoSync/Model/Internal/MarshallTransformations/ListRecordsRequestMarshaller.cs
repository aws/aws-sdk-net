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

using Amazon.CognitoSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListRecords Request Marshaller
    /// </summary>       
    public class ListRecordsRequestMarshaller : IMarshaller<IRequest, ListRecordsRequest> 
    {
        public IRequest Marshall(ListRecordsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoSync");
            request.HttpMethod = "GET";

            string uriResourcePath = "/identitypools/{IdentityPoolId}/identities/{IdentityId}/datasets/{DatasetName}/records";
            uriResourcePath = uriResourcePath.Replace("{DatasetName}", publicRequest.IsSetDatasetName() ? StringUtils.FromString(publicRequest.DatasetName) : string.Empty);
            uriResourcePath = uriResourcePath.Replace("{IdentityId}", publicRequest.IsSetIdentityId() ? StringUtils.FromString(publicRequest.IdentityId) : string.Empty);
            uriResourcePath = uriResourcePath.Replace("{IdentityPoolId}", publicRequest.IsSetIdentityPoolId() ? StringUtils.FromString(publicRequest.IdentityPoolId) : string.Empty);
            var queryStringBuilder = new StringBuilder(uriResourcePath);
            if(uriResourcePath.Contains("?"))
                queryStringBuilder.Append("&"); // URI contains static query params
            else
                queryStringBuilder.Append("?"); // URI does not contain any query params
            
            if (publicRequest.IsSetLastSyncCount())
                queryStringBuilder.AppendFormat("{0}={1}&", "lastSyncCount", StringUtils.FromLong(publicRequest.LastSyncCount));
            
            if (publicRequest.IsSetMaxResults())
                queryStringBuilder.AppendFormat("{0}={1}&", "maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                queryStringBuilder.AppendFormat("{0}={1}&", "nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetSyncSessionToken())
                queryStringBuilder.AppendFormat("{0}={1}&", "syncSessionToken", StringUtils.FromString(publicRequest.SyncSessionToken));
            uriResourcePath = queryStringBuilder.ToString();
            // Remove the last character if it is ';' or '?' or '&'
            uriResourcePath = uriResourcePath.TrimEnd(';', '?', '&');
            uriResourcePath = AddQueryParameters(request, uriResourcePath);
            request.ResourcePath = uriResourcePath;
            request.UseQueryString = true;

            return request;
        }

        private static string AddQueryParameters(IRequest request, string uriResourcePath)
        {            
            int queryIndex = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);

            if (queryIndex < 0)
                return uriResourcePath;

            string queryString = uriResourcePath.Substring(queryIndex + 1);
            uriResourcePath = uriResourcePath.Substring(0, queryIndex);

            foreach (string s in queryString.Split('&', ';'))
            {
                string[] nameValuePair = s.Split(new char[] { '=' }, 2);
                if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0)
                {
                    request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                }
                else
                {
                    request.Parameters.Add(nameValuePair[0], null);
                }
            }            
            return uriResourcePath;
        }

    }
}