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
    /// SourceSelectionCriteria Marshaller
    /// </summary>
    public partial class SourceSelectionCriteriaMarshaller : IRequestMarshaller<SourceSelectionCriteria, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(SourceSelectionCriteria requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetReplicaModifications())
            {
                context.Writer.WriteStartElement("ReplicaModifications");
                ReplicaModificationsMarshaller.Instance.Marshall(requestObject.ReplicaModifications, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetSseKmsEncryptedObjects())
            {
                context.Writer.WriteStartElement("SseKmsEncryptedObjects");
                SseKmsEncryptedObjectsMarshaller.Instance.Marshall(requestObject.SseKmsEncryptedObjects, context);
                context.Writer.WriteEndElement();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static SourceSelectionCriteriaMarshaller Instance = new SourceSelectionCriteriaMarshaller();
    }
}
