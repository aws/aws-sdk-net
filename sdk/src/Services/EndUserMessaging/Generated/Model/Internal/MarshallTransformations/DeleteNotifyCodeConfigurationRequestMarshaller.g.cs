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

using Amazon.EndUserMessaging.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.EndUserMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteNotifyCodeConfiguration Request Marshaller
    /// </summary>
    public partial class DeleteNotifyCodeConfigurationRequestMarshaller : IMarshaller<IRequest, DeleteNotifyCodeConfigurationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteNotifyCodeConfigurationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteNotifyCodeConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EndUserMessaging");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-09-21";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetNotifyCodeConfigurationId())
            {
                throw new AmazonEndUserMessagingException("Request object does not have required field NotifyCodeConfigurationId set");
            }
            request.AddPathResource("{notifyCodeConfigurationId+}", StringUtils.FromString(publicRequest.NotifyCodeConfigurationId.TrimStart('/')));

            request.ResourcePath = "/v1/notify-code-configurations/{notifyCodeConfigurationId+}";

            return request;
        }

        private static readonly DeleteNotifyCodeConfigurationRequestMarshaller _instance = new();

        internal static DeleteNotifyCodeConfigurationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteNotifyCodeConfigurationRequestMarshaller Instance => _instance;
    }
}
