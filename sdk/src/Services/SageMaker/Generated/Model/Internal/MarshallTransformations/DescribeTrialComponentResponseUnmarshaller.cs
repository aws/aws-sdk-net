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
    /// Response Unmarshaller for DescribeTrialComponent operation
    /// </summary>  
    public class DescribeTrialComponentResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeTrialComponentResponse response = new DescribeTrialComponentResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreatedBy", targetDepth))
                {
                    var unmarshaller = UserContextUnmarshaller.Instance;
                    response.CreatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DisplayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DisplayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.EndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputArtifacts", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, TrialComponentArtifact, StringUnmarshaller, TrialComponentArtifactUnmarshaller>(StringUnmarshaller.Instance, TrialComponentArtifactUnmarshaller.Instance);
                    response.InputArtifacts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedBy", targetDepth))
                {
                    var unmarshaller = UserContextUnmarshaller.Instance;
                    response.LastModifiedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LineageGroupArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LineageGroupArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetadataProperties", targetDepth))
                {
                    var unmarshaller = MetadataPropertiesUnmarshaller.Instance;
                    response.MetadataProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Metrics", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TrialComponentMetricSummary, TrialComponentMetricSummaryUnmarshaller>(TrialComponentMetricSummaryUnmarshaller.Instance);
                    response.Metrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputArtifacts", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, TrialComponentArtifact, StringUnmarshaller, TrialComponentArtifactUnmarshaller>(StringUnmarshaller.Instance, TrialComponentArtifactUnmarshaller.Instance);
                    response.OutputArtifacts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Parameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, TrialComponentParameterValue, StringUnmarshaller, TrialComponentParameterValueUnmarshaller>(StringUnmarshaller.Instance, TrialComponentParameterValueUnmarshaller.Instance);
                    response.Parameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Source", targetDepth))
                {
                    var unmarshaller = TrialComponentSourceUnmarshaller.Instance;
                    response.Source = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Sources", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TrialComponentSource, TrialComponentSourceUnmarshaller>(TrialComponentSourceUnmarshaller.Instance);
                    response.Sources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.StartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = TrialComponentStatusUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrialComponentArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TrialComponentArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrialComponentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TrialComponentName = unmarshaller.Unmarshall(context);
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

        private static DescribeTrialComponentResponseUnmarshaller _instance = new DescribeTrialComponentResponseUnmarshaller();        

        internal static DescribeTrialComponentResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeTrialComponentResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}