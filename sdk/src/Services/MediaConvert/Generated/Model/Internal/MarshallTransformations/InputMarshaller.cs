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
    /// Input Marshaller
    /// </summary>
    public class InputMarshaller : IRequestMarshaller<Input, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Input requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdvancedInputFilter())
            {
                context.Writer.WritePropertyName("advancedInputFilter");
                context.Writer.WriteStringValue(requestObject.AdvancedInputFilter);
            }

            if(requestObject.IsSetAdvancedInputFilterSettings())
            {
                context.Writer.WritePropertyName("advancedInputFilterSettings");
                context.Writer.WriteStartObject();

                var marshaller = AdvancedInputFilterSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.AdvancedInputFilterSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAudioSelectorGroups())
            {
                context.Writer.WritePropertyName("audioSelectorGroups");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAudioSelectorGroupsKvp in requestObject.AudioSelectorGroups)
                {
                    context.Writer.WritePropertyName(requestObjectAudioSelectorGroupsKvp.Key);
                    var requestObjectAudioSelectorGroupsValue = requestObjectAudioSelectorGroupsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = AudioSelectorGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectAudioSelectorGroupsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAudioSelectors())
            {
                context.Writer.WritePropertyName("audioSelectors");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAudioSelectorsKvp in requestObject.AudioSelectors)
                {
                    context.Writer.WritePropertyName(requestObjectAudioSelectorsKvp.Key);
                    var requestObjectAudioSelectorsValue = requestObjectAudioSelectorsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = AudioSelectorMarshaller.Instance;
                    marshaller.Marshall(requestObjectAudioSelectorsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCaptionSelectors())
            {
                context.Writer.WritePropertyName("captionSelectors");
                context.Writer.WriteStartObject();
                foreach (var requestObjectCaptionSelectorsKvp in requestObject.CaptionSelectors)
                {
                    context.Writer.WritePropertyName(requestObjectCaptionSelectorsKvp.Key);
                    var requestObjectCaptionSelectorsValue = requestObjectCaptionSelectorsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = CaptionSelectorMarshaller.Instance;
                    marshaller.Marshall(requestObjectCaptionSelectorsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCrop())
            {
                context.Writer.WritePropertyName("crop");
                context.Writer.WriteStartObject();

                var marshaller = RectangleMarshaller.Instance;
                marshaller.Marshall(requestObject.Crop, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDeblockFilter())
            {
                context.Writer.WritePropertyName("deblockFilter");
                context.Writer.WriteStringValue(requestObject.DeblockFilter);
            }

            if(requestObject.IsSetDecryptionSettings())
            {
                context.Writer.WritePropertyName("decryptionSettings");
                context.Writer.WriteStartObject();

                var marshaller = InputDecryptionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DecryptionSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDenoiseFilter())
            {
                context.Writer.WritePropertyName("denoiseFilter");
                context.Writer.WriteStringValue(requestObject.DenoiseFilter);
            }

            if(requestObject.IsSetDolbyVisionMetadataXml())
            {
                context.Writer.WritePropertyName("dolbyVisionMetadataXml");
                context.Writer.WriteStringValue(requestObject.DolbyVisionMetadataXml);
            }

            if(requestObject.IsSetDynamicAudioSelectors())
            {
                context.Writer.WritePropertyName("dynamicAudioSelectors");
                context.Writer.WriteStartObject();
                foreach (var requestObjectDynamicAudioSelectorsKvp in requestObject.DynamicAudioSelectors)
                {
                    context.Writer.WritePropertyName(requestObjectDynamicAudioSelectorsKvp.Key);
                    var requestObjectDynamicAudioSelectorsValue = requestObjectDynamicAudioSelectorsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = DynamicAudioSelectorMarshaller.Instance;
                    marshaller.Marshall(requestObjectDynamicAudioSelectorsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFileInput())
            {
                context.Writer.WritePropertyName("fileInput");
                context.Writer.WriteStringValue(requestObject.FileInput);
            }

            if(requestObject.IsSetFilterEnable())
            {
                context.Writer.WritePropertyName("filterEnable");
                context.Writer.WriteStringValue(requestObject.FilterEnable);
            }

            if(requestObject.IsSetFilterStrength())
            {
                context.Writer.WritePropertyName("filterStrength");
                context.Writer.WriteNumberValue(requestObject.FilterStrength.Value);
            }

            if(requestObject.IsSetImageInserter())
            {
                context.Writer.WritePropertyName("imageInserter");
                context.Writer.WriteStartObject();

                var marshaller = ImageInserterMarshaller.Instance;
                marshaller.Marshall(requestObject.ImageInserter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInputClippings())
            {
                context.Writer.WritePropertyName("inputClippings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInputClippingsListValue in requestObject.InputClippings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InputClippingMarshaller.Instance;
                    marshaller.Marshall(requestObjectInputClippingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInputScanType())
            {
                context.Writer.WritePropertyName("inputScanType");
                context.Writer.WriteStringValue(requestObject.InputScanType);
            }

            if(requestObject.IsSetPosition())
            {
                context.Writer.WritePropertyName("position");
                context.Writer.WriteStartObject();

                var marshaller = RectangleMarshaller.Instance;
                marshaller.Marshall(requestObject.Position, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProgramNumber())
            {
                context.Writer.WritePropertyName("programNumber");
                context.Writer.WriteNumberValue(requestObject.ProgramNumber.Value);
            }

            if(requestObject.IsSetPsiControl())
            {
                context.Writer.WritePropertyName("psiControl");
                context.Writer.WriteStringValue(requestObject.PsiControl);
            }

            if(requestObject.IsSetSupplementalImps())
            {
                context.Writer.WritePropertyName("supplementalImps");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSupplementalImpsListValue in requestObject.SupplementalImps)
                {
                        context.Writer.WriteStringValue(requestObjectSupplementalImpsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTamsSettings())
            {
                context.Writer.WritePropertyName("tamsSettings");
                context.Writer.WriteStartObject();

                var marshaller = InputTamsSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.TamsSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimecodeSource())
            {
                context.Writer.WritePropertyName("timecodeSource");
                context.Writer.WriteStringValue(requestObject.TimecodeSource);
            }

            if(requestObject.IsSetTimecodeStart())
            {
                context.Writer.WritePropertyName("timecodeStart");
                context.Writer.WriteStringValue(requestObject.TimecodeStart);
            }

            if(requestObject.IsSetVideoGenerator())
            {
                context.Writer.WritePropertyName("videoGenerator");
                context.Writer.WriteStartObject();

                var marshaller = InputVideoGeneratorMarshaller.Instance;
                marshaller.Marshall(requestObject.VideoGenerator, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVideoOverlays())
            {
                context.Writer.WritePropertyName("videoOverlays");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVideoOverlaysListValue in requestObject.VideoOverlays)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = VideoOverlayMarshaller.Instance;
                    marshaller.Marshall(requestObjectVideoOverlaysListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVideoSelector())
            {
                context.Writer.WritePropertyName("videoSelector");
                context.Writer.WriteStartObject();

                var marshaller = VideoSelectorMarshaller.Instance;
                marshaller.Marshall(requestObject.VideoSelector, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InputMarshaller Instance = new InputMarshaller();

    }
}