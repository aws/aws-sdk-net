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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Kafka.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConsumerGroupReplicationUpdate Marshaller
    /// </summary>
    public class ConsumerGroupReplicationUpdateMarshaller : IRequestMarshaller<ConsumerGroupReplicationUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConsumerGroupReplicationUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConsumerGroupsToExclude())
            {
                context.Writer.WritePropertyName("consumerGroupsToExclude");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectConsumerGroupsToExcludeListValue in requestObject.ConsumerGroupsToExclude)
                {
                        context.Writer.Write(requestObjectConsumerGroupsToExcludeListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetConsumerGroupsToReplicate())
            {
                context.Writer.WritePropertyName("consumerGroupsToReplicate");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectConsumerGroupsToReplicateListValue in requestObject.ConsumerGroupsToReplicate)
                {
                        context.Writer.Write(requestObjectConsumerGroupsToReplicateListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDetectAndCopyNewConsumerGroups())
            {
                context.Writer.WritePropertyName("detectAndCopyNewConsumerGroups");
                context.Writer.Write(requestObject.DetectAndCopyNewConsumerGroups);
            }

            if(requestObject.IsSetSynchroniseConsumerGroupOffsets())
            {
                context.Writer.WritePropertyName("synchroniseConsumerGroupOffsets");
                context.Writer.Write(requestObject.SynchroniseConsumerGroupOffsets);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConsumerGroupReplicationUpdateMarshaller Instance = new ConsumerGroupReplicationUpdateMarshaller();

    }
}
#pragma warning restore CS0612,CS0618