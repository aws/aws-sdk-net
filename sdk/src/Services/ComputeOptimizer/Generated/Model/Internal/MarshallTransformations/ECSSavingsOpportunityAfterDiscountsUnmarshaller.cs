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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComputeOptimizer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.ComputeOptimizer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ECSSavingsOpportunityAfterDiscounts Object
    /// </summary>  
    public class ECSSavingsOpportunityAfterDiscountsUnmarshaller : ICborUnmarshaller<ECSSavingsOpportunityAfterDiscounts, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ECSSavingsOpportunityAfterDiscounts Unmarshall(CborUnmarshallerContext context)
        {
            ECSSavingsOpportunityAfterDiscounts unmarshalledObject = new ECSSavingsOpportunityAfterDiscounts();
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
                    case "estimatedMonthlySavings":
                        {
                            context.AddPathSegment("EstimatedMonthlySavings");
                            var unmarshaller = ECSEstimatedMonthlySavingsUnmarshaller.Instance;
                            unmarshalledObject.EstimatedMonthlySavings = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "savingsOpportunityPercentage":
                        {
                            context.AddPathSegment("SavingsOpportunityPercentage");
                            var unmarshaller = CborNullableDoubleUnmarshaller.Instance;
                            unmarshalledObject.SavingsOpportunityPercentage = unmarshaller.Unmarshall(context);
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


        private static ECSSavingsOpportunityAfterDiscountsUnmarshaller _instance = new ECSSavingsOpportunityAfterDiscountsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ECSSavingsOpportunityAfterDiscountsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}