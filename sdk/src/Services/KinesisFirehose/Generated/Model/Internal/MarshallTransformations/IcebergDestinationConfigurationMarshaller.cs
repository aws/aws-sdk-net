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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// IcebergDestinationConfiguration Marshaller
    /// </summary>
    public class IcebergDestinationConfigurationMarshaller : IRequestMarshaller<IcebergDestinationConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(IcebergDestinationConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAppendOnly())
            {
                context.Writer.WritePropertyName("AppendOnly");
                context.Writer.WriteBooleanValue(requestObject.AppendOnly.Value);
            }

            if(requestObject.IsSetBufferingHints())
            {
                context.Writer.WritePropertyName("BufferingHints");
                context.Writer.WriteStartObject();

                var marshaller = BufferingHintsMarshaller.Instance;
                marshaller.Marshall(requestObject.BufferingHints, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCatalogConfiguration())
            {
                context.Writer.WritePropertyName("CatalogConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CatalogConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CatalogConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCloudWatchLoggingOptions())
            {
                context.Writer.WritePropertyName("CloudWatchLoggingOptions");
                context.Writer.WriteStartObject();

                var marshaller = CloudWatchLoggingOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatchLoggingOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDestinationTableConfigurationList())
            {
                context.Writer.WritePropertyName("DestinationTableConfigurationList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDestinationTableConfigurationListListValue in requestObject.DestinationTableConfigurationList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DestinationTableConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectDestinationTableConfigurationListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProcessingConfiguration())
            {
                context.Writer.WritePropertyName("ProcessingConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ProcessingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ProcessingConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRetryOptions())
            {
                context.Writer.WritePropertyName("RetryOptions");
                context.Writer.WriteStartObject();

                var marshaller = RetryOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.RetryOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRoleARN())
            {
                context.Writer.WritePropertyName("RoleARN");
                context.Writer.WriteStringValue(requestObject.RoleARN);
            }

            if(requestObject.IsSetS3BackupMode())
            {
                context.Writer.WritePropertyName("S3BackupMode");
                context.Writer.WriteStringValue(requestObject.S3BackupMode);
            }

            if(requestObject.IsSetS3Configuration())
            {
                context.Writer.WritePropertyName("S3Configuration");
                context.Writer.WriteStartObject();

                var marshaller = S3DestinationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Configuration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSchemaEvolutionConfiguration())
            {
                context.Writer.WritePropertyName("SchemaEvolutionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SchemaEvolutionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SchemaEvolutionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTableCreationConfiguration())
            {
                context.Writer.WritePropertyName("TableCreationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = TableCreationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.TableCreationConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static IcebergDestinationConfigurationMarshaller Instance = new IcebergDestinationConfigurationMarshaller();

    }
}