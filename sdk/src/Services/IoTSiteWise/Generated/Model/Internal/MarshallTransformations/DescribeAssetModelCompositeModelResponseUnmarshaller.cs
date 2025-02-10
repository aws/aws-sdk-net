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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeAssetModelCompositeModel operation
    /// </summary>  
    public class DescribeAssetModelCompositeModelResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeAssetModelCompositeModelResponse response = new DescribeAssetModelCompositeModelResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("actionDefinitions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ActionDefinition, ActionDefinitionUnmarshaller>(ActionDefinitionUnmarshaller.Instance);
                    response.ActionDefinitions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("assetModelCompositeModelDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssetModelCompositeModelDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("assetModelCompositeModelExternalId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssetModelCompositeModelExternalId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("assetModelCompositeModelId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssetModelCompositeModelId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("assetModelCompositeModelName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssetModelCompositeModelName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("assetModelCompositeModelPath", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetModelCompositeModelPathSegment, AssetModelCompositeModelPathSegmentUnmarshaller>(AssetModelCompositeModelPathSegmentUnmarshaller.Instance);
                    response.AssetModelCompositeModelPath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("assetModelCompositeModelProperties", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetModelProperty, AssetModelPropertyUnmarshaller>(AssetModelPropertyUnmarshaller.Instance);
                    response.AssetModelCompositeModelProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("assetModelCompositeModelSummaries", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetModelCompositeModelSummary, AssetModelCompositeModelSummaryUnmarshaller>(AssetModelCompositeModelSummaryUnmarshaller.Instance);
                    response.AssetModelCompositeModelSummaries = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("assetModelCompositeModelType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssetModelCompositeModelType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("assetModelId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssetModelId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("compositionDetails", targetDepth))
                {
                    var unmarshaller = CompositionDetailsUnmarshaller.Instance;
                    response.CompositionDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy);
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
            return new AmazonIoTSiteWiseException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeAssetModelCompositeModelResponseUnmarshaller _instance = new DescribeAssetModelCompositeModelResponseUnmarshaller();        

        internal static DescribeAssetModelCompositeModelResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAssetModelCompositeModelResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}