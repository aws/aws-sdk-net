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
using ThirdParty.Json.LitJson;

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InputSettings Marshaller
    /// </summary>       
    public class InputSettingsMarshaller : IRequestMarshaller<InputSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InputSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAudioSelectors())
            {
                context.Writer.WritePropertyName("audioSelectors");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAudioSelectorsListValue in requestObject.AudioSelectors)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AudioSelectorMarshaller.Instance;
                    marshaller.Marshall(requestObjectAudioSelectorsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCaptionSelectors())
            {
                context.Writer.WritePropertyName("captionSelectors");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCaptionSelectorsListValue in requestObject.CaptionSelectors)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CaptionSelectorMarshaller.Instance;
                    marshaller.Marshall(requestObjectCaptionSelectorsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDeblockFilter())
            {
                context.Writer.WritePropertyName("deblockFilter");
                context.Writer.Write(requestObject.DeblockFilter);
            }

            if(requestObject.IsSetDenoiseFilter())
            {
                context.Writer.WritePropertyName("denoiseFilter");
                context.Writer.Write(requestObject.DenoiseFilter);
            }

            if(requestObject.IsSetFilterStrength())
            {
                context.Writer.WritePropertyName("filterStrength");
                context.Writer.Write(requestObject.FilterStrength);
            }

            if(requestObject.IsSetInputFilter())
            {
                context.Writer.WritePropertyName("inputFilter");
                context.Writer.Write(requestObject.InputFilter);
            }

            if(requestObject.IsSetNetworkInputSettings())
            {
                context.Writer.WritePropertyName("networkInputSettings");
                context.Writer.WriteObjectStart();

                var marshaller = NetworkInputSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkInputSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSmpte2038DataPreference())
            {
                context.Writer.WritePropertyName("smpte2038DataPreference");
                context.Writer.Write(requestObject.Smpte2038DataPreference);
            }

            if(requestObject.IsSetSourceEndBehavior())
            {
                context.Writer.WritePropertyName("sourceEndBehavior");
                context.Writer.Write(requestObject.SourceEndBehavior);
            }

            if(requestObject.IsSetVideoSelector())
            {
                context.Writer.WritePropertyName("videoSelector");
                context.Writer.WriteObjectStart();

                var marshaller = VideoSelectorMarshaller.Instance;
                marshaller.Marshall(requestObject.VideoSelector, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static InputSettingsMarshaller Instance = new InputSettingsMarshaller();

    }
}