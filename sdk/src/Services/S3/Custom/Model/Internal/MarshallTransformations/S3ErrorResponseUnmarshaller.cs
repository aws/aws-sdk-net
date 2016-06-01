/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime.Internal;

using Amazon.Util;
using Amazon.S3.Util;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime;
using System;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for all Errors
    /// </summary>
    public class S3ErrorResponseUnmarshaller : IUnmarshaller<S3ErrorResponse, XmlUnmarshallerContext>
    {
        const string XML_CONTENT_TYPE = "text/xml";

        /// <summary>
        /// Build an S3ErrorResponse from XML 
        /// </summary>
        /// <param name="context">The XML parsing context. 
        /// Usually an <c>Amazon.Runtime.Internal.UnmarshallerContext</c>.</param>
        /// <returns>An <c>S3ErrorResponse</c> object.</returns>
        public S3ErrorResponse Unmarshall(XmlUnmarshallerContext context)
        {
            S3ErrorResponse response = new S3ErrorResponse();

            var statusCode = context.ResponseData.StatusCode;
            response.Code = statusCode.ToString();
            if (context.ResponseData.IsHeaderPresent(HeaderKeys.XAmzRequestIdHeader))
                response.RequestId = context.ResponseData.GetHeaderValue(HeaderKeys.XAmzRequestIdHeader);
            if (context.ResponseData.IsHeaderPresent(HeaderKeys.XAmzId2Header))
                response.Id2 = context.ResponseData.GetHeaderValue(HeaderKeys.XAmzId2Header);
            if (context.ResponseData.IsHeaderPresent(HeaderKeys.XAmzCloudFrontIdHeader))
                response.AmzCfId = context.ResponseData.GetHeaderValue(HeaderKeys.XAmzCloudFrontIdHeader);

            if ((int)statusCode >= 500)
                response.Type = ErrorType.Receiver;
            else if ((int)statusCode >= 400)
                response.Type = ErrorType.Sender;
            else
                response.Type = ErrorType.Unknown;

            string contentLengthHeader = null;
            if (context.ResponseData.IsHeaderPresent(HeaderKeys.ContentLengthHeader))
                contentLengthHeader = context.ResponseData.GetHeaderValue(HeaderKeys.ContentLengthHeader);

            string contentTypeHeader = XML_CONTENT_TYPE;
            if (context.ResponseData.IsHeaderPresent(HeaderKeys.ContentTypeHeader))
                contentTypeHeader = context.ResponseData.GetHeaderValue(HeaderKeys.ContentTypeHeader);

            long contentLength;
            if (string.IsNullOrEmpty(contentLengthHeader) || !long.TryParse(contentLengthHeader, out contentLength))
            {
                contentLength = -1;
            }
            if (contentLength < 0)
            {
                try
                {
                    contentLength = context.Stream.Length;
                }
                catch
                {
                    contentLength = -1;
                }
            }

            if (context.Stream.CanRead && contentLength != 0 && contentTypeHeader.EndsWith("/xml", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    while (context.Read())
                    {
                        if (context.IsStartElement)
                        {
                            if (context.TestExpression("Error/Code"))
                            {
                                response.Code = StringUnmarshaller.GetInstance().Unmarshall(context);
                                continue;
                            }
                            if (context.TestExpression("Error/Message"))
                            {
                                response.Message = StringUnmarshaller.GetInstance().Unmarshall(context);
                                continue;
                            }
                            if (context.TestExpression("Error/Resource"))
                            {
                                response.Resource = StringUnmarshaller.GetInstance().Unmarshall(context);
                                continue;
                            }
                            if (context.TestExpression("Error/RequestId"))
                            {
                                response.RequestId = StringUnmarshaller.GetInstance().Unmarshall(context);
                                continue;
                            }
                            if (context.TestExpression("Error/HostId"))
                            {
                                response.Id2 = StringUnmarshaller.GetInstance().Unmarshall(context);
                                continue;
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    // Error response was not XML
                    response.ParsingException = e;
                }
            }

            return response;
        }


        private static S3ErrorResponseUnmarshaller _instance;

        public static S3ErrorResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new S3ErrorResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }

    public class S3ErrorResponse : ErrorResponse
    {
        public string Resource { get; set; }

        public string Id2 { get; set; }

        public string AmzCfId { get; set; }

        public Exception ParsingException { get; set; }
    }
}
