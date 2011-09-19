/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElastiCache.Model.Transform
{
    /// <summary>
    ///    Response Unmarshaller for DescribeCacheSecurityGroups operation
    /// </summary>
    internal class DescribeCacheSecurityGroupsResponseUnmarshaller : IResponseUnmarshaller<DescribeCacheSecurityGroupsResponse, UnmarshallerContext> {

        public DescribeCacheSecurityGroupsResponse Unmarshall(UnmarshallerContext context) 
        {
            DescribeCacheSecurityGroupsResponse response = new DescribeCacheSecurityGroupsResponse();

            while (context.Read())
            {
                if (context.IsStartElement)
                {
                    if(context.TestExpression("DescribeCacheSecurityGroupsResult", 2))
                    {
                        response.DescribeCacheSecurityGroupsResult = DescribeCacheSecurityGroupsResultUnmarshaller.GetInstance().Unmarshall(context);
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
        
        
        public AmazonServiceException UnmarshallException(UnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValue"))
            {
                return new InvalidParameterValueException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterCombination"))
            {
                return new InvalidParameterCombinationException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("CacheSecurityGroupNotFound"))
            {
                return new CacheSecurityGroupNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            return new AmazonElastiCacheException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static DescribeCacheSecurityGroupsResponseUnmarshaller instance;

        public static DescribeCacheSecurityGroupsResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new DescribeCacheSecurityGroupsResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
