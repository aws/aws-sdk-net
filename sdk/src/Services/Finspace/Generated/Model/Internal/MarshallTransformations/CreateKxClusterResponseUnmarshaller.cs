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
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Finspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateKxCluster operation
    /// </summary>  
    public class CreateKxClusterResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            CreateKxClusterResponse response = new CreateKxClusterResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("autoScalingConfiguration", targetDepth))
                {
                    var unmarshaller = AutoScalingConfigurationUnmarshaller.Instance;
                    response.AutoScalingConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("availabilityZoneId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AvailabilityZoneId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("azMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AzMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cacheStorageConfigurations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<KxCacheStorageConfiguration, KxCacheStorageConfigurationUnmarshaller>(KxCacheStorageConfigurationUnmarshaller.Instance);
                    response.CacheStorageConfigurations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("capacityConfiguration", targetDepth))
                {
                    var unmarshaller = CapacityConfigurationUnmarshaller.Instance;
                    response.CapacityConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("clusterDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ClusterDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("clusterName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ClusterName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("clusterType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ClusterType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("code", targetDepth))
                {
                    var unmarshaller = CodeConfigurationUnmarshaller.Instance;
                    response.Code = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("commandLineArguments", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<KxCommandLineArgument, KxCommandLineArgumentUnmarshaller>(KxCommandLineArgumentUnmarshaller.Instance);
                    response.CommandLineArguments = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createdTimestamp", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.CreatedTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("databases", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<KxDatabaseConfiguration, KxDatabaseConfigurationUnmarshaller>(KxDatabaseConfigurationUnmarshaller.Instance);
                    response.Databases = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("environmentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EnvironmentId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("executionRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ExecutionRole = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("initializationScript", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.InitializationScript = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lastModifiedTimestamp", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.LastModifiedTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("releaseLabel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ReleaseLabel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("savedownStorageConfiguration", targetDepth))
                {
                    var unmarshaller = KxSavedownStorageConfigurationUnmarshaller.Instance;
                    response.SavedownStorageConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scalingGroupConfiguration", targetDepth))
                {
                    var unmarshaller = KxScalingGroupConfigurationUnmarshaller.Instance;
                    response.ScalingGroupConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("statusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StatusReason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tickerplantLogConfiguration", targetDepth))
                {
                    var unmarshaller = TickerplantLogConfigurationUnmarshaller.Instance;
                    response.TickerplantLogConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("volumes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Volume, VolumeUnmarshaller>(VolumeUnmarshaller.Instance);
                    response.Volumes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("vpcConfiguration", targetDepth))
                {
                    var unmarshaller = VpcConfigurationUnmarshaller.Instance;
                    response.VpcConfiguration = unmarshaller.Unmarshall(context, ref reader);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                {
                    return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("LimitExceededException"))
                {
                    return LimitExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonFinspaceException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static CreateKxClusterResponseUnmarshaller _instance = new CreateKxClusterResponseUnmarshaller();        

        internal static CreateKxClusterResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateKxClusterResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}