/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.StorageGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeGatewayInformation operation
    /// </summary>  
    public class DescribeGatewayInformationResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeGatewayInformationResponse response = new DescribeGatewayInformationResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CloudWatchLogGroupARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CloudWatchLogGroupARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Ec2InstanceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Ec2InstanceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Ec2InstanceRegion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Ec2InstanceRegion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndpointType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EndpointType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GatewayARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.GatewayARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GatewayId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.GatewayId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GatewayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.GatewayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GatewayNetworkInterfaces", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NetworkInterface, NetworkInterfaceUnmarshaller>(NetworkInterfaceUnmarshaller.Instance);
                    response.GatewayNetworkInterfaces = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GatewayState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.GatewayState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GatewayTimezone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.GatewayTimezone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GatewayType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.GatewayType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HostEnvironment", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HostEnvironment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastSoftwareUpdate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LastSoftwareUpdate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NextUpdateAvailabilityDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.NextUpdateAvailabilityDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VPCEndpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VPCEndpoint = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerError"))
                {
                    return InternalServerErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidGatewayRequestException"))
                {
                    return InvalidGatewayRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonStorageGatewayException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeGatewayInformationResponseUnmarshaller _instance = new DescribeGatewayInformationResponseUnmarshaller();        

        internal static DescribeGatewayInformationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeGatewayInformationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}