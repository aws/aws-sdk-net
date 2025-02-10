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
    /// Response Unmarshaller for DescribeType operation
    /// </summary>  
    public class DescribeTypeResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            DescribeTypeResponse response = new DescribeTypeResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("DescribeTypeResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, DescribeTypeResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("Arn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Arn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AutoUpdate", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.AutoUpdate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ConfigurationSchema", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ConfigurationSchema = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultVersionId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.DefaultVersionId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DeprecatedStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.DeprecatedStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DocumentationUrl", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.DocumentationUrl = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ExecutionRoleArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ExecutionRoleArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IsActivated", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.IsActivated = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IsDefaultVersion", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.IsDefaultVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LastUpdated", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        response.LastUpdated = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LatestPublicVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.LatestPublicVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LoggingConfig", targetDepth))
                    {
                        var unmarshaller = LoggingConfigUnmarshaller.Instance;
                        response.LoggingConfig = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OriginalTypeArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.OriginalTypeArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OriginalTypeName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.OriginalTypeName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ProvisioningType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ProvisioningType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PublicVersionNumber", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.PublicVersionNumber = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PublisherId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.PublisherId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequiredActivatedTypes/member", targetDepth))
                    {
                        var unmarshaller = RequiredActivatedTypeUnmarshaller.Instance;
                        if (response.RequiredActivatedTypes == null)
                        {
                            response.RequiredActivatedTypes = new List<RequiredActivatedType>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.RequiredActivatedTypes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Schema", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Schema = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SourceUrl", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.SourceUrl = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TimeCreated", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        response.TimeCreated = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Type", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Type = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TypeName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.TypeName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TypeTestsStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.TypeTestsStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TypeTestsStatusDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.TypeTestsStatusDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Visibility", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Visibility = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("CFNRegistryException"))
                {
                    return CFNRegistryExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TypeNotFoundException"))
                {
                    return TypeNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonCloudFormationException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static DescribeTypeResponseUnmarshaller _instance = new DescribeTypeResponseUnmarshaller();        

        internal static DescribeTypeResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeTypeResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}