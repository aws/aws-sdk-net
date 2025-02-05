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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetAccountAuthorizationDetails operation
    /// </summary>  
    public class GetAccountAuthorizationDetailsResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            GetAccountAuthorizationDetailsResponse response = new GetAccountAuthorizationDetailsResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("GetAccountAuthorizationDetailsResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, GetAccountAuthorizationDetailsResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("GroupDetailList/member", targetDepth))
                    {
                        var unmarshaller = GroupDetailUnmarshaller.Instance;
                        if (response.GroupDetailList == null)
                        {
                            response.GroupDetailList = new List<GroupDetail>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.GroupDetailList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.IsTruncated = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Marker = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Policies/member", targetDepth))
                    {
                        var unmarshaller = ManagedPolicyDetailUnmarshaller.Instance;
                        if (response.Policies == null)
                        {
                            response.Policies = new List<ManagedPolicyDetail>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.Policies.Add(item);
                        continue;
                    }
                    if (context.TestExpression("RoleDetailList/member", targetDepth))
                    {
                        var unmarshaller = RoleDetailUnmarshaller.Instance;
                        if (response.RoleDetailList == null)
                        {
                            response.RoleDetailList = new List<RoleDetail>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.RoleDetailList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("UserDetailList/member", targetDepth))
                    {
                        var unmarshaller = UserDetailUnmarshaller.Instance;
                        if (response.UserDetailList == null)
                        {
                            response.UserDetailList = new List<UserDetail>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.UserDetailList.Add(item);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceFailure"))
                {
                    return ServiceFailureExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonIdentityManagementServiceException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static GetAccountAuthorizationDetailsResponseUnmarshaller _instance = new GetAccountAuthorizationDetailsResponseUnmarshaller();        

        internal static GetAccountAuthorizationDetailsResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetAccountAuthorizationDetailsResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}