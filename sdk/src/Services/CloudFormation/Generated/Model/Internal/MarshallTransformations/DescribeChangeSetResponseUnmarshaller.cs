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
    /// Response Unmarshaller for DescribeChangeSet operation
    /// </summary>  
    public class DescribeChangeSetResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            DescribeChangeSetResponse response = new DescribeChangeSetResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("DescribeChangeSetResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, DescribeChangeSetResponse response)
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
                    if (context.TestExpression("Changes/member", targetDepth))
                    {
                        var unmarshaller = ChangeUnmarshaller.Instance;
                        if (response.Changes == null)
                        {
                            response.Changes = new List<Change>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.Changes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ChangeSetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ChangeSetId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ChangeSetName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ChangeSetName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CreationTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        response.CreationTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ExecutionStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ExecutionStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ImportExistingResources", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.ImportExistingResources = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IncludeNestedStacks", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.IncludeNestedStacks = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NextToken", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.NextToken = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NotificationARNs/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.NotificationARNs == null)
                        {
                            response.NotificationARNs = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.NotificationARNs.Add(item);
                        continue;
                    }
                    if (context.TestExpression("OnStackFailure", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.OnStackFailure = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Parameters/member", targetDepth))
                    {
                        var unmarshaller = ParameterUnmarshaller.Instance;
                        if (response.Parameters == null)
                        {
                            response.Parameters = new List<Parameter>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.Parameters.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ParentChangeSetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ParentChangeSetId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RollbackConfiguration", targetDepth))
                    {
                        var unmarshaller = RollbackConfigurationUnmarshaller.Instance;
                        response.RollbackConfiguration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RootChangeSetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.RootChangeSetId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StackId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.StackId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StackName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.StackName = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("Tags/member", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (response.Tags == null)
                        {
                            response.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.Tags.Add(item);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ChangeSetNotFound"))
                {
                    return ChangeSetNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonCloudFormationException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static DescribeChangeSetResponseUnmarshaller _instance = new DescribeChangeSetResponseUnmarshaller();        

        internal static DescribeChangeSetResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeChangeSetResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}