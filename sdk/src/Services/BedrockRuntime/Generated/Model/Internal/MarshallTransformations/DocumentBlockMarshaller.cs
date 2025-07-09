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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DocumentBlock Marshaller
    /// </summary>
    public class DocumentBlockMarshaller : IRequestMarshaller<DocumentBlock, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DocumentBlock requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCitations())
            {
                context.Writer.WritePropertyName("citations");
                context.Writer.WriteStartObject();

                var marshaller = CitationsConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.Citations, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContext())
            {
                context.Writer.WritePropertyName("context");
                context.Writer.WriteStringValue(requestObject.Context);
            }

            if(requestObject.IsSetFormat())
            {
                context.Writer.WritePropertyName("format");
                context.Writer.WriteStringValue(requestObject.Format);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetSource())
            {
                context.Writer.WritePropertyName("source");
                context.Writer.WriteStartObject();

                var marshaller = DocumentSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.Source, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DocumentBlockMarshaller Instance = new DocumentBlockMarshaller();

    }
}