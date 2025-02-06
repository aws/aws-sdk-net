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
    /// DefaultFilterControlOptions Marshaller
    /// </summary>
    public class DefaultFilterControlOptionsMarshaller : IRequestMarshaller<DefaultFilterControlOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DefaultFilterControlOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDefaultDateTimePickerOptions())
            {
                context.Writer.WritePropertyName("DefaultDateTimePickerOptions");
                context.Writer.WriteStartObject();

                var marshaller = DefaultDateTimePickerControlOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultDateTimePickerOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDefaultDropdownOptions())
            {
                context.Writer.WritePropertyName("DefaultDropdownOptions");
                context.Writer.WriteStartObject();

                var marshaller = DefaultFilterDropDownControlOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultDropdownOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDefaultListOptions())
            {
                context.Writer.WritePropertyName("DefaultListOptions");
                context.Writer.WriteStartObject();

                var marshaller = DefaultFilterListControlOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultListOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDefaultRelativeDateTimeOptions())
            {
                context.Writer.WritePropertyName("DefaultRelativeDateTimeOptions");
                context.Writer.WriteStartObject();

                var marshaller = DefaultRelativeDateTimeControlOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultRelativeDateTimeOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDefaultSliderOptions())
            {
                context.Writer.WritePropertyName("DefaultSliderOptions");
                context.Writer.WriteStartObject();

                var marshaller = DefaultSliderControlOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultSliderOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDefaultTextAreaOptions())
            {
                context.Writer.WritePropertyName("DefaultTextAreaOptions");
                context.Writer.WriteStartObject();

                var marshaller = DefaultTextAreaControlOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultTextAreaOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDefaultTextFieldOptions())
            {
                context.Writer.WritePropertyName("DefaultTextFieldOptions");
                context.Writer.WriteStartObject();

                var marshaller = DefaultTextFieldControlOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultTextFieldOptions, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DefaultFilterControlOptionsMarshaller Instance = new DefaultFilterControlOptionsMarshaller();

    }
}