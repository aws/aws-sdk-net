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
using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for GetConsoleOutput operation
    /// </summary>
    internal class GetConsoleOutputResponseUnmarshaller : EC2ResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            GetConsoleOutputResponse response = new GetConsoleOutputResponse();
            
            int targetDepth = 2;
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    
                    if (context.TestExpression("instanceId", targetDepth))
                    {
                        response.InstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("timestamp", targetDepth))
                    {
                        response.Timestamp = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("output", targetDepth))
                    {
                        response.Output = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
            }
                 
                        
            return response;
        }
        
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            
            return new AmazonEC2Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static GetConsoleOutputResponseUnmarshaller instance;

        public static GetConsoleOutputResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new GetConsoleOutputResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
