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

using Amazon.Lightsail.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WafRule Marshaller
    /// </summary>
    public partial class WafRuleMarshaller : IRequestMarshaller<WafRule, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(WafRule requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAcfpConfig())
            {
                context.Writer.WritePropertyName("acfpConfig");
                context.Writer.WriteStartObject();

                var marshaller = WafAcfpConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.AcfpConfig, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetAtpConfig())
            {
                context.Writer.WritePropertyName("atpConfig");
                context.Writer.WriteStartObject();

                var marshaller = WafAtpConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.AtpConfig, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetBotControlConfig())
            {
                context.Writer.WritePropertyName("botControlConfig");
                context.Writer.WriteStartObject();

                var marshaller = WafBotControlConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.BotControlConfig, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static WafRuleMarshaller Instance = new WafRuleMarshaller();
    }
}
