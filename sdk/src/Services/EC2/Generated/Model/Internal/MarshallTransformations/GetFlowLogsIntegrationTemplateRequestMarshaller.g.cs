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
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.EC2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetFlowLogsIntegrationTemplate Request Marshaller
    /// </summary>
    public partial class GetFlowLogsIntegrationTemplateRequestMarshaller : IMarshaller<IRequest, GetFlowLogsIntegrationTemplateRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetFlowLogsIntegrationTemplateRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetFlowLogsIntegrationTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "GetFlowLogsIntegrationTemplate");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetConfigDeliveryS3DestinationArn())
            {
                request.Parameters.Add("ConfigDeliveryS3DestinationArn", StringUtils.FromString(publicRequest.ConfigDeliveryS3DestinationArn));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetFlowLogId())
            {
                request.Parameters.Add("FlowLogId", StringUtils.FromString(publicRequest.FlowLogId));
            }
            if (publicRequest.IsSetIntegrateServices())
            {
                if (publicRequest.IntegrateServices.IsSetAthenaIntegrations())
                {
                    if (publicRequest.IntegrateServices.AthenaIntegrations.Count == 0)
                    {
                        request.Parameters.Add("IntegrateService" + ".AthenaIntegration", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.IntegrateServices.AthenaIntegrations)
                        {
                            if (item1.IsSetIntegrationResultS3DestinationArn())
                            {
                                request.Parameters.Add("IntegrateService" + ".AthenaIntegration" + "." + index1 + ".IntegrationResultS3DestinationArn", StringUtils.FromString(item1.IntegrationResultS3DestinationArn));
                            }
                            if (item1.IsSetPartitionEndDate())
                            {
                                request.Parameters.Add("IntegrateService" + ".AthenaIntegration" + "." + index1 + ".PartitionEndDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(item1.PartitionEndDate.Value));
                            }
                            if (item1.IsSetPartitionLoadFrequency())
                            {
                                request.Parameters.Add("IntegrateService" + ".AthenaIntegration" + "." + index1 + ".PartitionLoadFrequency", StringUtils.FromString(item1.PartitionLoadFrequency));
                            }
                            if (item1.IsSetPartitionStartDate())
                            {
                                request.Parameters.Add("IntegrateService" + ".AthenaIntegration" + "." + index1 + ".PartitionStartDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(item1.PartitionStartDate.Value));
                            }
                            index1++;
                        }
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly GetFlowLogsIntegrationTemplateRequestMarshaller _instance = new();

        internal static GetFlowLogsIntegrationTemplateRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetFlowLogsIntegrationTemplateRequestMarshaller Instance => _instance;
    }
}
