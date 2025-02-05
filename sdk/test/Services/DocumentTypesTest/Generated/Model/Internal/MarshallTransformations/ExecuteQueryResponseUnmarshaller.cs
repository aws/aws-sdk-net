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
 * Do not modify this file. This file is generated from the document-types-test-2022-09-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DocumentTypesTest.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DocumentTypesTest.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ExecuteQuery operation
    /// </summary>  
    public class ExecuteQueryResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            ExecuteQueryResponse response = new ExecuteQueryResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("queryDocument", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    response.QueryDocument = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("queryList", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Amazon.Runtime.Documents.Document, Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller>(Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance);
                    response.QueryList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("queryListOfMap", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Dictionary<string, Amazon.Runtime.Documents.Document>, JsonDictionaryUnmarshaller<string, Amazon.Runtime.Documents.Document, StringUnmarshaller, Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller>>(new JsonDictionaryUnmarshaller<string, Amazon.Runtime.Documents.Document, StringUnmarshaller, Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller>(StringUnmarshaller.Instance, Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance));
                    response.QueryListOfMap = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("queryMap", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, Amazon.Runtime.Documents.Document, StringUnmarshaller, Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller>(StringUnmarshaller.Instance, Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance);
                    response.QueryMap = unmarshaller.Unmarshall(context, ref reader);
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
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy);
            }
            return new AmazonDocumentTypesTestException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static ExecuteQueryResponseUnmarshaller _instance = new ExecuteQueryResponseUnmarshaller();        

        internal static ExecuteQueryResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExecuteQueryResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}