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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationDiscoveryService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationDiscoveryService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UsageMetricBasis Marshaller
    /// </summary>
    public class UsageMetricBasisMarshaller : IRequestMarshaller<UsageMetricBasis, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UsageMetricBasis requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetPercentageAdjust())
            {
                context.Writer.WritePropertyName("percentageAdjust");
                if(StringUtils.IsSpecialDoubleValue(requestObject.PercentageAdjust.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.PercentageAdjust.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.PercentageAdjust.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UsageMetricBasisMarshaller Instance = new UsageMetricBasisMarshaller();

    }
}