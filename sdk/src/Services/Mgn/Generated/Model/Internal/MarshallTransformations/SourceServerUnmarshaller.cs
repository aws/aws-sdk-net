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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Mgn.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SourceServer Object
    /// </summary>  
    public class SourceServerUnmarshaller : IUnmarshaller<SourceServer, XmlUnmarshallerContext>, IUnmarshaller<SourceServer, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SourceServer IUnmarshaller<SourceServer, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SourceServer Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SourceServer unmarshalledObject = new SourceServer();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("applicationID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataReplicationInfo", targetDepth))
                {
                    var unmarshaller = DataReplicationInfoUnmarshaller.Instance;
                    unmarshalledObject.DataReplicationInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fqdnForActionFramework", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FqdnForActionFramework = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isArchived", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsArchived = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("launchedInstance", targetDepth))
                {
                    var unmarshaller = LaunchedInstanceUnmarshaller.Instance;
                    unmarshalledObject.LaunchedInstance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lifeCycle", targetDepth))
                {
                    var unmarshaller = LifeCycleUnmarshaller.Instance;
                    unmarshalledObject.LifeCycle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("replicationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceProperties", targetDepth))
                {
                    var unmarshaller = SourcePropertiesUnmarshaller.Instance;
                    unmarshalledObject.SourceProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceServerID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceServerID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userProvidedID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserProvidedID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vcenterClientID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VcenterClientID = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SourceServerUnmarshaller _instance = new SourceServerUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SourceServerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}