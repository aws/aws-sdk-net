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
    /// Response Unmarshaller for DescribeAlgorithm operation
    /// </summary>  
    public class DescribeAlgorithmResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeAlgorithmResponse response = new DescribeAlgorithmResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AlgorithmArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AlgorithmArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AlgorithmDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AlgorithmDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AlgorithmName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AlgorithmName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AlgorithmStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AlgorithmStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AlgorithmStatusDetails", targetDepth))
                {
                    var unmarshaller = AlgorithmStatusDetailsUnmarshaller.Instance;
                    response.AlgorithmStatusDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CertifyForMarketplace", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.CertifyForMarketplace = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InferenceSpecification", targetDepth))
                {
                    var unmarshaller = InferenceSpecificationUnmarshaller.Instance;
                    response.InferenceSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProductId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ProductId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingSpecification", targetDepth))
                {
                    var unmarshaller = TrainingSpecificationUnmarshaller.Instance;
                    response.TrainingSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ValidationSpecification", targetDepth))
                {
                    var unmarshaller = AlgorithmValidationSpecificationUnmarshaller.Instance;
                    response.ValidationSpecification = unmarshaller.Unmarshall(context);
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
            }
            return new AmazonSageMakerException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeAlgorithmResponseUnmarshaller _instance = new DescribeAlgorithmResponseUnmarshaller();        

        internal static DescribeAlgorithmResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAlgorithmResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}