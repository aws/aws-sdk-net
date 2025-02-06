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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InstanceStorageConfig Marshaller
    /// </summary>
    public class InstanceStorageConfigMarshaller : IRequestMarshaller<InstanceStorageConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InstanceStorageConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAssociationId())
            {
                context.Writer.WritePropertyName("AssociationId");
                context.Writer.WriteStringValue(requestObject.AssociationId);
            }

            if(requestObject.IsSetKinesisFirehoseConfig())
            {
                context.Writer.WritePropertyName("KinesisFirehoseConfig");
                context.Writer.WriteStartObject();

                var marshaller = KinesisFirehoseConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisFirehoseConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKinesisStreamConfig())
            {
                context.Writer.WritePropertyName("KinesisStreamConfig");
                context.Writer.WriteStartObject();

                var marshaller = KinesisStreamConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisStreamConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKinesisVideoStreamConfig())
            {
                context.Writer.WritePropertyName("KinesisVideoStreamConfig");
                context.Writer.WriteStartObject();

                var marshaller = KinesisVideoStreamConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisVideoStreamConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3Config())
            {
                context.Writer.WritePropertyName("S3Config");
                context.Writer.WriteStartObject();

                var marshaller = S3ConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Config, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStorageType())
            {
                context.Writer.WritePropertyName("StorageType");
                context.Writer.WriteStringValue(requestObject.StorageType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InstanceStorageConfigMarshaller Instance = new InstanceStorageConfigMarshaller();

    }
}