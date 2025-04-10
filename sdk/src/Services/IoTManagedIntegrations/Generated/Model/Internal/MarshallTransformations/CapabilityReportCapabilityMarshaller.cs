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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTManagedIntegrations.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTManagedIntegrations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CapabilityReportCapability Marshaller
    /// </summary>
    public class CapabilityReportCapabilityMarshaller : IRequestMarshaller<CapabilityReportCapability, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CapabilityReportCapability requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActions())
            {
                context.Writer.WritePropertyName("actions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectActionsListValue in requestObject.Actions)
                {
                        context.Writer.Write(requestObjectActionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEvents())
            {
                context.Writer.WritePropertyName("events");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEventsListValue in requestObject.Events)
                {
                        context.Writer.Write(requestObjectEventsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.Write(requestObject.Id);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetProperties())
            {
                context.Writer.WritePropertyName("properties");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPropertiesListValue in requestObject.Properties)
                {
                        context.Writer.Write(requestObjectPropertiesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetVersion())
            {
                context.Writer.WritePropertyName("version");
                context.Writer.Write(requestObject.Version);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CapabilityReportCapabilityMarshaller Instance = new CapabilityReportCapabilityMarshaller();

    }
}