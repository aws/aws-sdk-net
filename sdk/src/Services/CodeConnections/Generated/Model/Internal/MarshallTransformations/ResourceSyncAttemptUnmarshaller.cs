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
 * Do not modify this file. This file is generated from the codeconnections-2023-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeConnections.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeConnections.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceSyncAttempt Object
    /// </summary>  
    public class ResourceSyncAttemptUnmarshaller : IJsonUnmarshaller<ResourceSyncAttempt, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ResourceSyncAttempt Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ResourceSyncAttempt unmarshalledObject = new ResourceSyncAttempt();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Events", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ResourceSyncEvent, ResourceSyncEventUnmarshaller>(ResourceSyncEventUnmarshaller.Instance);
                    unmarshalledObject.Events = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InitialRevision", targetDepth))
                {
                    var unmarshaller = RevisionUnmarshaller.Instance;
                    unmarshalledObject.InitialRevision = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StartedAt", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Target", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Target = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TargetRevision", targetDepth))
                {
                    var unmarshaller = RevisionUnmarshaller.Instance;
                    unmarshalledObject.TargetRevision = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ResourceSyncAttemptUnmarshaller _instance = new ResourceSyncAttemptUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResourceSyncAttemptUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}