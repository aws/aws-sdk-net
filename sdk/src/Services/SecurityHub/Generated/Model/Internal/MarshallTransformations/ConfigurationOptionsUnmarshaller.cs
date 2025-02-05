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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConfigurationOptions Object
    /// </summary>  
    public class ConfigurationOptionsUnmarshaller : IJsonUnmarshaller<ConfigurationOptions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ConfigurationOptions Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ConfigurationOptions unmarshalledObject = new ConfigurationOptions();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Boolean", targetDepth))
                {
                    var unmarshaller = BooleanConfigurationOptionsUnmarshaller.Instance;
                    unmarshalledObject.Boolean = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Double", targetDepth))
                {
                    var unmarshaller = DoubleConfigurationOptionsUnmarshaller.Instance;
                    unmarshalledObject.Double = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Enum", targetDepth))
                {
                    var unmarshaller = EnumConfigurationOptionsUnmarshaller.Instance;
                    unmarshalledObject.Enum = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EnumList", targetDepth))
                {
                    var unmarshaller = EnumListConfigurationOptionsUnmarshaller.Instance;
                    unmarshalledObject.EnumList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Integer", targetDepth))
                {
                    var unmarshaller = IntegerConfigurationOptionsUnmarshaller.Instance;
                    unmarshalledObject.Integer = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IntegerList", targetDepth))
                {
                    var unmarshaller = IntegerListConfigurationOptionsUnmarshaller.Instance;
                    unmarshalledObject.IntegerList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("String", targetDepth))
                {
                    var unmarshaller = StringConfigurationOptionsUnmarshaller.Instance;
                    unmarshalledObject.String = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StringList", targetDepth))
                {
                    var unmarshaller = StringListConfigurationOptionsUnmarshaller.Instance;
                    unmarshalledObject.StringList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ConfigurationOptionsUnmarshaller _instance = new ConfigurationOptionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConfigurationOptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}