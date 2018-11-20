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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExponentialRolloutRate Marshaller
    /// </summary>       
    public class ExponentialRolloutRateMarshaller : IRequestMarshaller<ExponentialRolloutRate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ExponentialRolloutRate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBaseRatePerMinute())
            {
                context.Writer.WritePropertyName("baseRatePerMinute");
                context.Writer.Write(requestObject.BaseRatePerMinute);
            }

            if(requestObject.IsSetIncrementFactor())
            {
                context.Writer.WritePropertyName("incrementFactor");
                context.Writer.Write(requestObject.IncrementFactor);
            }

            if(requestObject.IsSetRateIncreaseCriteria())
            {
                context.Writer.WritePropertyName("rateIncreaseCriteria");
                context.Writer.WriteObjectStart();

                var marshaller = RateIncreaseCriteriaMarshaller.Instance;
                marshaller.Marshall(requestObject.RateIncreaseCriteria, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ExponentialRolloutRateMarshaller Instance = new ExponentialRolloutRateMarshaller();

    }
}