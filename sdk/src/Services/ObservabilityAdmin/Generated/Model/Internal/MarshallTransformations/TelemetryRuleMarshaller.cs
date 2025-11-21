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
    /// TelemetryRule Marshaller
    /// </summary>
    public class TelemetryRuleMarshaller : IRequestMarshaller<TelemetryRule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TelemetryRule requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDestinationConfiguration())
            {
                context.Writer.WritePropertyName("DestinationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = TelemetryDestinationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DestinationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("ResourceType");
                context.Writer.WriteStringValue(requestObject.ResourceType);
            }

            if(requestObject.IsSetScope())
            {
                context.Writer.WritePropertyName("Scope");
                context.Writer.WriteStringValue(requestObject.Scope);
            }

            if(requestObject.IsSetSelectionCriteria())
            {
                context.Writer.WritePropertyName("SelectionCriteria");
                context.Writer.WriteStringValue(requestObject.SelectionCriteria);
            }

            if(requestObject.IsSetTelemetryType())
            {
                context.Writer.WritePropertyName("TelemetryType");
                context.Writer.WriteStringValue(requestObject.TelemetryType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TelemetryRuleMarshaller Instance = new TelemetryRuleMarshaller();

    }
}