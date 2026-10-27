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

using Amazon.Comprehend.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.Comprehend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ClassifyDocument operation.
    /// </summary>
    public partial class ClassifyDocumentResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new ClassifyDocumentResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Classes", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DocumentClass, DocumentClassUnmarshaller>(DocumentClassUnmarshaller.Instance);
                    unmarshalledObject.Classes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("DocumentMetadata", targetDepth, ref reader))
                {
                    var unmarshaller = DocumentMetadataUnmarshaller.Instance;
                    unmarshalledObject.DocumentMetadata = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("DocumentType", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DocumentTypeListItem, DocumentTypeListItemUnmarshaller>(DocumentTypeListItemUnmarshaller.Instance);
                    unmarshalledObject.DocumentType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Errors", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ErrorsListItem, ErrorsListItemUnmarshaller>(ErrorsListItemUnmarshaller.Instance);
                    unmarshalledObject.Errors = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Labels", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DocumentLabel, DocumentLabelUnmarshaller>(DocumentLabelUnmarshaller.Instance);
                    unmarshalledObject.Labels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Warnings", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<WarningsListItem, WarningsListItemUnmarshaller>(WarningsListItemUnmarshaller.Instance);
                    unmarshalledObject.Warnings = unmarshaller.Unmarshall(context, ref reader);
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
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                    {
                        return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRequestException"))
                    {
                        return InvalidRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceUnavailableException"))
                    {
                        return ResourceUnavailableExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("TextSizeLimitExceededException"))
                    {
                        return TextSizeLimitExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonComprehendException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static ClassifyDocumentResponseUnmarshaller _instance = new ClassifyDocumentResponseUnmarshaller();

        internal static ClassifyDocumentResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ClassifyDocumentResponseUnmarshaller Instance => _instance;
    }
}
