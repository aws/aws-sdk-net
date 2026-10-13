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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.SageMaker.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeCluster operation.
    /// </summary>
    public partial class DescribeClusterResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new DescribeClusterResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AutoScaling", targetDepth, ref reader))
                {
                    var unmarshaller = ClusterAutoScalingConfigOutputUnmarshaller.Instance;
                    unmarshalledObject.AutoScaling = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ClusterArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ClusterName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ClusterRole", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterRole = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ClusterStatus", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("CreationTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FailureMessage", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureMessage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InstanceGroups", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ClusterInstanceGroupDetails, ClusterInstanceGroupDetailsUnmarshaller>(ClusterInstanceGroupDetailsUnmarshaller.Instance);
                    unmarshalledObject.InstanceGroups = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("NodeProvisioningMode", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NodeProvisioningMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("NodeRecovery", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NodeRecovery = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Orchestrator", targetDepth, ref reader))
                {
                    var unmarshaller = ClusterOrchestratorUnmarshaller.Instance;
                    unmarshalledObject.Orchestrator = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("RestrictedInstanceGroups", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ClusterRestrictedInstanceGroupDetails, ClusterRestrictedInstanceGroupDetailsUnmarshaller>(ClusterRestrictedInstanceGroupDetailsUnmarshaller.Instance);
                    unmarshalledObject.RestrictedInstanceGroups = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("RestrictedInstanceGroupsConfig", targetDepth, ref reader))
                {
                    var unmarshaller = ClusterRestrictedInstanceGroupsConfigOutputUnmarshaller.Instance;
                    unmarshalledObject.RestrictedInstanceGroupsConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TieredStorageConfig", targetDepth, ref reader))
                {
                    var unmarshaller = ClusterTieredStorageConfigUnmarshaller.Instance;
                    unmarshalledObject.TieredStorageConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("VpcConfig", targetDepth, ref reader))
                {
                    var unmarshaller = VpcConfigUnmarshaller.Instance;
                    unmarshalledObject.VpcConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);

            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                    var readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFound"))
                    {
                        return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonSageMakerException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeClusterResponseUnmarshaller _instance = new DescribeClusterResponseUnmarshaller();

        internal static DescribeClusterResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeClusterResponseUnmarshaller Instance => _instance;
    }
}
