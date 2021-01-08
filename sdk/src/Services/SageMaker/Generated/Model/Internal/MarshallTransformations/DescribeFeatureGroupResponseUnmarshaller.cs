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
    /// Response Unmarshaller for DescribeFeatureGroup operation
    /// </summary>  
    public class DescribeFeatureGroupResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeFeatureGroupResponse response = new DescribeFeatureGroupResponse();

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
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventTimeFeatureName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EventTimeFeatureName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FailureReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FeatureDefinitions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FeatureDefinition, FeatureDefinitionUnmarshaller>(FeatureDefinitionUnmarshaller.Instance);
                    response.FeatureDefinitions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FeatureGroupArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FeatureGroupArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FeatureGroupName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FeatureGroupName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FeatureGroupStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FeatureGroupStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NextToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.NextToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OfflineStoreConfig", targetDepth))
                {
                    var unmarshaller = OfflineStoreConfigUnmarshaller.Instance;
                    response.OfflineStoreConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OfflineStoreStatus", targetDepth))
                {
                    var unmarshaller = OfflineStoreStatusUnmarshaller.Instance;
                    response.OfflineStoreStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OnlineStoreConfig", targetDepth))
                {
                    var unmarshaller = OnlineStoreConfigUnmarshaller.Instance;
                    response.OnlineStoreConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecordIdentifierFeatureName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RecordIdentifierFeatureName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RoleArn = unmarshaller.Unmarshall(context);
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

        private static DescribeFeatureGroupResponseUnmarshaller _instance = new DescribeFeatureGroupResponseUnmarshaller();        

        internal static DescribeFeatureGroupResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeFeatureGroupResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}