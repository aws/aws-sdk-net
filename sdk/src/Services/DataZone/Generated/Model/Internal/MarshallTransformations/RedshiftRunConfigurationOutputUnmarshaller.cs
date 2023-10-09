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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RedshiftRunConfigurationOutput Object
    /// </summary>  
    public class RedshiftRunConfigurationOutputUnmarshaller : IUnmarshaller<RedshiftRunConfigurationOutput, XmlUnmarshallerContext>, IUnmarshaller<RedshiftRunConfigurationOutput, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RedshiftRunConfigurationOutput IUnmarshaller<RedshiftRunConfigurationOutput, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RedshiftRunConfigurationOutput Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RedshiftRunConfigurationOutput unmarshalledObject = new RedshiftRunConfigurationOutput();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataAccessRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataAccessRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("redshiftCredentialConfiguration", targetDepth))
                {
                    var unmarshaller = RedshiftCredentialConfigurationUnmarshaller.Instance;
                    unmarshalledObject.RedshiftCredentialConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("redshiftStorage", targetDepth))
                {
                    var unmarshaller = RedshiftStorageUnmarshaller.Instance;
                    unmarshalledObject.RedshiftStorage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("region", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Region = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("relationalFilterConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RelationalFilterConfiguration, RelationalFilterConfigurationUnmarshaller>(RelationalFilterConfigurationUnmarshaller.Instance);
                    unmarshalledObject.RelationalFilterConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RedshiftRunConfigurationOutputUnmarshaller _instance = new RedshiftRunConfigurationOutputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RedshiftRunConfigurationOutputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}