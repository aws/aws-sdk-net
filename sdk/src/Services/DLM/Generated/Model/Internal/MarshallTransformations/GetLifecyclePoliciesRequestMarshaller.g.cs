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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.DLM.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.DLM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetLifecyclePolicies Request Marshaller
    /// </summary>
    public partial class GetLifecyclePoliciesRequestMarshaller : IMarshaller<IRequest, GetLifecyclePoliciesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetLifecyclePoliciesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetLifecyclePoliciesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DLM");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-01-12";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetDefaultPolicyType())
            {
                request.Parameters.Add("defaultPolicyType", StringUtils.FromString(publicRequest.DefaultPolicyType));
            }

            if (publicRequest.IsSetPolicyIds())
            {
                request.ParameterCollection.Add("policyIds", publicRequest.PolicyIds);
            }

            if (publicRequest.IsSetResourceTypes())
            {
                request.ParameterCollection.Add("resourceTypes", publicRequest.ResourceTypes);
            }

            if (publicRequest.IsSetState())
            {
                request.Parameters.Add("state", StringUtils.FromString(publicRequest.State));
            }

            if (publicRequest.IsSetTagsToAdd())
            {
                request.ParameterCollection.Add("tagsToAdd", publicRequest.TagsToAdd);
            }

            if (publicRequest.IsSetTargetTags())
            {
                request.ParameterCollection.Add("targetTags", publicRequest.TargetTags);
            }

            request.ResourcePath = "/policies";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetLifecyclePoliciesRequestMarshaller _instance = new();

        internal static GetLifecyclePoliciesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetLifecyclePoliciesRequestMarshaller Instance => _instance;
    }
}
