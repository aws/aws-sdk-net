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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResourceGroups.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ResourceGroups.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TagSyncTaskItem Object
    /// </summary>  
    public class TagSyncTaskItemUnmarshaller : IUnmarshaller<TagSyncTaskItem, XmlUnmarshallerContext>, IUnmarshaller<TagSyncTaskItem, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TagSyncTaskItem IUnmarshaller<TagSyncTaskItem, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TagSyncTaskItem Unmarshall(JsonUnmarshallerContext context)
        {
            TagSyncTaskItem unmarshalledObject = new TagSyncTaskItem();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ErrorMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ErrorMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GroupArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GroupArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GroupName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GroupName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceQuery", targetDepth))
                {
                    var unmarshaller = ResourceQueryUnmarshaller.Instance;
                    unmarshalledObject.ResourceQuery = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TagKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TagKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TagValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TagValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskArn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TagSyncTaskItemUnmarshaller _instance = new TagSyncTaskItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TagSyncTaskItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}