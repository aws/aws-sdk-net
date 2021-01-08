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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MQ.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MQ.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeBroker operation
    /// </summary>  
    public class DescribeBrokerResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeBrokerResponse response = new DescribeBrokerResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("authenticationStrategy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AuthenticationStrategy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("autoMinorVersionUpgrade", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.AutoMinorVersionUpgrade = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("brokerArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BrokerArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("brokerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BrokerId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("brokerInstances", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<BrokerInstance, BrokerInstanceUnmarshaller>(BrokerInstanceUnmarshaller.Instance);
                    response.BrokerInstances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("brokerName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BrokerName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("brokerState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BrokerState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("configurations", targetDepth))
                {
                    var unmarshaller = ConfigurationsUnmarshaller.Instance;
                    response.Configurations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("created", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.Created = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deploymentMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DeploymentMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("encryptionOptions", targetDepth))
                {
                    var unmarshaller = EncryptionOptionsUnmarshaller.Instance;
                    response.EncryptionOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("engineType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EngineType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("engineVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EngineVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hostInstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HostInstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ldapServerMetadata", targetDepth))
                {
                    var unmarshaller = LdapServerMetadataOutputUnmarshaller.Instance;
                    response.LdapServerMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logs", targetDepth))
                {
                    var unmarshaller = LogsSummaryUnmarshaller.Instance;
                    response.Logs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maintenanceWindowStartTime", targetDepth))
                {
                    var unmarshaller = WeeklyStartTimeUnmarshaller.Instance;
                    response.MaintenanceWindowStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pendingAuthenticationStrategy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PendingAuthenticationStrategy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pendingEngineVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PendingEngineVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pendingHostInstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PendingHostInstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pendingLdapServerMetadata", targetDepth))
                {
                    var unmarshaller = LdapServerMetadataOutputUnmarshaller.Instance;
                    response.PendingLdapServerMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pendingSecurityGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.PendingSecurityGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("publiclyAccessible", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.PubliclyAccessible = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("securityGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.SecurityGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StorageType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("subnetIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.SubnetIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("users", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<UserSummary, UserSummaryUnmarshaller>(UserSummaryUnmarshaller.Instance);
                    response.Users = unmarshaller.Unmarshall(context);
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
            }
            return new AmazonMQException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeBrokerResponseUnmarshaller _instance = new DescribeBrokerResponseUnmarshaller();        

        internal static DescribeBrokerResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeBrokerResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}