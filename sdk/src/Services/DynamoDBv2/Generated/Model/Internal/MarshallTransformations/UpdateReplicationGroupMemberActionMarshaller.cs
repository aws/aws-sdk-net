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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateReplicationGroupMemberAction Marshaller
    /// </summary>
    public class UpdateReplicationGroupMemberActionMarshaller : IRequestMarshaller<UpdateReplicationGroupMemberAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateReplicationGroupMemberAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetGlobalSecondaryIndexes())
            {
                context.Writer.WritePropertyName("GlobalSecondaryIndexes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGlobalSecondaryIndexesListValue in requestObject.GlobalSecondaryIndexes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ReplicaGlobalSecondaryIndexMarshaller.Instance;
                    marshaller.Marshall(requestObjectGlobalSecondaryIndexesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetKMSMasterKeyId())
            {
                context.Writer.WritePropertyName("KMSMasterKeyId");
                context.Writer.WriteStringValue(requestObject.KMSMasterKeyId);
            }

            if(requestObject.IsSetOnDemandThroughputOverride())
            {
                context.Writer.WritePropertyName("OnDemandThroughputOverride");
                context.Writer.WriteStartObject();

                var marshaller = OnDemandThroughputOverrideMarshaller.Instance;
                marshaller.Marshall(requestObject.OnDemandThroughputOverride, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProvisionedThroughputOverride())
            {
                context.Writer.WritePropertyName("ProvisionedThroughputOverride");
                context.Writer.WriteStartObject();

                var marshaller = ProvisionedThroughputOverrideMarshaller.Instance;
                marshaller.Marshall(requestObject.ProvisionedThroughputOverride, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRegionName())
            {
                context.Writer.WritePropertyName("RegionName");
                context.Writer.WriteStringValue(requestObject.RegionName);
            }

            if(requestObject.IsSetTableClassOverride())
            {
                context.Writer.WritePropertyName("TableClassOverride");
                context.Writer.WriteStringValue(requestObject.TableClassOverride);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateReplicationGroupMemberActionMarshaller Instance = new UpdateReplicationGroupMemberActionMarshaller();

    }
}