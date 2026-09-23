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

using Amazon.ChimeSDKIdentity.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ChimeSDKIdentity.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetAppInstanceRetentionSettings Request Marshaller
    /// </summary>
    public partial class GetAppInstanceRetentionSettingsRequestMarshaller : IMarshaller<IRequest, GetAppInstanceRetentionSettingsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetAppInstanceRetentionSettingsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetAppInstanceRetentionSettingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKIdentity");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-04-20";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetAppInstanceArn())
            {
                throw new AmazonChimeSDKIdentityException("Request object does not have required field AppInstanceArn set");
            }
            request.AddPathResource("{AppInstanceArn}", StringUtils.FromString(publicRequest.AppInstanceArn));

            request.ResourcePath = "/app-instances/{AppInstanceArn}/retention-settings";

            return request;
        }

        private static readonly GetAppInstanceRetentionSettingsRequestMarshaller _instance = new();

        internal static GetAppInstanceRetentionSettingsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetAppInstanceRetentionSettingsRequestMarshaller Instance => _instance;
    }
}
