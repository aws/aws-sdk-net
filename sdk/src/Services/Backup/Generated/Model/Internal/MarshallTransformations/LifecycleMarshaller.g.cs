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

using Amazon.Backup.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Lifecycle Marshaller
    /// </summary>
    public partial class LifecycleMarshaller : IRequestMarshaller<Lifecycle, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(Lifecycle requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDeleteAfterDays())
            {
                context.Writer.WritePropertyName("DeleteAfterDays");
                context.Writer.WriteNumberValue(requestObject.DeleteAfterDays.Value);
            }

            if (requestObject.IsSetDeleteAfterEvent())
            {
                context.Writer.WritePropertyName("DeleteAfterEvent");
                context.Writer.WriteStringValue(requestObject.DeleteAfterEvent);
            }

            if (requestObject.IsSetMoveToColdStorageAfterDays())
            {
                context.Writer.WritePropertyName("MoveToColdStorageAfterDays");
                context.Writer.WriteNumberValue(requestObject.MoveToColdStorageAfterDays.Value);
            }

            if (requestObject.IsSetOptInToArchiveForSupportedResources())
            {
                context.Writer.WritePropertyName("OptInToArchiveForSupportedResources");
                context.Writer.WriteBooleanValue(requestObject.OptInToArchiveForSupportedResources.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static LifecycleMarshaller Instance = new LifecycleMarshaller();
    }
}
