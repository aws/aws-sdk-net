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

using Amazon.IdentityManagement.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetAccountAuthorizationDetails operation.
    /// </summary>
    public partial class GetAccountAuthorizationDetailsResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            GetAccountAuthorizationDetailsResponse response = new GetAccountAuthorizationDetailsResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {
                    if (context.TestExpression("GetAccountAuthorizationDetailsResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, GetAccountAuthorizationDetailsResponse unmarshalledObject)
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
                    if (context.TestExpression("GroupDetailList/member", targetDepth))
                    {
                        if (unmarshalledObject.GroupDetailList == null)
                        {
                            unmarshalledObject.GroupDetailList = new List<GroupDetail>();
                        }
                        var unmarshaller = GroupDetailUnmarshaller.Instance;
                        unmarshalledObject.GroupDetailList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.IsTruncated = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Marker", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Marker = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Policies/member", targetDepth))
                    {
                        if (unmarshalledObject.Policies == null)
                        {
                            unmarshalledObject.Policies = new List<ManagedPolicyDetail>();
                        }
                        var unmarshaller = ManagedPolicyDetailUnmarshaller.Instance;
                        unmarshalledObject.Policies.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("RoleDetailList/member", targetDepth))
                    {
                        if (unmarshalledObject.RoleDetailList == null)
                        {
                            unmarshalledObject.RoleDetailList = new List<RoleDetail>();
                        }
                        var unmarshaller = RoleDetailUnmarshaller.Instance;
                        unmarshalledObject.RoleDetailList.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("UserDetailList/member", targetDepth))
                    {
                        if (unmarshalledObject.UserDetailList == null)
                        {
                            unmarshalledObject.UserDetailList = new List<UserDetail>();
                        }
                        var unmarshaller = UserDetailUnmarshaller.Instance;
                        unmarshalledObject.UserDetailList.Add(unmarshaller.Unmarshall(context));
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
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceFailure"))
                    {
                        return ServiceFailureExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                }
            }
            return new AmazonIdentityManagementServiceException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static GetAccountAuthorizationDetailsResponseUnmarshaller _instance = new GetAccountAuthorizationDetailsResponseUnmarshaller();

        internal static GetAccountAuthorizationDetailsResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetAccountAuthorizationDetailsResponseUnmarshaller Instance => _instance;
    }
}
