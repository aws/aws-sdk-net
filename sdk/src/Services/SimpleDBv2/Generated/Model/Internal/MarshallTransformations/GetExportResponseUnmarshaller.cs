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
 * Do not modify this file. This file is generated from the simpledbv2-2025-09-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetExport operation
    /// </summary>  
    public class GetExportResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetExportResponse response = new GetExportResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("clientToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ClientToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("domainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DomainName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("exportArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ExportArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("exportDataCutoffTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.ExportDataCutoffTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("exportManifest", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ExportManifest = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("exportStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ExportStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failureCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FailureCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failureMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FailureMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("itemsCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.ItemsCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requestedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.RequestedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("s3Bucket", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.S3Bucket = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("s3BucketOwner", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.S3BucketOwner = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("s3KeyPrefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.S3KeyPrefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("s3SseAlgorithm", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.S3SseAlgorithm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("s3SseKmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.S3SseKmsKeyId = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValueException"))
                {
                    return InvalidParameterValueExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchExportException"))
                {
                    return NoSuchExportExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonSimpleDBv2Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetExportResponseUnmarshaller _instance = new GetExportResponseUnmarshaller();        

        internal static GetExportResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetExportResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}