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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.ComputeOptimizer.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ComputeOptimizer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for IdleSavingsOpportunityAfterDiscounts Object
    /// </summary>
    public partial class IdleSavingsOpportunityAfterDiscountsUnmarshaller : ICborUnmarshaller<IdleSavingsOpportunityAfterDiscounts, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public IdleSavingsOpportunityAfterDiscounts Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new IdleSavingsOpportunityAfterDiscounts();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "estimatedMonthlySavings":
                        context.AddPathSegment("EstimatedMonthlySavings");
                        unmarshalledObject.EstimatedMonthlySavings = IdleEstimatedMonthlySavingsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "savingsOpportunityPercentage":
                        context.AddPathSegment("SavingsOpportunityPercentage");
                        unmarshalledObject.SavingsOpportunityPercentage = CborNullableDoubleUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }

        private static IdleSavingsOpportunityAfterDiscountsUnmarshaller _instance = new IdleSavingsOpportunityAfterDiscountsUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static IdleSavingsOpportunityAfterDiscountsUnmarshaller Instance => _instance;
    }
}
