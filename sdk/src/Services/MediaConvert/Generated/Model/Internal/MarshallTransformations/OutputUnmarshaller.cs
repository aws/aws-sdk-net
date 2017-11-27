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
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Output Object
    /// </summary>  
    public class OutputUnmarshaller : IUnmarshaller<Output, XmlUnmarshallerContext>, IUnmarshaller<Output, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Output IUnmarshaller<Output, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Output Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Output unmarshalledObject = new Output();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("audioDescriptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AudioDescription, AudioDescriptionUnmarshaller>(AudioDescriptionUnmarshaller.Instance);
                    unmarshalledObject.AudioDescriptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("captionDescriptions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CaptionDescription, CaptionDescriptionUnmarshaller>(CaptionDescriptionUnmarshaller.Instance);
                    unmarshalledObject.CaptionDescriptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("containerSettings", targetDepth))
                {
                    var unmarshaller = ContainerSettingsUnmarshaller.Instance;
                    unmarshalledObject.ContainerSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("extension", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Extension = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nameModifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NameModifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputSettings", targetDepth))
                {
                    var unmarshaller = OutputSettingsUnmarshaller.Instance;
                    unmarshalledObject.OutputSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("preset", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Preset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("videoDescription", targetDepth))
                {
                    var unmarshaller = VideoDescriptionUnmarshaller.Instance;
                    unmarshalledObject.VideoDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static OutputUnmarshaller _instance = new OutputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OutputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}