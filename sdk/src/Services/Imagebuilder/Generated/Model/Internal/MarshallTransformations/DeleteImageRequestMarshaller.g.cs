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
    /// DeleteImage Request Marshaller
    /// </summary>
    public partial class DeleteImageRequestMarshaller : IMarshaller<IRequest, DeleteImageRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteImageRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Imagebuilder");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "DELETE";

            if (string.IsNullOrEmpty(publicRequest.ImageBuildVersionArn))
            {
                throw new AmazonImagebuilderException("Request object does not have required field ImageBuildVersionArn set");
            }

            if (publicRequest.IsSetImageBuildVersionArn())
            {
                request.Parameters.Add("imageBuildVersionArn", StringUtils.FromString(publicRequest.ImageBuildVersionArn));
            }

            request.ResourcePath = "/DeleteImage";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DeleteImageRequestMarshaller _instance = new();

        internal static DeleteImageRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteImageRequestMarshaller Instance => _instance;
    }
}
