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
 * Do not modify this file. This file is generated from the support-app-2021-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SupportApp.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SupportApp.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SlackChannelConfiguration Object
    /// </summary>  
    public class SlackChannelConfigurationUnmarshaller : IJsonUnmarshaller<SlackChannelConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public SlackChannelConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            SlackChannelConfiguration unmarshalledObject = new SlackChannelConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("channelId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChannelId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("channelName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChannelName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("channelRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChannelRoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("notifyOnAddCorrespondenceToCase", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.NotifyOnAddCorrespondenceToCase = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("notifyOnCaseSeverity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NotifyOnCaseSeverity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("notifyOnCreateOrReopenCase", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.NotifyOnCreateOrReopenCase = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("notifyOnResolveCase", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.NotifyOnResolveCase = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("teamId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TeamId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SlackChannelConfigurationUnmarshaller _instance = new SlackChannelConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SlackChannelConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}