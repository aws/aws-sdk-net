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
    /// ScheduledQueryConfiguration Marshaller
    /// </summary>
    public class ScheduledQueryConfigurationMarshaller : IRequestMarshaller<ScheduledQueryConfiguration, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ScheduledQueryConfiguration requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetAggregationExpression())
            {
                context.Writer.WriteTextString("AggregationExpression");
                context.Writer.WriteTextString(requestObject.AggregationExpression);
            }
            if (requestObject.IsSetLogGroupIdentifiers())
            {
                context.Writer.WriteTextString("LogGroupIdentifiers");
                context.Writer.WriteStartArray(requestObject.LogGroupIdentifiers.Count);
                foreach(var requestObjectLogGroupIdentifiersListValue in requestObject.LogGroupIdentifiers)
                {
                        context.Writer.WriteTextString(requestObjectLogGroupIdentifiersListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetQueryARN())
            {
                context.Writer.WriteTextString("QueryARN");
                context.Writer.WriteTextString(requestObject.QueryARN);
            }
            if (requestObject.IsSetQueryString())
            {
                context.Writer.WriteTextString("QueryString");
                context.Writer.WriteTextString(requestObject.QueryString);
            }
            if (requestObject.IsSetScheduleConfiguration())
            {
                context.Writer.WriteTextString("ScheduleConfiguration");
                context.Writer.WriteStartMap(null);

                var marshaller = ScheduleConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ScheduleConfiguration, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetScheduledQueryRoleARN())
            {
                context.Writer.WriteTextString("ScheduledQueryRoleARN");
                context.Writer.WriteTextString(requestObject.ScheduledQueryRoleARN);
            }
            if (requestObject.IsSetTags())
            {
                context.Writer.WriteTextString("Tags");
                context.Writer.WriteStartArray(requestObject.Tags.Count);
                foreach(var requestObjectTagsListValue in requestObject.Tags)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScheduledQueryConfigurationMarshaller Instance = new ScheduledQueryConfigurationMarshaller();

    }
}