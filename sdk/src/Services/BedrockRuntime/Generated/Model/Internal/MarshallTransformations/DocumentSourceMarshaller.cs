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
    /// DocumentSource Marshaller
    /// </summary>
    public class DocumentSourceMarshaller : IRequestMarshaller<DocumentSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DocumentSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBytes())
            {
                context.Writer.WritePropertyName("bytes");
                context.Writer.WriteStringValue(StringUtils.FromMemoryStream(requestObject.Bytes));
            }

            if(requestObject.IsSetContent())
            {
                context.Writer.WritePropertyName("content");
                context.Writer.WriteStartArray();
                foreach(var requestObjectContentListValue in requestObject.Content)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DocumentContentBlockMarshaller.Instance;
                    marshaller.Marshall(requestObjectContentListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetS3Location())
            {
                context.Writer.WritePropertyName("s3Location");
                context.Writer.WriteStartObject();

                var marshaller = S3LocationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Location, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetText())
            {
                context.Writer.WritePropertyName("text");
                context.Writer.WriteStringValue(requestObject.Text);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DocumentSourceMarshaller Instance = new DocumentSourceMarshaller();

    }
}