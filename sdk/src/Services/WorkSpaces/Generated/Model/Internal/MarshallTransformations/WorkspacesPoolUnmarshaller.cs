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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for WorkspacesPool Object
    /// </summary>  
    public class WorkspacesPoolUnmarshaller : IUnmarshaller<WorkspacesPool, XmlUnmarshallerContext>, IUnmarshaller<WorkspacesPool, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        WorkspacesPool IUnmarshaller<WorkspacesPool, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public WorkspacesPool Unmarshall(JsonUnmarshallerContext context)
        {
            WorkspacesPool unmarshalledObject = new WorkspacesPool();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ApplicationSettings", targetDepth))
                {
                    var unmarshaller = ApplicationSettingsResponseUnmarshaller.Instance;
                    unmarshalledObject.ApplicationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BundleId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BundleId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CapacityStatus", targetDepth))
                {
                    var unmarshaller = CapacityStatusUnmarshaller.Instance;
                    unmarshalledObject.CapacityStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DirectoryId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DirectoryId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Errors", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<WorkspacesPoolError, WorkspacesPoolErrorUnmarshaller>(WorkspacesPoolErrorUnmarshaller.Instance);
                    unmarshalledObject.Errors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PoolArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PoolArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PoolId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PoolId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PoolName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PoolName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeoutSettings", targetDepth))
                {
                    var unmarshaller = TimeoutSettingsUnmarshaller.Instance;
                    unmarshalledObject.TimeoutSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static WorkspacesPoolUnmarshaller _instance = new WorkspacesPoolUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static WorkspacesPoolUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}