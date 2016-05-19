using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Class for unmarshalling S3 service responses
    /// </summary>
    public abstract class S3ReponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override UnmarshallerContext CreateContext(IWebResponseData response, bool readEntireResponse, Stream stream, RequestMetrics metrics)
        {
            if (response.IsHeaderPresent(HeaderKeys.XAmzId2Header))
                metrics.AddProperty(Metric.AmzId2, response.GetHeaderValue(HeaderKeys.XAmzId2Header));

            if (response.IsHeaderPresent(HeaderKeys.XAmzCloudFrontIdHeader))
                metrics.AddProperty(Metric.AmzCfId, response.GetHeaderValue(HeaderKeys.XAmzCloudFrontIdHeader));

            return base.CreateContext(response, readEntireResponse, stream, metrics);
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

        protected override UnmarshallerContext ConstructUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData response)
        {
            return new S3UnmarshallerContext(responseStream, maintainResponseBody, response);
        }

        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = Amazon.S3.Model.Internal.MarshallTransformations.S3ErrorResponseUnmarshaller.Instance.Unmarshall(context);
            var s3Exception = new Amazon.S3.AmazonS3Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode, errorResponse.Id2, errorResponse.AmzCfId);

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
