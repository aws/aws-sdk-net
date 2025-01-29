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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WellArchitected.Model;
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
namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListShareInvitations Request Marshaller
    /// </summary>       
    public class ListShareInvitationsRequestMarshaller : IMarshaller<IRequest, ListShareInvitationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListShareInvitationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListShareInvitationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WellArchitected");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-31";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetLensNamePrefix())
                request.Parameters.Add("LensNamePrefix", StringUtils.FromString(publicRequest.LensNamePrefix));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetProfileNamePrefix())
                request.Parameters.Add("ProfileNamePrefix", StringUtils.FromString(publicRequest.ProfileNamePrefix));
            
            if (publicRequest.IsSetShareResourceType())
                request.Parameters.Add("ShareResourceType", StringUtils.FromString(publicRequest.ShareResourceType));
            
            if (publicRequest.IsSetTemplateNamePrefix())
                request.Parameters.Add("TemplateNamePrefix", StringUtils.FromString(publicRequest.TemplateNamePrefix));
            
            if (publicRequest.IsSetWorkloadNamePrefix())
                request.Parameters.Add("WorkloadNamePrefix", StringUtils.FromString(publicRequest.WorkloadNamePrefix));
            request.ResourcePath = "/shareInvitations";
            request.UseQueryString = true;

            return request;
        }
        private static ListShareInvitationsRequestMarshaller _instance = new ListShareInvitationsRequestMarshaller();        

        internal static ListShareInvitationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListShareInvitationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}