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

using Amazon.Imagebuilder.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetImageRecipePolicy Request Marshaller
    /// </summary>
    public partial class GetImageRecipePolicyRequestMarshaller : IMarshaller<IRequest, GetImageRecipePolicyRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetImageRecipePolicyRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetImageRecipePolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Imagebuilder");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.ImageRecipeArn))
            {
                throw new AmazonImagebuilderException("Request object does not have required field ImageRecipeArn set");
            }

            if (publicRequest.IsSetImageRecipeArn())
            {
                request.Parameters.Add("imageRecipeArn", StringUtils.FromString(publicRequest.ImageRecipeArn));
            }

            request.ResourcePath = "/GetImageRecipePolicy";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetImageRecipePolicyRequestMarshaller _instance = new();

        internal static GetImageRecipePolicyRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetImageRecipePolicyRequestMarshaller Instance => _instance;
    }
}
