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
using System.Collections.Generic;
using Amazon.SimpleEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for GetIdentityVerificationAttributes operation
    /// </summary>
    internal class GetIdentityVerificationAttributesResponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            GetIdentityVerificationAttributesResponse response = new GetIdentityVerificationAttributesResponse();
            
            while (context.Read())
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("GetIdentityVerificationAttributesResult", 2))
                    {
                        UnmarshallResult(context,response);                        
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
        
        private static void UnmarshallResult(XmlUnmarshallerContext context,GetIdentityVerificationAttributesResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("VerificationAttributes/entry", targetDepth))
                    {
                        KeyValueUnmarshaller<string, IdentityVerificationAttributes, StringUnmarshaller, IdentityVerificationAttributesUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, IdentityVerificationAttributes, StringUnmarshaller, IdentityVerificationAttributesUnmarshaller>(StringUnmarshaller.GetInstance(), IdentityVerificationAttributesUnmarshaller.GetInstance());
                        KeyValuePair<string, IdentityVerificationAttributes> kvp = unmarshaller.Unmarshall(context);
                        response.VerificationAttributes.Add(kvp.Key, kvp.Value);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }
                            


            return;
        }
        
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            
            return new AmazonSimpleEmailServiceException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static GetIdentityVerificationAttributesResponseUnmarshaller instance;

        public static GetIdentityVerificationAttributesResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new GetIdentityVerificationAttributesResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
