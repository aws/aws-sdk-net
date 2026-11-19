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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.S3Control.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReplicationRule Marshaller
    /// </summary>
    public partial class ReplicationRuleMarshaller : IRequestMarshaller<ReplicationRule, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ReplicationRule requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetBucket())
            {
                context.Writer.WriteElementString("Bucket", StringUtils.FromString(requestObject.Bucket));
            }
            if (requestObject.IsSetDeleteMarkerReplication())
            {
                context.Writer.WriteStartElement("DeleteMarkerReplication");
                DeleteMarkerReplicationMarshaller.Instance.Marshall(requestObject.DeleteMarkerReplication, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetDestination())
            {
                context.Writer.WriteStartElement("Destination");
                DestinationMarshaller.Instance.Marshall(requestObject.Destination, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetExistingObjectReplication())
            {
                context.Writer.WriteStartElement("ExistingObjectReplication");
                ExistingObjectReplicationMarshaller.Instance.Marshall(requestObject.ExistingObjectReplication, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetFilter())
            {
                context.Writer.WriteStartElement("Filter");
                ReplicationRuleFilterMarshaller.Instance.Marshall(requestObject.Filter, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetID())
            {
                context.Writer.WriteElementString("ID", StringUtils.FromString(requestObject.ID));
            }
            if (requestObject.IsSetPrefix())
            {
                context.Writer.WriteElementString("Prefix", StringUtils.FromString(requestObject.Prefix));
            }
            if (requestObject.IsSetPriority())
            {
                context.Writer.WriteElementString("Priority", StringUtils.FromInt(requestObject.Priority.Value));
            }
            if (requestObject.IsSetSourceSelectionCriteria())
            {
                context.Writer.WriteStartElement("SourceSelectionCriteria");
                SourceSelectionCriteriaMarshaller.Instance.Marshall(requestObject.SourceSelectionCriteria, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetStatus())
            {
                context.Writer.WriteElementString("Status", StringUtils.FromString(requestObject.Status));
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ReplicationRuleMarshaller Instance = new ReplicationRuleMarshaller();
    }
}
