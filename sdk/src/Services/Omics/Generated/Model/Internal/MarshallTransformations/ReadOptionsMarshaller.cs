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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Omics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReadOptions Marshaller
    /// </summary>
    public class ReadOptionsMarshaller : IRequestMarshaller<ReadOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ReadOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComment())
            {
                context.Writer.WritePropertyName("comment");
                context.Writer.WriteStringValue(requestObject.Comment);
            }

            if(requestObject.IsSetEncoding())
            {
                context.Writer.WritePropertyName("encoding");
                context.Writer.WriteStringValue(requestObject.Encoding);
            }

            if(requestObject.IsSetEscape())
            {
                context.Writer.WritePropertyName("escape");
                context.Writer.WriteStringValue(requestObject.Escape);
            }

            if(requestObject.IsSetEscapeQuotes())
            {
                context.Writer.WritePropertyName("escapeQuotes");
                context.Writer.WriteBooleanValue(requestObject.EscapeQuotes.Value);
            }

            if(requestObject.IsSetHeader())
            {
                context.Writer.WritePropertyName("header");
                context.Writer.WriteBooleanValue(requestObject.Header.Value);
            }

            if(requestObject.IsSetLineSep())
            {
                context.Writer.WritePropertyName("lineSep");
                context.Writer.WriteStringValue(requestObject.LineSep);
            }

            if(requestObject.IsSetQuote())
            {
                context.Writer.WritePropertyName("quote");
                context.Writer.WriteStringValue(requestObject.Quote);
            }

            if(requestObject.IsSetQuoteAll())
            {
                context.Writer.WritePropertyName("quoteAll");
                context.Writer.WriteBooleanValue(requestObject.QuoteAll.Value);
            }

            if(requestObject.IsSetSep())
            {
                context.Writer.WritePropertyName("sep");
                context.Writer.WriteStringValue(requestObject.Sep);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ReadOptionsMarshaller Instance = new ReadOptionsMarshaller();

    }
}