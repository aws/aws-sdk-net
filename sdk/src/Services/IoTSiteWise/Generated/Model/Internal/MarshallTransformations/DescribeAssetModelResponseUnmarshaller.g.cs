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
    /// Response Unmarshaller for DescribeAssetModel operation.
    /// </summary>
    public partial class DescribeAssetModelResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new DescribeAssetModelResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("assetModelArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssetModelArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelCompositeModelSummaries", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetModelCompositeModelSummary, AssetModelCompositeModelSummaryUnmarshaller>(AssetModelCompositeModelSummaryUnmarshaller.Instance);
                    unmarshalledObject.AssetModelCompositeModelSummaries = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelCompositeModels", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetModelCompositeModel, AssetModelCompositeModelUnmarshaller>(AssetModelCompositeModelUnmarshaller.Instance);
                    unmarshalledObject.AssetModelCompositeModels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelCreationDate", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.AssetModelCreationDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelDescription", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssetModelDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelExternalId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssetModelExternalId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelHierarchies", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetModelHierarchy, AssetModelHierarchyUnmarshaller>(AssetModelHierarchyUnmarshaller.Instance);
                    unmarshalledObject.AssetModelHierarchies = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssetModelId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelLastUpdateDate", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.AssetModelLastUpdateDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssetModelName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelProperties", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetModelProperty, AssetModelPropertyUnmarshaller>(AssetModelPropertyUnmarshaller.Instance);
                    unmarshalledObject.AssetModelProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelStatus", targetDepth, ref reader))
                {
                    var unmarshaller = AssetModelStatusUnmarshaller.Instance;
                    unmarshalledObject.AssetModelStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssetModelType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("assetModelVersion", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssetModelVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("interfaceDetails", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<InterfaceRelationship, InterfaceRelationshipUnmarshaller>(InterfaceRelationshipUnmarshaller.Instance);
                    unmarshalledObject.InterfaceDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            if (context.ResponseData.IsHeaderPresent("ETag"))
            {
                unmarshalledObject.ETag = context.ResponseData.GetHeaderValue("ETag");
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

        private static DescribeAssetModelResponseUnmarshaller _instance = new DescribeAssetModelResponseUnmarshaller();

        internal static DescribeAssetModelResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeAssetModelResponseUnmarshaller Instance => _instance;
    }
}
