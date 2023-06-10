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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Finspace.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Finspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetKxCluster operation
    /// </summary>  
    public class GetKxClusterResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetKxClusterResponse response = new GetKxClusterResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("autoScalingConfiguration", targetDepth))
                {
                    var unmarshaller = AutoScalingConfigurationUnmarshaller.Instance;
                    response.AutoScalingConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("availabilityZoneId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AvailabilityZoneId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("azMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AzMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cacheStorageConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<KxCacheStorageConfiguration, KxCacheStorageConfigurationUnmarshaller>(KxCacheStorageConfigurationUnmarshaller.Instance);
                    response.CacheStorageConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("capacityConfiguration", targetDepth))
                {
                    var unmarshaller = CapacityConfigurationUnmarshaller.Instance;
                    response.CapacityConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clusterDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ClusterDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clusterName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ClusterName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clusterType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ClusterType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("code", targetDepth))
                {
                    var unmarshaller = CodeConfigurationUnmarshaller.Instance;
                    response.Code = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("commandLineArguments", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<KxCommandLineArgument, KxCommandLineArgumentUnmarshaller>(KxCommandLineArgumentUnmarshaller.Instance);
                    response.CommandLineArguments = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreatedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("databases", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<KxDatabaseConfiguration, KxDatabaseConfigurationUnmarshaller>(KxDatabaseConfigurationUnmarshaller.Instance);
                    response.Databases = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("executionRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ExecutionRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("initializationScript", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.InitializationScript = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastModifiedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastModifiedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("releaseLabel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ReleaseLabel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("savedownStorageConfiguration", targetDepth))
                {
                    var unmarshaller = KxSavedownStorageConfigurationUnmarshaller.Instance;
                    response.SavedownStorageConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StatusReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vpcConfiguration", targetDepth))
                {
                    var unmarshaller = VpcConfigurationUnmarshaller.Instance;
                    response.VpcConfiguration = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                {
                    return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("LimitExceededException"))
                {
                    return LimitExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonFinspaceException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetKxClusterResponseUnmarshaller _instance = new GetKxClusterResponseUnmarshaller();        

        internal static GetKxClusterResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetKxClusterResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}