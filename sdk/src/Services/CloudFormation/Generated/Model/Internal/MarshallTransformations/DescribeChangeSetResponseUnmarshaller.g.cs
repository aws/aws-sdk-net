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
    /// Response Unmarshaller for DescribeChangeSet operation.
    /// </summary>
    public partial class DescribeChangeSetResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            DescribeChangeSetResponse response = new DescribeChangeSetResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {
                    if (context.TestExpression("DescribeChangeSetResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, DescribeChangeSetResponse unmarshalledObject)
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
                    if (context.TestExpression("Capabilities/member", targetDepth))
                    {
                        if (unmarshalledObject.Capabilities == null)
                        {
                            unmarshalledObject.Capabilities = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Capabilities.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ChangeSetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ChangeSetId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ChangeSetName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ChangeSetName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Changes/member", targetDepth))
                    {
                        if (unmarshalledObject.Changes == null)
                        {
                            unmarshalledObject.Changes = new List<Change>();
                        }
                        var unmarshaller = ChangeUnmarshaller.Instance;
                        unmarshalledObject.Changes.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("CreationTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("DeploymentConfig", targetDepth))
                    {
                        var unmarshaller = DeploymentConfigUnmarshaller.Instance;
                        unmarshalledObject.DeploymentConfig = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("DeploymentMode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DeploymentMode = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ExecutionStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ExecutionStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ImportExistingResources", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.ImportExistingResources = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("IncludeNestedStacks", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.IncludeNestedStacks = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("NextToken", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NextToken = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("NotificationARNs/member", targetDepth))
                    {
                        if (unmarshalledObject.NotificationARNs == null)
                        {
                            unmarshalledObject.NotificationARNs = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NotificationARNs.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("OnStackFailure", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OnStackFailure = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Parameters/member", targetDepth))
                    {
                        if (unmarshalledObject.Parameters == null)
                        {
                            unmarshalledObject.Parameters = new List<Parameter>();
                        }
                        var unmarshaller = ParameterUnmarshaller.Instance;
                        unmarshalledObject.Parameters.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ParentChangeSetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ParentChangeSetId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("RollbackConfiguration", targetDepth))
                    {
                        var unmarshaller = RollbackConfigurationUnmarshaller.Instance;
                        unmarshalledObject.RollbackConfiguration = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("RootChangeSetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RootChangeSetId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("StackDriftStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StackDriftStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("StackId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StackId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("StackName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StackName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("StatusReason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StatusReason = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Tags/member", targetDepth))
                    {
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var unmarshaller = TagUnmarshaller.Instance;
                        unmarshalledObject.Tags.Add(unmarshaller.Unmarshall(context));
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
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ChangeSetNotFound"))
                    {
                        return ChangeSetNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                }
            }
            return new AmazonCloudFormationException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeChangeSetResponseUnmarshaller _instance = new DescribeChangeSetResponseUnmarshaller();

        internal static DescribeChangeSetResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeChangeSetResponseUnmarshaller Instance => _instance;
    }
}
