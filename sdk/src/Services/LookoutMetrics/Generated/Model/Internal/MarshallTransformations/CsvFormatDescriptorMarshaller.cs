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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutMetrics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LookoutMetrics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CsvFormatDescriptor Marshaller
    /// </summary>
    public class CsvFormatDescriptorMarshaller : IRequestMarshaller<CsvFormatDescriptor, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CsvFormatDescriptor requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCharset())
            {
                context.Writer.WritePropertyName("Charset");
                context.Writer.Write(requestObject.Charset);
            }

            if(requestObject.IsSetContainsHeader())
            {
                context.Writer.WritePropertyName("ContainsHeader");
                context.Writer.Write(requestObject.ContainsHeader);
            }

            if(requestObject.IsSetDelimiter())
            {
                context.Writer.WritePropertyName("Delimiter");
                context.Writer.Write(requestObject.Delimiter);
            }

            if(requestObject.IsSetFileCompression())
            {
                context.Writer.WritePropertyName("FileCompression");
                context.Writer.Write(requestObject.FileCompression);
            }

            if(requestObject.IsSetHeaderList())
            {
                context.Writer.WritePropertyName("HeaderList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectHeaderListListValue in requestObject.HeaderList)
                {
                        context.Writer.Write(requestObjectHeaderListListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetQuoteSymbol())
            {
                context.Writer.WritePropertyName("QuoteSymbol");
                context.Writer.Write(requestObject.QuoteSymbol);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CsvFormatDescriptorMarshaller Instance = new CsvFormatDescriptorMarshaller();

    }
}