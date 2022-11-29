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
    /// FontConfiguration Marshaller
    /// </summary>
    public class FontConfigurationMarshaller : IRequestMarshaller<FontConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FontConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFontColor())
            {
                context.Writer.WritePropertyName("FontColor");
                context.Writer.Write(requestObject.FontColor);
            }

            if(requestObject.IsSetFontDecoration())
            {
                context.Writer.WritePropertyName("FontDecoration");
                context.Writer.Write(requestObject.FontDecoration);
            }

            if(requestObject.IsSetFontSize())
            {
                context.Writer.WritePropertyName("FontSize");
                context.Writer.WriteObjectStart();

                var marshaller = FontSizeMarshaller.Instance;
                marshaller.Marshall(requestObject.FontSize, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFontStyle())
            {
                context.Writer.WritePropertyName("FontStyle");
                context.Writer.Write(requestObject.FontStyle);
            }

            if(requestObject.IsSetFontWeight())
            {
                context.Writer.WritePropertyName("FontWeight");
                context.Writer.WriteObjectStart();

                var marshaller = FontWeightMarshaller.Instance;
                marshaller.Marshall(requestObject.FontWeight, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FontConfigurationMarshaller Instance = new FontConfigurationMarshaller();

    }
}