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
    /// OutputGroupSettings Marshaller
    /// </summary>
    public class OutputGroupSettingsMarshaller : IRequestMarshaller<OutputGroupSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OutputGroupSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCmafGroupSettings())
            {
                context.Writer.WritePropertyName("cmafGroupSettings");
                context.Writer.WriteStartObject();

                var marshaller = CmafGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.CmafGroupSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDashIsoGroupSettings())
            {
                context.Writer.WritePropertyName("dashIsoGroupSettings");
                context.Writer.WriteStartObject();

                var marshaller = DashIsoGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DashIsoGroupSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFileGroupSettings())
            {
                context.Writer.WritePropertyName("fileGroupSettings");
                context.Writer.WriteStartObject();

                var marshaller = FileGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.FileGroupSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHlsGroupSettings())
            {
                context.Writer.WritePropertyName("hlsGroupSettings");
                context.Writer.WriteStartObject();

                var marshaller = HlsGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.HlsGroupSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMsSmoothGroupSettings())
            {
                context.Writer.WritePropertyName("msSmoothGroupSettings");
                context.Writer.WriteStartObject();

                var marshaller = MsSmoothGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MsSmoothGroupSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPerFrameMetrics())
            {
                context.Writer.WritePropertyName("perFrameMetrics");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPerFrameMetricsListValue in requestObject.PerFrameMetrics)
                {
                        context.Writer.WriteStringValue(requestObjectPerFrameMetricsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OutputGroupSettingsMarshaller Instance = new OutputGroupSettingsMarshaller();

    }
}