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
    /// Response Unmarshaller for UpdateFunctionConfiguration operation
    /// </summary>  
    public class UpdateFunctionConfigurationResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            UpdateFunctionConfigurationResponse response = new UpdateFunctionConfigurationResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Architectures", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.Architectures = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CodeSha256", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CodeSha256 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CodeSize", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.CodeSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeadLetterConfig", targetDepth))
                {
                    var unmarshaller = DeadLetterConfigUnmarshaller.Instance;
                    response.DeadLetterConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Environment", targetDepth))
                {
                    var unmarshaller = EnvironmentResponseUnmarshaller.Instance;
                    response.Environment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EphemeralStorage", targetDepth))
                {
                    var unmarshaller = EphemeralStorageUnmarshaller.Instance;
                    response.EphemeralStorage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FileSystemConfigs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FileSystemConfig, FileSystemConfigUnmarshaller>(FileSystemConfigUnmarshaller.Instance);
                    response.FileSystemConfigs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FunctionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FunctionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FunctionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FunctionName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Handler", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Handler = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImageConfigResponse", targetDepth))
                {
                    var unmarshaller = ImageConfigResponseUnmarshaller.Instance;
                    response.ImageConfigResponse = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KMSKeyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.KMSKeyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModified", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LastModified = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdateStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LastUpdateStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdateStatusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LastUpdateStatusReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdateStatusReasonCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LastUpdateStatusReasonCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Layers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Layer, LayerUnmarshaller>(LayerUnmarshaller.Instance);
                    response.Layers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MasterArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MasterArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MemorySize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.MemorySize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PackageType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PackageType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RevisionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RevisionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Role", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Role = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Runtime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Runtime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RuntimeVersionConfig", targetDepth))
                {
                    var unmarshaller = RuntimeVersionConfigUnmarshaller.Instance;
                    response.RuntimeVersionConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SigningJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SigningJobArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SigningProfileVersionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SigningProfileVersionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnapStart", targetDepth))
                {
                    var unmarshaller = SnapStartResponseUnmarshaller.Instance;
                    response.SnapStart = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StateReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StateReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StateReasonCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StateReasonCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Timeout", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.Timeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TracingConfig", targetDepth))
                {
                    var unmarshaller = TracingConfigResponseUnmarshaller.Instance;
                    response.TracingConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Version", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Version = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcConfig", targetDepth))
                {
                    var unmarshaller = VpcConfigDetailUnmarshaller.Instance;
                    response.VpcConfig = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("CodeSigningConfigNotFoundException"))
                {
                    return CodeSigningConfigNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("CodeVerificationFailedException"))
                {
                    return CodeVerificationFailedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidCodeSignatureException"))
                {
                    return InvalidCodeSignatureExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValueException"))
                {
                    return InvalidParameterValueExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("PreconditionFailedException"))
                {
                    return PreconditionFailedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceConflictException"))
                {
                    return ResourceConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
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

        private static UpdateFunctionConfigurationResponseUnmarshaller _instance = new UpdateFunctionConfigurationResponseUnmarshaller();        

        internal static UpdateFunctionConfigurationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFunctionConfigurationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}