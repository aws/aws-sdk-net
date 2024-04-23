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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PlaybackConfiguration Object
    /// </summary>  
    public class PlaybackConfigurationUnmarshaller : IUnmarshaller<PlaybackConfiguration, XmlUnmarshallerContext>, IUnmarshaller<PlaybackConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PlaybackConfiguration IUnmarshaller<PlaybackConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PlaybackConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            PlaybackConfiguration unmarshalledObject = new PlaybackConfiguration();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdDecisionServerUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdDecisionServerUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AvailSuppression", targetDepth))
                {
                    var unmarshaller = AvailSuppressionUnmarshaller.Instance;
                    unmarshalledObject.AvailSuppression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Bumper", targetDepth))
                {
                    var unmarshaller = BumperUnmarshaller.Instance;
                    unmarshalledObject.Bumper = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CdnConfiguration", targetDepth))
                {
                    var unmarshaller = CdnConfigurationUnmarshaller.Instance;
                    unmarshalledObject.CdnConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConfigurationAliases", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, Dictionary<string, string>, StringUnmarshaller, DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>>(StringUnmarshaller.Instance, new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance));
                    unmarshalledObject.ConfigurationAliases = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DashConfiguration", targetDepth))
                {
                    var unmarshaller = DashConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DashConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HlsConfiguration", targetDepth))
                {
                    var unmarshaller = HlsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.HlsConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InsertionMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InsertionMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LivePreRollConfiguration", targetDepth))
                {
                    var unmarshaller = LivePreRollConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LivePreRollConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogConfiguration", targetDepth))
                {
                    var unmarshaller = LogConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LogConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ManifestProcessingRules", targetDepth))
                {
                    var unmarshaller = ManifestProcessingRulesUnmarshaller.Instance;
                    unmarshalledObject.ManifestProcessingRules = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PersonalizationThresholdSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PersonalizationThresholdSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlaybackConfigurationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlaybackConfigurationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlaybackEndpointPrefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlaybackEndpointPrefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SessionInitializationEndpointPrefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SessionInitializationEndpointPrefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SlateAdUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SlateAdUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TranscodeProfileName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TranscodeProfileName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VideoContentSourceUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VideoContentSourceUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PlaybackConfigurationUnmarshaller _instance = new PlaybackConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PlaybackConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618