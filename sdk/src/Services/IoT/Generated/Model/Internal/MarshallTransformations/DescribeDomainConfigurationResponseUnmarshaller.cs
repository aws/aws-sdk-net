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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeDomainConfiguration operation
    /// </summary>  
    public class DescribeDomainConfigurationResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeDomainConfigurationResponse response = new DescribeDomainConfigurationResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("authorizerConfig", targetDepth))
                {
                    var unmarshaller = AuthorizerConfigUnmarshaller.Instance;
                    response.AuthorizerConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("domainConfigurationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DomainConfigurationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("domainConfigurationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DomainConfigurationName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("domainConfigurationStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DomainConfigurationStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("domainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DomainName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("domainType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DomainType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serverCertificates", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ServerCertificateSummary, ServerCertificateSummaryUnmarshaller>(ServerCertificateSummaryUnmarshaller.Instance);
                    response.ServerCertificates = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ServiceType = unmarshaller.Unmarshall(context);
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
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalFailureException"))
            {
                return new InternalFailureException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
            {
                return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceUnavailableException"))
            {
                return new ServiceUnavailableException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
            {
                return new ThrottlingException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("UnauthorizedException"))
            {
                return new UnauthorizedException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonIoTException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeDomainConfigurationResponseUnmarshaller _instance = new DescribeDomainConfigurationResponseUnmarshaller();        

        internal static DescribeDomainConfigurationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeDomainConfigurationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}