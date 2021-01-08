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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticFileSystem.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticFileSystem.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeFileSystems Request Marshaller
    /// </summary>       
    public class DescribeFileSystemsRequestMarshaller : IMarshaller<IRequest, DescribeFileSystemsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeFileSystemsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeFileSystemsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticFileSystem");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-02-01";            
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetCreationToken())
                request.Parameters.Add("CreationToken", StringUtils.FromString(publicRequest.CreationToken));
            
            if (publicRequest.IsSetFileSystemId())
                request.Parameters.Add("FileSystemId", StringUtils.FromString(publicRequest.FileSystemId));
            
            if (publicRequest.IsSetMarker())
                request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
            
            if (publicRequest.IsSetMaxItems())
                request.Parameters.Add("MaxItems", StringUtils.FromInt(publicRequest.MaxItems));
            request.ResourcePath = "/2015-02-01/file-systems";
            request.MarshallerVersion = 2;
            request.UseQueryString = true;

            return request;
        }
        private static DescribeFileSystemsRequestMarshaller _instance = new DescribeFileSystemsRequestMarshaller();        

        internal static DescribeFileSystemsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeFileSystemsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}