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
using ThirdParty.Json.LitJson;

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

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("actionDefinitions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ActionDefinition, ActionDefinitionUnmarshaller>(ActionDefinitionUnmarshaller.Instance);
                    response.ActionDefinitions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetModelCompositeModelDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssetModelCompositeModelDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetModelCompositeModelExternalId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssetModelCompositeModelExternalId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetModelCompositeModelId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssetModelCompositeModelId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetModelCompositeModelName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssetModelCompositeModelName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetModelCompositeModelPath", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AssetModelCompositeModelPathSegment, AssetModelCompositeModelPathSegmentUnmarshaller>(AssetModelCompositeModelPathSegmentUnmarshaller.Instance);
                    response.AssetModelCompositeModelPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetModelCompositeModelProperties", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AssetModelProperty, AssetModelPropertyUnmarshaller>(AssetModelPropertyUnmarshaller.Instance);
                    response.AssetModelCompositeModelProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetModelCompositeModelSummaries", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AssetModelCompositeModelSummary, AssetModelCompositeModelSummaryUnmarshaller>(AssetModelCompositeModelSummaryUnmarshaller.Instance);
                    response.AssetModelCompositeModelSummaries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetModelCompositeModelType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssetModelCompositeModelType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetModelId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssetModelId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("compositionDetails", targetDepth))
                {
                    var unmarshaller = CompositionDetailsUnmarshaller.Instance;
                    response.CompositionDetails = unmarshaller.Unmarshall(context);
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
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalFailureException"))
                {
                    return InternalFailureExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRequestException"))
                {
                    return InvalidRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
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