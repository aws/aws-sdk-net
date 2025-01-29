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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LoggingConfig Marshaller
    /// </summary>
    public class LoggingConfigMarshaller : IRequestMarshaller<LoggingConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LoggingConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCloudWatchConfig())
            {
                context.Writer.WritePropertyName("cloudWatchConfig");
                context.Writer.WriteStartObject();

                var marshaller = CloudWatchConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatchConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEmbeddingDataDeliveryEnabled())
            {
                context.Writer.WritePropertyName("embeddingDataDeliveryEnabled");
                context.Writer.WriteBooleanValue(requestObject.EmbeddingDataDeliveryEnabled.Value);
            }

            if(requestObject.IsSetImageDataDeliveryEnabled())
            {
                context.Writer.WritePropertyName("imageDataDeliveryEnabled");
                context.Writer.WriteBooleanValue(requestObject.ImageDataDeliveryEnabled.Value);
            }

            if(requestObject.IsSetS3Config())
            {
                context.Writer.WritePropertyName("s3Config");
                context.Writer.WriteStartObject();

                var marshaller = S3ConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Config, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTextDataDeliveryEnabled())
            {
                context.Writer.WritePropertyName("textDataDeliveryEnabled");
                context.Writer.WriteBooleanValue(requestObject.TextDataDeliveryEnabled.Value);
            }

            if(requestObject.IsSetVideoDataDeliveryEnabled())
            {
                context.Writer.WritePropertyName("videoDataDeliveryEnabled");
                context.Writer.WriteBooleanValue(requestObject.VideoDataDeliveryEnabled.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LoggingConfigMarshaller Instance = new LoggingConfigMarshaller();

    }
}