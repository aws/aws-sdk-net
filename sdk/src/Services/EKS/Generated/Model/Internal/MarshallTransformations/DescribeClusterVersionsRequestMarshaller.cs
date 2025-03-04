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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EKS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeClusterVersions Request Marshaller
    /// </summary>       
    public class DescribeClusterVersionsRequestMarshaller : IMarshaller<IRequest, DescribeClusterVersionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeClusterVersionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeClusterVersionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EKS");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-01";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetClusterType())
                request.Parameters.Add("clusterType", StringUtils.FromString(publicRequest.ClusterType));
            
            if (publicRequest.IsSetClusterVersions())
                request.ParameterCollection.Add("clusterVersions", publicRequest.ClusterVersions);
            
            if (publicRequest.IsSetDefaultOnly())
                request.Parameters.Add("defaultOnly", StringUtils.FromBool(publicRequest.DefaultOnly));
            
            if (publicRequest.IsSetIncludeAll())
                request.Parameters.Add("includeAll", StringUtils.FromBool(publicRequest.IncludeAll));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetStatus())
                request.Parameters.Add("status", StringUtils.FromString(publicRequest.Status));
            
            if (publicRequest.IsSetVersionStatus())
                request.Parameters.Add("versionStatus", StringUtils.FromString(publicRequest.VersionStatus));
            request.ResourcePath = "/cluster-versions";
            request.UseQueryString = true;

            return request;
        }
        private static DescribeClusterVersionsRequestMarshaller _instance = new DescribeClusterVersionsRequestMarshaller();        

        internal static DescribeClusterVersionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeClusterVersionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}