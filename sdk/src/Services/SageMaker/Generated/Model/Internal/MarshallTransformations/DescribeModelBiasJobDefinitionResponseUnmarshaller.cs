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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeModelBiasJobDefinition operation
    /// </summary>  
    public class DescribeModelBiasJobDefinitionResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeModelBiasJobDefinitionResponse response = new DescribeModelBiasJobDefinitionResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JobDefinitionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobDefinitionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JobDefinitionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobDefinitionName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JobResources", targetDepth))
                {
                    var unmarshaller = MonitoringResourcesUnmarshaller.Instance;
                    response.JobResources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelBiasAppSpecification", targetDepth))
                {
                    var unmarshaller = ModelBiasAppSpecificationUnmarshaller.Instance;
                    response.ModelBiasAppSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelBiasBaselineConfig", targetDepth))
                {
                    var unmarshaller = ModelBiasBaselineConfigUnmarshaller.Instance;
                    response.ModelBiasBaselineConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelBiasJobInput", targetDepth))
                {
                    var unmarshaller = ModelBiasJobInputUnmarshaller.Instance;
                    response.ModelBiasJobInput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelBiasJobOutputConfig", targetDepth))
                {
                    var unmarshaller = MonitoringOutputConfigUnmarshaller.Instance;
                    response.ModelBiasJobOutputConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkConfig", targetDepth))
                {
                    var unmarshaller = MonitoringNetworkConfigUnmarshaller.Instance;
                    response.NetworkConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StoppingCondition", targetDepth))
                {
                    var unmarshaller = MonitoringStoppingConditionUnmarshaller.Instance;
                    response.StoppingCondition = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFound"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonSageMakerException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeModelBiasJobDefinitionResponseUnmarshaller _instance = new DescribeModelBiasJobDefinitionResponseUnmarshaller();        

        internal static DescribeModelBiasJobDefinitionResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeModelBiasJobDefinitionResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}