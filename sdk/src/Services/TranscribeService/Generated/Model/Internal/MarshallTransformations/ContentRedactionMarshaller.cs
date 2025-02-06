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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TranscribeService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.TranscribeService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ContentRedaction Marshaller
    /// </summary>
    public class ContentRedactionMarshaller : IRequestMarshaller<ContentRedaction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ContentRedaction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetPiiEntityTypes())
            {
                context.Writer.WritePropertyName("PiiEntityTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPiiEntityTypesListValue in requestObject.PiiEntityTypes)
                {
                        context.Writer.WriteStringValue(requestObjectPiiEntityTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRedactionOutput())
            {
                context.Writer.WritePropertyName("RedactionOutput");
                context.Writer.WriteStringValue(requestObject.RedactionOutput);
            }

            if(requestObject.IsSetRedactionType())
            {
                context.Writer.WritePropertyName("RedactionType");
                context.Writer.WriteStringValue(requestObject.RedactionType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ContentRedactionMarshaller Instance = new ContentRedactionMarshaller();

    }
}