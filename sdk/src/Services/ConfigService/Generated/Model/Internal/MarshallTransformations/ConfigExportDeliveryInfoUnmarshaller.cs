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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConfigExportDeliveryInfo Object
    /// </summary>  
    public class ConfigExportDeliveryInfoUnmarshaller : IUnmarshaller<ConfigExportDeliveryInfo, XmlUnmarshallerContext>, IUnmarshaller<ConfigExportDeliveryInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConfigExportDeliveryInfo IUnmarshaller<ConfigExportDeliveryInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ConfigExportDeliveryInfo Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ConfigExportDeliveryInfo unmarshalledObject = new ConfigExportDeliveryInfo();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("lastAttemptTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastAttemptTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastErrorCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastErrorCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastErrorMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastErrorMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastSuccessfulTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastSuccessfulTime = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ConfigExportDeliveryInfoUnmarshaller _instance = new ConfigExportDeliveryInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConfigExportDeliveryInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}