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

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RDS.Model.Transform
{
    /// <summary>
    ///    Response Unmarshaller for DescribeDBInstances operation
    /// </summary>
    internal class DescribeDBInstancesResponseUnmarshaller : IResponseUnmarshaller<DescribeDBInstancesResponse, UnmarshallerContext> {

        public DescribeDBInstancesResponse Unmarshall(UnmarshallerContext context) 
        {
            DescribeDBInstancesResponse response = new DescribeDBInstancesResponse();

            while (context.Read())
            {
                if (context.IsStartElement)
                {
                    if(context.TestExpression("DescribeDBInstancesResult", 2))
                    {
                        response.DescribeDBInstancesResult = DescribeDBInstancesResultUnmarshaller.GetInstance().Unmarshall(context);
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
            
            if (errorResponse.Code != null && errorResponse.Code.Equals("DBInstanceNotFound"))
            {
                return new DBInstanceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            return new AmazonRDSException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static DescribeDBInstancesResponseUnmarshaller instance;

        public static DescribeDBInstancesResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new DescribeDBInstancesResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
