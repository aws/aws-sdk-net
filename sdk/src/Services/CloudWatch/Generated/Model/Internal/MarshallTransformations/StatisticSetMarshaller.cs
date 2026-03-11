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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StatisticSet Marshaller
    /// </summary>
    public class StatisticSetMarshaller : IRequestMarshaller<StatisticSet, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StatisticSet requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetMaximum())
            {
                context.Writer.WriteTextString("Maximum");
                context.Writer.WriteOptimizedNumber(requestObject.Maximum.Value);
            }
            if (requestObject.IsSetMinimum())
            {
                context.Writer.WriteTextString("Minimum");
                context.Writer.WriteOptimizedNumber(requestObject.Minimum.Value);
            }
            if (requestObject.IsSetSampleCount())
            {
                context.Writer.WriteTextString("SampleCount");
                context.Writer.WriteOptimizedNumber(requestObject.SampleCount.Value);
            }
            if (requestObject.IsSetSum())
            {
                context.Writer.WriteTextString("Sum");
                context.Writer.WriteOptimizedNumber(requestObject.Sum.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StatisticSetMarshaller Instance = new StatisticSetMarshaller();

    }
}