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
    /// SplunkDestinationUpdate Marshaller
    /// </summary>
    public class SplunkDestinationUpdateMarshaller : IRequestMarshaller<SplunkDestinationUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SplunkDestinationUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBufferingHints())
            {
                context.Writer.WritePropertyName("BufferingHints");
                context.Writer.WriteStartObject();

                var marshaller = SplunkBufferingHintsMarshaller.Instance;
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

            if(requestObject.IsSetHECAcknowledgmentTimeoutInSeconds())
            {
                context.Writer.WritePropertyName("HECAcknowledgmentTimeoutInSeconds");
                context.Writer.WriteNumberValue(requestObject.HECAcknowledgmentTimeoutInSeconds.Value);
            }

            if(requestObject.IsSetHECEndpoint())
            {
                context.Writer.WritePropertyName("HECEndpoint");
                context.Writer.WriteStringValue(requestObject.HECEndpoint);
            }

            if(requestObject.IsSetHECEndpointType())
            {
                context.Writer.WritePropertyName("HECEndpointType");
                context.Writer.WriteStringValue(requestObject.HECEndpointType);
            }

            if(requestObject.IsSetHECToken())
            {
                context.Writer.WritePropertyName("HECToken");
                context.Writer.WriteStringValue(requestObject.HECToken);
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

                var marshaller = SplunkRetryOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.RetryOptions, context);

                context.Writer.WriteEndObject();
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

            if(requestObject.IsSetSecretsManagerConfiguration())
            {
                context.Writer.WritePropertyName("SecretsManagerConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SecretsManagerConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SecretsManagerConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SplunkDestinationUpdateMarshaller Instance = new SplunkDestinationUpdateMarshaller();

    }
}