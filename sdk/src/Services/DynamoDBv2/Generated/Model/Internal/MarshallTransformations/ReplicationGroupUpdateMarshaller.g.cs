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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReplicationGroupUpdate Marshaller
    /// </summary>
    public partial class ReplicationGroupUpdateMarshaller : IRequestMarshaller<ReplicationGroupUpdate, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ReplicationGroupUpdate requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCreate())
            {
                context.Writer.WritePropertyName("Create");
                context.Writer.WriteStartObject();

                var marshaller = CreateReplicationGroupMemberActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Create, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetDelete())
            {
                context.Writer.WritePropertyName("Delete");
                context.Writer.WriteStartObject();

                var marshaller = DeleteReplicationGroupMemberActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Delete, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetDisassociate())
            {
                context.Writer.WritePropertyName("Disassociate");
                context.Writer.WriteStartObject();

                var marshaller = DisassociateReplicationGroupMemberActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Disassociate, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetUpdate())
            {
                context.Writer.WritePropertyName("Update");
                context.Writer.WriteStartObject();

                var marshaller = UpdateReplicationGroupMemberActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Update, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ReplicationGroupUpdateMarshaller Instance = new ReplicationGroupUpdateMarshaller();
    }
}
