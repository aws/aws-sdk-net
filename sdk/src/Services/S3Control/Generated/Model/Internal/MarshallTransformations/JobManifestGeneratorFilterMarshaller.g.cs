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
    /// JobManifestGeneratorFilter Marshaller
    /// </summary>
    public partial class JobManifestGeneratorFilterMarshaller : IRequestMarshaller<JobManifestGeneratorFilter, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(JobManifestGeneratorFilter requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCreatedAfter())
            {
                context.Writer.WriteElementString("CreatedAfter", StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.CreatedAfter.Value));
            }
            if (requestObject.IsSetCreatedBefore())
            {
                context.Writer.WriteElementString("CreatedBefore", StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.CreatedBefore.Value));
            }
            if (requestObject.IsSetEligibleForReplication())
            {
                context.Writer.WriteElementString("EligibleForReplication", StringUtils.FromBool(requestObject.EligibleForReplication.Value));
            }
            if (requestObject.IsSetKeyNameConstraint())
            {
                context.Writer.WriteStartElement("KeyNameConstraint");
                KeyNameConstraintMarshaller.Instance.Marshall(requestObject.KeyNameConstraint, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetMatchAnyObjectEncryption())
            {
                var requestObjectMatchAnyObjectEncryption = requestObject.MatchAnyObjectEncryption;
                context.Writer.WriteStartElement("MatchAnyObjectEncryption");
                foreach (var requestObjectMatchAnyObjectEncryptionValue in requestObjectMatchAnyObjectEncryption)
                {
                    if (requestObjectMatchAnyObjectEncryptionValue != null)
                    {
                        context.Writer.WriteStartElement("ObjectEncryption");
                        ObjectEncryptionFilterMarshaller.Instance.Marshall(requestObjectMatchAnyObjectEncryptionValue, context);
                        context.Writer.WriteEndElement();
                    }
                }
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetMatchAnyStorageClass())
            {
                var requestObjectMatchAnyStorageClass = requestObject.MatchAnyStorageClass;
                context.Writer.WriteStartElement("MatchAnyStorageClass");
                foreach (var requestObjectMatchAnyStorageClassValue in requestObjectMatchAnyStorageClass)
                {
                    context.Writer.WriteStartElement("member");
                    context.Writer.WriteValue(requestObjectMatchAnyStorageClassValue);
                    context.Writer.WriteEndElement();
                }
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetObjectReplicationStatuses())
            {
                var requestObjectObjectReplicationStatuses = requestObject.ObjectReplicationStatuses;
                context.Writer.WriteStartElement("ObjectReplicationStatuses");
                foreach (var requestObjectObjectReplicationStatusesValue in requestObjectObjectReplicationStatuses)
                {
                    context.Writer.WriteStartElement("member");
                    context.Writer.WriteValue(requestObjectObjectReplicationStatusesValue);
                    context.Writer.WriteEndElement();
                }
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetObjectSizeGreaterThanBytes())
            {
                context.Writer.WriteElementString("ObjectSizeGreaterThanBytes", StringUtils.FromLong(requestObject.ObjectSizeGreaterThanBytes.Value));
            }
            if (requestObject.IsSetObjectSizeLessThanBytes())
            {
                context.Writer.WriteElementString("ObjectSizeLessThanBytes", StringUtils.FromLong(requestObject.ObjectSizeLessThanBytes.Value));
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static JobManifestGeneratorFilterMarshaller Instance = new JobManifestGeneratorFilterMarshaller();
    }
}
