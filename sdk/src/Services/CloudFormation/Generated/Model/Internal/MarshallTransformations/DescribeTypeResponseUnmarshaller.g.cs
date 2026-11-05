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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.CloudFormation.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeType operation.
    /// </summary>
    public partial class DescribeTypeResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            DescribeTypeResponse response = new DescribeTypeResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {
                    if (context.TestExpression("DescribeTypeResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, DescribeTypeResponse unmarshalledObject)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Arn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("AutoUpdate", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.AutoUpdate = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ConfigurationSchema", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ConfigurationSchema = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("DefaultVersionId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DefaultVersionId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("DeprecatedStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DeprecatedStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("DocumentationUrl", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DocumentationUrl = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ExecutionRoleArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ExecutionRoleArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("IsActivated", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.IsActivated = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("IsDefaultVersion", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.IsDefaultVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("LastUpdated", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.LastUpdated = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("LatestPublicVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LatestPublicVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("LoggingConfig", targetDepth))
                    {
                        var unmarshaller = LoggingConfigUnmarshaller.Instance;
                        unmarshalledObject.LoggingConfig = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("OriginalTypeArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OriginalTypeArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("OriginalTypeName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OriginalTypeName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ProvisioningType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ProvisioningType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PublicVersionNumber", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PublicVersionNumber = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("PublisherId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PublisherId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("RequiredActivatedTypes/member", targetDepth))
                    {
                        if (unmarshalledObject.RequiredActivatedTypes == null)
                        {
                            unmarshalledObject.RequiredActivatedTypes = new List<RequiredActivatedType>();
                        }
                        var unmarshaller = RequiredActivatedTypeUnmarshaller.Instance;
                        unmarshalledObject.RequiredActivatedTypes.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("Schema", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Schema = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("SourceUrl", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SourceUrl = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("TimeCreated", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.TimeCreated = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Type", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("TypeName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TypeName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("TypeTestsStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TypeTestsStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("TypeTestsStatusDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TypeTestsStatusDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Visibility", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Visibility = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
            }

            return;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, context.ResponseData))
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
            }
            return new AmazonCloudFormationException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeTypeResponseUnmarshaller _instance = new DescribeTypeResponseUnmarshaller();

        internal static DescribeTypeResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeTypeResponseUnmarshaller Instance => _instance;
    }
}
