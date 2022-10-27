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
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCsvClassifierRequest Marshaller
    /// </summary>
    public class CreateCsvClassifierRequestMarshaller : IRequestMarshaller<CreateCsvClassifierRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateCsvClassifierRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAllowSingleColumn())
            {
                context.Writer.WritePropertyName("AllowSingleColumn");
                context.Writer.Write(requestObject.AllowSingleColumn);
            }

            if(requestObject.IsSetContainsHeader())
            {
                context.Writer.WritePropertyName("ContainsHeader");
                context.Writer.Write(requestObject.ContainsHeader);
            }

            if(requestObject.IsSetCustomDatatypeConfigured())
            {
                context.Writer.WritePropertyName("CustomDatatypeConfigured");
                context.Writer.Write(requestObject.CustomDatatypeConfigured);
            }

            if(requestObject.IsSetCustomDatatypes())
            {
                context.Writer.WritePropertyName("CustomDatatypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCustomDatatypesListValue in requestObject.CustomDatatypes)
                {
                        context.Writer.Write(requestObjectCustomDatatypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDelimiter())
            {
                context.Writer.WritePropertyName("Delimiter");
                context.Writer.Write(requestObject.Delimiter);
            }

            if(requestObject.IsSetDisableValueTrimming())
            {
                context.Writer.WritePropertyName("DisableValueTrimming");
                context.Writer.Write(requestObject.DisableValueTrimming);
            }

            if(requestObject.IsSetHeader())
            {
                context.Writer.WritePropertyName("Header");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectHeaderListValue in requestObject.Header)
                {
                        context.Writer.Write(requestObjectHeaderListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
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
        public readonly static CreateCsvClassifierRequestMarshaller Instance = new CreateCsvClassifierRequestMarshaller();

    }
}