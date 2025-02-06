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
    /// UpdateCsvClassifierRequest Marshaller
    /// </summary>
    public class UpdateCsvClassifierRequestMarshaller : IRequestMarshaller<UpdateCsvClassifierRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateCsvClassifierRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllowSingleColumn())
            {
                context.Writer.WritePropertyName("AllowSingleColumn");
                context.Writer.WriteBooleanValue(requestObject.AllowSingleColumn.Value);
            }

            if(requestObject.IsSetContainsHeader())
            {
                context.Writer.WritePropertyName("ContainsHeader");
                context.Writer.WriteStringValue(requestObject.ContainsHeader);
            }

            if(requestObject.IsSetCustomDatatypeConfigured())
            {
                context.Writer.WritePropertyName("CustomDatatypeConfigured");
                context.Writer.WriteBooleanValue(requestObject.CustomDatatypeConfigured.Value);
            }

            if(requestObject.IsSetCustomDatatypes())
            {
                context.Writer.WritePropertyName("CustomDatatypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCustomDatatypesListValue in requestObject.CustomDatatypes)
                {
                        context.Writer.WriteStringValue(requestObjectCustomDatatypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDelimiter())
            {
                context.Writer.WritePropertyName("Delimiter");
                context.Writer.WriteStringValue(requestObject.Delimiter);
            }

            if(requestObject.IsSetDisableValueTrimming())
            {
                context.Writer.WritePropertyName("DisableValueTrimming");
                context.Writer.WriteBooleanValue(requestObject.DisableValueTrimming.Value);
            }

            if(requestObject.IsSetHeader())
            {
                context.Writer.WritePropertyName("Header");
                context.Writer.WriteStartArray();
                foreach(var requestObjectHeaderListValue in requestObject.Header)
                {
                        context.Writer.WriteStringValue(requestObjectHeaderListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetQuoteSymbol())
            {
                context.Writer.WritePropertyName("QuoteSymbol");
                context.Writer.WriteStringValue(requestObject.QuoteSymbol);
            }

            if(requestObject.IsSetSerde())
            {
                context.Writer.WritePropertyName("Serde");
                context.Writer.WriteStringValue(requestObject.Serde);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateCsvClassifierRequestMarshaller Instance = new UpdateCsvClassifierRequestMarshaller();

    }
}