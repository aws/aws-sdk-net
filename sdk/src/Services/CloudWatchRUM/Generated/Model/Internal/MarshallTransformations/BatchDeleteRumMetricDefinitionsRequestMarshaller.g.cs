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

using Amazon.CloudWatchRUM.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudWatchRUM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchDeleteRumMetricDefinitions Request Marshaller
    /// </summary>
    public partial class BatchDeleteRumMetricDefinitionsRequestMarshaller : IMarshaller<IRequest, BatchDeleteRumMetricDefinitionsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchDeleteRumMetricDefinitionsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(BatchDeleteRumMetricDefinitionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchRUM");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "DELETE";

            if (string.IsNullOrEmpty(publicRequest.Destination))
            {
                throw new AmazonCloudWatchRUMException("Request object does not have required field Destination set");
            }

            if (publicRequest.IsSetDestination())
            {
                request.Parameters.Add("destination", StringUtils.FromString(publicRequest.Destination));
            }

            if (publicRequest.IsSetDestinationArn())
            {
                request.Parameters.Add("destinationArn", StringUtils.FromString(publicRequest.DestinationArn));
            }

            if (publicRequest.MetricDefinitionIds == null)
            {
                throw new AmazonCloudWatchRUMException("Request object does not have required field MetricDefinitionIds set");
            }

            if (publicRequest.IsSetMetricDefinitionIds())
            {
                request.ParameterCollection.Add("metricDefinitionIds", publicRequest.MetricDefinitionIds);
            }

            if (!publicRequest.IsSetAppMonitorName())
            {
                throw new AmazonCloudWatchRUMException("Request object does not have required field AppMonitorName set");
            }
            request.AddPathResource("{AppMonitorName}", StringUtils.FromString(publicRequest.AppMonitorName));

            request.ResourcePath = "/rummetrics/{AppMonitorName}/metrics";

            request.UseQueryString = true;

            return request;
        }

        private static readonly BatchDeleteRumMetricDefinitionsRequestMarshaller _instance = new();

        internal static BatchDeleteRumMetricDefinitionsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BatchDeleteRumMetricDefinitionsRequestMarshaller Instance => _instance;
    }
}
