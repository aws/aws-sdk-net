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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FilterConfiguration Marshaller
    /// </summary>
    public class FilterConfigurationMarshaller : IRequestMarshaller<FilterConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FilterConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBetweenConfiguration())
            {
                context.Writer.WritePropertyName("BetweenConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = BetweenConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.BetweenConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDateTimeFormat())
            {
                context.Writer.WritePropertyName("DateTimeFormat");
                context.Writer.WriteStringValue(requestObject.DateTimeFormat);
            }

            if(requestObject.IsSetFilterMode())
            {
                context.Writer.WritePropertyName("FilterMode");
                context.Writer.WriteStringValue(requestObject.FilterMode);
            }

            if(requestObject.IsSetFilterStringConfiguration())
            {
                context.Writer.WritePropertyName("FilterStringConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = FilterStringConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.FilterStringConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOperatorMappings())
            {
                context.Writer.WritePropertyName("OperatorMappings");
                context.Writer.WriteStartObject();
                foreach (var requestObjectOperatorMappingsKvp in requestObject.OperatorMappings)
                {
                    context.Writer.WritePropertyName(requestObjectOperatorMappingsKvp.Key);
                    var requestObjectOperatorMappingsValue = requestObjectOperatorMappingsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectOperatorMappingsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStripQuotes())
            {
                context.Writer.WritePropertyName("StripQuotes");
                context.Writer.WriteBooleanValue(requestObject.StripQuotes.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FilterConfigurationMarshaller Instance = new FilterConfigurationMarshaller();

    }
}