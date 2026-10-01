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

using Amazon.MediaConvert.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EmbeddedSourceSettings Marshaller
    /// </summary>
    public partial class EmbeddedSourceSettingsMarshaller : IRequestMarshaller<EmbeddedSourceSettings, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(EmbeddedSourceSettings requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetConvert608To708())
            {
                context.Writer.WritePropertyName("convert608To708");
                context.Writer.WriteStringValue(requestObject.Convert608To708);
            }

            if (requestObject.IsSetSource608ChannelNumber())
            {
                context.Writer.WritePropertyName("source608ChannelNumber");
                context.Writer.WriteNumberValue(requestObject.Source608ChannelNumber.Value);
            }

            if (requestObject.IsSetSource608TrackNumber())
            {
                context.Writer.WritePropertyName("source608TrackNumber");
                context.Writer.WriteNumberValue(requestObject.Source608TrackNumber.Value);
            }

            if (requestObject.IsSetTerminateCaptions())
            {
                context.Writer.WritePropertyName("terminateCaptions");
                context.Writer.WriteStringValue(requestObject.TerminateCaptions);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static EmbeddedSourceSettingsMarshaller Instance = new EmbeddedSourceSettingsMarshaller();
    }
}
