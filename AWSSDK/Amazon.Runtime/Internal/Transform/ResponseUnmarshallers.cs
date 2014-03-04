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
using System.Web;
using System.Xml;
using System.IO;
using Amazon.Util;

namespace Amazon.Runtime.Internal.Transform
{
    /// <summary>
    /// Abstract class for unmarshalling service responses.
    /// </summary>
    public abstract class ResponseUnmarshaller : IResponseUnmarshaller<AmazonWebServiceResponse, UnmarshallerContext>
    {
        public virtual UnmarshallerContext CreateContext(HttpWebResponse response, bool readEntireResponse, AsyncResult asyncResult)
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
        protected string contents;

        public override UnmarshallerContext CreateContext(HttpWebResponse response, bool readEntireResponse, AsyncResult asyncResult)
        {
            if (response == null)
            {
                throw new WebException(
                    "The Web Response for a successful request is null!",
                    WebExceptionStatus.ProtocolError
                    );
            }

            XmlUnmarshallerContext context;
            if (readEntireResponse)
            {
                string responseBody;
                using (asyncResult.Metrics.StartEvent(RequestMetrics.Metric.ResponseReadTime))
                {
                    responseBody = new StreamReader(response.GetResponseStream()).ReadToEnd();
                }
                context = new XmlUnmarshallerContext(responseBody, response.Headers);
            }
            else
            {
                context = new XmlUnmarshallerContext(response.GetResponseStream(), response.Headers);
            }
            return context;
        }

        public override AmazonWebServiceResponse Unmarshall(UnmarshallerContext input)
        {
            XmlUnmarshallerContext context = input as XmlUnmarshallerContext;
            if (context == null)
                throw new ArgumentOutOfRangeException("Unsupported UnmarshallerContext");

            AmazonWebServiceResponse response = this.Unmarshall(context);

            if (context.Headers[AWSSDKUtils.RequestIdHeader] != null)
            {
                response.ResponseMetadata = new ResponseMetadata();
                response.ResponseMetadata.RequestId = context.Headers[AWSSDKUtils.RequestIdHeader];
            }

            return response;
        }
        public override AmazonServiceException UnmarshallException(UnmarshallerContext input, Exception innerException, HttpStatusCode statusCode)
        {
            XmlUnmarshallerContext context = input as XmlUnmarshallerContext;
            if (context == null)
                throw new ArgumentOutOfRangeException("Unsupported UnmarshallerContext");

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
    /// Class for unmarshalling JSON service responses.
    /// </summary>
    public class JsonResponseUnmarshaller : ResponseUnmarshaller
    {
        protected string contents;

        public override UnmarshallerContext CreateContext(HttpWebResponse response, bool readEntireResponse, AsyncResult asyncResult)
        {
            if (response == null)
            {
                throw new WebException(
                    "The Web Response for a successful request is null!",
                    WebExceptionStatus.ProtocolError
                    );
            }

            JsonUnmarshallerContext context;
            if (readEntireResponse && response.ContentType != "application/octet-stream")
            {
                string responseBody;
                using (asyncResult.Metrics.StartEvent(RequestMetrics.Metric.ResponseReadTime))
                {
                    responseBody = new StreamReader(response.GetResponseStream()).ReadToEnd();
                }
                context = new JsonUnmarshallerContext(responseBody, (int)response.StatusCode, response.Headers);
            }
            else
            {
                context = new JsonUnmarshallerContext(response.GetResponseStream(), (int)response.StatusCode, response.Headers);
            }

            return context;
        }

        public override AmazonWebServiceResponse Unmarshall(UnmarshallerContext input)
        {
            JsonUnmarshallerContext context = input as JsonUnmarshallerContext;
            if (context == null)
                throw new ArgumentOutOfRangeException("Unsupported UnmarshallerContext");

            string requestId = context.Headers[AWSSDKUtils.RequestIdHeader];
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
                throw new ArgumentOutOfRangeException("Unsupported UnmarshallerContext");

            var responseException = this.UnmarshallException(context, innerException, statusCode);
            responseException.SetRequestId(context.Headers[AWSSDKUtils.RequestIdHeader]);
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
