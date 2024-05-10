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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Drs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Drs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DisconnectSourceServer operation
    /// </summary>  
    public class DisconnectSourceServerResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DisconnectSourceServerResponse response = new DisconnectSourceServerResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("agentVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AgentVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataReplicationInfo", targetDepth))
                {
                    var unmarshaller = DataReplicationInfoUnmarshaller.Instance;
                    response.DataReplicationInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastLaunchResult", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LastLaunchResult = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lifeCycle", targetDepth))
                {
                    var unmarshaller = LifeCycleUnmarshaller.Instance;
                    response.LifeCycle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("recoveryInstanceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RecoveryInstanceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("replicationDirection", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ReplicationDirection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("reversedDirectionSourceServerArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ReversedDirectionSourceServerArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceCloudProperties", targetDepth))
                {
                    var unmarshaller = SourceCloudPropertiesUnmarshaller.Instance;
                    response.SourceCloudProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceNetworkID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceNetworkID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceProperties", targetDepth))
                {
                    var unmarshaller = SourcePropertiesUnmarshaller.Instance;
                    response.SourceProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceServerID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceServerID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stagingArea", targetDepth))
                {
                    var unmarshaller = StagingAreaUnmarshaller.Instance;
                    response.StagingArea = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                {
                    return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UninitializedAccountException"))
                {
                    return UninitializedAccountExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonDrsException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DisconnectSourceServerResponseUnmarshaller _instance = new DisconnectSourceServerResponseUnmarshaller();        

        internal static DisconnectSourceServerResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DisconnectSourceServerResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}