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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ObservabilityAdmin.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ObservabilityAdmin.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TelemetryDestinationConfiguration Marshaller
    /// </summary>
    public class TelemetryDestinationConfigurationMarshaller : IRequestMarshaller<TelemetryDestinationConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TelemetryDestinationConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDestinationPattern())
            {
                context.Writer.WritePropertyName("DestinationPattern");
                context.Writer.WriteStringValue(requestObject.DestinationPattern);
            }

            if(requestObject.IsSetDestinationType())
            {
                context.Writer.WritePropertyName("DestinationType");
                context.Writer.WriteStringValue(requestObject.DestinationType);
            }

            if(requestObject.IsSetRetentionInDays())
            {
                context.Writer.WritePropertyName("RetentionInDays");
                context.Writer.WriteNumberValue(requestObject.RetentionInDays.Value);
            }

            if(requestObject.IsSetVPCFlowLogParameters())
            {
                context.Writer.WritePropertyName("VPCFlowLogParameters");
                context.Writer.WriteStartObject();

                var marshaller = VPCFlowLogParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.VPCFlowLogParameters, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TelemetryDestinationConfigurationMarshaller Instance = new TelemetryDestinationConfigurationMarshaller();

    }
}