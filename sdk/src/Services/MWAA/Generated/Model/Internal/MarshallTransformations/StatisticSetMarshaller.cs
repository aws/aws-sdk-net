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
                if(StringUtils.IsSpecialDoubleValue(requestObject.Maximum.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Maximum.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Maximum.Value);
                }
            }

            if(requestObject.IsSetMinimum())
            {
                context.Writer.WritePropertyName("Minimum");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Minimum.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Minimum.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Minimum.Value);
                }
            }

            if(requestObject.IsSetSampleCount())
            {
                context.Writer.WritePropertyName("SampleCount");
                context.Writer.WriteNumberValue(requestObject.SampleCount.Value);
            }

            if(requestObject.IsSetSum())
            {
                context.Writer.WritePropertyName("Sum");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Sum.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Sum.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Sum.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StatisticSetMarshaller Instance = new StatisticSetMarshaller();

    }
}