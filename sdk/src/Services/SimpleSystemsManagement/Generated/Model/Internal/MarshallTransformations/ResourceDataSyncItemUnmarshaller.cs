/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceDataSyncItem Object
    /// </summary>  
    public class ResourceDataSyncItemUnmarshaller : IUnmarshaller<ResourceDataSyncItem, XmlUnmarshallerContext>, IUnmarshaller<ResourceDataSyncItem, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ResourceDataSyncItem IUnmarshaller<ResourceDataSyncItem, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResourceDataSyncItem Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ResourceDataSyncItem unmarshalledObject = new ResourceDataSyncItem();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("LastStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastSuccessfulSyncTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastSuccessfulSyncTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastSyncStatusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastSyncStatusMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastSyncTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastSyncTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3Destination", targetDepth))
                {
                    var unmarshaller = ResourceDataSyncS3DestinationUnmarshaller.Instance;
                    unmarshalledObject.S3Destination = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SyncCreatedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.SyncCreatedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SyncName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SyncName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ResourceDataSyncItemUnmarshaller _instance = new ResourceDataSyncItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResourceDataSyncItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}