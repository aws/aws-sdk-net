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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.APIGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateDomainName operation
    /// </summary>  
    public class CreateDomainNameResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            CreateDomainNameResponse response = new CreateDomainNameResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("certificateArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CertificateArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("certificateName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CertificateName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("certificateUploadDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CertificateUploadDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("distributionDomainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DistributionDomainName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("distributionHostedZoneId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DistributionHostedZoneId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("domainNameStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DomainNameStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("domainNameStatusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DomainNameStatusMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("endpointConfiguration", targetDepth))
                {
                    var unmarshaller = EndpointConfigurationUnmarshaller.Instance;
                    response.EndpointConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mutualTlsAuthentication", targetDepth))
                {
                    var unmarshaller = MutualTlsAuthenticationUnmarshaller.Instance;
                    response.MutualTlsAuthentication = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("domainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("regionalCertificateArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RegionalCertificateArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("regionalCertificateName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RegionalCertificateName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("regionalDomainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RegionalDomainName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("regionalHostedZoneId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RegionalHostedZoneId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("securityPolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SecurityPolicy = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
                {
                    return BadRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                {
                    return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
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
            return new AmazonAPIGatewayException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static CreateDomainNameResponseUnmarshaller _instance = new CreateDomainNameResponseUnmarshaller();        

        internal static CreateDomainNameResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDomainNameResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}