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
    ///    Response Unmarshaller for PurchaseReservedNodeOffering operation
    /// </summary>
    internal class PurchaseReservedNodeOfferingResponseUnmarshaller : XmlResponseUnmarshaller
    {

        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {
            PurchaseReservedNodeOfferingResponse response = new PurchaseReservedNodeOfferingResponse();
            
            while (context.Read())
            {
                if (context.IsStartElement)
                {
                    
                    if(context.TestExpression("PurchaseReservedNodeOfferingResult", 2))
                    {
                        response.PurchaseReservedNodeOfferingResult = PurchaseReservedNodeOfferingResultUnmarshaller.GetInstance().Unmarshall(context);
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
            
            if (errorResponse.Code != null && errorResponse.Code.Equals("ReservedNodeAlreadyExists"))
            {
                return new ReservedNodeAlreadyExistsException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("ReservedNodeOfferingNotFound"))
            {
                return new ReservedNodeOfferingNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("ReservedNodeQuotaExceeded"))
            {
                return new ReservedNodeQuotaExceededException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            return new AmazonRedshiftException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static PurchaseReservedNodeOfferingResponseUnmarshaller instance;

        public static PurchaseReservedNodeOfferingResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new PurchaseReservedNodeOfferingResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
