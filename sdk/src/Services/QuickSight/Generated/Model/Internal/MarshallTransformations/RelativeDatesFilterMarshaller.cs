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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RelativeDatesFilter Marshaller
    /// </summary>
    public class RelativeDatesFilterMarshaller : IRequestMarshaller<RelativeDatesFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RelativeDatesFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAnchorDateConfiguration())
            {
                context.Writer.WritePropertyName("AnchorDateConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AnchorDateConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AnchorDateConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetColumn())
            {
                context.Writer.WritePropertyName("Column");
                context.Writer.WriteStartObject();

                var marshaller = ColumnIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.Column, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDefaultFilterControlConfiguration())
            {
                context.Writer.WritePropertyName("DefaultFilterControlConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DefaultFilterControlConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultFilterControlConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExcludePeriodConfiguration())
            {
                context.Writer.WritePropertyName("ExcludePeriodConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ExcludePeriodConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ExcludePeriodConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFilterId())
            {
                context.Writer.WritePropertyName("FilterId");
                context.Writer.WriteStringValue(requestObject.FilterId);
            }

            if(requestObject.IsSetMinimumGranularity())
            {
                context.Writer.WritePropertyName("MinimumGranularity");
                context.Writer.WriteStringValue(requestObject.MinimumGranularity);
            }

            if(requestObject.IsSetNullOption())
            {
                context.Writer.WritePropertyName("NullOption");
                context.Writer.WriteStringValue(requestObject.NullOption);
            }

            if(requestObject.IsSetParameterName())
            {
                context.Writer.WritePropertyName("ParameterName");
                context.Writer.WriteStringValue(requestObject.ParameterName);
            }

            if(requestObject.IsSetRelativeDateType())
            {
                context.Writer.WritePropertyName("RelativeDateType");
                context.Writer.WriteStringValue(requestObject.RelativeDateType);
            }

            if(requestObject.IsSetRelativeDateValue())
            {
                context.Writer.WritePropertyName("RelativeDateValue");
                context.Writer.WriteNumberValue(requestObject.RelativeDateValue.Value);
            }

            if(requestObject.IsSetTimeGranularity())
            {
                context.Writer.WritePropertyName("TimeGranularity");
                context.Writer.WriteStringValue(requestObject.TimeGranularity);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RelativeDatesFilterMarshaller Instance = new RelativeDatesFilterMarshaller();

    }
}