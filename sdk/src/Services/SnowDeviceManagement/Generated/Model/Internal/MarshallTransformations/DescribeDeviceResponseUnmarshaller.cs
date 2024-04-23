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
 * Do not modify this file. This file is generated from the snow-device-management-2021-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SnowDeviceManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SnowDeviceManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeDevice operation
    /// </summary>  
    public class DescribeDeviceResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeDeviceResponse response = new DescribeDeviceResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("associatedWithJob", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssociatedWithJob = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deviceCapacities", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Capacity, CapacityUnmarshaller>(CapacityUnmarshaller.Instance);
                    response.DeviceCapacities = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deviceState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DeviceState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deviceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DeviceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastReachedOutAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastReachedOutAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastUpdatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastUpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("managedDeviceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ManagedDeviceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("managedDeviceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ManagedDeviceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("physicalNetworkInterfaces", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PhysicalNetworkInterface, PhysicalNetworkInterfaceUnmarshaller>(PhysicalNetworkInterfaceUnmarshaller.Instance);
                    response.PhysicalNetworkInterfaces = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("software", targetDepth))
                {
                    var unmarshaller = SoftwareInformationUnmarshaller.Instance;
                    response.Software = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonSnowDeviceManagementException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeDeviceResponseUnmarshaller _instance = new DescribeDeviceResponseUnmarshaller();        

        internal static DescribeDeviceResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeDeviceResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618