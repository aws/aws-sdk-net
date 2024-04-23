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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EntityResolution.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.EntityResolution.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetProviderService operation
    /// </summary>  
    public class GetProviderServiceResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetProviderServiceResponse response = new GetProviderServiceResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("anonymizedOutput", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.AnonymizedOutput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("providerComponentSchema", targetDepth))
                {
                    var unmarshaller = ProviderComponentSchemaUnmarshaller.Instance;
                    response.ProviderComponentSchema = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("providerConfigurationDefinition", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    response.ProviderConfigurationDefinition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("providerEndpointConfiguration", targetDepth))
                {
                    var unmarshaller = ProviderEndpointConfigurationUnmarshaller.Instance;
                    response.ProviderEndpointConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("providerEntityOutputDefinition", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    response.ProviderEntityOutputDefinition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("providerIdNameSpaceConfiguration", targetDepth))
                {
                    var unmarshaller = ProviderIdNameSpaceConfigurationUnmarshaller.Instance;
                    response.ProviderIdNameSpaceConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("providerIntermediateDataAccessConfiguration", targetDepth))
                {
                    var unmarshaller = ProviderIntermediateDataAccessConfigurationUnmarshaller.Instance;
                    response.ProviderIntermediateDataAccessConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("providerJobConfiguration", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    response.ProviderJobConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("providerName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ProviderName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("providerServiceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ProviderServiceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("providerServiceDisplayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ProviderServiceDisplayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("providerServiceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ProviderServiceName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("providerServiceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ProviderServiceType = unmarshaller.Unmarshall(context);
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
            return new AmazonEntityResolutionException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetProviderServiceResponseUnmarshaller _instance = new GetProviderServiceResponseUnmarshaller();        

        internal static GetProviderServiceResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetProviderServiceResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618