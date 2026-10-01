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

using Amazon.GeoPlaces.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.GeoPlaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetPlace Request Marshaller
    /// </summary>
    public partial class GetPlaceRequestMarshaller : IMarshaller<IRequest, GetPlaceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetPlaceRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetPlaceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GeoPlaces");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetAdditionalFeatures())
            {
                request.ParameterCollection.Add("additional-features", publicRequest.AdditionalFeatures);
            }

            if (publicRequest.IsSetAddressNamesMode())
            {
                request.Parameters.Add("address-names-mode", StringUtils.FromString(publicRequest.AddressNamesMode));
            }

            if (publicRequest.IsSetIntendedUse())
            {
                request.Parameters.Add("intended-use", StringUtils.FromString(publicRequest.IntendedUse));
            }

            if (publicRequest.IsSetKey())
            {
                request.Parameters.Add("key", StringUtils.FromString(publicRequest.Key));
            }

            if (publicRequest.IsSetLanguage())
            {
                request.Parameters.Add("language", StringUtils.FromString(publicRequest.Language));
            }

            if (publicRequest.IsSetPoliticalView())
            {
                request.Parameters.Add("political-view", StringUtils.FromString(publicRequest.PoliticalView));
            }

            if (!publicRequest.IsSetPlaceId())
            {
                throw new AmazonGeoPlacesException("Request object does not have required field PlaceId set");
            }
            request.AddPathResource("{PlaceId}", StringUtils.FromString(publicRequest.PlaceId));

            request.ResourcePath = "/v2/place/{PlaceId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetPlaceRequestMarshaller _instance = new();

        internal static GetPlaceRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetPlaceRequestMarshaller Instance => _instance;
    }
}
