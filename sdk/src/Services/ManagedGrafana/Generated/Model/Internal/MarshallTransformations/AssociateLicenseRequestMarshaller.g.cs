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

using Amazon.ManagedGrafana.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ManagedGrafana.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssociateLicense Request Marshaller
    /// </summary>
    public partial class AssociateLicenseRequestMarshaller : IMarshaller<IRequest, AssociateLicenseRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssociateLicenseRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AssociateLicenseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ManagedGrafana");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-18";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetGrafanaToken())
            {
                request.Headers["Grafana-Token"] = publicRequest.GrafanaToken;
            }

            if (!publicRequest.IsSetLicenseType())
            {
                throw new AmazonManagedGrafanaException("Request object does not have required field LicenseType set");
            }
            request.AddPathResource("{licenseType}", StringUtils.FromString(publicRequest.LicenseType));

            if (!publicRequest.IsSetWorkspaceId())
            {
                throw new AmazonManagedGrafanaException("Request object does not have required field WorkspaceId set");
            }
            request.AddPathResource("{workspaceId}", StringUtils.FromString(publicRequest.WorkspaceId));

            request.ResourcePath = "/workspaces/{workspaceId}/licenses/{licenseType}";

            return request;
        }

        private static readonly AssociateLicenseRequestMarshaller _instance = new();

        internal static AssociateLicenseRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AssociateLicenseRequestMarshaller Instance => _instance;
    }
}
