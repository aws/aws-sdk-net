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
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeGatewayInformationResponse response = new DescribeGatewayInformationResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
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
            }

            return response;
        }

        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerError"))
            {
                return new InternalServerErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidGatewayRequestException"))
            {
                return new InvalidGatewayRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonStorageGatewayException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeGatewayInformationResponseUnmarshaller _instance = new DescribeGatewayInformationResponseUnmarshaller();        

        internal static DescribeGatewayInformationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static DescribeGatewayInformationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}