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
    /// S3Retention Marshaller
    /// </summary>
    public partial class S3RetentionMarshaller : IRequestMarshaller<S3Retention, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(S3Retention requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetEventHold())
            {
                context.Writer.WriteElementString("EventHold", StringUtils.FromString(requestObject.EventHold));
            }
            if (requestObject.IsSetEventHoldDuration())
            {
                context.Writer.WriteStartElement("EventHoldDuration");
                S3ObjectLockRetentionEventHoldDurationMarshaller.Instance.Marshall(requestObject.EventHoldDuration, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetMode())
            {
                context.Writer.WriteElementString("Mode", StringUtils.FromString(requestObject.Mode));
            }
            if (requestObject.IsSetRetainUntilDate())
            {
                context.Writer.WriteElementString("RetainUntilDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.RetainUntilDate.Value));
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static S3RetentionMarshaller Instance = new S3RetentionMarshaller();
    }
}
