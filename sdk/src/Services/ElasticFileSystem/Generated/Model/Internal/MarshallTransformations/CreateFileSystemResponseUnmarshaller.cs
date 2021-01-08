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
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticFileSystem.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateFileSystem operation
    /// </summary>  
    public class CreateFileSystemResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            CreateFileSystemResponse response = new CreateFileSystemResponse();

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
                if (context.TestExpression("CreationToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CreationToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Encrypted", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.Encrypted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FileSystemArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FileSystemArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FileSystemId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FileSystemId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.KmsKeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LifeCycleState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LifeCycleState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfMountTargets", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.NumberOfMountTargets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OwnerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OwnerId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PerformanceMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PerformanceMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProvisionedThroughputInMibps", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    response.ProvisionedThroughputInMibps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SizeInBytes", targetDepth))
                {
                    var unmarshaller = FileSystemSizeUnmarshaller.Instance;
                    response.SizeInBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThroughputMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ThroughputMode = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequest"))
                {
                    return BadRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("FileSystemAlreadyExists"))
                {
                    return FileSystemAlreadyExistsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("FileSystemLimitExceeded"))
                {
                    return FileSystemLimitExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InsufficientThroughputCapacity"))
                {
                    return InsufficientThroughputCapacityExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerError"))
                {
                    return InternalServerErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThroughputLimitExceeded"))
                {
                    return ThroughputLimitExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonElasticFileSystemException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static CreateFileSystemResponseUnmarshaller _instance = new CreateFileSystemResponseUnmarshaller();        

        internal static CreateFileSystemResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFileSystemResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}