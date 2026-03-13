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
    /// Response Unmarshaller for NetworkMigrationDeployedStackDetails Object
    /// </summary>  
    public class NetworkMigrationDeployedStackDetailsUnmarshaller : IUnmarshaller<NetworkMigrationDeployedStackDetails, XmlUnmarshallerContext>, IUnmarshaller<NetworkMigrationDeployedStackDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NetworkMigrationDeployedStackDetails IUnmarshaller<NetworkMigrationDeployedStackDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public NetworkMigrationDeployedStackDetails Unmarshall(JsonUnmarshallerContext context)
        {
            NetworkMigrationDeployedStackDetails unmarshalledObject = new NetworkMigrationDeployedStackDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("failedResources", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NetworkMigrationFailedResourceDetails, NetworkMigrationFailedResourceDetailsUnmarshaller>(NetworkMigrationFailedResourceDetailsUnmarshaller.Instance);
                    unmarshalledObject.FailedResources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("segmentID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stackLogicalID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StackLogicalID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stackPhysicalID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StackPhysicalID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetAccount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetAccount = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static NetworkMigrationDeployedStackDetailsUnmarshaller _instance = new NetworkMigrationDeployedStackDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetworkMigrationDeployedStackDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}