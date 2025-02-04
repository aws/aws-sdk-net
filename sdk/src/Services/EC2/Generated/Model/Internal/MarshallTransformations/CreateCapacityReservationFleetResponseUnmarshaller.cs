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
    /// Response Unmarshaller for CreateCapacityReservationFleet operation
    /// </summary>  
    public class CreateCapacityReservationFleetResponseUnmarshaller : EC2ResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            CreateCapacityReservationFleetResponse response = new CreateCapacityReservationFleetResponse();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth = 2;

            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("allocationStrategy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.AllocationStrategy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("capacityReservationFleetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.CapacityReservationFleetId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("createTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        response.CreateTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("endDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        response.EndDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("fleetCapacityReservationSet/item", targetDepth))
                    {
                        var unmarshaller = FleetCapacityReservationUnmarshaller.Instance;
                        if (response.FleetCapacityReservations == null)
                        {
                            response.FleetCapacityReservations = new List<FleetCapacityReservation>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.FleetCapacityReservations.Add(item);
                        continue;
                    }
                    if (context.TestExpression("instanceMatchCriteria", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.InstanceMatchCriteria = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.State = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (response.Tags == null)
                        {
                            response.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("tenancy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Tenancy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("totalFulfilledCapacity", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        response.TotalFulfilledCapacity = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("totalTargetCapacity", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        response.TotalTargetCapacity = unmarshaller.Unmarshall(context);
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
        private static CreateCapacityReservationFleetResponseUnmarshaller _instance = new CreateCapacityReservationFleetResponseUnmarshaller();        

        internal static CreateCapacityReservationFleetResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCapacityReservationFleetResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}