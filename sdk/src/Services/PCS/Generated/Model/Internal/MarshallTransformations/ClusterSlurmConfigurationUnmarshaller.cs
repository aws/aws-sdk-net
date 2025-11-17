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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PCS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PCS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ClusterSlurmConfiguration Object
    /// </summary>  
    public class ClusterSlurmConfigurationUnmarshaller : IUnmarshaller<ClusterSlurmConfiguration, XmlUnmarshallerContext>, IUnmarshaller<ClusterSlurmConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ClusterSlurmConfiguration IUnmarshaller<ClusterSlurmConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ClusterSlurmConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            ClusterSlurmConfiguration unmarshalledObject = new ClusterSlurmConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accounting", targetDepth))
                {
                    var unmarshaller = AccountingUnmarshaller.Instance;
                    unmarshalledObject.Accounting = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("authKey", targetDepth))
                {
                    var unmarshaller = SlurmAuthKeyUnmarshaller.Instance;
                    unmarshalledObject.AuthKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jwtAuth", targetDepth))
                {
                    var unmarshaller = JwtAuthUnmarshaller.Instance;
                    unmarshalledObject.JwtAuth = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scaleDownIdleTimeInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ScaleDownIdleTimeInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("slurmCustomSettings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SlurmCustomSetting, SlurmCustomSettingUnmarshaller>(SlurmCustomSettingUnmarshaller.Instance);
                    unmarshalledObject.SlurmCustomSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("slurmRest", targetDepth))
                {
                    var unmarshaller = SlurmRestUnmarshaller.Instance;
                    unmarshalledObject.SlurmRest = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ClusterSlurmConfigurationUnmarshaller _instance = new ClusterSlurmConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ClusterSlurmConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}