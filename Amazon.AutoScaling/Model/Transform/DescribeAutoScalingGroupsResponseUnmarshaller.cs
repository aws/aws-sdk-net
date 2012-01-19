/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AutoScaling.Model.Transform
{
    /// <summary>
    ///    Response Unmarshaller for DescribeAutoScalingGroups operation
    /// </summary>
    internal class DescribeAutoScalingGroupsResponseUnmarshaller : IResponseUnmarshaller<DescribeAutoScalingGroupsResponse, UnmarshallerContext> {

        public DescribeAutoScalingGroupsResponse Unmarshall(UnmarshallerContext context) 
        {
            DescribeAutoScalingGroupsResponse response = new DescribeAutoScalingGroupsResponse();

            while (context.Read())
            {
                if (context.IsStartElement)
                {
                    if(context.TestExpression("DescribeAutoScalingGroupsResult", 2))
                    {
                        response.DescribeAutoScalingGroupsResult = DescribeAutoScalingGroupsResultUnmarshaller.GetInstance().Unmarshall(context);
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
            
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidNextToken"))
            {
                return new InvalidNextTokenException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            return new AmazonAutoScalingException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static DescribeAutoScalingGroupsResponseUnmarshaller instance;

        public static DescribeAutoScalingGroupsResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new DescribeAutoScalingGroupsResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
