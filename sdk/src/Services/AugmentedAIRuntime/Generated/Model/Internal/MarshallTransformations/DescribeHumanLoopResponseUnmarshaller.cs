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
 * Do not modify this file. This file is generated from the sagemaker-a2i-runtime-2019-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AugmentedAIRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AugmentedAIRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeHumanLoop operation
    /// </summary>  
    public class DescribeHumanLoopResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeHumanLoopResponse response = new DescribeHumanLoopResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreationTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FailureCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FailureReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FlowDefinitionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FlowDefinitionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HumanLoopArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HumanLoopArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HumanLoopInput", targetDepth))
                {
                    var unmarshaller = HumanLoopInputContentUnmarshaller.Instance;
                    response.HumanLoopInput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HumanLoopName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HumanLoopName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HumanLoopOutput", targetDepth))
                {
                    var unmarshaller = HumanLoopOutputContentUnmarshaller.Instance;
                    response.HumanLoopOutput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HumanLoopStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HumanLoopStatus = unmarshaller.Unmarshall(context);
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
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
            {
                return new InternalServerException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
            {
                return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
            {
                return new ThrottlingException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
            {
                return new ValidationException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonAugmentedAIRuntimeException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeHumanLoopResponseUnmarshaller _instance = new DescribeHumanLoopResponseUnmarshaller();        

        internal static DescribeHumanLoopResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeHumanLoopResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}