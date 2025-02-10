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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeGeneratedTemplate operation
    /// </summary>  
    public class DescribeGeneratedTemplateResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            DescribeGeneratedTemplateResponse response = new DescribeGeneratedTemplateResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("DescribeGeneratedTemplateResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, DescribeGeneratedTemplateResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("CreationTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        response.CreationTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("GeneratedTemplateId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.GeneratedTemplateId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("GeneratedTemplateName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.GeneratedTemplateName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LastUpdatedTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        response.LastUpdatedTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Progress", targetDepth))
                    {
                        var unmarshaller = TemplateProgressUnmarshaller.Instance;
                        response.Progress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Resources/member", targetDepth))
                    {
                        var unmarshaller = ResourceDetailUnmarshaller.Instance;
                        if (response.Resources == null)
                        {
                            response.Resources = new List<ResourceDetail>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.Resources.Add(item);
                        continue;
                    }
                    if (context.TestExpression("StackId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.StackId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StatusReason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.StatusReason = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TemplateConfiguration", targetDepth))
                    {
                        var unmarshaller = TemplateConfigurationUnmarshaller.Instance;
                        response.TemplateConfiguration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TotalWarnings", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        response.TotalWarnings = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("GeneratedTemplateNotFound"))
                {
                    return GeneratedTemplateNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonCloudFormationException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static DescribeGeneratedTemplateResponseUnmarshaller _instance = new DescribeGeneratedTemplateResponseUnmarshaller();        

        internal static DescribeGeneratedTemplateResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeGeneratedTemplateResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}