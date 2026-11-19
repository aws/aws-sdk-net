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
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeTaskExecution operation.
    /// </summary>
    public partial class DescribeTaskExecutionResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new DescribeTaskExecutionResponse();
            var reader = context.Reader;

            context.AddPathSegment("DescribeTaskExecution");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "BytesCompressed":
                        context.AddPathSegment("BytesCompressed");
                        unmarshalledObject.BytesCompressed = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "BytesTransferred":
                        context.AddPathSegment("BytesTransferred");
                        unmarshalledObject.BytesTransferred = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "BytesWritten":
                        context.AddPathSegment("BytesWritten");
                        unmarshalledObject.BytesWritten = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EndTime":
                        context.AddPathSegment("EndTime");
                        unmarshalledObject.EndTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EstimatedBytesToTransfer":
                        context.AddPathSegment("EstimatedBytesToTransfer");
                        unmarshalledObject.EstimatedBytesToTransfer = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EstimatedFilesToDelete":
                        context.AddPathSegment("EstimatedFilesToDelete");
                        unmarshalledObject.EstimatedFilesToDelete = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EstimatedFilesToTransfer":
                        context.AddPathSegment("EstimatedFilesToTransfer");
                        unmarshalledObject.EstimatedFilesToTransfer = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EstimatedFoldersToDelete":
                        context.AddPathSegment("EstimatedFoldersToDelete");
                        unmarshalledObject.EstimatedFoldersToDelete = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EstimatedFoldersToTransfer":
                        context.AddPathSegment("EstimatedFoldersToTransfer");
                        unmarshalledObject.EstimatedFoldersToTransfer = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Excludes":
                        context.AddPathSegment("Excludes");
                        unmarshalledObject.Excludes = new CborListUnmarshaller<FilterRule, FilterRuleUnmarshaller>(FilterRuleUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FilesDeleted":
                        context.AddPathSegment("FilesDeleted");
                        unmarshalledObject.FilesDeleted = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FilesFailed":
                        context.AddPathSegment("FilesFailed");
                        unmarshalledObject.FilesFailed = TaskExecutionFilesFailedDetailUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FilesListed":
                        context.AddPathSegment("FilesListed");
                        unmarshalledObject.FilesListed = TaskExecutionFilesListedDetailUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FilesPrepared":
                        context.AddPathSegment("FilesPrepared");
                        unmarshalledObject.FilesPrepared = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FilesSkipped":
                        context.AddPathSegment("FilesSkipped");
                        unmarshalledObject.FilesSkipped = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FilesTransferred":
                        context.AddPathSegment("FilesTransferred");
                        unmarshalledObject.FilesTransferred = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FilesVerified":
                        context.AddPathSegment("FilesVerified");
                        unmarshalledObject.FilesVerified = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FoldersDeleted":
                        context.AddPathSegment("FoldersDeleted");
                        unmarshalledObject.FoldersDeleted = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FoldersFailed":
                        context.AddPathSegment("FoldersFailed");
                        unmarshalledObject.FoldersFailed = TaskExecutionFoldersFailedDetailUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FoldersListed":
                        context.AddPathSegment("FoldersListed");
                        unmarshalledObject.FoldersListed = TaskExecutionFoldersListedDetailUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FoldersPrepared":
                        context.AddPathSegment("FoldersPrepared");
                        unmarshalledObject.FoldersPrepared = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FoldersSkipped":
                        context.AddPathSegment("FoldersSkipped");
                        unmarshalledObject.FoldersSkipped = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FoldersTransferred":
                        context.AddPathSegment("FoldersTransferred");
                        unmarshalledObject.FoldersTransferred = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FoldersVerified":
                        context.AddPathSegment("FoldersVerified");
                        unmarshalledObject.FoldersVerified = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Includes":
                        context.AddPathSegment("Includes");
                        unmarshalledObject.Includes = new CborListUnmarshaller<FilterRule, FilterRuleUnmarshaller>(FilterRuleUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LaunchTime":
                        context.AddPathSegment("LaunchTime");
                        unmarshalledObject.LaunchTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ManifestConfig":
                        context.AddPathSegment("ManifestConfig");
                        unmarshalledObject.ManifestConfig = ManifestConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Options":
                        context.AddPathSegment("Options");
                        unmarshalledObject.Options = OptionsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ReportResult":
                        context.AddPathSegment("ReportResult");
                        unmarshalledObject.ReportResult = ReportResultUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Result":
                        context.AddPathSegment("Result");
                        unmarshalledObject.Result = TaskExecutionResultDetailUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StartTime":
                        context.AddPathSegment("StartTime");
                        unmarshalledObject.StartTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Status":
                        context.AddPathSegment("Status");
                        unmarshalledObject.Status = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TaskExecutionArn":
                        context.AddPathSegment("TaskExecutionArn");
                        unmarshalledObject.TaskExecutionArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TaskMode":
                        context.AddPathSegment("TaskMode");
                        unmarshalledObject.TaskMode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TaskReportConfig":
                        context.AddPathSegment("TaskReportConfig");
                        unmarshalledObject.TaskReportConfig = TaskReportConfigUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            context.PopPathSegment();

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(CborUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = CborErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new CborUnmarshallerContext(streamCopy, false, context.ResponseData))
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
