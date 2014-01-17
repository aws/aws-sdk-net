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

using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Xml;
using System.IO;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal.Transform
{
    /// <summary>
    /// Abstract class for unmarshalling service responses.
    /// </summary>
    public abstract class ResponseUnmarshaller : IResponseUnmarshaller<AmazonWebServiceResponse, UnmarshallerContext>
    {
        public virtual UnmarshallerContext CreateContext(IWebResponseData response, bool readEntireResponse, RequestMetrics metrics)
        {
            throw new NotImplementedException();
        }

        internal virtual bool HasStreamingProperty
        {
            get { return false; }
        }

        #region IResponseUnmarshaller<AmazonWebServiceResponse,UnmarshallerContext> Members

        public virtual AmazonServiceException UnmarshallException(UnmarshallerContext input, Exception innerException, HttpStatusCode statusCode)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IUnmarshaller<AmazonWebServiceResponse,UnmarshallerContext> Members

        public virtual AmazonWebServiceResponse Unmarshall(UnmarshallerContext input)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    /// <summary>
    /// Class for unmarshalling XML service responses.
    /// </summary>
    public class XmlResponseUnmarshaller : ResponseUnmarshaller
    {
        public override UnmarshallerContext CreateContext(IWebResponseData response, bool readEntireResponse, RequestMetrics metrics)
        {
            if (response == null)
            {
                throw new WebException("The Web Response for a successful request is null!");
            }

            XmlUnmarshallerContext context;
            if (readEntireResponse)
            {
                string responseBody;
                using (metrics.StartEvent(Metric.ResponseReadTime))
                {
                    responseBody = new StreamReader(response.OpenResponse()).ReadToEnd();
                }
                context = new XmlUnmarshallerContext(responseBody, response);
            }
            else
            {
                context = new XmlUnmarshallerContext(response.OpenResponse(), response);
            }
            return context;
        }

        public override AmazonWebServiceResponse Unmarshall(UnmarshallerContext input)
        {
            XmlUnmarshallerContext context = input as XmlUnmarshallerContext;
            if (context == null)
                throw new InvalidOperationException("Unsupported UnmarshallerContext");

            AmazonWebServiceResponse response = this.Unmarshall(context);

            if (!string.IsNullOrEmpty(context.ResponseData.GetHeaderValue(AWSSDKUtils.RequestIdHeader)))
            {
                if(response.ResponseMetadata == null)
                    response.ResponseMetadata = new ResponseMetadata();
                response.ResponseMetadata.RequestId = context.ResponseData.GetHeaderValue(AWSSDKUtils.RequestIdHeader);
            }
            else if (!string.IsNullOrEmpty(context.ResponseData.GetHeaderValue(AWSSDKUtils.S3RequestIdHeader)))
            {
                if (response.ResponseMetadata == null)
                    response.ResponseMetadata = new ResponseMetadata();
                response.ResponseMetadata.RequestId = context.ResponseData.GetHeaderValue(AWSSDKUtils.S3RequestIdHeader);
            }

            return response;
        }
        public override AmazonServiceException UnmarshallException(UnmarshallerContext input, Exception innerException, HttpStatusCode statusCode)
        {
            XmlUnmarshallerContext context = input as XmlUnmarshallerContext;
            if (context == null)
                throw new InvalidOperationException("Unsupported UnmarshallerContext");

            return this.UnmarshallException(context, innerException, statusCode);
        }

        public virtual AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext input)
        {
            throw new NotImplementedException();
        }
        public virtual AmazonServiceException UnmarshallException(XmlUnmarshallerContext input, Exception innerException, HttpStatusCode statusCode)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Class for unmarshalling EC2 service responses.
    /// </summary>
    public class EC2ResponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override UnmarshallerContext CreateContext(IWebResponseData response, bool readEntireResponse, RequestMetrics metrics)
        {
            if (response == null)
            {
                throw new WebException(
                    "The Web Response for a successful request is null!"
                    );
            }

            EC2UnmarshallerContext context;
            if (readEntireResponse)
            {
                string responseBody;
                using (metrics.StartEvent(Metric.ResponseReadTime))
                {
                    responseBody = new StreamReader(response.OpenResponse()).ReadToEnd();
                }
                context = new EC2UnmarshallerContext(responseBody, response);
            }
            else
            {
                context = new EC2UnmarshallerContext(response.OpenResponse(), response);
            }
            return context;
        }

        public override AmazonWebServiceResponse Unmarshall(UnmarshallerContext input)
        {
            // Unmarshall response
            var response = base.Unmarshall(input);

            // Make sure ResponseMetadata is set
            if (response.ResponseMetadata == null)
                response.ResponseMetadata = new ResponseMetadata();

            // Populate RequestId
            var ec2UnmarshallerContext = input as EC2UnmarshallerContext;
            if (ec2UnmarshallerContext != null && !string.IsNullOrEmpty(ec2UnmarshallerContext.RequestId))
            {
                response.ResponseMetadata.RequestId = ec2UnmarshallerContext.RequestId;
            }

            return response;
        }
    }

    /// <summary>
    /// Class for unmarshalling S3 service responses
    /// </summary>
    public class S3ReponseUnmarshaller : XmlResponseUnmarshaller
    {
        private static string AMZ_ID_2 = "x-amz-id-2";

        public override UnmarshallerContext CreateContext(IWebResponseData response, bool readEntireResponse, RequestMetrics metrics)
        {
            if (response.IsHeaderPresent(AMZ_ID_2))
                metrics.AddProperty(Metric.AmzId2, response.GetHeaderValue(AMZ_ID_2));
            return base.CreateContext(response, readEntireResponse, metrics);
        }
        
        public override AmazonWebServiceResponse Unmarshall(UnmarshallerContext input)
        {
            // Unmarshall response
            var response = base.Unmarshall(input);
            
            // Make sure ResponseMetadata is set
            if (response.ResponseMetadata == null)
                response.ResponseMetadata = new ResponseMetadata();

            // Populate AmazonId2
            response.ResponseMetadata.Metadata.Add(AMZ_ID_2, input.ResponseData.GetHeaderValue(AMZ_ID_2));
            return response;
        }
    }

    /// <summary>
    /// Class for unmarshalling JSON service responses.
    /// </summary>
    public class JsonResponseUnmarshaller : ResponseUnmarshaller
    {
        public override UnmarshallerContext CreateContext(IWebResponseData response, bool readEntireResponse, RequestMetrics metrics)
        {
            if (response == null)
            {
                throw new WebException(
                    "The Web Response for a successful request is null!"
                    );
            }

            JsonUnmarshallerContext context;
            if (readEntireResponse && response.ContentType != "application/octet-stream")
            {
                string responseBody;
                using (metrics.StartEvent(Metric.ResponseReadTime))
                {
                    responseBody = new StreamReader(response.OpenResponse()).ReadToEnd();
                }
                context = new JsonUnmarshallerContext(responseBody, response);
            }
            else
            {
                context = new JsonUnmarshallerContext(response.OpenResponse(), response);
            }

            return context;
        }

        public override AmazonWebServiceResponse Unmarshall(UnmarshallerContext input)
        {
            JsonUnmarshallerContext context = input as JsonUnmarshallerContext;
            if (context == null)
                throw new InvalidOperationException("Unsupported UnmarshallerContext");

            string requestId = context.ResponseData.GetHeaderValue(AWSSDKUtils.RequestIdHeader);
            try
            {
                var response = this.Unmarshall(context);
                response.ResponseMetadata = new ResponseMetadata();
                response.ResponseMetadata.RequestId = requestId;
                return response;
            }
            catch (Exception e)
            {
                throw new AmazonUnmarshallingException(requestId, context.CurrentPath, e);
            }
        }
        public override AmazonServiceException UnmarshallException(UnmarshallerContext input, Exception innerException, HttpStatusCode statusCode)
        {
            JsonUnmarshallerContext context = input as JsonUnmarshallerContext;
            if (context == null)
                throw new InvalidOperationException("Unsupported UnmarshallerContext");

            var responseException = this.UnmarshallException(context, innerException, statusCode);
            responseException.SetRequestId(context.ResponseData.GetHeaderValue(AWSSDKUtils.RequestIdHeader));
            return responseException;
        }

        public virtual AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext input)
        {
            throw new NotImplementedException();
        }
        public virtual AmazonServiceException UnmarshallException(JsonUnmarshallerContext input, Exception innerException, HttpStatusCode statusCode)
        {
            throw new NotImplementedException();
        }

    }
}
