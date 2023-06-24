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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Keyspaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Keyspaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetTable operation
    /// </summary>  
    public class GetTableResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetTableResponse response = new GetTableResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("capacitySpecification", targetDepth))
                {
                    var unmarshaller = CapacitySpecificationSummaryUnmarshaller.Instance;
                    response.CapacitySpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clientSideTimestamps", targetDepth))
                {
                    var unmarshaller = ClientSideTimestampsUnmarshaller.Instance;
                    response.ClientSideTimestamps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("comment", targetDepth))
                {
                    var unmarshaller = CommentUnmarshaller.Instance;
                    response.Comment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("creationTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultTimeToLive", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.DefaultTimeToLive = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("encryptionSpecification", targetDepth))
                {
                    var unmarshaller = EncryptionSpecificationUnmarshaller.Instance;
                    response.EncryptionSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("keyspaceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.KeyspaceName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pointInTimeRecovery", targetDepth))
                {
                    var unmarshaller = PointInTimeRecoverySummaryUnmarshaller.Instance;
                    response.PointInTimeRecovery = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ResourceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("schemaDefinition", targetDepth))
                {
                    var unmarshaller = SchemaDefinitionUnmarshaller.Instance;
                    response.SchemaDefinition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tableName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TableName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ttl", targetDepth))
                {
                    var unmarshaller = TimeToLiveUnmarshaller.Instance;
                    response.Ttl = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceQuotaExceededException"))
                {
                    return ServiceQuotaExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonKeyspacesException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetTableResponseUnmarshaller _instance = new GetTableResponseUnmarshaller();        

        internal static GetTableResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetTableResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}