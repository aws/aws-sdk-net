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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Input Object
    /// </summary>  
    public class InputUnmarshaller : IJsonUnmarshaller<Input, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Input Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Input unmarshalledObject = new Input();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("advancedInputFilter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdvancedInputFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("advancedInputFilterSettings", targetDepth))
                {
                    var unmarshaller = AdvancedInputFilterSettingsUnmarshaller.Instance;
                    unmarshalledObject.AdvancedInputFilterSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("audioSelectorGroups", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, AudioSelectorGroup, StringUnmarshaller, AudioSelectorGroupUnmarshaller>(StringUnmarshaller.Instance, AudioSelectorGroupUnmarshaller.Instance);
                    unmarshalledObject.AudioSelectorGroups = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("audioSelectors", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, AudioSelector, StringUnmarshaller, AudioSelectorUnmarshaller>(StringUnmarshaller.Instance, AudioSelectorUnmarshaller.Instance);
                    unmarshalledObject.AudioSelectors = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("captionSelectors", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, CaptionSelector, StringUnmarshaller, CaptionSelectorUnmarshaller>(StringUnmarshaller.Instance, CaptionSelectorUnmarshaller.Instance);
                    unmarshalledObject.CaptionSelectors = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("crop", targetDepth))
                {
                    var unmarshaller = RectangleUnmarshaller.Instance;
                    unmarshalledObject.Crop = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("deblockFilter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeblockFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("decryptionSettings", targetDepth))
                {
                    var unmarshaller = InputDecryptionSettingsUnmarshaller.Instance;
                    unmarshalledObject.DecryptionSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("denoiseFilter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DenoiseFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dolbyVisionMetadataXml", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DolbyVisionMetadataXml = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dynamicAudioSelectors", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, DynamicAudioSelector, StringUnmarshaller, DynamicAudioSelectorUnmarshaller>(StringUnmarshaller.Instance, DynamicAudioSelectorUnmarshaller.Instance);
                    unmarshalledObject.DynamicAudioSelectors = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("fileInput", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FileInput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("filterEnable", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FilterEnable = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("filterStrength", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.FilterStrength = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("imageInserter", targetDepth))
                {
                    var unmarshaller = ImageInserterUnmarshaller.Instance;
                    unmarshalledObject.ImageInserter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("inputClippings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<InputClipping, InputClippingUnmarshaller>(InputClippingUnmarshaller.Instance);
                    unmarshalledObject.InputClippings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("inputScanType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InputScanType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("position", targetDepth))
                {
                    var unmarshaller = RectangleUnmarshaller.Instance;
                    unmarshalledObject.Position = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("programNumber", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ProgramNumber = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("psiControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PsiControl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("supplementalImps", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SupplementalImps = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tamsSettings", targetDepth))
                {
                    var unmarshaller = InputTamsSettingsUnmarshaller.Instance;
                    unmarshalledObject.TamsSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timecodeSource", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimecodeSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timecodeStart", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimecodeStart = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("videoGenerator", targetDepth))
                {
                    var unmarshaller = InputVideoGeneratorUnmarshaller.Instance;
                    unmarshalledObject.VideoGenerator = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("videoOverlays", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<VideoOverlay, VideoOverlayUnmarshaller>(VideoOverlayUnmarshaller.Instance);
                    unmarshalledObject.VideoOverlays = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("videoSelector", targetDepth))
                {
                    var unmarshaller = VideoSelectorUnmarshaller.Instance;
                    unmarshalledObject.VideoSelector = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InputUnmarshaller _instance = new InputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}