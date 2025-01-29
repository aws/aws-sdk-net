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
    /// Response Unmarshaller for JobSettings Object
    /// </summary>  
    public class JobSettingsUnmarshaller : IJsonUnmarshaller<JobSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public JobSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            JobSettings unmarshalledObject = new JobSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("adAvailOffset", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.AdAvailOffset = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("availBlanking", targetDepth))
                {
                    var unmarshaller = AvailBlankingUnmarshaller.Instance;
                    unmarshalledObject.AvailBlanking = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("colorConversion3DLUTSettings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ColorConversion3DLUTSetting, ColorConversion3DLUTSettingUnmarshaller>(ColorConversion3DLUTSettingUnmarshaller.Instance);
                    unmarshalledObject.ColorConversion3DLUTSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("esam", targetDepth))
                {
                    var unmarshaller = EsamSettingsUnmarshaller.Instance;
                    unmarshalledObject.Esam = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("extendedDataServices", targetDepth))
                {
                    var unmarshaller = ExtendedDataServicesUnmarshaller.Instance;
                    unmarshalledObject.ExtendedDataServices = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("followSource", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.FollowSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("inputs", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Input, InputUnmarshaller>(InputUnmarshaller.Instance);
                    unmarshalledObject.Inputs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("kantarWatermark", targetDepth))
                {
                    var unmarshaller = KantarWatermarkSettingsUnmarshaller.Instance;
                    unmarshalledObject.KantarWatermark = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("motionImageInserter", targetDepth))
                {
                    var unmarshaller = MotionImageInserterUnmarshaller.Instance;
                    unmarshalledObject.MotionImageInserter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("nielsenConfiguration", targetDepth))
                {
                    var unmarshaller = NielsenConfigurationUnmarshaller.Instance;
                    unmarshalledObject.NielsenConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("nielsenNonLinearWatermark", targetDepth))
                {
                    var unmarshaller = NielsenNonLinearWatermarkSettingsUnmarshaller.Instance;
                    unmarshalledObject.NielsenNonLinearWatermark = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("outputGroups", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<OutputGroup, OutputGroupUnmarshaller>(OutputGroupUnmarshaller.Instance);
                    unmarshalledObject.OutputGroups = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timecodeConfig", targetDepth))
                {
                    var unmarshaller = TimecodeConfigUnmarshaller.Instance;
                    unmarshalledObject.TimecodeConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timedMetadataInsertion", targetDepth))
                {
                    var unmarshaller = TimedMetadataInsertionUnmarshaller.Instance;
                    unmarshalledObject.TimedMetadataInsertion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static JobSettingsUnmarshaller _instance = new JobSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JobSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}