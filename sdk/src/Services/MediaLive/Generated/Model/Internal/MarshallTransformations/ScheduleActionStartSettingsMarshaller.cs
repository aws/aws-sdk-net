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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ScheduleActionStartSettings Marshaller
    /// </summary>
    public class ScheduleActionStartSettingsMarshaller : IRequestMarshaller<ScheduleActionStartSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ScheduleActionStartSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFixedModeScheduleActionStartSettings())
            {
                context.Writer.WritePropertyName("fixedModeScheduleActionStartSettings");
                context.Writer.WriteStartObject();

                var marshaller = FixedModeScheduleActionStartSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.FixedModeScheduleActionStartSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFollowModeScheduleActionStartSettings())
            {
                context.Writer.WritePropertyName("followModeScheduleActionStartSettings");
                context.Writer.WriteStartObject();

                var marshaller = FollowModeScheduleActionStartSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.FollowModeScheduleActionStartSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetImmediateModeScheduleActionStartSettings())
            {
                context.Writer.WritePropertyName("immediateModeScheduleActionStartSettings");
                context.Writer.WriteStartObject();

                var marshaller = ImmediateModeScheduleActionStartSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ImmediateModeScheduleActionStartSettings, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScheduleActionStartSettingsMarshaller Instance = new ScheduleActionStartSettingsMarshaller();

    }
}