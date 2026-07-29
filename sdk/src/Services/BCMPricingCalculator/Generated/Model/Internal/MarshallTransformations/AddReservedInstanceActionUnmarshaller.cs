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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BCMPricingCalculator.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.BCMPricingCalculator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AddReservedInstanceAction Object
    /// </summary>  
    public class AddReservedInstanceActionUnmarshaller : ICborUnmarshaller<AddReservedInstanceAction, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AddReservedInstanceAction Unmarshall(CborUnmarshallerContext context)
        {
            AddReservedInstanceAction unmarshalledObject = new AddReservedInstanceAction();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "instanceCount":
                        {
                            context.AddPathSegment("InstanceCount");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.InstanceCount = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "reservedInstancesOfferingId":
                        {
                            context.AddPathSegment("ReservedInstancesOfferingId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ReservedInstancesOfferingId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }


        private static AddReservedInstanceActionUnmarshaller _instance = new AddReservedInstanceActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AddReservedInstanceActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}