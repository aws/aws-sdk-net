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
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NumberDisplayFormatConfiguration Marshaller
    /// </summary>
    public class NumberDisplayFormatConfigurationMarshaller : IRequestMarshaller<NumberDisplayFormatConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NumberDisplayFormatConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDecimalPlacesConfiguration())
            {
                context.Writer.WritePropertyName("DecimalPlacesConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = DecimalPlacesConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DecimalPlacesConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNegativeValueConfiguration())
            {
                context.Writer.WritePropertyName("NegativeValueConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = NegativeValueConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.NegativeValueConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNullValueFormatConfiguration())
            {
                context.Writer.WritePropertyName("NullValueFormatConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = NullValueFormatConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.NullValueFormatConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNumberScale())
            {
                context.Writer.WritePropertyName("NumberScale");
                context.Writer.Write(requestObject.NumberScale);
            }

            if(requestObject.IsSetPrefix())
            {
                context.Writer.WritePropertyName("Prefix");
                context.Writer.Write(requestObject.Prefix);
            }

            if(requestObject.IsSetSeparatorConfiguration())
            {
                context.Writer.WritePropertyName("SeparatorConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = NumericSeparatorConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SeparatorConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSuffix())
            {
                context.Writer.WritePropertyName("Suffix");
                context.Writer.Write(requestObject.Suffix);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NumberDisplayFormatConfigurationMarshaller Instance = new NumberDisplayFormatConfigurationMarshaller();

    }
}