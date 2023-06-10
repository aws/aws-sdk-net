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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMediaPipelines.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for KinesisVideoStreamSourceRuntimeConfiguration Object
    /// </summary>  
    public class KinesisVideoStreamSourceRuntimeConfigurationUnmarshaller : IUnmarshaller<KinesisVideoStreamSourceRuntimeConfiguration, XmlUnmarshallerContext>, IUnmarshaller<KinesisVideoStreamSourceRuntimeConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        KinesisVideoStreamSourceRuntimeConfiguration IUnmarshaller<KinesisVideoStreamSourceRuntimeConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public KinesisVideoStreamSourceRuntimeConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            KinesisVideoStreamSourceRuntimeConfiguration unmarshalledObject = new KinesisVideoStreamSourceRuntimeConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("MediaEncoding", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MediaEncoding = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MediaSampleRate", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MediaSampleRate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Streams", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StreamConfiguration, StreamConfigurationUnmarshaller>(StreamConfigurationUnmarshaller.Instance);
                    unmarshalledObject.Streams = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static KinesisVideoStreamSourceRuntimeConfigurationUnmarshaller _instance = new KinesisVideoStreamSourceRuntimeConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static KinesisVideoStreamSourceRuntimeConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}