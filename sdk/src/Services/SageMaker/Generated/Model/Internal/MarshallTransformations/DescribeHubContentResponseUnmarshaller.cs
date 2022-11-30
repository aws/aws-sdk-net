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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeHubContent operation
    /// </summary>  
    public class DescribeHubContentResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeHubContentResponse response = new DescribeHubContentResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DocumentSchemaVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DocumentSchemaVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FailureReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HubArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HubArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HubContentArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HubContentArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HubContentDependencies", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<HubContentDependency, HubContentDependencyUnmarshaller>(HubContentDependencyUnmarshaller.Instance);
                    response.HubContentDependencies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HubContentDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HubContentDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HubContentDisplayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HubContentDisplayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HubContentDocument", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HubContentDocument = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HubContentMarkdown", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HubContentMarkdown = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HubContentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HubContentName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HubContentSearchKeywords", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.HubContentSearchKeywords = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HubContentStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HubContentStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HubContentType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HubContentType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HubContentVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HubContentVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HubName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HubName = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFound"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonSageMakerException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeHubContentResponseUnmarshaller _instance = new DescribeHubContentResponseUnmarshaller();        

        internal static DescribeHubContentResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeHubContentResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}