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
    /// ReferenceLineLabelConfiguration Marshaller
    /// </summary>
    public class ReferenceLineLabelConfigurationMarshaller : IRequestMarshaller<ReferenceLineLabelConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ReferenceLineLabelConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCustomLabelConfiguration())
            {
                context.Writer.WritePropertyName("CustomLabelConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ReferenceLineCustomLabelConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomLabelConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFontColor())
            {
                context.Writer.WritePropertyName("FontColor");
                context.Writer.Write(requestObject.FontColor);
            }

            if(requestObject.IsSetFontConfiguration())
            {
                context.Writer.WritePropertyName("FontConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = FontConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.FontConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHorizontalPosition())
            {
                context.Writer.WritePropertyName("HorizontalPosition");
                context.Writer.Write(requestObject.HorizontalPosition);
            }

            if(requestObject.IsSetValueLabelConfiguration())
            {
                context.Writer.WritePropertyName("ValueLabelConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ReferenceLineValueLabelConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ValueLabelConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVerticalPosition())
            {
                context.Writer.WritePropertyName("VerticalPosition");
                context.Writer.Write(requestObject.VerticalPosition);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ReferenceLineLabelConfigurationMarshaller Instance = new ReferenceLineLabelConfigurationMarshaller();

    }
}