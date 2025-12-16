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
 * Do not modify this file. This file is generated from the timestream-influxdb-2023-01-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamInfluxDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.TimestreamInfluxDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RebootDbInstance operation
    /// </summary>  
    public class RebootDbInstanceResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            RebootDbInstanceResponse response = new RebootDbInstanceResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("allocatedStorage", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.AllocatedStorage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("availabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AvailabilityZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dbClusterId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DbClusterId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dbInstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DbInstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dbParameterGroupIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DbParameterGroupIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dbStorageType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DbStorageType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deploymentType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DeploymentType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("endpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Endpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("influxAuthParametersSecretArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.InfluxAuthParametersSecretArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instanceMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.InstanceMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instanceModes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.InstanceModes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logDeliveryConfiguration", targetDepth))
                {
                    var unmarshaller = LogDeliveryConfigurationUnmarshaller.Instance;
                    response.LogDeliveryConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networkType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.NetworkType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("port", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.Port = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("publiclyAccessible", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.PubliclyAccessible = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("secondaryAvailabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SecondaryAvailabilityZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vpcSecurityGroupIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.VpcSecurityGroupIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vpcSubnetIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.VpcSubnetIds = unmarshaller.Unmarshall(context);
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
            return new AmazonTimestreamInfluxDBException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static RebootDbInstanceResponseUnmarshaller _instance = new RebootDbInstanceResponseUnmarshaller();        

        internal static RebootDbInstanceResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RebootDbInstanceResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}