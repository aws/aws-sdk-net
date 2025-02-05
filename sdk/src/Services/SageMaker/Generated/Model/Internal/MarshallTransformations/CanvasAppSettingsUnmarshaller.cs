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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CanvasAppSettings Object
    /// </summary>  
    public class CanvasAppSettingsUnmarshaller : IJsonUnmarshaller<CanvasAppSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public CanvasAppSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            CanvasAppSettings unmarshalledObject = new CanvasAppSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("DirectDeploySettings", targetDepth))
                {
                    var unmarshaller = DirectDeploySettingsUnmarshaller.Instance;
                    unmarshalledObject.DirectDeploySettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EmrServerlessSettings", targetDepth))
                {
                    var unmarshaller = EmrServerlessSettingsUnmarshaller.Instance;
                    unmarshalledObject.EmrServerlessSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GenerativeAiSettings", targetDepth))
                {
                    var unmarshaller = GenerativeAiSettingsUnmarshaller.Instance;
                    unmarshalledObject.GenerativeAiSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IdentityProviderOAuthSettings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<IdentityProviderOAuthSetting, IdentityProviderOAuthSettingUnmarshaller>(IdentityProviderOAuthSettingUnmarshaller.Instance);
                    unmarshalledObject.IdentityProviderOAuthSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KendraSettings", targetDepth))
                {
                    var unmarshaller = KendraSettingsUnmarshaller.Instance;
                    unmarshalledObject.KendraSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ModelRegisterSettings", targetDepth))
                {
                    var unmarshaller = ModelRegisterSettingsUnmarshaller.Instance;
                    unmarshalledObject.ModelRegisterSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TimeSeriesForecastingSettings", targetDepth))
                {
                    var unmarshaller = TimeSeriesForecastingSettingsUnmarshaller.Instance;
                    unmarshalledObject.TimeSeriesForecastingSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WorkspaceSettings", targetDepth))
                {
                    var unmarshaller = WorkspaceSettingsUnmarshaller.Instance;
                    unmarshalledObject.WorkspaceSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CanvasAppSettingsUnmarshaller _instance = new CanvasAppSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CanvasAppSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}