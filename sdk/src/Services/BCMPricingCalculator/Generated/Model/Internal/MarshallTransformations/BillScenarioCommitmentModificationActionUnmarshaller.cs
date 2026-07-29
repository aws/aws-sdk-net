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
    /// Response Unmarshaller for BillScenarioCommitmentModificationAction Object
    /// </summary>  
    public class BillScenarioCommitmentModificationActionUnmarshaller : ICborUnmarshaller<BillScenarioCommitmentModificationAction, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public BillScenarioCommitmentModificationAction Unmarshall(CborUnmarshallerContext context)
        {
            BillScenarioCommitmentModificationAction unmarshalledObject = new BillScenarioCommitmentModificationAction();
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
                    case "addReservedInstanceAction":
                        {
                            context.AddPathSegment("AddReservedInstanceAction");
                            var unmarshaller = AddReservedInstanceActionUnmarshaller.Instance;
                            unmarshalledObject.AddReservedInstanceAction = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "addSavingsPlanAction":
                        {
                            context.AddPathSegment("AddSavingsPlanAction");
                            var unmarshaller = AddSavingsPlanActionUnmarshaller.Instance;
                            unmarshalledObject.AddSavingsPlanAction = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "negateReservedInstanceAction":
                        {
                            context.AddPathSegment("NegateReservedInstanceAction");
                            var unmarshaller = NegateReservedInstanceActionUnmarshaller.Instance;
                            unmarshalledObject.NegateReservedInstanceAction = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "negateSavingsPlanAction":
                        {
                            context.AddPathSegment("NegateSavingsPlanAction");
                            var unmarshaller = NegateSavingsPlanActionUnmarshaller.Instance;
                            unmarshalledObject.NegateSavingsPlanAction = unmarshaller.Unmarshall(context);
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


        private static BillScenarioCommitmentModificationActionUnmarshaller _instance = new BillScenarioCommitmentModificationActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BillScenarioCommitmentModificationActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}