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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpacesWeb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpacesWeb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UserSettingsSummary Object
    /// </summary>  
    public class UserSettingsSummaryUnmarshaller : IJsonUnmarshaller<UserSettingsSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public UserSettingsSummary Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            UserSettingsSummary unmarshalledObject = new UserSettingsSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("cookieSynchronizationConfiguration", targetDepth))
                {
                    var unmarshaller = CookieSynchronizationConfigurationUnmarshaller.Instance;
                    unmarshalledObject.CookieSynchronizationConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("copyAllowed", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CopyAllowed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("deepLinkAllowed", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeepLinkAllowed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("disconnectTimeoutInMinutes", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DisconnectTimeoutInMinutes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("downloadAllowed", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DownloadAllowed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("idleDisconnectTimeoutInMinutes", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.IdleDisconnectTimeoutInMinutes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pasteAllowed", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PasteAllowed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("printAllowed", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrintAllowed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("toolbarConfiguration", targetDepth))
                {
                    var unmarshaller = ToolbarConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ToolbarConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("uploadAllowed", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UploadAllowed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("userSettingsArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserSettingsArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static UserSettingsSummaryUnmarshaller _instance = new UserSettingsSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UserSettingsSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}