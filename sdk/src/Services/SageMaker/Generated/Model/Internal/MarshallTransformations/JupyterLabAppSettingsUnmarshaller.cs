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
    /// Response Unmarshaller for JupyterLabAppSettings Object
    /// </summary>  
    public class JupyterLabAppSettingsUnmarshaller : IUnmarshaller<JupyterLabAppSettings, XmlUnmarshallerContext>, IUnmarshaller<JupyterLabAppSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        JupyterLabAppSettings IUnmarshaller<JupyterLabAppSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public JupyterLabAppSettings Unmarshall(JsonUnmarshallerContext context)
        {
            JupyterLabAppSettings unmarshalledObject = new JupyterLabAppSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AppLifecycleManagement", targetDepth))
                {
                    var unmarshaller = AppLifecycleManagementUnmarshaller.Instance;
                    unmarshalledObject.AppLifecycleManagement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BuiltInLifecycleConfigArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BuiltInLifecycleConfigArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CodeRepositories", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CodeRepository, CodeRepositoryUnmarshaller>(CodeRepositoryUnmarshaller.Instance);
                    unmarshalledObject.CodeRepositories = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomImages", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CustomImage, CustomImageUnmarshaller>(CustomImageUnmarshaller.Instance);
                    unmarshalledObject.CustomImages = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultResourceSpec", targetDepth))
                {
                    var unmarshaller = ResourceSpecUnmarshaller.Instance;
                    unmarshalledObject.DefaultResourceSpec = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EmrSettings", targetDepth))
                {
                    var unmarshaller = EmrSettingsUnmarshaller.Instance;
                    unmarshalledObject.EmrSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LifecycleConfigArns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.LifecycleConfigArns = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static JupyterLabAppSettingsUnmarshaller _instance = new JupyterLabAppSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JupyterLabAppSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}