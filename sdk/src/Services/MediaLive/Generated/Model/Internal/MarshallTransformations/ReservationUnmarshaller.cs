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
    /// Response Unmarshaller for Reservation Object
    /// </summary>  
    public class ReservationUnmarshaller : IUnmarshaller<Reservation, XmlUnmarshallerContext>, IUnmarshaller<Reservation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Reservation IUnmarshaller<Reservation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Reservation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Reservation unmarshalledObject = new Reservation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("count", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Count = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("currencyCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrencyCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("duration", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Duration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("durationUnits", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DurationUnits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("end", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.End = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fixedPrice", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.FixedPrice = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("offeringDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OfferingDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("offeringId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OfferingId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("offeringType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OfferingType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("region", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Region = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("reservationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReservationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceSpecification", targetDepth))
                {
                    var unmarshaller = ReservationResourceSpecificationUnmarshaller.Instance;
                    unmarshalledObject.ResourceSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("start", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Start = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("state", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("usagePrice", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.UsagePrice = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ReservationUnmarshaller _instance = new ReservationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReservationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}