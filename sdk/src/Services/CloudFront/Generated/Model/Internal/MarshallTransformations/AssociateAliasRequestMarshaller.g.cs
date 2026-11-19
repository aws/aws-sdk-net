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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.CloudFront.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssociateAlias Request Marshaller
    /// </summary>
    public partial class AssociateAliasRequestMarshaller : IMarshaller<IRequest, AssociateAliasRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssociateAliasRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AssociateAliasRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetTargetDistributionId())
            {
                throw new AmazonCloudFrontException("Request object does not have required field TargetDistributionId set");
            }
            request.AddPathResource("{TargetDistributionId}", StringUtils.FromString(publicRequest.TargetDistributionId));

            request.ResourcePath = "/2020-05-31/distribution/{TargetDistributionId}/associate-alias";

            if (string.IsNullOrEmpty(publicRequest.Alias))
            {
                throw new AmazonCloudFrontException("Request object does not have required field Alias set");
            }

            if (publicRequest.IsSetAlias())
            {
                request.Parameters.Add("Alias", StringUtils.FromString(publicRequest.Alias));
            }


            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;

            return request;
        }

        private static readonly AssociateAliasRequestMarshaller _instance = new();

        internal static AssociateAliasRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AssociateAliasRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, AssociateAliasRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, AssociateAliasRequest publicRequest);
    }
}
