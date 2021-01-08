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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetLayerVersionByArn operation
    /// </summary>  
    public class GetLayerVersionByArnResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetLayerVersionByArnResponse response = new GetLayerVersionByArnResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CompatibleRuntimes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.CompatibleRuntimes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Content", targetDepth))
                {
                    var unmarshaller = LayerVersionContentOutputUnmarshaller.Instance;
                    response.Content = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CreatedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LayerArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LayerArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LayerVersionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LayerVersionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LicenseInfo", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LicenseInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Version", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.Version = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValueException"))
                {
                    return InvalidParameterValueExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceException"))
                {
                    return ServiceExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
                {
                    return TooManyRequestsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonLambdaException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetLayerVersionByArnResponseUnmarshaller _instance = new GetLayerVersionByArnResponseUnmarshaller();        

        internal static GetLayerVersionByArnResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetLayerVersionByArnResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}