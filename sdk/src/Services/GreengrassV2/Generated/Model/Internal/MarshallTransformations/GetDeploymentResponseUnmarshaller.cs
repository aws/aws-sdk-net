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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GreengrassV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GreengrassV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetDeployment operation
    /// </summary>  
    public class GetDeploymentResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetDeploymentResponse response = new GetDeploymentResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("components", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, ComponentDeploymentSpecification, StringUnmarshaller, ComponentDeploymentSpecificationUnmarshaller>(StringUnmarshaller.Instance, ComponentDeploymentSpecificationUnmarshaller.Instance);
                    response.Components = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("creationTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deploymentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DeploymentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deploymentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DeploymentName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deploymentPolicies", targetDepth))
                {
                    var unmarshaller = DeploymentPoliciesUnmarshaller.Instance;
                    response.DeploymentPolicies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deploymentStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DeploymentStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iotJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.IotJobArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iotJobConfiguration", targetDepth))
                {
                    var unmarshaller = DeploymentIoTJobConfigurationUnmarshaller.Instance;
                    response.IotJobConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iotJobId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.IotJobId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isLatestForTarget", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.IsLatestForTarget = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("revisionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RevisionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TargetArn = unmarshaller.Unmarshall(context);
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
            return new AmazonGreengrassV2Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetDeploymentResponseUnmarshaller _instance = new GetDeploymentResponseUnmarshaller();        

        internal static GetDeploymentResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDeploymentResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}