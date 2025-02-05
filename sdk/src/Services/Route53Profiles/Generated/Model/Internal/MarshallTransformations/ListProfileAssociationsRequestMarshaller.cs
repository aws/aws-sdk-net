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
 * Do not modify this file. This file is generated from the route53profiles-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53Profiles.Model;
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
namespace Amazon.Route53Profiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListProfileAssociations Request Marshaller
    /// </summary>       
    public class ListProfileAssociationsRequestMarshaller : IMarshaller<IRequest, ListProfileAssociationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListProfileAssociationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListProfileAssociationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53Profiles");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetProfileId())
                request.Parameters.Add("profileId", StringUtils.FromString(publicRequest.ProfileId));
            
            if (publicRequest.IsSetResourceId())
                request.Parameters.Add("resourceId", StringUtils.FromString(publicRequest.ResourceId));
            request.ResourcePath = "/profileassociations";
            request.UseQueryString = true;

            return request;
        }
        private static ListProfileAssociationsRequestMarshaller _instance = new ListProfileAssociationsRequestMarshaller();        

        internal static ListProfileAssociationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListProfileAssociationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}