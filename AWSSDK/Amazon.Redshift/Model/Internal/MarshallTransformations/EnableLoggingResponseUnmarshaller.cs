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
    ///    Response Unmarshaller for EnableLogging operation
    /// </summary>
    internal class EnableLoggingResponseUnmarshaller : XmlResponseUnmarshaller
    {

        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {
            EnableLoggingResponse response = new EnableLoggingResponse();
            
            while (context.Read())
            {
                if (context.IsStartElement)                
                {
                    if(context.TestExpression("EnableLoggingResult", 2))
                    {
                        response.EnableLoggingResult = EnableLoggingResultUnmarshaller.GetInstance().Unmarshall(context);
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
            
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidS3KeyPrefixFault"))
            {
                return new InvalidS3KeyPrefixException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidS3BucketNameFault"))
            {
                return new InvalidS3BucketNameException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("BucketNotFoundFault"))
            {
                return new BucketNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("ClusterNotFound"))
            {
                return new ClusterNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("InsufficientS3BucketPolicyFault"))
            {
                return new InsufficientS3BucketPolicyException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            return new AmazonRedshiftException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static EnableLoggingResponseUnmarshaller instance;

        public static EnableLoggingResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new EnableLoggingResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
