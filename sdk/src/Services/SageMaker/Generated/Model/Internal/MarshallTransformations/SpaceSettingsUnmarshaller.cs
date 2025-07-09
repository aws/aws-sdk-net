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
    /// Response Unmarshaller for SpaceSettings Object
    /// </summary>  
    public class SpaceSettingsUnmarshaller : IJsonUnmarshaller<SpaceSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public SpaceSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            SpaceSettings unmarshalledObject = new SpaceSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AppType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AppType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CodeEditorAppSettings", targetDepth))
                {
                    var unmarshaller = SpaceCodeEditorAppSettingsUnmarshaller.Instance;
                    unmarshalledObject.CodeEditorAppSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CustomFileSystems", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<CustomFileSystem, CustomFileSystemUnmarshaller>(CustomFileSystemUnmarshaller.Instance);
                    unmarshalledObject.CustomFileSystems = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JupyterLabAppSettings", targetDepth))
                {
                    var unmarshaller = SpaceJupyterLabAppSettingsUnmarshaller.Instance;
                    unmarshalledObject.JupyterLabAppSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JupyterServerAppSettings", targetDepth))
                {
                    var unmarshaller = JupyterServerAppSettingsUnmarshaller.Instance;
                    unmarshalledObject.JupyterServerAppSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KernelGatewayAppSettings", targetDepth))
                {
                    var unmarshaller = KernelGatewayAppSettingsUnmarshaller.Instance;
                    unmarshalledObject.KernelGatewayAppSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RemoteAccess", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RemoteAccess = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SpaceManagedResources", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SpaceManagedResources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SpaceStorageSettings", targetDepth))
                {
                    var unmarshaller = SpaceStorageSettingsUnmarshaller.Instance;
                    unmarshalledObject.SpaceStorageSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SpaceSettingsUnmarshaller _instance = new SpaceSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SpaceSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}