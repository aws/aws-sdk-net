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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.Comprehend.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.Comprehend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DocumentReaderConfig Marshaller
    /// </summary>
    public partial class DocumentReaderConfigMarshaller : IRequestMarshaller<DocumentReaderConfig, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(DocumentReaderConfig requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDocumentReadAction())
            {
                context.Writer.WriteTextString("DocumentReadAction");
                context.Writer.WriteTextString(requestObject.DocumentReadAction);
            }

            if (requestObject.IsSetDocumentReadMode())
            {
                context.Writer.WriteTextString("DocumentReadMode");
                context.Writer.WriteTextString(requestObject.DocumentReadMode);
            }

            if (requestObject.IsSetFeatureTypes())
            {
                context.Writer.WriteTextString("FeatureTypes");
                context.Writer.WriteStartArray(requestObject.FeatureTypes.Count);
                foreach (var requestObjectFeatureTypesListValue in requestObject.FeatureTypes)
                {
                    context.Writer.WriteTextString(requestObjectFeatureTypesListValue);
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static DocumentReaderConfigMarshaller Instance = new DocumentReaderConfigMarshaller();
    }
}
