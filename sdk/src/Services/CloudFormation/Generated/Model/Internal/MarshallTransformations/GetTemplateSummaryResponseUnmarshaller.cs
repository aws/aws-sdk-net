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
    /// Response Unmarshaller for GetTemplateSummary operation
    /// </summary>  
    public class GetTemplateSummaryResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            GetTemplateSummaryResponse response = new GetTemplateSummaryResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("GetTemplateSummaryResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, GetTemplateSummaryResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("Capabilities/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.Capabilities == null)
                        {
                            response.Capabilities = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.Capabilities.Add(item);
                        continue;
                    }
                    if (context.TestExpression("CapabilitiesReason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.CapabilitiesReason = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DeclaredTransforms/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.DeclaredTransforms == null)
                        {
                            response.DeclaredTransforms = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.DeclaredTransforms.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Metadata", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Metadata = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Parameters/member", targetDepth))
                    {
                        var unmarshaller = ParameterDeclarationUnmarshaller.Instance;
                        if (response.Parameters == null)
                        {
                            response.Parameters = new List<ParameterDeclaration>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.Parameters.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ResourceIdentifierSummaries/member", targetDepth))
                    {
                        var unmarshaller = ResourceIdentifierSummaryUnmarshaller.Instance;
                        if (response.ResourceIdentifierSummaries == null)
                        {
                            response.ResourceIdentifierSummaries = new List<ResourceIdentifierSummary>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.ResourceIdentifierSummaries.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ResourceTypes/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.ResourceTypes == null)
                        {
                            response.ResourceTypes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.ResourceTypes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Version", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Version = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Warnings", targetDepth))
                    {
                        var unmarshaller = WarningsUnmarshaller.Instance;
                        response.Warnings = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("StackSetNotFoundException"))
                {
                    return StackSetNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonCloudFormationException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static GetTemplateSummaryResponseUnmarshaller _instance = new GetTemplateSummaryResponseUnmarshaller();        

        internal static GetTemplateSummaryResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetTemplateSummaryResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}