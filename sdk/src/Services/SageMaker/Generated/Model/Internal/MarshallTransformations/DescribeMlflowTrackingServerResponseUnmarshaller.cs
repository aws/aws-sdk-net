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

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeMlflowTrackingServer operation
    /// </summary>  
    public class DescribeMlflowTrackingServerResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeMlflowTrackingServerResponse response = new DescribeMlflowTrackingServerResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ArtifactStoreUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ArtifactStoreUri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutomaticModelRegistration", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.AutomaticModelRegistration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedBy", targetDepth))
                {
                    var unmarshaller = UserContextUnmarshaller.Instance;
                    response.CreatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsActive", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.IsActive = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedBy", targetDepth))
                {
                    var unmarshaller = UserContextUnmarshaller.Instance;
                    response.LastModifiedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MlflowVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MlflowVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrackingServerArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TrackingServerArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrackingServerName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TrackingServerName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrackingServerSize", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TrackingServerSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrackingServerStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TrackingServerStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrackingServerUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TrackingServerUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WeeklyMaintenanceWindowStart", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.WeeklyMaintenanceWindowStart = unmarshaller.Unmarshall(context);
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

        private static DescribeMlflowTrackingServerResponseUnmarshaller _instance = new DescribeMlflowTrackingServerResponseUnmarshaller();        

        internal static DescribeMlflowTrackingServerResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeMlflowTrackingServerResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}