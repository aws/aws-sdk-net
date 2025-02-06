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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NexGuardFileMarkerSettings Marshaller
    /// </summary>
    public class NexGuardFileMarkerSettingsMarshaller : IRequestMarshaller<NexGuardFileMarkerSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NexGuardFileMarkerSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLicense())
            {
                context.Writer.WritePropertyName("license");
                context.Writer.WriteStringValue(requestObject.License);
            }

            if(requestObject.IsSetPayload())
            {
                context.Writer.WritePropertyName("payload");
                context.Writer.WriteNumberValue(requestObject.Payload.Value);
            }

            if(requestObject.IsSetPreset())
            {
                context.Writer.WritePropertyName("preset");
                context.Writer.WriteStringValue(requestObject.Preset);
            }

            if(requestObject.IsSetStrength())
            {
                context.Writer.WritePropertyName("strength");
                context.Writer.WriteStringValue(requestObject.Strength);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NexGuardFileMarkerSettingsMarshaller Instance = new NexGuardFileMarkerSettingsMarshaller();

    }
}