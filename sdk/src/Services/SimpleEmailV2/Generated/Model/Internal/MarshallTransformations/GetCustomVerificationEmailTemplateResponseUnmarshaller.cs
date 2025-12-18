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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmailV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetCustomVerificationEmailTemplate operation
    /// </summary>  
    public class GetCustomVerificationEmailTemplateResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetCustomVerificationEmailTemplateResponse response = new GetCustomVerificationEmailTemplateResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("FailureRedirectionURL", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FailureRedirectionURL = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FromEmailAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FromEmailAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SuccessRedirectionURL", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SuccessRedirectionURL = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TemplateContent", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TemplateContent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TemplateName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TemplateName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TemplateSubject", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TemplateSubject = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
                {
                    return BadRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NotFoundException"))
                {
                    return NotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
                {
                    return TooManyRequestsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonSimpleEmailServiceV2Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static GetCustomVerificationEmailTemplateResponseUnmarshaller _instance = new GetCustomVerificationEmailTemplateResponseUnmarshaller();        

        internal static GetCustomVerificationEmailTemplateResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetCustomVerificationEmailTemplateResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}