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
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
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
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Arn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("componentTypeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ComponentTypeId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("componentTypeName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ComponentTypeName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("compositeComponentTypes", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, CompositeComponentTypeResponse, StringUnmarshaller, CompositeComponentTypeResponseUnmarshaller>(StringUnmarshaller.Instance, CompositeComponentTypeResponseUnmarshaller.Instance);
                    response.CompositeComponentTypes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("creationDateTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.CreationDateTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("extendsFrom", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.ExtendsFrom = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("functions", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, FunctionResponse, StringUnmarshaller, FunctionResponseUnmarshaller>(StringUnmarshaller.Instance, FunctionResponseUnmarshaller.Instance);
                    response.Functions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isAbstract", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    response.IsAbstract = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isSchemaInitialized", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    response.IsSchemaInitialized = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isSingleton", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    response.IsSingleton = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("propertyDefinitions", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, PropertyDefinitionResponse, StringUnmarshaller, PropertyDefinitionResponseUnmarshaller>(StringUnmarshaller.Instance, PropertyDefinitionResponseUnmarshaller.Instance);
                    response.PropertyDefinitions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("propertyGroups", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, PropertyGroupResponse, StringUnmarshaller, PropertyGroupResponseUnmarshaller>(StringUnmarshaller.Instance, PropertyGroupResponseUnmarshaller.Instance);
                    response.PropertyGroups = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StatusUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("syncSource", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SyncSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("updateDateTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.UpdateDateTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("workspaceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.WorkspaceId = unmarshaller.Unmarshall(context, ref reader);
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
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy);
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
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