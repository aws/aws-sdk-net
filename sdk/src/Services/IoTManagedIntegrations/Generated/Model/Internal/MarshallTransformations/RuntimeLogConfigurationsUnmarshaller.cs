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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTManagedIntegrations.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTManagedIntegrations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RuntimeLogConfigurations Object
    /// </summary>  
    public class RuntimeLogConfigurationsUnmarshaller : IUnmarshaller<RuntimeLogConfigurations, XmlUnmarshallerContext>, IUnmarshaller<RuntimeLogConfigurations, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RuntimeLogConfigurations IUnmarshaller<RuntimeLogConfigurations, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RuntimeLogConfigurations Unmarshall(JsonUnmarshallerContext context)
        {
            RuntimeLogConfigurations unmarshalledObject = new RuntimeLogConfigurations();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DeleteLocalStoreAfterUpload", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DeleteLocalStoreAfterUpload = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LocalStoreFileRotationMaxBytes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.LocalStoreFileRotationMaxBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LocalStoreFileRotationMaxFiles", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.LocalStoreFileRotationMaxFiles = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LocalStoreLocation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalStoreLocation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogFlushLevel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogFlushLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogLevel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UploadLog", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UploadLog = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UploadPeriodMinutes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.UploadPeriodMinutes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RuntimeLogConfigurationsUnmarshaller _instance = new RuntimeLogConfigurationsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RuntimeLogConfigurationsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}