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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PrefetchConsumption Marshaller
    /// </summary>
    public class PrefetchConsumptionMarshaller : IRequestMarshaller<PrefetchConsumption, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PrefetchConsumption requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAvailMatchingCriteria())
            {
                context.Writer.WritePropertyName("AvailMatchingCriteria");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAvailMatchingCriteriaListValue in requestObject.AvailMatchingCriteria)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AvailMatchingCriteriaMarshaller.Instance;
                    marshaller.Marshall(requestObjectAvailMatchingCriteriaListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEndTime())
            {
                context.Writer.WritePropertyName("EndTime");
                context.Writer.Write(requestObject.EndTime);
            }

            if(requestObject.IsSetStartTime())
            {
                context.Writer.WritePropertyName("StartTime");
                context.Writer.Write(requestObject.StartTime);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PrefetchConsumptionMarshaller Instance = new PrefetchConsumptionMarshaller();

    }
}