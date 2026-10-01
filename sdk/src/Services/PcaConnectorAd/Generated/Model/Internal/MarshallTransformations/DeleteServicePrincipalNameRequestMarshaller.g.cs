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

using Amazon.PcaConnectorAd.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteServicePrincipalName Request Marshaller
    /// </summary>
    public partial class DeleteServicePrincipalNameRequestMarshaller : IMarshaller<IRequest, DeleteServicePrincipalNameRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteServicePrincipalNameRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteServicePrincipalNameRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PcaConnectorAd");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetConnectorArn())
            {
                throw new AmazonPcaConnectorAdException("Request object does not have required field ConnectorArn set");
            }
            request.AddPathResource("{ConnectorArn}", StringUtils.FromString(publicRequest.ConnectorArn));

            if (!publicRequest.IsSetDirectoryRegistrationArn())
            {
                throw new AmazonPcaConnectorAdException("Request object does not have required field DirectoryRegistrationArn set");
            }
            request.AddPathResource("{DirectoryRegistrationArn}", StringUtils.FromString(publicRequest.DirectoryRegistrationArn));

            request.ResourcePath = "/directoryRegistrations/{DirectoryRegistrationArn}/servicePrincipalNames/{ConnectorArn}";

            return request;
        }

        private static readonly DeleteServicePrincipalNameRequestMarshaller _instance = new();

        internal static DeleteServicePrincipalNameRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteServicePrincipalNameRequestMarshaller Instance => _instance;
    }
}
