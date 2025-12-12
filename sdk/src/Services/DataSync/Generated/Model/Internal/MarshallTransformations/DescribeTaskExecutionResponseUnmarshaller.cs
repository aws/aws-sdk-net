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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeTaskExecution operation
    /// </summary>  
    public class DescribeTaskExecutionResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeTaskExecutionResponse response = new DescribeTaskExecutionResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BytesCompressed", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.BytesCompressed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BytesTransferred", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.BytesTransferred = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BytesWritten", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.BytesWritten = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.EndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedBytesToTransfer", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.EstimatedBytesToTransfer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedFilesToDelete", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.EstimatedFilesToDelete = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedFilesToTransfer", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.EstimatedFilesToTransfer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedFoldersToDelete", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.EstimatedFoldersToDelete = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedFoldersToTransfer", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.EstimatedFoldersToTransfer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Excludes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FilterRule, FilterRuleUnmarshaller>(FilterRuleUnmarshaller.Instance);
                    response.Excludes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilesDeleted", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.FilesDeleted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilesFailed", targetDepth))
                {
                    var unmarshaller = TaskExecutionFilesFailedDetailUnmarshaller.Instance;
                    response.FilesFailed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilesListed", targetDepth))
                {
                    var unmarshaller = TaskExecutionFilesListedDetailUnmarshaller.Instance;
                    response.FilesListed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilesPrepared", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.FilesPrepared = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilesSkipped", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.FilesSkipped = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilesTransferred", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.FilesTransferred = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilesVerified", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.FilesVerified = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FoldersDeleted", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.FoldersDeleted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FoldersFailed", targetDepth))
                {
                    var unmarshaller = TaskExecutionFoldersFailedDetailUnmarshaller.Instance;
                    response.FoldersFailed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FoldersListed", targetDepth))
                {
                    var unmarshaller = TaskExecutionFoldersListedDetailUnmarshaller.Instance;
                    response.FoldersListed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FoldersPrepared", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.FoldersPrepared = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FoldersSkipped", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.FoldersSkipped = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FoldersTransferred", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.FoldersTransferred = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FoldersVerified", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.FoldersVerified = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Includes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FilterRule, FilterRuleUnmarshaller>(FilterRuleUnmarshaller.Instance);
                    response.Includes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LaunchTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LaunchTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ManifestConfig", targetDepth))
                {
                    var unmarshaller = ManifestConfigUnmarshaller.Instance;
                    response.ManifestConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Options", targetDepth))
                {
                    var unmarshaller = OptionsUnmarshaller.Instance;
                    response.Options = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReportResult", targetDepth))
                {
                    var unmarshaller = ReportResultUnmarshaller.Instance;
                    response.ReportResult = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Result", targetDepth))
                {
                    var unmarshaller = TaskExecutionResultDetailUnmarshaller.Instance;
                    response.Result = unmarshaller.Unmarshall(context);
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
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskExecutionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TaskExecutionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TaskMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskReportConfig", targetDepth))
                {
                    var unmarshaller = TaskReportConfigUnmarshaller.Instance;
                    response.TaskReportConfig = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalException"))
                {
                    return InternalExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRequestException"))
                {
                    return InvalidRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonDataSyncException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeTaskExecutionResponseUnmarshaller _instance = new DescribeTaskExecutionResponseUnmarshaller();        

        internal static DescribeTaskExecutionResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeTaskExecutionResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}