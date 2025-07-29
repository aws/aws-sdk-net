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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeServiceJob operation
    /// </summary>  
    public class DescribeServiceJobResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeServiceJobResponse response = new DescribeServiceJobResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("attempts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ServiceJobAttemptDetail, ServiceJobAttemptDetailUnmarshaller>(ServiceJobAttemptDetailUnmarshaller.Instance);
                    response.Attempts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isTerminated", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.IsTerminated = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobQueue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobQueue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("latestAttempt", targetDepth))
                {
                    var unmarshaller = LatestServiceJobAttemptUnmarshaller.Instance;
                    response.LatestAttempt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("retryStrategy", targetDepth))
                {
                    var unmarshaller = ServiceJobRetryStrategyUnmarshaller.Instance;
                    response.RetryStrategy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("schedulingPriority", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.SchedulingPriority = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceJobType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ServiceJobType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceRequestPayload", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ServiceRequestPayload = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shareIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ShareIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startedAt", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.StartedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StatusReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stoppedAt", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.StoppedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeoutConfig", targetDepth))
                {
                    var unmarshaller = ServiceJobTimeoutUnmarshaller.Instance;
                    response.TimeoutConfig = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ClientException"))
                {
                    return ClientExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServerException"))
                {
                    return ServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonBatchException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeServiceJobResponseUnmarshaller _instance = new DescribeServiceJobResponseUnmarshaller();        

        internal static DescribeServiceJobResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeServiceJobResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}