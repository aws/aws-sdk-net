/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeReservation operation
    /// </summary>  
    public class DescribeReservationResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeReservationResponse response = new DescribeReservationResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("count", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.Count = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("currencyCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CurrencyCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("duration", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.Duration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("durationUnits", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DurationUnits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("end", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.End = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fixedPrice", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    response.FixedPrice = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("offeringDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OfferingDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("offeringId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OfferingId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("offeringType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OfferingType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("region", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Region = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("reservationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ReservationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceSpecification", targetDepth))
                {
                    var unmarshaller = ReservationResourceSpecificationUnmarshaller.Instance;
                    response.ResourceSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("start", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Start = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("state", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("usagePrice", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    response.UsagePrice = unmarshaller.Unmarshall(context);
                    continue;
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
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("BadGatewayException"))
            {
                return new BadGatewayException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequestException"))
            {
                return new BadRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ForbiddenException"))
            {
                return new ForbiddenException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("GatewayTimeoutException"))
            {
                return new GatewayTimeoutException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerErrorException"))
            {
                return new InternalServerErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("NotFoundException"))
            {
                return new NotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
            {
                return new TooManyRequestsException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonMediaLiveException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeReservationResponseUnmarshaller _instance = new DescribeReservationResponseUnmarshaller();        

        internal static DescribeReservationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeReservationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}