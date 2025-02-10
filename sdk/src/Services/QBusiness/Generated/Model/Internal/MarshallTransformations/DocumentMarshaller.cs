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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Document Marshaller
    /// </summary>
    public class DocumentMarshaller : IRequestMarshaller<Document, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Document requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccessConfiguration())
            {
                context.Writer.WritePropertyName("accessConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AccessConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AccessConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("attributes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAttributesListValue in requestObject.Attributes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DocumentAttributeMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttributesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetContent())
            {
                context.Writer.WritePropertyName("content");
                context.Writer.WriteStartObject();

                var marshaller = DocumentContentMarshaller.Instance;
                marshaller.Marshall(requestObject.Content, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContentType())
            {
                context.Writer.WritePropertyName("contentType");
                context.Writer.WriteStringValue(requestObject.ContentType);
            }

            if(requestObject.IsSetDocumentEnrichmentConfiguration())
            {
                context.Writer.WritePropertyName("documentEnrichmentConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DocumentEnrichmentConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DocumentEnrichmentConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetMediaExtractionConfiguration())
            {
                context.Writer.WritePropertyName("mediaExtractionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = MediaExtractionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.MediaExtractionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("title");
                context.Writer.WriteStringValue(requestObject.Title);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DocumentMarshaller Instance = new DocumentMarshaller();

    }
}