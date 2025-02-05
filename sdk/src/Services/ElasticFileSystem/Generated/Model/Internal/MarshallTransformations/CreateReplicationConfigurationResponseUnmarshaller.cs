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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticFileSystem.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticFileSystem.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateReplicationConfiguration operation
    /// </summary>  
    public class CreateReplicationConfigurationResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            CreateReplicationConfigurationResponse response = new CreateReplicationConfigurationResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Destinations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Destination, DestinationUnmarshaller>(DestinationUnmarshaller.Instance);
                    response.Destinations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OriginalSourceFileSystemArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OriginalSourceFileSystemArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceFileSystemArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceFileSystemArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceFileSystemId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceFileSystemId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceFileSystemOwnerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceFileSystemOwnerId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceFileSystemRegion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceFileSystemRegion = unmarshaller.Unmarshall(context, ref reader);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequest"))
                {
                    return BadRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                {
                    return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("FileSystemLimitExceeded"))
                {
                    return FileSystemLimitExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("FileSystemNotFound"))
                {
                    return FileSystemNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("IncorrectFileSystemLifeCycleState"))
                {
                    return IncorrectFileSystemLifeCycleStateExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InsufficientThroughputCapacity"))
                {
                    return InsufficientThroughputCapacityExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerError"))
                {
                    return InternalServerErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ReplicationNotFound"))
                {
                    return ReplicationNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThroughputLimitExceeded"))
                {
                    return ThroughputLimitExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UnsupportedAvailabilityZone"))
                {
                    return UnsupportedAvailabilityZoneExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonElasticFileSystemException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static CreateReplicationConfigurationResponseUnmarshaller _instance = new CreateReplicationConfigurationResponseUnmarshaller();        

        internal static CreateReplicationConfigurationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateReplicationConfigurationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}