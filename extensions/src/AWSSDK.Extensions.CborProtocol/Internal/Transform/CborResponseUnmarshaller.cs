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
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Formats.Cbor;
using System.IO;
using System.Net;

namespace Amazon.Extensions.CborProtocol.Internal.Transform
{
    public abstract class CborResponseUnmarshaller : ResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(UnmarshallerContext input)
        {
            CborUnmarshallerContext context = input as CborUnmarshallerContext;
            if (context == null)
                throw new InvalidOperationException("Unsupported UnmarshallerContext");

            string requestId = context.ResponseData.GetHeaderValue(HeaderKeys.RequestIdHeader);
            try
            {
                var response = Unmarshall(context);
                response.ResponseMetadata = new ResponseMetadata();
                response.ResponseMetadata.RequestId = requestId;
                return response;
            }
            catch (Exception e)
            {
                throw new AmazonUnmarshallingException(requestId, context.CurrentPath, e, context.ResponseData.StatusCode);
            }
        }

        public override AmazonServiceException UnmarshallException(UnmarshallerContext input, Exception innerException, HttpStatusCode statusCode)
        {
            CborUnmarshallerContext context = input as CborUnmarshallerContext;
            if (context == null)
                throw new InvalidOperationException("Unsupported UnmarshallerContext");
            var responseException = UnmarshallException(context, innerException, statusCode);
            responseException.RequestId = context.ResponseData.GetHeaderValue(HeaderKeys.RequestIdHeader);
            return responseException;
        }

        public abstract AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext input);

        public abstract AmazonServiceException UnmarshallException(CborUnmarshallerContext input, Exception innerException, HttpStatusCode statusCode);

        protected override UnmarshallerContext ConstructUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData response, bool isException)
        {
            return new CborUnmarshallerContext(responseStream, maintainResponseBody, response, isException, null);
        }

        protected override UnmarshallerContext ConstructUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData response, bool isException, IRequestContext requestContext)
        {
            return new CborUnmarshallerContext(responseStream, maintainResponseBody, response, isException, requestContext);
        }
    }
}
