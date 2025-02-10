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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glacier.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CSVInput Marshaller
    /// </summary>
    public class CSVInputMarshaller : IRequestMarshaller<CSVInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CSVInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComments())
            {
                context.Writer.WritePropertyName("Comments");
                context.Writer.WriteStringValue(requestObject.Comments);
            }

            if(requestObject.IsSetFieldDelimiter())
            {
                context.Writer.WritePropertyName("FieldDelimiter");
                context.Writer.WriteStringValue(requestObject.FieldDelimiter);
            }

            if(requestObject.IsSetFileHeaderInfo())
            {
                context.Writer.WritePropertyName("FileHeaderInfo");
                context.Writer.WriteStringValue(requestObject.FileHeaderInfo);
            }

            if(requestObject.IsSetQuoteCharacter())
            {
                context.Writer.WritePropertyName("QuoteCharacter");
                context.Writer.WriteStringValue(requestObject.QuoteCharacter);
            }

            if(requestObject.IsSetQuoteEscapeCharacter())
            {
                context.Writer.WritePropertyName("QuoteEscapeCharacter");
                context.Writer.WriteStringValue(requestObject.QuoteEscapeCharacter);
            }

            if(requestObject.IsSetRecordDelimiter())
            {
                context.Writer.WritePropertyName("RecordDelimiter");
                context.Writer.WriteStringValue(requestObject.RecordDelimiter);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CSVInputMarshaller Instance = new CSVInputMarshaller();

    }
}