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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KafkaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.KafkaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeConnector operation
    /// </summary>  
    public class DescribeConnectorResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeConnectorResponse response = new DescribeConnectorResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("capacity", targetDepth))
                {
                    var unmarshaller = CapacityDescriptionUnmarshaller.Instance;
                    response.Capacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConnectorArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorConfiguration", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.ConnectorConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConnectorDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConnectorName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectorState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConnectorState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("creationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("currentVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CurrentVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kafkaCluster", targetDepth))
                {
                    var unmarshaller = KafkaClusterDescriptionUnmarshaller.Instance;
                    response.KafkaCluster = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kafkaClusterClientAuthentication", targetDepth))
                {
                    var unmarshaller = KafkaClusterClientAuthenticationDescriptionUnmarshaller.Instance;
                    response.KafkaClusterClientAuthentication = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kafkaClusterEncryptionInTransit", targetDepth))
                {
                    var unmarshaller = KafkaClusterEncryptionInTransitDescriptionUnmarshaller.Instance;
                    response.KafkaClusterEncryptionInTransit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kafkaConnectVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.KafkaConnectVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logDelivery", targetDepth))
                {
                    var unmarshaller = LogDeliveryDescriptionUnmarshaller.Instance;
                    response.LogDelivery = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networkType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.NetworkType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("plugins", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PluginDescription, PluginDescriptionUnmarshaller>(PluginDescriptionUnmarshaller.Instance);
                    response.Plugins = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceExecutionRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ServiceExecutionRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stateDescription", targetDepth))
                {
                    var unmarshaller = StateDescriptionUnmarshaller.Instance;
                    response.StateDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("workerConfiguration", targetDepth))
                {
                    var unmarshaller = WorkerConfigurationDescriptionUnmarshaller.Instance;
                    response.WorkerConfiguration = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
                {
                    return BadRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ForbiddenException"))
                {
                    return ForbiddenExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerErrorException"))
                {
                    return InternalServerErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NotFoundException"))
                {
                    return NotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceUnavailableException"))
                {
                    return ServiceUnavailableExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
                {
                    return TooManyRequestsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UnauthorizedException"))
                {
                    return UnauthorizedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonKafkaConnectException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeConnectorResponseUnmarshaller _instance = new DescribeConnectorResponseUnmarshaller();        

        internal static DescribeConnectorResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeConnectorResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}