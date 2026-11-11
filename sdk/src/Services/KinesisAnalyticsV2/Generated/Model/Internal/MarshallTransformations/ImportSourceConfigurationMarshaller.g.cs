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

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportSourceConfiguration Marshaller
    /// </summary>
    public partial class ImportSourceConfigurationMarshaller : IRequestMarshaller<ImportSourceConfiguration, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ImportSourceConfiguration requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetImportRoleArn())
            {
                context.Writer.WritePropertyName("ImportRoleArn");
                context.Writer.WriteStringValue(requestObject.ImportRoleArn);
            }

            if (requestObject.IsSetSourceEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("SourceEncryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SnapshotEncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SourceEncryptionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetSourceS3PrefixLocation())
            {
                context.Writer.WritePropertyName("SourceS3PrefixLocation");
                context.Writer.WriteStartObject();

                var marshaller = S3PrefixLocationMarshaller.Instance;
                marshaller.Marshall(requestObject.SourceS3PrefixLocation, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetSourceType())
            {
                context.Writer.WritePropertyName("SourceType");
                context.Writer.WriteStringValue(requestObject.SourceType);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ImportSourceConfigurationMarshaller Instance = new ImportSourceConfigurationMarshaller();
    }
}
