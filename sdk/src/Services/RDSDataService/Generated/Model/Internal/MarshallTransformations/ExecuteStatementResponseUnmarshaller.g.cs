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

using Amazon.RDSDataService.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.RDSDataService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ExecuteStatement operation.
    /// </summary>
    public partial class ExecuteStatementResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new ExecuteStatementResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("columnMetadata", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ColumnMetadata, ColumnMetadataUnmarshaller>(ColumnMetadataUnmarshaller.Instance);
                    unmarshalledObject.ColumnMetadata = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("formattedRecords", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FormattedRecords = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("generatedFields", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<Field, FieldUnmarshaller>(FieldUnmarshaller.Instance);
                    unmarshalledObject.GeneratedFields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("numberOfRecordsUpdated", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.NumberOfRecordsUpdated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("records", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<List<Field>, JsonListUnmarshaller<Field, FieldUnmarshaller>>(new JsonListUnmarshaller<Field, FieldUnmarshaller>(FieldUnmarshaller.Instance));
                    unmarshalledObject.Records = unmarshaller.Unmarshall(context, ref reader);
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
                    if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                    {
                        return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
                    {
                        return BadRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("DatabaseErrorException"))
                    {
                        return DatabaseErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("DatabaseNotFoundException"))
                    {
                        return DatabaseNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("DatabaseResumingException"))
                    {
                        return DatabaseResumingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("DatabaseUnavailableException"))
                    {
                        return DatabaseUnavailableExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ForbiddenException"))
                    {
                        return ForbiddenExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("HttpEndpointNotEnabledException"))
                    {
                        return HttpEndpointNotEnabledExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerErrorException"))
                    {
                        return InternalServerErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidResourceStateException"))
                    {
                        return InvalidResourceStateExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidSecretException"))
                    {
                        return InvalidSecretExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("SecretsErrorException"))
                    {
                        return SecretsErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceUnavailableError"))
                    {
                        return ServiceUnavailableErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("StatementTimeoutException"))
                    {
                        return StatementTimeoutExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("TransactionNotFoundException"))
                    {
                        return TransactionNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("UnsupportedResultException"))
                    {
                        return UnsupportedResultExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonRDSDataServiceException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static ExecuteStatementResponseUnmarshaller _instance = new ExecuteStatementResponseUnmarshaller();

        internal static ExecuteStatementResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ExecuteStatementResponseUnmarshaller Instance => _instance;
    }
}
