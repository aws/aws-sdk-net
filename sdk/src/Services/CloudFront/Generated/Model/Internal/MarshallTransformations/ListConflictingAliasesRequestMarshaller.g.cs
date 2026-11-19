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
    /// ListConflictingAliases Request Marshaller
    /// </summary>
    public partial class ListConflictingAliasesRequestMarshaller : IMarshaller<IRequest, ListConflictingAliasesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListConflictingAliasesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListConflictingAliasesRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "GET";

            request.ResourcePath = "/2020-05-31/conflicting-alias";

            if (string.IsNullOrEmpty(publicRequest.Alias))
            {
                throw new AmazonCloudFrontException("Request object does not have required field Alias set");
            }

            if (publicRequest.IsSetAlias())
            {
                request.Parameters.Add("Alias", StringUtils.FromString(publicRequest.Alias));
            }

            if (string.IsNullOrEmpty(publicRequest.DistributionId))
            {
                throw new AmazonCloudFrontException("Request object does not have required field DistributionId set");
            }

            if (publicRequest.IsSetDistributionId())
            {
                request.Parameters.Add("DistributionId", StringUtils.FromString(publicRequest.DistributionId));
            }

            if (publicRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
            }

            if (publicRequest.IsSetMaxItems())
            {
                request.Parameters.Add("MaxItems", StringUtils.FromInt(publicRequest.MaxItems.Value));
            }


            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;

            return request;
        }

        private static readonly ListConflictingAliasesRequestMarshaller _instance = new();

        internal static ListConflictingAliasesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListConflictingAliasesRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, ListConflictingAliasesRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, ListConflictingAliasesRequest publicRequest);
    }
}
