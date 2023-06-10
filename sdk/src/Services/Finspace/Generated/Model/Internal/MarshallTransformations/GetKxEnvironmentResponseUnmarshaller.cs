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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Finspace.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Finspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetKxEnvironment operation
    /// </summary>  
    public class GetKxEnvironmentResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetKxEnvironmentResponse response = new GetKxEnvironmentResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("availabilityZoneIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.AvailabilityZoneIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("awsAccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AwsAccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("certificateAuthorityArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CertificateAuthorityArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("creationTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("customDNSConfiguration", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CustomDNSServer, CustomDNSServerUnmarshaller>(CustomDNSServerUnmarshaller.Instance);
                    response.CustomDNSConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dedicatedServiceAccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DedicatedServiceAccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dnsStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DnsStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("environmentArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EnvironmentArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("environmentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EnvironmentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("errorMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ErrorMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.KmsKeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tgwStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TgwStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("transitGatewayConfiguration", targetDepth))
                {
                    var unmarshaller = TransitGatewayConfigurationUnmarshaller.Instance;
                    response.TransitGatewayConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updateTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.UpdateTimestamp = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonFinspaceException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetKxEnvironmentResponseUnmarshaller _instance = new GetKxEnvironmentResponseUnmarshaller();        

        internal static GetKxEnvironmentResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetKxEnvironmentResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}