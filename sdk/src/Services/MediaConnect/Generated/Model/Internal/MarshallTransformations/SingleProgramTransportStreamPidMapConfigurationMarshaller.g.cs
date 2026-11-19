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

using Amazon.MediaConnect.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SingleProgramTransportStreamPidMapConfiguration Marshaller
    /// </summary>
    public partial class SingleProgramTransportStreamPidMapConfigurationMarshaller : IRequestMarshaller<SingleProgramTransportStreamPidMapConfiguration, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(SingleProgramTransportStreamPidMapConfiguration requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAuto())
            {
                context.Writer.WritePropertyName("auto");
                context.Writer.WriteStartObject();

                var marshaller = AutoPidMapConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Auto, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetDefaultAction())
            {
                context.Writer.WritePropertyName("defaultAction");
                context.Writer.WriteStringValue(requestObject.DefaultAction);
            }

            if (requestObject.IsSetProgramClockReferencePid())
            {
                context.Writer.WritePropertyName("programClockReferencePid");
                context.Writer.WriteStartObject();

                var marshaller = ProgramClockReferencePidConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ProgramClockReferencePid, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetProgramMapTablePid())
            {
                context.Writer.WritePropertyName("programMapTablePid");
                context.Writer.WriteStartObject();

                var marshaller = ProgramMapTablePidConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ProgramMapTablePid, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetProgramNumber())
            {
                context.Writer.WritePropertyName("programNumber");
                context.Writer.WriteStartObject();

                var marshaller = ProgramNumberConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ProgramNumber, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetRules())
            {
                context.Writer.WritePropertyName("rules");
                context.Writer.WriteStartArray();
                foreach (var requestObjectRulesListValue in requestObject.Rules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PidMapRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetTransportStreamId())
            {
                context.Writer.WritePropertyName("transportStreamId");
                context.Writer.WriteStartObject();

                var marshaller = TransportStreamIdConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.TransportStreamId, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static SingleProgramTransportStreamPidMapConfigurationMarshaller Instance = new SingleProgramTransportStreamPidMapConfigurationMarshaller();
    }
}
