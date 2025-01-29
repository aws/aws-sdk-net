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
    /// ExtendedS3DestinationConfiguration Marshaller
    /// </summary>
    public class ExtendedS3DestinationConfigurationMarshaller : IRequestMarshaller<ExtendedS3DestinationConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ExtendedS3DestinationConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBucketARN())
            {
                context.Writer.WritePropertyName("BucketARN");
                context.Writer.WriteStringValue(requestObject.BucketARN);
            }

            if(requestObject.IsSetBufferingHints())
            {
                context.Writer.WritePropertyName("BufferingHints");
                context.Writer.WriteStartObject();

                var marshaller = BufferingHintsMarshaller.Instance;
                marshaller.Marshall(requestObject.BufferingHints, context);

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

            if(requestObject.IsSetCompressionFormat())
            {
                context.Writer.WritePropertyName("CompressionFormat");
                context.Writer.WriteStringValue(requestObject.CompressionFormat);
            }

            if(requestObject.IsSetCustomTimeZone())
            {
                context.Writer.WritePropertyName("CustomTimeZone");
                context.Writer.WriteStringValue(requestObject.CustomTimeZone);
            }

            if(requestObject.IsSetDataFormatConversionConfiguration())
            {
                context.Writer.WritePropertyName("DataFormatConversionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DataFormatConversionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DataFormatConversionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDynamicPartitioningConfiguration())
            {
                context.Writer.WritePropertyName("DynamicPartitioningConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DynamicPartitioningConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamicPartitioningConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("EncryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.EncryptionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetErrorOutputPrefix())
            {
                context.Writer.WritePropertyName("ErrorOutputPrefix");
                context.Writer.WriteStringValue(requestObject.ErrorOutputPrefix);
            }

            if(requestObject.IsSetFileExtension())
            {
                context.Writer.WritePropertyName("FileExtension");
                context.Writer.WriteStringValue(requestObject.FileExtension);
            }

            if(requestObject.IsSetPrefix())
            {
                context.Writer.WritePropertyName("Prefix");
                context.Writer.WriteStringValue(requestObject.Prefix);
            }

            if(requestObject.IsSetProcessingConfiguration())
            {
                context.Writer.WritePropertyName("ProcessingConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ProcessingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ProcessingConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRoleARN())
            {
                context.Writer.WritePropertyName("RoleARN");
                context.Writer.WriteStringValue(requestObject.RoleARN);
            }

            if(requestObject.IsSetS3BackupConfiguration())
            {
                context.Writer.WritePropertyName("S3BackupConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = S3DestinationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3BackupConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3BackupMode())
            {
                context.Writer.WritePropertyName("S3BackupMode");
                context.Writer.WriteStringValue(requestObject.S3BackupMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExtendedS3DestinationConfigurationMarshaller Instance = new ExtendedS3DestinationConfigurationMarshaller();

    }
}