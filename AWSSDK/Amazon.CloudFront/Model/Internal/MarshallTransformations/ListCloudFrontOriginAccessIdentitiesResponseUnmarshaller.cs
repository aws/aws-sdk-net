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

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for ListCloudFrontOriginAccessIdentities operation
    /// </summary>
    internal class ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller : XmlResponseUnmarshaller
    {

        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {
            ListCloudFrontOriginAccessIdentitiesResponse response = new ListCloudFrontOriginAccessIdentitiesResponse();
            
            response.ListCloudFrontOriginAccessIdentitiesResult = ListCloudFrontOriginAccessIdentitiesResultUnmarshaller.GetInstance().Unmarshall(context);
             
                        
            return response;
        }

        
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidArgument"))
            {
                return new InvalidArgumentException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            return new AmazonCloudFrontException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller instance;

        public static ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new ListCloudFrontOriginAccessIdentitiesResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
