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
    /// DocumentClassifierInputDataConfig Marshaller
    /// </summary>
    public partial class DocumentClassifierInputDataConfigMarshaller : IRequestMarshaller<DocumentClassifierInputDataConfig, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(DocumentClassifierInputDataConfig requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAugmentedManifests())
            {
                context.Writer.WriteTextString("AugmentedManifests");
                context.Writer.WriteStartArray(requestObject.AugmentedManifests.Count);
                foreach (var requestObjectAugmentedManifestsListValue in requestObject.AugmentedManifests)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = AugmentedManifestsListItemMarshaller.Instance;
                    marshaller.Marshall(requestObjectAugmentedManifestsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetDataFormat())
            {
                context.Writer.WriteTextString("DataFormat");
                context.Writer.WriteTextString(requestObject.DataFormat);
            }

            if (requestObject.IsSetDocumentReaderConfig())
            {
                context.Writer.WriteTextString("DocumentReaderConfig");
                context.Writer.WriteStartMap(null);

                var marshaller = DocumentReaderConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.DocumentReaderConfig, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetDocumentType())
            {
                context.Writer.WriteTextString("DocumentType");
                context.Writer.WriteTextString(requestObject.DocumentType);
            }

            if (requestObject.IsSetDocuments())
            {
                context.Writer.WriteTextString("Documents");
                context.Writer.WriteStartMap(null);

                var marshaller = DocumentClassifierDocumentsMarshaller.Instance;
                marshaller.Marshall(requestObject.Documents, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetLabelDelimiter())
            {
                context.Writer.WriteTextString("LabelDelimiter");
                context.Writer.WriteTextString(requestObject.LabelDelimiter);
            }

            if (requestObject.IsSetS3Uri())
            {
                context.Writer.WriteTextString("S3Uri");
                context.Writer.WriteTextString(requestObject.S3Uri);
            }

            if (requestObject.IsSetTestS3Uri())
            {
                context.Writer.WriteTextString("TestS3Uri");
                context.Writer.WriteTextString(requestObject.TestS3Uri);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static DocumentClassifierInputDataConfigMarshaller Instance = new DocumentClassifierInputDataConfigMarshaller();
    }
}
