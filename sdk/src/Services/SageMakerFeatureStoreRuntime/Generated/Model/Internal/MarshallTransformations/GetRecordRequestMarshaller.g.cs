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

using Amazon.SageMakerFeatureStoreRuntime.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.SageMakerFeatureStoreRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetRecord Request Marshaller
    /// </summary>
    public partial class GetRecordRequestMarshaller : IMarshaller<IRequest, GetRecordRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetRecordRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetRecordRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMakerFeatureStoreRuntime");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-01";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetExpirationTimeResponse())
            {
                request.Parameters.Add("ExpirationTimeResponse", StringUtils.FromString(publicRequest.ExpirationTimeResponse));
            }

            if (publicRequest.IsSetFeatureNames())
            {
                request.ParameterCollection.Add("FeatureName", publicRequest.FeatureNames);
            }

            if (string.IsNullOrEmpty(publicRequest.RecordIdentifierValueAsString))
            {
                throw new AmazonSageMakerFeatureStoreRuntimeException("Request object does not have required field RecordIdentifierValueAsString set");
            }

            if (publicRequest.IsSetRecordIdentifierValueAsString())
            {
                request.Parameters.Add("RecordIdentifierValueAsString", StringUtils.FromString(publicRequest.RecordIdentifierValueAsString));
            }

            if (!publicRequest.IsSetFeatureGroupName())
            {
                throw new AmazonSageMakerFeatureStoreRuntimeException("Request object does not have required field FeatureGroupName set");
            }
            request.AddPathResource("{FeatureGroupName}", StringUtils.FromString(publicRequest.FeatureGroupName));

            request.ResourcePath = "/FeatureGroup/{FeatureGroupName}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetRecordRequestMarshaller _instance = new();

        internal static GetRecordRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetRecordRequestMarshaller Instance => _instance;
    }
}
