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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeConnectionType operation
    /// </summary>  
    public class DescribeConnectionTypeResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeConnectionTypeResponse response = new DescribeConnectionTypeResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AthenaConnectionProperties", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, Property, StringUnmarshaller, PropertyUnmarshaller>(StringUnmarshaller.Instance, PropertyUnmarshaller.Instance);
                    response.AthenaConnectionProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AuthenticationConfiguration", targetDepth))
                {
                    var unmarshaller = AuthConfigurationUnmarshaller.Instance;
                    response.AuthenticationConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Capabilities", targetDepth))
                {
                    var unmarshaller = CapabilitiesUnmarshaller.Instance;
                    response.Capabilities = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ComputeEnvironmentConfigurations", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, ComputeEnvironmentConfiguration, StringUnmarshaller, ComputeEnvironmentConfigurationUnmarshaller>(StringUnmarshaller.Instance, ComputeEnvironmentConfigurationUnmarshaller.Instance);
                    response.ComputeEnvironmentConfigurations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ConnectionOptions", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, Property, StringUnmarshaller, PropertyUnmarshaller>(StringUnmarshaller.Instance, PropertyUnmarshaller.Instance);
                    response.ConnectionOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ConnectionProperties", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, Property, StringUnmarshaller, PropertyUnmarshaller>(StringUnmarshaller.Instance, PropertyUnmarshaller.Instance);
                    response.ConnectionProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ConnectionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConnectionType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PhysicalConnectionRequirements", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, Property, StringUnmarshaller, PropertyUnmarshaller>(StringUnmarshaller.Instance, PropertyUnmarshaller.Instance);
                    response.PhysicalConnectionRequirements = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PythonConnectionProperties", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, Property, StringUnmarshaller, PropertyUnmarshaller>(StringUnmarshaller.Instance, PropertyUnmarshaller.Instance);
                    response.PythonConnectionProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SparkConnectionProperties", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, Property, StringUnmarshaller, PropertyUnmarshaller>(StringUnmarshaller.Instance, PropertyUnmarshaller.Instance);
                    response.SparkConnectionProperties = unmarshaller.Unmarshall(context, ref reader);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServiceException"))
                {
                    return InternalServiceExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidInputException"))
                {
                    return InvalidInputExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonGlueException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeConnectionTypeResponseUnmarshaller _instance = new DescribeConnectionTypeResponseUnmarshaller();        

        internal static DescribeConnectionTypeResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeConnectionTypeResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}