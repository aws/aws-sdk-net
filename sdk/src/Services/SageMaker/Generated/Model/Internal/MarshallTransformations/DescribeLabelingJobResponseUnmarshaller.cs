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
    /// Response Unmarshaller for DescribeLabelingJob operation
    /// </summary>  
    public class DescribeLabelingJobResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeLabelingJobResponse response = new DescribeLabelingJobResponse();

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
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FailureReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HumanTaskConfig", targetDepth))
                {
                    var unmarshaller = HumanTaskConfigUnmarshaller.Instance;
                    response.HumanTaskConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputConfig", targetDepth))
                {
                    var unmarshaller = LabelingJobInputConfigUnmarshaller.Instance;
                    response.InputConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JobReferenceCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobReferenceCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelAttributeName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LabelAttributeName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelCategoryConfigS3Uri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LabelCategoryConfigS3Uri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelCounters", targetDepth))
                {
                    var unmarshaller = LabelCountersUnmarshaller.Instance;
                    response.LabelCounters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelingJobAlgorithmsConfig", targetDepth))
                {
                    var unmarshaller = LabelingJobAlgorithmsConfigUnmarshaller.Instance;
                    response.LabelingJobAlgorithmsConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelingJobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LabelingJobArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelingJobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LabelingJobName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelingJobOutput", targetDepth))
                {
                    var unmarshaller = LabelingJobOutputUnmarshaller.Instance;
                    response.LabelingJobOutput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelingJobStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LabelingJobStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputConfig", targetDepth))
                {
                    var unmarshaller = LabelingJobOutputConfigUnmarshaller.Instance;
                    response.OutputConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StoppingConditions", targetDepth))
                {
                    var unmarshaller = LabelingJobStoppingConditionsUnmarshaller.Instance;
                    response.StoppingConditions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context);
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

        private static DescribeLabelingJobResponseUnmarshaller _instance = new DescribeLabelingJobResponseUnmarshaller();        

        internal static DescribeLabelingJobResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeLabelingJobResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}