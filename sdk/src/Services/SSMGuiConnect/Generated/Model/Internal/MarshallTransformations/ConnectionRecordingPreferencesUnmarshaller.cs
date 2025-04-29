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
 * Do not modify this file. This file is generated from the ssm-guiconnect-2021-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMGuiConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SSMGuiConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConnectionRecordingPreferences Object
    /// </summary>  
    public class ConnectionRecordingPreferencesUnmarshaller : IUnmarshaller<ConnectionRecordingPreferences, XmlUnmarshallerContext>, IUnmarshaller<ConnectionRecordingPreferences, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConnectionRecordingPreferences IUnmarshaller<ConnectionRecordingPreferences, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ConnectionRecordingPreferences Unmarshall(JsonUnmarshallerContext context)
        {
            ConnectionRecordingPreferences unmarshalledObject = new ConnectionRecordingPreferences();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("KMSKeyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KMSKeyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecordingDestinations", targetDepth))
                {
                    var unmarshaller = RecordingDestinationsUnmarshaller.Instance;
                    unmarshalledObject.RecordingDestinations = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ConnectionRecordingPreferencesUnmarshaller _instance = new ConnectionRecordingPreferencesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConnectionRecordingPreferencesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}