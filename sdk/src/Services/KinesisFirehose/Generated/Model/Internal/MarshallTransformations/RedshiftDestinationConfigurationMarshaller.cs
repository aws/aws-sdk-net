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
    /// RedshiftDestinationConfiguration Marshaller
    /// </summary>
    public class RedshiftDestinationConfigurationMarshaller : IRequestMarshaller<RedshiftDestinationConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RedshiftDestinationConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCloudWatchLoggingOptions())
            {
                context.Writer.WritePropertyName("CloudWatchLoggingOptions");
                context.Writer.WriteStartObject();

                var marshaller = CloudWatchLoggingOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatchLoggingOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetClusterJDBCURL())
            {
                context.Writer.WritePropertyName("ClusterJDBCURL");
                context.Writer.WriteStringValue(requestObject.ClusterJDBCURL);
            }

            if(requestObject.IsSetCopyCommand())
            {
                context.Writer.WritePropertyName("CopyCommand");
                context.Writer.WriteStartObject();

                var marshaller = CopyCommandMarshaller.Instance;
                marshaller.Marshall(requestObject.CopyCommand, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPassword())
            {
                context.Writer.WritePropertyName("Password");
                context.Writer.WriteStringValue(requestObject.Password);
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

                var marshaller = RedshiftRetryOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.RetryOptions, context);

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

            if(requestObject.IsSetS3Configuration())
            {
                context.Writer.WritePropertyName("S3Configuration");
                context.Writer.WriteStartObject();

                var marshaller = S3DestinationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Configuration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSecretsManagerConfiguration())
            {
                context.Writer.WritePropertyName("SecretsManagerConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SecretsManagerConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SecretsManagerConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUsername())
            {
                context.Writer.WritePropertyName("Username");
                context.Writer.WriteStringValue(requestObject.Username);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RedshiftDestinationConfigurationMarshaller Instance = new RedshiftDestinationConfigurationMarshaller();

    }
}