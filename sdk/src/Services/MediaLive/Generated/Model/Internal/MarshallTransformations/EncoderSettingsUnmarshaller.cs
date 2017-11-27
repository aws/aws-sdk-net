/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;
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
    /// Response Unmarshaller for EncoderSettings Object
    /// </summary>  
    public class EncoderSettingsUnmarshaller : IUnmarshaller<EncoderSettings, XmlUnmarshallerContext>, IUnmarshaller<EncoderSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EncoderSettings IUnmarshaller<EncoderSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EncoderSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            EncoderSettings unmarshalledObject = new EncoderSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("audioDescriptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AudioDescription, AudioDescriptionUnmarshaller>(AudioDescriptionUnmarshaller.Instance);
                    unmarshalledObject.AudioDescriptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("availBlanking", targetDepth))
                {
                    var unmarshaller = AvailBlankingUnmarshaller.Instance;
                    unmarshalledObject.AvailBlanking = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("availConfiguration", targetDepth))
                {
                    var unmarshaller = AvailConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AvailConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("blackoutSlate", targetDepth))
                {
                    var unmarshaller = BlackoutSlateUnmarshaller.Instance;
                    unmarshalledObject.BlackoutSlate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("captionDescriptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CaptionDescription, CaptionDescriptionUnmarshaller>(CaptionDescriptionUnmarshaller.Instance);
                    unmarshalledObject.CaptionDescriptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("globalConfiguration", targetDepth))
                {
                    var unmarshaller = GlobalConfigurationUnmarshaller.Instance;
                    unmarshalledObject.GlobalConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<OutputGroup, OutputGroupUnmarshaller>(OutputGroupUnmarshaller.Instance);
                    unmarshalledObject.OutputGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timecodeConfig", targetDepth))
                {
                    var unmarshaller = TimecodeConfigUnmarshaller.Instance;
                    unmarshalledObject.TimecodeConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("videoDescriptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<VideoDescription, VideoDescriptionUnmarshaller>(VideoDescriptionUnmarshaller.Instance);
                    unmarshalledObject.VideoDescriptions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static EncoderSettingsUnmarshaller _instance = new EncoderSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EncoderSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}