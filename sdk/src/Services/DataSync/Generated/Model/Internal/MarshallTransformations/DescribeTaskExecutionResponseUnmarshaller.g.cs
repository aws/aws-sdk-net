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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.DataSync.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeTaskExecution operation.
    /// </summary>
    public partial class DescribeTaskExecutionResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new DescribeTaskExecutionResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("BytesCompressed", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.BytesCompressed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("BytesTransferred", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.BytesTransferred = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("BytesWritten", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.BytesWritten = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("EndTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("EstimatedBytesToTransfer", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.EstimatedBytesToTransfer = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("EstimatedFilesToDelete", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.EstimatedFilesToDelete = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("EstimatedFilesToTransfer", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.EstimatedFilesToTransfer = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("EstimatedFoldersToDelete", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.EstimatedFoldersToDelete = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("EstimatedFoldersToTransfer", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.EstimatedFoldersToTransfer = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Excludes", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<FilterRule, FilterRuleUnmarshaller>(FilterRuleUnmarshaller.Instance);
                    unmarshalledObject.Excludes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FilesDeleted", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.FilesDeleted = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FilesFailed", targetDepth, ref reader))
                {
                    var unmarshaller = TaskExecutionFilesFailedDetailUnmarshaller.Instance;
                    unmarshalledObject.FilesFailed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FilesListed", targetDepth, ref reader))
                {
                    var unmarshaller = TaskExecutionFilesListedDetailUnmarshaller.Instance;
                    unmarshalledObject.FilesListed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FilesPrepared", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.FilesPrepared = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FilesSkipped", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.FilesSkipped = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FilesTransferred", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.FilesTransferred = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FilesVerified", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.FilesVerified = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FoldersDeleted", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.FoldersDeleted = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FoldersFailed", targetDepth, ref reader))
                {
                    var unmarshaller = TaskExecutionFoldersFailedDetailUnmarshaller.Instance;
                    unmarshalledObject.FoldersFailed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FoldersListed", targetDepth, ref reader))
                {
                    var unmarshaller = TaskExecutionFoldersListedDetailUnmarshaller.Instance;
                    unmarshalledObject.FoldersListed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FoldersPrepared", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.FoldersPrepared = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FoldersSkipped", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.FoldersSkipped = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FoldersTransferred", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.FoldersTransferred = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FoldersVerified", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.FoldersVerified = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Includes", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<FilterRule, FilterRuleUnmarshaller>(FilterRuleUnmarshaller.Instance);
                    unmarshalledObject.Includes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("LaunchTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LaunchTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ManifestConfig", targetDepth, ref reader))
                {
                    var unmarshaller = ManifestConfigUnmarshaller.Instance;
                    unmarshalledObject.ManifestConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Options", targetDepth, ref reader))
                {
                    var unmarshaller = OptionsUnmarshaller.Instance;
                    unmarshalledObject.Options = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ReportResult", targetDepth, ref reader))
                {
                    var unmarshaller = ReportResultUnmarshaller.Instance;
                    unmarshalledObject.ReportResult = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Result", targetDepth, ref reader))
                {
                    var unmarshaller = TaskExecutionResultDetailUnmarshaller.Instance;
                    unmarshalledObject.Result = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("StartTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Status", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TaskExecutionArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskExecutionArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TaskMode", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TaskReportConfig", targetDepth, ref reader))
                {
                    var unmarshaller = TaskReportConfigUnmarshaller.Instance;
                    unmarshalledObject.TaskReportConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);

            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                    var readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InternalException"))
                    {
                        return InternalExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRequestException"))
                    {
                        return InvalidRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonDataSyncException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeTaskExecutionResponseUnmarshaller _instance = new DescribeTaskExecutionResponseUnmarshaller();

        internal static DescribeTaskExecutionResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeTaskExecutionResponseUnmarshaller Instance => _instance;
    }
}
