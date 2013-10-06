/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Net;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for AuthorizeClusterSecurityGroupIngress operation
    /// </summary>
    internal class AuthorizeClusterSecurityGroupIngressResponseUnmarshaller : XmlResponseUnmarshaller
    {

        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {
            AuthorizeClusterSecurityGroupIngressResponse response = new AuthorizeClusterSecurityGroupIngressResponse();
            
            while (context.Read())
            {
                if (context.IsStartElement)
                {
                    
                    if(context.TestExpression("AuthorizeClusterSecurityGroupIngressResult", 2))
                    {
                        response.AuthorizeClusterSecurityGroupIngressResult = AuthorizeClusterSecurityGroupIngressResultUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    
                    if (context.TestExpression("ResponseMetadata", 2))
                    {
                        response.ResponseMetadata = ResponseMetadataUnmarshaller.GetInstance().Unmarshall(context);
                    }
                }
            }
                

            return response;
        }
        
        
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidClusterSecurityGroupState"))
            {
                return new InvalidClusterSecurityGroupStateException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("AuthorizationAlreadyExists"))
            {
                return new AuthorizationAlreadyExistsException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("AuthorizationQuotaExceeded"))
            {
                return new AuthorizationQuotaExceededException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("ClusterSecurityGroupNotFound"))
            {
                return new ClusterSecurityGroupNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            return new AmazonRedshiftException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static AuthorizeClusterSecurityGroupIngressResponseUnmarshaller instance;

        public static AuthorizeClusterSecurityGroupIngressResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new AuthorizeClusterSecurityGroupIngressResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
