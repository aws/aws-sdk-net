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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRoomsML.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CleanRoomsML.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetTrainedModelInferenceJob operation
    /// </summary>  
    public class GetTrainedModelInferenceJobResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetTrainedModelInferenceJobResponse response = new GetTrainedModelInferenceJobResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("configuredModelAlgorithmAssociationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConfiguredModelAlgorithmAssociationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("containerExecutionParameters", targetDepth))
                {
                    var unmarshaller = InferenceContainerExecutionParametersUnmarshaller.Instance;
                    response.ContainerExecutionParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataSource", targetDepth))
                {
                    var unmarshaller = ModelInferenceDataSourceUnmarshaller.Instance;
                    response.DataSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("environment", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.Environment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inferenceContainerImageDigest", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.InferenceContainerImageDigest = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kmsKeyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.KmsKeyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logsStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LogsStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logsStatusDetails", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LogsStatusDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("membershipIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MembershipIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metricsStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MetricsStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metricsStatusDetails", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MetricsStatusDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputConfiguration", targetDepth))
                {
                    var unmarshaller = InferenceOutputConfigurationUnmarshaller.Instance;
                    response.OutputConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceConfig", targetDepth))
                {
                    var unmarshaller = InferenceResourceConfigUnmarshaller.Instance;
                    response.ResourceConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statusDetails", targetDepth))
                {
                    var unmarshaller = StatusDetailsUnmarshaller.Instance;
                    response.StatusDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("trainedModelArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TrainedModelArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("trainedModelInferenceJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TrainedModelInferenceJobArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.UpdateTime = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonCleanRoomsMLException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetTrainedModelInferenceJobResponseUnmarshaller _instance = new GetTrainedModelInferenceJobResponseUnmarshaller();        

        internal static GetTrainedModelInferenceJobResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetTrainedModelInferenceJobResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}