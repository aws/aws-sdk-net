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
    /// Response Unmarshaller for DescribeAutoMLJobV2 operation
    /// </summary>  
    public class DescribeAutoMLJobV2ResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeAutoMLJobV2Response response = new DescribeAutoMLJobV2Response();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AutoMLJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AutoMLJobArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoMLJobInputDataConfig", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AutoMLJobChannel, AutoMLJobChannelUnmarshaller>(AutoMLJobChannelUnmarshaller.Instance);
                    response.AutoMLJobInputDataConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoMLJobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AutoMLJobName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoMLJobObjective", targetDepth))
                {
                    var unmarshaller = AutoMLJobObjectiveUnmarshaller.Instance;
                    response.AutoMLJobObjective = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoMLJobSecondaryStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AutoMLJobSecondaryStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoMLJobStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AutoMLJobStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoMLProblemTypeConfig", targetDepth))
                {
                    var unmarshaller = AutoMLProblemTypeConfigUnmarshaller.Instance;
                    response.AutoMLProblemTypeConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BestCandidate", targetDepth))
                {
                    var unmarshaller = AutoMLCandidateUnmarshaller.Instance;
                    response.BestCandidate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataSplitConfig", targetDepth))
                {
                    var unmarshaller = AutoMLDataSplitConfigUnmarshaller.Instance;
                    response.DataSplitConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.EndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FailureReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelDeployConfig", targetDepth))
                {
                    var unmarshaller = ModelDeployConfigUnmarshaller.Instance;
                    response.ModelDeployConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelDeployResult", targetDepth))
                {
                    var unmarshaller = ModelDeployResultUnmarshaller.Instance;
                    response.ModelDeployResult = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputDataConfig", targetDepth))
                {
                    var unmarshaller = AutoMLOutputDataConfigUnmarshaller.Instance;
                    response.OutputDataConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PartialFailureReasons", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AutoMLPartialFailureReason, AutoMLPartialFailureReasonUnmarshaller>(AutoMLPartialFailureReasonUnmarshaller.Instance);
                    response.PartialFailureReasons = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityConfig", targetDepth))
                {
                    var unmarshaller = AutoMLSecurityConfigUnmarshaller.Instance;
                    response.SecurityConfig = unmarshaller.Unmarshall(context);
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

        private static DescribeAutoMLJobV2ResponseUnmarshaller _instance = new DescribeAutoMLJobV2ResponseUnmarshaller();        

        internal static DescribeAutoMLJobV2ResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAutoMLJobV2ResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}