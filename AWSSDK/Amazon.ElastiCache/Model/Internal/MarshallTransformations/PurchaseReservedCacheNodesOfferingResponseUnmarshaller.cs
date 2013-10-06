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
    ///    Response Unmarshaller for PurchaseReservedCacheNodesOffering operation
    /// </summary>
    internal class PurchaseReservedCacheNodesOfferingResponseUnmarshaller : XmlResponseUnmarshaller
    {

        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {
            PurchaseReservedCacheNodesOfferingResponse response = new PurchaseReservedCacheNodesOfferingResponse();
            
            while (context.Read())
            {
                if (context.IsStartElement)
                {
                    
                    if(context.TestExpression("PurchaseReservedCacheNodesOfferingResult", 2))
                    {
                        response.PurchaseReservedCacheNodesOfferingResult = PurchaseReservedCacheNodesOfferingResultUnmarshaller.GetInstance().Unmarshall(context);
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
            
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValue"))
            {
                return new InvalidParameterValueException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("ReservedCacheNodeQuotaExceeded"))
            {
                return new ReservedCacheNodeQuotaExceededException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("ReservedCacheNodeAlreadyExists"))
            {
                return new ReservedCacheNodeAlreadyExistsException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("ReservedCacheNodesOfferingNotFound"))
            {
                return new ReservedCacheNodesOfferingNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterCombination"))
            {
                return new InvalidParameterCombinationException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            return new AmazonElastiCacheException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static PurchaseReservedCacheNodesOfferingResponseUnmarshaller instance;

        public static PurchaseReservedCacheNodesOfferingResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new PurchaseReservedCacheNodesOfferingResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
