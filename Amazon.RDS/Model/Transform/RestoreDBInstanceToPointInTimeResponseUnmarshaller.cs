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

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RDS.Model.Transform
{
    /// <summary>
    ///    Response Unmarshaller for RestoreDBInstanceToPointInTime operation
    /// </summary>
    internal class RestoreDBInstanceToPointInTimeResponseUnmarshaller : IResponseUnmarshaller<RestoreDBInstanceToPointInTimeResponse, UnmarshallerContext> {

        public RestoreDBInstanceToPointInTimeResponse Unmarshall(UnmarshallerContext context) 
        {
            RestoreDBInstanceToPointInTimeResponse response = new RestoreDBInstanceToPointInTimeResponse();

            while (context.Read())
            {
                if (context.IsStartElement)
                {
                    
                    if(context.TestExpression("RestoreDBInstanceToPointInTimeResult", 2))
                    {
                        response.RestoreDBInstanceToPointInTimeResult = RestoreDBInstanceToPointInTimeResultUnmarshaller.GetInstance().Unmarshall(context);
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
            
            if (errorResponse.Code != null && errorResponse.Code.Equals("PointInTimeRestoreNotEnabled"))
            {
                return new PointInTimeRestoreNotEnabledException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("InstanceQuotaExceeded"))
            {
                return new InstanceQuotaExceededException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("DBInstanceAlreadyExists"))
            {
                return new DBInstanceAlreadyExistsException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("DBInstanceNotFound"))
            {
                return new DBInstanceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("StorageQuotaExceeded"))
            {
                return new StorageQuotaExceededException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidDBInstanceState"))
            {
                return new InvalidDBInstanceStateException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("InsufficientDBInstanceCapacity"))
            {
                return new InsufficientDBInstanceCapacityException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            return new AmazonRDSException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static RestoreDBInstanceToPointInTimeResponseUnmarshaller instance;

        public static RestoreDBInstanceToPointInTimeResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new RestoreDBInstanceToPointInTimeResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
