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
    /// DisplayFormatOptions Marshaller
    /// </summary>
    public class DisplayFormatOptionsMarshaller : IRequestMarshaller<DisplayFormatOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DisplayFormatOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBlankCellFormat())
            {
                context.Writer.WritePropertyName("BlankCellFormat");
                context.Writer.Write(requestObject.BlankCellFormat);
            }

            if(requestObject.IsSetCurrencySymbol())
            {
                context.Writer.WritePropertyName("CurrencySymbol");
                context.Writer.Write(requestObject.CurrencySymbol);
            }

            if(requestObject.IsSetDateFormat())
            {
                context.Writer.WritePropertyName("DateFormat");
                context.Writer.Write(requestObject.DateFormat);
            }

            if(requestObject.IsSetDecimalSeparator())
            {
                context.Writer.WritePropertyName("DecimalSeparator");
                context.Writer.Write(requestObject.DecimalSeparator);
            }

            if(requestObject.IsSetFractionDigits())
            {
                context.Writer.WritePropertyName("FractionDigits");
                context.Writer.Write(requestObject.FractionDigits);
            }

            if(requestObject.IsSetGroupingSeparator())
            {
                context.Writer.WritePropertyName("GroupingSeparator");
                context.Writer.Write(requestObject.GroupingSeparator);
            }

            if(requestObject.IsSetNegativeFormat())
            {
                context.Writer.WritePropertyName("NegativeFormat");
                context.Writer.WriteObjectStart();

                var marshaller = NegativeFormatMarshaller.Instance;
                marshaller.Marshall(requestObject.NegativeFormat, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPrefix())
            {
                context.Writer.WritePropertyName("Prefix");
                context.Writer.Write(requestObject.Prefix);
            }

            if(requestObject.IsSetSuffix())
            {
                context.Writer.WritePropertyName("Suffix");
                context.Writer.Write(requestObject.Suffix);
            }

            if(requestObject.IsSetUnitScaler())
            {
                context.Writer.WritePropertyName("UnitScaler");
                context.Writer.Write(requestObject.UnitScaler);
            }

            if(requestObject.IsSetUseBlankCellFormat())
            {
                context.Writer.WritePropertyName("UseBlankCellFormat");
                context.Writer.Write(requestObject.UseBlankCellFormat);
            }

            if(requestObject.IsSetUseGrouping())
            {
                context.Writer.WritePropertyName("UseGrouping");
                context.Writer.Write(requestObject.UseGrouping);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DisplayFormatOptionsMarshaller Instance = new DisplayFormatOptionsMarshaller();

    }
}