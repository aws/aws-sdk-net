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

#pragma warning disable CS0612,CS0618
namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LifeCycle Object
    /// </summary>  
    public class LifeCycleUnmarshaller : IUnmarshaller<LifeCycle, XmlUnmarshallerContext>, IUnmarshaller<LifeCycle, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LifeCycle IUnmarshaller<LifeCycle, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public LifeCycle Unmarshall(JsonUnmarshallerContext context)
        {
            LifeCycle unmarshalledObject = new LifeCycle();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("addedToServiceDateTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AddedToServiceDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("elapsedReplicationDuration", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ElapsedReplicationDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("firstByteDateTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FirstByteDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastCutover", targetDepth))
                {
                    var unmarshaller = LifeCycleLastCutoverUnmarshaller.Instance;
                    unmarshalledObject.LastCutover = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastSeenByServiceDateTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastSeenByServiceDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastTest", targetDepth))
                {
                    var unmarshaller = LifeCycleLastTestUnmarshaller.Instance;
                    unmarshalledObject.LastTest = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("state", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static LifeCycleUnmarshaller _instance = new LifeCycleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LifeCycleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618