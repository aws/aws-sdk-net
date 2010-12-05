/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticMapReduce.Model.Transform
{
    /// <summary>
    ///    Response Unmarshaller for AddInstanceGroups operation
    /// </summary>
    internal class AddInstanceGroupsResponseUnmarshaller : IResponseUnmarshaller<AddInstanceGroupsResponse, UnmarshallerContext> {

        public AddInstanceGroupsResponse Unmarshall(UnmarshallerContext context) 
        {
            AddInstanceGroupsResponse response = new AddInstanceGroupsResponse();

            while (context.Read())
            {
                if (context.IsStartElement)
                {
                    if(context.TestExpression("AddInstanceGroupsResult", 2))
                    {
                        response.AddInstanceGroupsResult = AddInstanceGroupsResultUnmarshaller.GetInstance().Unmarshall(context);
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
            
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalFailure"))
            {
                return new InternalServerErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            return new AmazonElasticMapReduceException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static AddInstanceGroupsResponseUnmarshaller instance;

        public static AddInstanceGroupsResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new AddInstanceGroupsResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
