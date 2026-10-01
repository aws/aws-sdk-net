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

using Amazon.IAMRolesAnywhere.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.IAMRolesAnywhere.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteAttributeMapping Request Marshaller
    /// </summary>
    public partial class DeleteAttributeMappingRequestMarshaller : IMarshaller<IRequest, DeleteAttributeMappingRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteAttributeMappingRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteAttributeMappingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IAMRolesAnywhere");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "DELETE";

            if (string.IsNullOrEmpty(publicRequest.CertificateField))
            {
                throw new AmazonIAMRolesAnywhereException("Request object does not have required field CertificateField set");
            }

            if (publicRequest.IsSetCertificateField())
            {
                request.Parameters.Add("certificateField", StringUtils.FromString(publicRequest.CertificateField));
            }

            if (publicRequest.IsSetSpecifiers())
            {
                request.ParameterCollection.Add("specifiers", publicRequest.Specifiers);
            }

            if (!publicRequest.IsSetProfileId())
            {
                throw new AmazonIAMRolesAnywhereException("Request object does not have required field ProfileId set");
            }
            request.AddPathResource("{profileId}", StringUtils.FromString(publicRequest.ProfileId));

            request.ResourcePath = "/profiles/{profileId}/mappings";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DeleteAttributeMappingRequestMarshaller _instance = new();

        internal static DeleteAttributeMappingRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteAttributeMappingRequestMarshaller Instance => _instance;
    }
}
