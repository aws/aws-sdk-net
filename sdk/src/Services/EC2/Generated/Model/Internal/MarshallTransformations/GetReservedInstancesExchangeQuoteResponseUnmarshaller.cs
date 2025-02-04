/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetReservedInstancesExchangeQuote operation
    /// </summary>  
    public class GetReservedInstancesExchangeQuoteResponseUnmarshaller : EC2ResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            GetReservedInstancesExchangeQuoteResponse response = new GetReservedInstancesExchangeQuoteResponse();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth = 2;

            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("currencyCode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.CurrencyCode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("isValidExchange", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.IsValidExchange = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("outputReservedInstancesWillExpireAt", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        response.OutputReservedInstancesWillExpireAt = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("paymentDue", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.PaymentDue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("reservedInstanceValueRollup", targetDepth))
                    {
                        var unmarshaller = ReservationValueUnmarshaller.Instance;
                        response.ReservedInstanceValueRollup = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("reservedInstanceValueSet/item", targetDepth))
                    {
                        var unmarshaller = ReservedInstanceReservationValueUnmarshaller.Instance;
                        if (response.ReservedInstanceValueSet == null)
                        {
                            response.ReservedInstanceValueSet = new List<ReservedInstanceReservationValue>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.ReservedInstanceValueSet.Add(item);
                        continue;
                    }
                    if (context.TestExpression("targetConfigurationValueRollup", targetDepth))
                    {
                        var unmarshaller = ReservationValueUnmarshaller.Instance;
                        response.TargetConfigurationValueRollup = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("targetConfigurationValueSet/item", targetDepth))
                    {
                        var unmarshaller = TargetReservationValueUnmarshaller.Instance;
                        if (response.TargetConfigurationValueSet == null)
                        {
                            response.TargetConfigurationValueSet = new List<TargetReservationValue>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.TargetConfigurationValueSet.Add(item);
                        continue;
                    }
                    if (context.TestExpression("validationFailureReason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ValidationFailureReason = unmarshaller.Unmarshall(context);
                        continue;
                    }
                } 
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            return new AmazonEC2Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static GetReservedInstancesExchangeQuoteResponseUnmarshaller _instance = new GetReservedInstancesExchangeQuoteResponseUnmarshaller();        

        internal static GetReservedInstancesExchangeQuoteResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetReservedInstancesExchangeQuoteResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}