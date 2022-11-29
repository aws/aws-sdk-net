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
using ThirdParty.Json.LitJson;

namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeAddonVersions Request Marshaller
    /// </summary>       
    public class DescribeAddonVersionsRequestMarshaller : IMarshaller<IRequest, DescribeAddonVersionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeAddonVersionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeAddonVersionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EKS");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-01";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetAddonName())
                request.Parameters.Add("addonName", StringUtils.FromString(publicRequest.AddonName));
            
            if (publicRequest.IsSetKubernetesVersion())
                request.Parameters.Add("kubernetesVersion", StringUtils.FromString(publicRequest.KubernetesVersion));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetOwners())
                request.ParameterCollection.Add("owners", publicRequest.Owners);
            
            if (publicRequest.IsSetPublishers())
                request.ParameterCollection.Add("publishers", publicRequest.Publishers);
            
            if (publicRequest.IsSetTypes())
                request.ParameterCollection.Add("types", publicRequest.Types);
            request.ResourcePath = "/addons/supported-versions";
            request.UseQueryString = true;

            return request;
        }
        private static DescribeAddonVersionsRequestMarshaller _instance = new DescribeAddonVersionsRequestMarshaller();        

        internal static DescribeAddonVersionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAddonVersionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}