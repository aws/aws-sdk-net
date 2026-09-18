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

using Amazon.Bedrock.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListFoundationModels Request Marshaller
    /// </summary>
    public partial class ListFoundationModelsRequestMarshaller : IMarshaller<IRequest, ListFoundationModelsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListFoundationModelsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListFoundationModelsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Bedrock");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-20";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetByCustomizationType())
            {
                request.Parameters.Add("byCustomizationType", StringUtils.FromString(publicRequest.ByCustomizationType));
            }

            if (publicRequest.IsSetByInferenceType())
            {
                request.Parameters.Add("byInferenceType", StringUtils.FromString(publicRequest.ByInferenceType));
            }

            if (publicRequest.IsSetByOutputModality())
            {
                request.Parameters.Add("byOutputModality", StringUtils.FromString(publicRequest.ByOutputModality));
            }

            if (publicRequest.IsSetByProvider())
            {
                request.Parameters.Add("byProvider", StringUtils.FromString(publicRequest.ByProvider));
            }

            request.ResourcePath = "/foundation-models";

            request.UseQueryString = true;

            return request;
        }

        private static readonly ListFoundationModelsRequestMarshaller _instance = new();

        internal static ListFoundationModelsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListFoundationModelsRequestMarshaller Instance => _instance;
    }
}
