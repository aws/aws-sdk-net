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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetCustomVerificationEmailTemplate operation
    /// </summary>  
    public class GetCustomVerificationEmailTemplateResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            GetCustomVerificationEmailTemplateResponse response = new GetCustomVerificationEmailTemplateResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("GetCustomVerificationEmailTemplateResult", 2))
                    {
                        UnmarshallResult(context, response);                        
                        continue;
                    }
                    
                    if (context.TestExpression("ResponseMetadata", 2))
                    {
                        response.ResponseMetadata = ResponseMetadataUnmarshaller.Instance.Unmarshall(context);
                    }
                }
            }

            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, GetCustomVerificationEmailTemplateResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
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
           }

            return;
        }


        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("CustomVerificationEmailTemplateDoesNotExist"))
                {
                    return CustomVerificationEmailTemplateDoesNotExistExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonSimpleEmailServiceException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
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