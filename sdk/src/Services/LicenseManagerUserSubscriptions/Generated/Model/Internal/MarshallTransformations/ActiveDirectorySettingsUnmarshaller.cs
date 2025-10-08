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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LicenseManagerUserSubscriptions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LicenseManagerUserSubscriptions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ActiveDirectorySettings Object
    /// </summary>  
    public class ActiveDirectorySettingsUnmarshaller : IUnmarshaller<ActiveDirectorySettings, XmlUnmarshallerContext>, IUnmarshaller<ActiveDirectorySettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ActiveDirectorySettings IUnmarshaller<ActiveDirectorySettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ActiveDirectorySettings Unmarshall(JsonUnmarshallerContext context)
        {
            ActiveDirectorySettings unmarshalledObject = new ActiveDirectorySettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DomainCredentialsProvider", targetDepth))
                {
                    var unmarshaller = CredentialsProviderUnmarshaller.Instance;
                    unmarshalledObject.DomainCredentialsProvider = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainIpv4List", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DomainIpv4List = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainIpv6List", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DomainIpv6List = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DomainName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainNetworkSettings", targetDepth))
                {
                    var unmarshaller = DomainNetworkSettingsUnmarshaller.Instance;
                    unmarshalledObject.DomainNetworkSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ActiveDirectorySettingsUnmarshaller _instance = new ActiveDirectorySettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ActiveDirectorySettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}