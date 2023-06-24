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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTTwinMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTTwinMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetComponentType operation
    /// </summary>  
    public class GetComponentTypeResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetComponentTypeResponse response = new GetComponentTypeResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("componentTypeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ComponentTypeId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("componentTypeName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ComponentTypeName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("creationDateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("extendsFrom", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.ExtendsFrom = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("functions", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, FunctionResponse, StringUnmarshaller, FunctionResponseUnmarshaller>(StringUnmarshaller.Instance, FunctionResponseUnmarshaller.Instance);
                    response.Functions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isAbstract", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.IsAbstract = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isSchemaInitialized", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.IsSchemaInitialized = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isSingleton", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.IsSingleton = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("propertyDefinitions", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, PropertyDefinitionResponse, StringUnmarshaller, PropertyDefinitionResponseUnmarshaller>(StringUnmarshaller.Instance, PropertyDefinitionResponseUnmarshaller.Instance);
                    response.PropertyDefinitions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("propertyGroups", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, PropertyGroupResponse, StringUnmarshaller, PropertyGroupResponseUnmarshaller>(StringUnmarshaller.Instance, PropertyGroupResponseUnmarshaller.Instance);
                    response.PropertyGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StatusUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("syncSource", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SyncSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updateDateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.UpdateDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("workspaceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.WorkspaceId = unmarshaller.Unmarshall(context);
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
            return new AmazonIoTTwinMakerException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetComponentTypeResponseUnmarshaller _instance = new GetComponentTypeResponseUnmarshaller();        

        internal static GetComponentTypeResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetComponentTypeResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}