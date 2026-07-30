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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kafka.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Kafka.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TopicConfiguration Marshaller
    /// </summary>
    public class TopicConfigurationMarshaller : IRequestMarshaller<TopicConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TopicConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetRecordConverter())
            {
                context.Writer.WritePropertyName("recordConverter");
                context.Writer.WriteStartObject();

                var marshaller = RecordConverterMarshaller.Instance;
                marshaller.Marshall(requestObject.RecordConverter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRecordSchema())
            {
                context.Writer.WritePropertyName("recordSchema");
                context.Writer.WriteStartObject();

                var marshaller = RecordSchemaMarshaller.Instance;
                marshaller.Marshall(requestObject.RecordSchema, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTopicArn())
            {
                context.Writer.WritePropertyName("topicArn");
                context.Writer.WriteStringValue(requestObject.TopicArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TopicConfigurationMarshaller Instance = new TopicConfigurationMarshaller();

    }
}