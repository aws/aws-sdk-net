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
    /// DocumentChunkLocation Marshaller
    /// </summary>
    public class DocumentChunkLocationMarshaller : IRequestMarshaller<DocumentChunkLocation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DocumentChunkLocation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDocumentIndex())
            {
                context.Writer.WritePropertyName("documentIndex");
                context.Writer.WriteNumberValue(requestObject.DocumentIndex.Value);
            }

            if(requestObject.IsSetEnd())
            {
                context.Writer.WritePropertyName("end");
                context.Writer.WriteNumberValue(requestObject.End.Value);
            }

            if(requestObject.IsSetStart())
            {
                context.Writer.WritePropertyName("start");
                context.Writer.WriteNumberValue(requestObject.Start.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DocumentChunkLocationMarshaller Instance = new DocumentChunkLocationMarshaller();

    }
}