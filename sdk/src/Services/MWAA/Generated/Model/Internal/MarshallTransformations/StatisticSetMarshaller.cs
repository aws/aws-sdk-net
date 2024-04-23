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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MWAA.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MWAA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StatisticSet Marshaller
    /// </summary>
    public class StatisticSetMarshaller : IRequestMarshaller<StatisticSet, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StatisticSet requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMaximum())
            {
                context.Writer.WritePropertyName("Maximum");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Maximum))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Maximum));
                }
                else
                {
                    context.Writer.Write(requestObject.Maximum);
                }
            }

            if(requestObject.IsSetMinimum())
            {
                context.Writer.WritePropertyName("Minimum");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Minimum))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Minimum));
                }
                else
                {
                    context.Writer.Write(requestObject.Minimum);
                }
            }

            if(requestObject.IsSetSampleCount())
            {
                context.Writer.WritePropertyName("SampleCount");
                context.Writer.Write(requestObject.SampleCount);
            }

            if(requestObject.IsSetSum())
            {
                context.Writer.WritePropertyName("Sum");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Sum))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Sum));
                }
                else
                {
                    context.Writer.Write(requestObject.Sum);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StatisticSetMarshaller Instance = new StatisticSetMarshaller();

    }
}
#pragma warning restore CS0612,CS0618