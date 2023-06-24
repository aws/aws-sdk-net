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
    /// TableCellStyle Marshaller
    /// </summary>
    public class TableCellStyleMarshaller : IRequestMarshaller<TableCellStyle, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TableCellStyle requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBackgroundColor())
            {
                context.Writer.WritePropertyName("BackgroundColor");
                context.Writer.Write(requestObject.BackgroundColor);
            }

            if(requestObject.IsSetBorder())
            {
                context.Writer.WritePropertyName("Border");
                context.Writer.WriteObjectStart();

                var marshaller = GlobalTableBorderOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Border, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFontConfiguration())
            {
                context.Writer.WritePropertyName("FontConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = FontConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.FontConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHeight())
            {
                context.Writer.WritePropertyName("Height");
                context.Writer.Write(requestObject.Height);
            }

            if(requestObject.IsSetHorizontalTextAlignment())
            {
                context.Writer.WritePropertyName("HorizontalTextAlignment");
                context.Writer.Write(requestObject.HorizontalTextAlignment);
            }

            if(requestObject.IsSetTextWrap())
            {
                context.Writer.WritePropertyName("TextWrap");
                context.Writer.Write(requestObject.TextWrap);
            }

            if(requestObject.IsSetVerticalTextAlignment())
            {
                context.Writer.WritePropertyName("VerticalTextAlignment");
                context.Writer.Write(requestObject.VerticalTextAlignment);
            }

            if(requestObject.IsSetVisibility())
            {
                context.Writer.WritePropertyName("Visibility");
                context.Writer.Write(requestObject.Visibility);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TableCellStyleMarshaller Instance = new TableCellStyleMarshaller();

    }
}