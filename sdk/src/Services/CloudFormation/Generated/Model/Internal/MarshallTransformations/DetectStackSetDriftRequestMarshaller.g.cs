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

using Amazon.CloudFormation.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DetectStackSetDrift Request Marshaller
    /// </summary>
    public partial class DetectStackSetDriftRequestMarshaller : IMarshaller<IRequest, DetectStackSetDriftRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DetectStackSetDriftRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DetectStackSetDriftRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DetectStackSetDrift");
            request.Parameters.Add("Version", "2010-05-15");

            if (publicRequest.IsSetCallAs())
            {
                request.Parameters.Add("CallAs", StringUtils.FromString(publicRequest.CallAs));
            }
            if (publicRequest.IsSetOperationId())
            {
                request.Parameters.Add("OperationId", StringUtils.FromString(publicRequest.OperationId));
            }
            else
            {
                request.Parameters.Add("OperationId", StringUtils.FromString(Guid.NewGuid().ToString()));
            }
            if (publicRequest.IsSetOperationPreferences())
            {
                if (publicRequest.OperationPreferences.IsSetConcurrencyMode())
                {
                    request.Parameters.Add("OperationPreferences" + ".ConcurrencyMode", StringUtils.FromString(publicRequest.OperationPreferences.ConcurrencyMode));
                }
                if (publicRequest.OperationPreferences.IsSetFailureToleranceCount())
                {
                    request.Parameters.Add("OperationPreferences" + ".FailureToleranceCount", StringUtils.FromInt(publicRequest.OperationPreferences.FailureToleranceCount.Value));
                }
                if (publicRequest.OperationPreferences.IsSetFailureTolerancePercentage())
                {
                    request.Parameters.Add("OperationPreferences" + ".FailureTolerancePercentage", StringUtils.FromInt(publicRequest.OperationPreferences.FailureTolerancePercentage.Value));
                }
                if (publicRequest.OperationPreferences.IsSetMaxConcurrentCount())
                {
                    request.Parameters.Add("OperationPreferences" + ".MaxConcurrentCount", StringUtils.FromInt(publicRequest.OperationPreferences.MaxConcurrentCount.Value));
                }
                if (publicRequest.OperationPreferences.IsSetMaxConcurrentPercentage())
                {
                    request.Parameters.Add("OperationPreferences" + ".MaxConcurrentPercentage", StringUtils.FromInt(publicRequest.OperationPreferences.MaxConcurrentPercentage.Value));
                }
                if (publicRequest.OperationPreferences.IsSetRegionConcurrencyType())
                {
                    request.Parameters.Add("OperationPreferences" + ".RegionConcurrencyType", StringUtils.FromString(publicRequest.OperationPreferences.RegionConcurrencyType));
                }
                if (publicRequest.OperationPreferences.IsSetRegionOrder())
                {
                    if (publicRequest.OperationPreferences.RegionOrder.Count == 0)
                    {
                        request.Parameters.Add("OperationPreferences" + ".RegionOrder", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.OperationPreferences.RegionOrder)
                        {
                            request.Parameters.Add("OperationPreferences" + ".RegionOrder" + ".member" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
            }
            if (publicRequest.IsSetStackSetName())
            {
                request.Parameters.Add("StackSetName", StringUtils.FromString(publicRequest.StackSetName));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly DetectStackSetDriftRequestMarshaller _instance = new();

        internal static DetectStackSetDriftRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DetectStackSetDriftRequestMarshaller Instance => _instance;
    }
}
