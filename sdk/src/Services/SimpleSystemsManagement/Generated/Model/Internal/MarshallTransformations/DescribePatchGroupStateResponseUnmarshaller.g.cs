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

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribePatchGroupState operation.
    /// </summary>
    public partial class DescribePatchGroupStateResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new DescribePatchGroupStateResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Instances", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Instances = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InstancesWithAvailableSecurityUpdates", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.InstancesWithAvailableSecurityUpdates = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InstancesWithCriticalNonCompliantPatches", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.InstancesWithCriticalNonCompliantPatches = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InstancesWithFailedPatches", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.InstancesWithFailedPatches = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InstancesWithInstalledOtherPatches", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.InstancesWithInstalledOtherPatches = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InstancesWithInstalledPatches", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.InstancesWithInstalledPatches = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InstancesWithInstalledPendingRebootPatches", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.InstancesWithInstalledPendingRebootPatches = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InstancesWithInstalledRejectedPatches", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.InstancesWithInstalledRejectedPatches = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InstancesWithMissingPatches", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.InstancesWithMissingPatches = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InstancesWithNotApplicablePatches", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.InstancesWithNotApplicablePatches = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InstancesWithOtherNonCompliantPatches", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.InstancesWithOtherNonCompliantPatches = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InstancesWithSecurityNonCompliantPatches", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.InstancesWithSecurityNonCompliantPatches = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InstancesWithUnreportedNotApplicablePatches", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.InstancesWithUnreportedNotApplicablePatches = unmarshaller.Unmarshall(context, ref reader);
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
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerError"))
                    {
                        return InternalServerErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidNextToken"))
                    {
                        return InvalidNextTokenExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonSimpleSystemsManagementException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribePatchGroupStateResponseUnmarshaller _instance = new DescribePatchGroupStateResponseUnmarshaller();

        internal static DescribePatchGroupStateResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribePatchGroupStateResponseUnmarshaller Instance => _instance;
    }
}
