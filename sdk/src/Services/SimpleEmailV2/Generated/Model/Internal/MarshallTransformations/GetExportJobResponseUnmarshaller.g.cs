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

using Amazon.SimpleEmailV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetExportJob operation.
    /// </summary>
    public partial class GetExportJobResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new GetExportJobResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CompletedTimestamp", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CompletedTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("CreatedTimestamp", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ExportDataSource", targetDepth, ref reader))
                {
                    var unmarshaller = ExportDataSourceUnmarshaller.Instance;
                    unmarshalledObject.ExportDataSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ExportDestination", targetDepth, ref reader))
                {
                    var unmarshaller = ExportDestinationUnmarshaller.Instance;
                    unmarshalledObject.ExportDestination = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ExportSourceType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExportSourceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FailureInfo", targetDepth, ref reader))
                {
                    var unmarshaller = FailureInfoUnmarshaller.Instance;
                    unmarshalledObject.FailureInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("JobId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("JobStatus", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Statistics", targetDepth, ref reader))
                {
                    var unmarshaller = ExportStatisticsUnmarshaller.Instance;
                    unmarshalledObject.Statistics = unmarshaller.Unmarshall(context, ref reader);
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
                    if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
                    {
                        return BadRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("NotFoundException"))
                    {
                        return NotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
                    {
                        return TooManyRequestsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonSimpleEmailServiceV2Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetExportJobResponseUnmarshaller _instance = new GetExportJobResponseUnmarshaller();

        internal static GetExportJobResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetExportJobResponseUnmarshaller Instance => _instance;
    }
}
