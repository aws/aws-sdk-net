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
    /// DatasetInputDataConfig Marshaller
    /// </summary>
    public partial class DatasetInputDataConfigMarshaller : IRequestMarshaller<DatasetInputDataConfig, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(DatasetInputDataConfig requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAugmentedManifests())
            {
                context.Writer.WriteTextString("AugmentedManifests");
                context.Writer.WriteStartArray(requestObject.AugmentedManifests.Count);
                foreach (var requestObjectAugmentedManifestsListValue in requestObject.AugmentedManifests)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = DatasetAugmentedManifestsListItemMarshaller.Instance;
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

            if (requestObject.IsSetDocumentClassifierInputDataConfig())
            {
                context.Writer.WriteTextString("DocumentClassifierInputDataConfig");
                context.Writer.WriteStartMap(null);

                var marshaller = DatasetDocumentClassifierInputDataConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.DocumentClassifierInputDataConfig, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetEntityRecognizerInputDataConfig())
            {
                context.Writer.WriteTextString("EntityRecognizerInputDataConfig");
                context.Writer.WriteStartMap(null);

                var marshaller = DatasetEntityRecognizerInputDataConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.EntityRecognizerInputDataConfig, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static DatasetInputDataConfigMarshaller Instance = new DatasetInputDataConfigMarshaller();
    }
}
