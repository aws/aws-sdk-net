/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Response Unmarshaller for DescribeTransformJob operation
    /// </summary>  
    public class DescribeTransformJobResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeTransformJobResponse response = new DescribeTransformJobResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BatchStrategy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BatchStrategy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Environment", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.Environment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FailureReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxConcurrentTransforms", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.MaxConcurrentTransforms = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxPayloadInMB", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.MaxPayloadInMB = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TransformEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.TransformEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TransformInput", targetDepth))
                {
                    var unmarshaller = TransformInputUnmarshaller.Instance;
                    response.TransformInput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TransformJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TransformJobArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TransformJobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TransformJobName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TransformJobStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TransformJobStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TransformOutput", targetDepth))
                {
                    var unmarshaller = TransformOutputUnmarshaller.Instance;
                    response.TransformOutput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TransformResources", targetDepth))
                {
                    var unmarshaller = TransformResourcesUnmarshaller.Instance;
                    response.TransformResources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TransformStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.TransformStartTime = unmarshaller.Unmarshall(context);
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
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFound"))
            {
                return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonSageMakerException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeTransformJobResponseUnmarshaller _instance = new DescribeTransformJobResponseUnmarshaller();        

        internal static DescribeTransformJobResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeTransformJobResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}