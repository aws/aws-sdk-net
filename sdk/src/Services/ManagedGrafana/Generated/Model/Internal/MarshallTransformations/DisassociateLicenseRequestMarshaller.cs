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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ManagedGrafana.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ManagedGrafana.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DisassociateLicense Request Marshaller
    /// </summary>       
    public class DisassociateLicenseRequestMarshaller : IMarshaller<IRequest, DisassociateLicenseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DisassociateLicenseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DisassociateLicenseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ManagedGrafana");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-18";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetLicenseType())
                throw new AmazonManagedGrafanaException("Request object does not have required field LicenseType set");
            request.AddPathResource("{licenseType}", StringUtils.FromString(publicRequest.LicenseType));
            if (!publicRequest.IsSetWorkspaceId())
                throw new AmazonManagedGrafanaException("Request object does not have required field WorkspaceId set");
            request.AddPathResource("{workspaceId}", StringUtils.FromString(publicRequest.WorkspaceId));
            request.ResourcePath = "/workspaces/{workspaceId}/licenses/{licenseType}";

            return request;
        }
        private static DisassociateLicenseRequestMarshaller _instance = new DisassociateLicenseRequestMarshaller();        

        internal static DisassociateLicenseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DisassociateLicenseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}