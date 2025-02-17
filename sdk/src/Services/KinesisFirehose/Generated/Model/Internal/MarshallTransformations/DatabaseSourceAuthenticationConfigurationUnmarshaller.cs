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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DatabaseSourceAuthenticationConfiguration Object
    /// </summary>  
    public class DatabaseSourceAuthenticationConfigurationUnmarshaller : IUnmarshaller<DatabaseSourceAuthenticationConfiguration, XmlUnmarshallerContext>, IUnmarshaller<DatabaseSourceAuthenticationConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DatabaseSourceAuthenticationConfiguration IUnmarshaller<DatabaseSourceAuthenticationConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DatabaseSourceAuthenticationConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            DatabaseSourceAuthenticationConfiguration unmarshalledObject = new DatabaseSourceAuthenticationConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("SecretsManagerConfiguration", targetDepth))
                {
                    var unmarshaller = SecretsManagerConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SecretsManagerConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DatabaseSourceAuthenticationConfigurationUnmarshaller _instance = new DatabaseSourceAuthenticationConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DatabaseSourceAuthenticationConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}