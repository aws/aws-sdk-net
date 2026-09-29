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

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeAssetModelCompositeModel operation.
    /// </summary>
    public partial class DescribeAssetModelCompositeModelResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new DescribeAssetModelCompositeModelResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("actionDefinitions", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ActionDefinition, ActionDefinitionUnmarshaller>(ActionDefinitionUnmarshaller.Instance);
                    unmarshalledObject.ActionDefinitions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelCompositeModelDescription", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssetModelCompositeModelDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelCompositeModelExternalId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssetModelCompositeModelExternalId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelCompositeModelId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssetModelCompositeModelId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelCompositeModelName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssetModelCompositeModelName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelCompositeModelPath", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetModelCompositeModelPathSegment, AssetModelCompositeModelPathSegmentUnmarshaller>(AssetModelCompositeModelPathSegmentUnmarshaller.Instance);
                    unmarshalledObject.AssetModelCompositeModelPath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelCompositeModelProperties", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetModelProperty, AssetModelPropertyUnmarshaller>(AssetModelPropertyUnmarshaller.Instance);
                    unmarshalledObject.AssetModelCompositeModelProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelCompositeModelSummaries", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetModelCompositeModelSummary, AssetModelCompositeModelSummaryUnmarshaller>(AssetModelCompositeModelSummaryUnmarshaller.Instance);
                    unmarshalledObject.AssetModelCompositeModelSummaries = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelCompositeModelType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssetModelCompositeModelType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssetModelId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("compositionDetails", targetDepth, ref reader))
                {
                    var unmarshaller = CompositionDetailsUnmarshaller.Instance;
                    unmarshalledObject.CompositionDetails = unmarshaller.Unmarshall(context, ref reader);
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
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InternalFailureException"))
                    {
                        return InternalFailureExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRequestException"))
                    {
                        return InvalidRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                    {
                        return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                    {
                        return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonIoTSiteWiseException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeAssetModelCompositeModelResponseUnmarshaller _instance = new DescribeAssetModelCompositeModelResponseUnmarshaller();

        internal static DescribeAssetModelCompositeModelResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeAssetModelCompositeModelResponseUnmarshaller Instance => _instance;
    }
}
