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

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListDistributions Request Marshaller
    /// </summary>       
    public class ListDistributionsRequestMarshaller : IMarshaller<IRequest, ListDistributionsRequest> 
    {
        public IRequest Marshall(ListDistributionsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "GET";
            var uriResourcePath = "/2014-05-31/distribution";

            var queryStringBuilder = new StringBuilder(uriResourcePath);
            if(uriResourcePath.Contains("?"))
                queryStringBuilder.Append("&"); // URI contains static query params
            else
                queryStringBuilder.Append("?"); // URI does not contain any query params
            
            if (publicRequest.IsSetMarker())
                queryStringBuilder.AppendFormat("{0}={1}&", "Marker", StringUtils.FromString(publicRequest.Marker));
            
            if (publicRequest.IsSetMaxItems())
                queryStringBuilder.AppendFormat("{0}={1}&", "MaxItems", StringUtils.FromString(publicRequest.MaxItems));
            uriResourcePath = queryStringBuilder.ToString();
            // Remove the last character if it is ';' or '?' or '&'
            uriResourcePath = uriResourcePath.TrimEnd(';', '?', '&');
            uriResourcePath = AddQueryParameters(request,uriResourcePath);
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
            return uriResourcePath;
        }
        
    }    
}