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
    /// TopicReplication Marshaller
    /// </summary>
    public class TopicReplicationMarshaller : IRequestMarshaller<TopicReplication, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TopicReplication requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCopyAccessControlListsForTopics())
            {
                context.Writer.WritePropertyName("copyAccessControlListsForTopics");
                context.Writer.WriteBooleanValue(requestObject.CopyAccessControlListsForTopics.Value);
            }

            if(requestObject.IsSetCopyTopicConfigurations())
            {
                context.Writer.WritePropertyName("copyTopicConfigurations");
                context.Writer.WriteBooleanValue(requestObject.CopyTopicConfigurations.Value);
            }

            if(requestObject.IsSetDetectAndCopyNewTopics())
            {
                context.Writer.WritePropertyName("detectAndCopyNewTopics");
                context.Writer.WriteBooleanValue(requestObject.DetectAndCopyNewTopics.Value);
            }

            if(requestObject.IsSetStartingPosition())
            {
                context.Writer.WritePropertyName("startingPosition");
                context.Writer.WriteStartObject();

                var marshaller = ReplicationStartingPositionMarshaller.Instance;
                marshaller.Marshall(requestObject.StartingPosition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTopicNameConfiguration())
            {
                context.Writer.WritePropertyName("topicNameConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ReplicationTopicNameConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.TopicNameConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTopicsToExclude())
            {
                context.Writer.WritePropertyName("topicsToExclude");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTopicsToExcludeListValue in requestObject.TopicsToExclude)
                {
                        context.Writer.WriteStringValue(requestObjectTopicsToExcludeListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTopicsToReplicate())
            {
                context.Writer.WritePropertyName("topicsToReplicate");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTopicsToReplicateListValue in requestObject.TopicsToReplicate)
                {
                        context.Writer.WriteStringValue(requestObjectTopicsToReplicateListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TopicReplicationMarshaller Instance = new TopicReplicationMarshaller();

    }
}