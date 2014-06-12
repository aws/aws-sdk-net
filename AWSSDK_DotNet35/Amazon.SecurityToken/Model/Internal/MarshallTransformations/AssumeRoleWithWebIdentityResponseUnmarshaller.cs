/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityToken.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AssumeRoleWithWebIdentity operation
    /// </summary>  
    public class AssumeRoleWithWebIdentityResponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            AssumeRoleWithWebIdentityResponse response = new AssumeRoleWithWebIdentityResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("AssumeRoleWithWebIdentityResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, AssumeRoleWithWebIdentityResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("AssumedRoleUser", targetDepth))
                    {
                        var unmarshaller = AssumedRoleUserUnmarshaller.Instance;
                        response.AssumedRoleUser = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Audience", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Audience = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Credentials", targetDepth))
                    {
                        var unmarshaller = CredentialsUnmarshaller.Instance;
                        response.Credentials = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PackedPolicySize", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.PackedPolicySize = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Provider", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Provider = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SubjectFromWebIdentityToken", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.SubjectFromWebIdentityToken = unmarshaller.Unmarshall(context);
                        continue;
                    }
                } 
           }

            return;
        }


        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("ExpiredTokenException"))
            {
                return new ExpiredTokenException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("IDPCommunicationError"))
            {
                return new IDPCommunicationErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("IDPRejectedClaim"))
            {
                return new IDPRejectedClaimException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidIdentityToken"))
            {
                return new InvalidIdentityTokenException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("MalformedPolicyDocument"))
            {
                return new MalformedPolicyDocumentException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("PackedPolicyTooLarge"))
            {
                return new PackedPolicyTooLargeException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonSecurityTokenServiceException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static AssumeRoleWithWebIdentityResponseUnmarshaller _instance = new AssumeRoleWithWebIdentityResponseUnmarshaller();        

        internal static AssumeRoleWithWebIdentityResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static AssumeRoleWithWebIdentityResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}