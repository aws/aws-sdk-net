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

using Amazon.FIS.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.FIS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetExperimentTargetAccountConfiguration Request Marshaller
    /// </summary>
    public partial class GetExperimentTargetAccountConfigurationRequestMarshaller : IMarshaller<IRequest, GetExperimentTargetAccountConfigurationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetExperimentTargetAccountConfigurationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetExperimentTargetAccountConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.FIS");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-12-01";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetAccountId())
            {
                throw new AmazonFISException("Request object does not have required field AccountId set");
            }
            request.AddPathResource("{accountId}", StringUtils.FromString(publicRequest.AccountId));

            if (!publicRequest.IsSetExperimentId())
            {
                throw new AmazonFISException("Request object does not have required field ExperimentId set");
            }
            request.AddPathResource("{experimentId}", StringUtils.FromString(publicRequest.ExperimentId));

            request.ResourcePath = "/experiments/{experimentId}/targetAccountConfigurations/{accountId}";

            return request;
        }

        private static readonly GetExperimentTargetAccountConfigurationRequestMarshaller _instance = new();

        internal static GetExperimentTargetAccountConfigurationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetExperimentTargetAccountConfigurationRequestMarshaller Instance => _instance;
    }
}
