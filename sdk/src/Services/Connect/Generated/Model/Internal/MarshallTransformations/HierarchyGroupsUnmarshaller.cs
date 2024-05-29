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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HierarchyGroups Object
    /// </summary>  
    public class HierarchyGroupsUnmarshaller : IUnmarshaller<HierarchyGroups, XmlUnmarshallerContext>, IUnmarshaller<HierarchyGroups, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        HierarchyGroups IUnmarshaller<HierarchyGroups, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public HierarchyGroups Unmarshall(JsonUnmarshallerContext context)
        {
            HierarchyGroups unmarshalledObject = new HierarchyGroups();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Level1", targetDepth))
                {
                    var unmarshaller = AgentHierarchyGroupUnmarshaller.Instance;
                    unmarshalledObject.Level1 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Level2", targetDepth))
                {
                    var unmarshaller = AgentHierarchyGroupUnmarshaller.Instance;
                    unmarshalledObject.Level2 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Level3", targetDepth))
                {
                    var unmarshaller = AgentHierarchyGroupUnmarshaller.Instance;
                    unmarshalledObject.Level3 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Level4", targetDepth))
                {
                    var unmarshaller = AgentHierarchyGroupUnmarshaller.Instance;
                    unmarshalledObject.Level4 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Level5", targetDepth))
                {
                    var unmarshaller = AgentHierarchyGroupUnmarshaller.Instance;
                    unmarshalledObject.Level5 = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static HierarchyGroupsUnmarshaller _instance = new HierarchyGroupsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HierarchyGroupsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}