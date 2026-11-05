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

using Amazon.RDS.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateBlueGreenDeployment Request Marshaller
    /// </summary>
    public partial class CreateBlueGreenDeploymentRequestMarshaller : IMarshaller<IRequest, CreateBlueGreenDeploymentRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBlueGreenDeploymentRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateBlueGreenDeploymentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateBlueGreenDeployment");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetBlueGreenDeploymentName())
            {
                request.Parameters.Add("BlueGreenDeploymentName", StringUtils.FromString(publicRequest.BlueGreenDeploymentName));
            }
            if (publicRequest.IsSetSource())
            {
                request.Parameters.Add("Source", StringUtils.FromString(publicRequest.Source));
            }
            if (publicRequest.IsSetTags())
            {
                if (publicRequest.Tags.Count == 0)
                {
                    request.Parameters.Add("Tags", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Tags)
                    {
                        if (item0.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + ".Tag" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + ".Tag" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTargetAllocatedStorage())
            {
                request.Parameters.Add("TargetAllocatedStorage", StringUtils.FromInt(publicRequest.TargetAllocatedStorage.Value));
            }
            if (publicRequest.IsSetTargetDBClusterParameterGroupName())
            {
                request.Parameters.Add("TargetDBClusterParameterGroupName", StringUtils.FromString(publicRequest.TargetDBClusterParameterGroupName));
            }
            if (publicRequest.IsSetTargetDBInstanceClass())
            {
                request.Parameters.Add("TargetDBInstanceClass", StringUtils.FromString(publicRequest.TargetDBInstanceClass));
            }
            if (publicRequest.IsSetTargetDBParameterGroupName())
            {
                request.Parameters.Add("TargetDBParameterGroupName", StringUtils.FromString(publicRequest.TargetDBParameterGroupName));
            }
            if (publicRequest.IsSetTargetEngineVersion())
            {
                request.Parameters.Add("TargetEngineVersion", StringUtils.FromString(publicRequest.TargetEngineVersion));
            }
            if (publicRequest.IsSetTargetIops())
            {
                request.Parameters.Add("TargetIops", StringUtils.FromInt(publicRequest.TargetIops.Value));
            }
            if (publicRequest.IsSetTargetResourceConfigurations())
            {
                if (publicRequest.TargetResourceConfigurations.Count == 0)
                {
                    request.Parameters.Add("TargetResourceConfigurations", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TargetResourceConfigurations)
                    {
                        if (item0.IsSetSourceArn())
                        {
                            request.Parameters.Add("TargetResourceConfigurations" + ".TargetResourceConfiguration" + "." + index0 + ".SourceArn", StringUtils.FromString(item0.SourceArn));
                        }
                        if (item0.IsSetTargetKmsKeyId())
                        {
                            request.Parameters.Add("TargetResourceConfigurations" + ".TargetResourceConfiguration" + "." + index0 + ".TargetKmsKeyId", StringUtils.FromString(item0.TargetKmsKeyId));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTargetStorageThroughput())
            {
                request.Parameters.Add("TargetStorageThroughput", StringUtils.FromInt(publicRequest.TargetStorageThroughput.Value));
            }
            if (publicRequest.IsSetTargetStorageType())
            {
                request.Parameters.Add("TargetStorageType", StringUtils.FromString(publicRequest.TargetStorageType));
            }
            if (publicRequest.IsSetUpgradeTargetStorageConfig())
            {
                request.Parameters.Add("UpgradeTargetStorageConfig", StringUtils.FromBool(publicRequest.UpgradeTargetStorageConfig.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateBlueGreenDeploymentRequestMarshaller _instance = new();

        internal static CreateBlueGreenDeploymentRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateBlueGreenDeploymentRequestMarshaller Instance => _instance;
    }
}
