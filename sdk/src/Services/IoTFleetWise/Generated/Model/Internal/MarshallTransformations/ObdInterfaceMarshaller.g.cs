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

using Amazon.IoTFleetWise.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ObdInterface Marshaller
    /// </summary>
    public partial class ObdInterfaceMarshaller : IRequestMarshaller<ObdInterface, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ObdInterface requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDtcRequestIntervalSeconds())
            {
                context.Writer.WritePropertyName("dtcRequestIntervalSeconds");
                context.Writer.WriteNumberValue(requestObject.DtcRequestIntervalSeconds.Value);
            }

            if (requestObject.IsSetHasTransmissionEcu())
            {
                context.Writer.WritePropertyName("hasTransmissionEcu");
                context.Writer.WriteBooleanValue(requestObject.HasTransmissionEcu.Value);
            }

            if (requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if (requestObject.IsSetObdStandard())
            {
                context.Writer.WritePropertyName("obdStandard");
                context.Writer.WriteStringValue(requestObject.ObdStandard);
            }

            if (requestObject.IsSetPidRequestIntervalSeconds())
            {
                context.Writer.WritePropertyName("pidRequestIntervalSeconds");
                context.Writer.WriteNumberValue(requestObject.PidRequestIntervalSeconds.Value);
            }

            if (requestObject.IsSetRequestMessageId())
            {
                context.Writer.WritePropertyName("requestMessageId");
                context.Writer.WriteNumberValue(requestObject.RequestMessageId.Value);
            }

            if (requestObject.IsSetUseExtendedIds())
            {
                context.Writer.WritePropertyName("useExtendedIds");
                context.Writer.WriteBooleanValue(requestObject.UseExtendedIds.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ObdInterfaceMarshaller Instance = new ObdInterfaceMarshaller();
    }
}
