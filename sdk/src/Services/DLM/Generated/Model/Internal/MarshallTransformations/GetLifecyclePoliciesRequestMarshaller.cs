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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DLM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DLM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetLifecyclePolicies Request Marshaller
    /// </summary>       
    public class GetLifecyclePoliciesRequestMarshaller : IMarshaller<IRequest, GetLifecyclePoliciesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetLifecyclePoliciesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetLifecyclePoliciesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DLM");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-01-12";            
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetPolicyIds())
                request.ParameterCollection.Add("policyIds", publicRequest.PolicyIds);
            
            if (publicRequest.IsSetResourceTypes())
                request.ParameterCollection.Add("resourceTypes", publicRequest.ResourceTypes);
            
            if (publicRequest.IsSetState())
                request.Parameters.Add("state", StringUtils.FromString(publicRequest.State));
            
            if (publicRequest.IsSetTagsToAdd())
                request.ParameterCollection.Add("tagsToAdd", publicRequest.TagsToAdd);
            
            if (publicRequest.IsSetTargetTags())
                request.ParameterCollection.Add("targetTags", publicRequest.TargetTags);
            request.ResourcePath = "/policies";
            request.MarshallerVersion = 2;
            request.UseQueryString = true;

            return request;
        }
        private static GetLifecyclePoliciesRequestMarshaller _instance = new GetLifecyclePoliciesRequestMarshaller();        

        internal static GetLifecyclePoliciesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetLifecyclePoliciesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}