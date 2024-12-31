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
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.IO;
using System.Net;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Class for unmarshalling S3 service responses
    /// </summary>
    public abstract class S3ReponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override UnmarshallerContext CreateContext(
            IWebResponseData response,
            bool readEntireResponse,
            Stream stream,
            RequestMetrics metrics,
            bool isException)
        {
            return CreateContext(response, readEntireResponse, stream, metrics, isException, null);
        }

        public override UnmarshallerContext CreateContext(
            IWebResponseData response,
            bool readEntireResponse,
            Stream stream,
            RequestMetrics metrics,
            bool isException,
            IRequestContext context)
        {
            if (response.IsHeaderPresent(HeaderKeys.XAmzId2Header))
                metrics.AddProperty(Metric.AmzId2, response.GetHeaderValue(HeaderKeys.XAmzId2Header));

            if (response.IsHeaderPresent(HeaderKeys.XAmzCloudFrontIdHeader))
                metrics.AddProperty(Metric.AmzCfId, response.GetHeaderValue(HeaderKeys.XAmzCloudFrontIdHeader));

            return base.CreateContext(response, readEntireResponse, stream, metrics, isException, context);
        }

        public override AmazonWebServiceResponse Unmarshall(UnmarshallerContext input)
        {
            // Unmarshall response
            var response = base.Unmarshall(input);

            // Make sure ResponseMetadata is set
            if (response.ResponseMetadata == null)
                response.ResponseMetadata = new ResponseMetadata();

            // Populate AmazonId2
            response.ResponseMetadata.Metadata.Add(
                HeaderKeys.XAmzId2Header, input.ResponseData.GetHeaderValue(HeaderKeys.XAmzId2Header));

            // Populate X-Amz-Cf-Id for S3 accelerate responses
            if (input.ResponseData.IsHeaderPresent(HeaderKeys.XAmzCloudFrontIdHeader))
                response.ResponseMetadata.Metadata.Add(
                    HeaderKeys.XAmzCloudFrontIdHeader, input.ResponseData.GetHeaderValue(HeaderKeys.XAmzCloudFrontIdHeader));

            return response;
        }

        protected override UnmarshallerContext ConstructUnmarshallerContext(
            Stream responseStream,
            bool maintainResponseBody,
            IWebResponseData response,
            bool isException)
        {
             return new S3UnmarshallerContext(responseStream, maintainResponseBody, response, isException);
        }

        protected override UnmarshallerContext ConstructUnmarshallerContext(
            Stream responseStream,
            bool maintainResponseBody,
            IWebResponseData response,
            bool isException,
            IRequestContext requestContext)
        {
            return new S3UnmarshallerContext(responseStream, maintainResponseBody, response, isException, requestContext);
        }

        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = Amazon.S3.Model.Internal.MarshallTransformations.S3ErrorResponseUnmarshaller.Instance.Unmarshall(context);
            return ConstructS3Exception(context, errorResponse, innerException, statusCode);
        }

        protected private AmazonS3Exception ConstructS3Exception(XmlUnmarshallerContext context, S3ErrorResponse errorResponse, Exception innerException, HttpStatusCode statusCode)
        {
            var s3Exception = new Amazon.S3.AmazonS3Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode, errorResponse.Id2, errorResponse.AmzCfId);
            s3Exception.Region = errorResponse.Region;

            if (errorResponse.ParsingException != null)
            {
                var body = context.ResponseBody;
                if (!string.IsNullOrEmpty(body))
                {
                    s3Exception.ResponseBody = body;
                }
            }

            return s3Exception;
        }
    }
}
