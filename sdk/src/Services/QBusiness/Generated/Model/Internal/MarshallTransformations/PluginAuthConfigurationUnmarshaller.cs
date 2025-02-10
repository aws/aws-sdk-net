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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PluginAuthConfiguration Object
    /// </summary>  
    public class PluginAuthConfigurationUnmarshaller : IJsonUnmarshaller<PluginAuthConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public PluginAuthConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            PluginAuthConfiguration unmarshalledObject = new PluginAuthConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("basicAuthConfiguration", targetDepth))
                {
                    var unmarshaller = BasicAuthConfigurationUnmarshaller.Instance;
                    unmarshalledObject.BasicAuthConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("idcAuthConfiguration", targetDepth))
                {
                    var unmarshaller = IdcAuthConfigurationUnmarshaller.Instance;
                    unmarshalledObject.IdcAuthConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("noAuthConfiguration", targetDepth))
                {
                    var unmarshaller = NoAuthConfigurationUnmarshaller.Instance;
                    unmarshalledObject.NoAuthConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("oAuth2ClientCredentialConfiguration", targetDepth))
                {
                    var unmarshaller = OAuth2ClientCredentialConfigurationUnmarshaller.Instance;
                    unmarshalledObject.OAuth2ClientCredentialConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PluginAuthConfigurationUnmarshaller _instance = new PluginAuthConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PluginAuthConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}