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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.VPCLattice.Model;
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
namespace Amazon.VPCLattice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListServiceNetworkResourceAssociations Request Marshaller
    /// </summary>       
    public class ListServiceNetworkResourceAssociationsRequestMarshaller : IMarshaller<IRequest, ListServiceNetworkResourceAssociationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListServiceNetworkResourceAssociationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListServiceNetworkResourceAssociationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.VPCLattice");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-11-30";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetIncludeChildren())
                request.Parameters.Add("includeChildren", StringUtils.FromBool(publicRequest.IncludeChildren));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetResourceConfigurationIdentifier())
                request.Parameters.Add("resourceConfigurationIdentifier", StringUtils.FromString(publicRequest.ResourceConfigurationIdentifier));
            
            if (publicRequest.IsSetServiceNetworkIdentifier())
                request.Parameters.Add("serviceNetworkIdentifier", StringUtils.FromString(publicRequest.ServiceNetworkIdentifier));
            request.ResourcePath = "/servicenetworkresourceassociations";
            request.UseQueryString = true;

            return request;
        }
        private static ListServiceNetworkResourceAssociationsRequestMarshaller _instance = new ListServiceNetworkResourceAssociationsRequestMarshaller();        

        internal static ListServiceNetworkResourceAssociationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListServiceNetworkResourceAssociationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}