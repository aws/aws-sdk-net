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

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for DescribeCacheEngineVersions operation
    /// </summary>
    internal class DescribeCacheEngineVersionsResponseUnmarshaller : XmlResponseUnmarshaller
    {

        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {
            DescribeCacheEngineVersionsResponse response = new DescribeCacheEngineVersionsResponse();
            
            while (context.Read())
            {
                if (context.IsStartElement)                
                {
                    if(context.TestExpression("DescribeCacheEngineVersionsResult", 2))
                    {
                        response.DescribeCacheEngineVersionsResult = DescribeCacheEngineVersionsResultUnmarshaller.GetInstance().Unmarshall(context);
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
            
            return new AmazonElastiCacheException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static DescribeCacheEngineVersionsResponseUnmarshaller instance;

        public static DescribeCacheEngineVersionsResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new DescribeCacheEngineVersionsResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
