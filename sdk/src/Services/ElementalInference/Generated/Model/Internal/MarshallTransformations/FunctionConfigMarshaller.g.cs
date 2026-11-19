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

using Amazon.ElementalInference.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.ElementalInference.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FunctionConfig Marshaller
    /// </summary>
    public partial class FunctionConfigMarshaller : IRequestMarshaller<FunctionConfig, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(FunctionConfig requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetClippingSettings())
            {
                context.Writer.WritePropertyName("clippingSettings");
                context.Writer.WriteStartObject();

                var marshaller = ClippingSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ClippingSettings, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetContextualMetadataSettings())
            {
                context.Writer.WritePropertyName("contextualMetadataSettings");
                context.Writer.WriteStartObject();

                var marshaller = ContextualMetadataSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ContextualMetadataSettings, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetFrameSettings())
            {
                context.Writer.WritePropertyName("frameSettings");
                context.Writer.WriteStartObject();

                var marshaller = FrameSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.FrameSettings, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetFunctionArn())
            {
                context.Writer.WritePropertyName("functionArn");
                context.Writer.WriteStringValue(requestObject.FunctionArn);
            }

            if (requestObject.IsSetSubtitlingSettings())
            {
                context.Writer.WritePropertyName("subtitlingSettings");
                context.Writer.WriteStartObject();

                var marshaller = SubtitlingSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.SubtitlingSettings, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetTrigger())
            {
                context.Writer.WritePropertyName("trigger");
                context.Writer.WriteStartObject();

                var marshaller = TriggerMarshaller.Instance;
                marshaller.Marshall(requestObject.Trigger, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static FunctionConfigMarshaller Instance = new FunctionConfigMarshaller();
    }
}
