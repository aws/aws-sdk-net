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
    /// SnowflakeDestinationUpdate Marshaller
    /// </summary>
    public class SnowflakeDestinationUpdateMarshaller : IRequestMarshaller<SnowflakeDestinationUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SnowflakeDestinationUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccountUrl())
            {
                context.Writer.WritePropertyName("AccountUrl");
                context.Writer.WriteStringValue(requestObject.AccountUrl);
            }

            if(requestObject.IsSetBufferingHints())
            {
                context.Writer.WritePropertyName("BufferingHints");
                context.Writer.WriteStartObject();

                var marshaller = SnowflakeBufferingHintsMarshaller.Instance;
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

            if(requestObject.IsSetContentColumnName())
            {
                context.Writer.WritePropertyName("ContentColumnName");
                context.Writer.WriteStringValue(requestObject.ContentColumnName);
            }

            if(requestObject.IsSetDatabase())
            {
                context.Writer.WritePropertyName("Database");
                context.Writer.WriteStringValue(requestObject.Database);
            }

            if(requestObject.IsSetDataLoadingOption())
            {
                context.Writer.WritePropertyName("DataLoadingOption");
                context.Writer.WriteStringValue(requestObject.DataLoadingOption);
            }

            if(requestObject.IsSetKeyPassphrase())
            {
                context.Writer.WritePropertyName("KeyPassphrase");
                context.Writer.WriteStringValue(requestObject.KeyPassphrase);
            }

            if(requestObject.IsSetMetaDataColumnName())
            {
                context.Writer.WritePropertyName("MetaDataColumnName");
                context.Writer.WriteStringValue(requestObject.MetaDataColumnName);
            }

            if(requestObject.IsSetPrivateKey())
            {
                context.Writer.WritePropertyName("PrivateKey");
                context.Writer.WriteStringValue(requestObject.PrivateKey);
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

                var marshaller = SnowflakeRetryOptionsMarshaller.Instance;
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

            if(requestObject.IsSetS3Update())
            {
                context.Writer.WritePropertyName("S3Update");
                context.Writer.WriteStartObject();

                var marshaller = S3DestinationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Update, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSchema())
            {
                context.Writer.WritePropertyName("Schema");
                context.Writer.WriteStringValue(requestObject.Schema);
            }

            if(requestObject.IsSetSecretsManagerConfiguration())
            {
                context.Writer.WritePropertyName("SecretsManagerConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SecretsManagerConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SecretsManagerConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSnowflakeRoleConfiguration())
            {
                context.Writer.WritePropertyName("SnowflakeRoleConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SnowflakeRoleConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SnowflakeRoleConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTable())
            {
                context.Writer.WritePropertyName("Table");
                context.Writer.WriteStringValue(requestObject.Table);
            }

            if(requestObject.IsSetUser())
            {
                context.Writer.WritePropertyName("User");
                context.Writer.WriteStringValue(requestObject.User);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SnowflakeDestinationUpdateMarshaller Instance = new SnowflakeDestinationUpdateMarshaller();

    }
}