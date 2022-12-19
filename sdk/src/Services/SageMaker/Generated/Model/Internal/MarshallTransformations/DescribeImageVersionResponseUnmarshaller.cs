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
    /// Response Unmarshaller for DescribeImageVersion operation
    /// </summary>  
    public class DescribeImageVersionResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeImageVersionResponse response = new DescribeImageVersionResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BaseImage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.BaseImage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContainerImage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ContainerImage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FailureReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Horovod", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.Horovod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImageArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ImageArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImageVersionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ImageVersionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImageVersionStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ImageVersionStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JobType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MLFramework", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MLFramework = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Processor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Processor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProgrammingLang", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ProgrammingLang = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReleaseNotes", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ReleaseNotes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VendorGuidance", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VendorGuidance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Version", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.Version = unmarshaller.Unmarshall(context);
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

        private static DescribeImageVersionResponseUnmarshaller _instance = new DescribeImageVersionResponseUnmarshaller();        

        internal static DescribeImageVersionResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeImageVersionResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}