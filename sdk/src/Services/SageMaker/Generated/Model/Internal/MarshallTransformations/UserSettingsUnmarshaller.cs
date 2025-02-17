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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UserSettings Object
    /// </summary>  
    public class UserSettingsUnmarshaller : IUnmarshaller<UserSettings, XmlUnmarshallerContext>, IUnmarshaller<UserSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        UserSettings IUnmarshaller<UserSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public UserSettings Unmarshall(JsonUnmarshallerContext context)
        {
            UserSettings unmarshalledObject = new UserSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AutoMountHomeEFS", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AutoMountHomeEFS = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CanvasAppSettings", targetDepth))
                {
                    var unmarshaller = CanvasAppSettingsUnmarshaller.Instance;
                    unmarshalledObject.CanvasAppSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CodeEditorAppSettings", targetDepth))
                {
                    var unmarshaller = CodeEditorAppSettingsUnmarshaller.Instance;
                    unmarshalledObject.CodeEditorAppSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomFileSystemConfigs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CustomFileSystemConfig, CustomFileSystemConfigUnmarshaller>(CustomFileSystemConfigUnmarshaller.Instance);
                    unmarshalledObject.CustomFileSystemConfigs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomPosixUserConfig", targetDepth))
                {
                    var unmarshaller = CustomPosixUserConfigUnmarshaller.Instance;
                    unmarshalledObject.CustomPosixUserConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultLandingUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultLandingUri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JupyterLabAppSettings", targetDepth))
                {
                    var unmarshaller = JupyterLabAppSettingsUnmarshaller.Instance;
                    unmarshalledObject.JupyterLabAppSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JupyterServerAppSettings", targetDepth))
                {
                    var unmarshaller = JupyterServerAppSettingsUnmarshaller.Instance;
                    unmarshalledObject.JupyterServerAppSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KernelGatewayAppSettings", targetDepth))
                {
                    var unmarshaller = KernelGatewayAppSettingsUnmarshaller.Instance;
                    unmarshalledObject.KernelGatewayAppSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RSessionAppSettings", targetDepth))
                {
                    var unmarshaller = RSessionAppSettingsUnmarshaller.Instance;
                    unmarshalledObject.RSessionAppSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RStudioServerProAppSettings", targetDepth))
                {
                    var unmarshaller = RStudioServerProAppSettingsUnmarshaller.Instance;
                    unmarshalledObject.RStudioServerProAppSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SecurityGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SharingSettings", targetDepth))
                {
                    var unmarshaller = SharingSettingsUnmarshaller.Instance;
                    unmarshalledObject.SharingSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SpaceStorageSettings", targetDepth))
                {
                    var unmarshaller = DefaultSpaceStorageSettingsUnmarshaller.Instance;
                    unmarshalledObject.SpaceStorageSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StudioWebPortal", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StudioWebPortal = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StudioWebPortalSettings", targetDepth))
                {
                    var unmarshaller = StudioWebPortalSettingsUnmarshaller.Instance;
                    unmarshalledObject.StudioWebPortalSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TensorBoardAppSettings", targetDepth))
                {
                    var unmarshaller = TensorBoardAppSettingsUnmarshaller.Instance;
                    unmarshalledObject.TensorBoardAppSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static UserSettingsUnmarshaller _instance = new UserSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UserSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}