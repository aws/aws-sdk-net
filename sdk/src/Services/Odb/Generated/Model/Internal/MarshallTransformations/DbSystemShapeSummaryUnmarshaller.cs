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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Odb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Odb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DbSystemShapeSummary Object
    /// </summary>  
    public class DbSystemShapeSummaryUnmarshaller : IUnmarshaller<DbSystemShapeSummary, XmlUnmarshallerContext>, IUnmarshaller<DbSystemShapeSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DbSystemShapeSummary IUnmarshaller<DbSystemShapeSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DbSystemShapeSummary Unmarshall(JsonUnmarshallerContext context)
        {
            DbSystemShapeSummary unmarshalledObject = new DbSystemShapeSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("areServerTypesSupported", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AreServerTypesSupported = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("availableCoreCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AvailableCoreCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("availableCoreCountPerNode", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AvailableCoreCountPerNode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("availableDataStorageInTBs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AvailableDataStorageInTBs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("availableDataStoragePerServerInTBs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AvailableDataStoragePerServerInTBs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("availableDbNodePerNodeInGBs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AvailableDbNodePerNodeInGBs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("availableDbNodeStorageInGBs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AvailableDbNodeStorageInGBs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("availableMemoryInGBs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AvailableMemoryInGBs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("availableMemoryPerNodeInGBs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AvailableMemoryPerNodeInGBs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("computeModel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComputeModel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("coreCountIncrement", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CoreCountIncrement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maximumNodeCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaximumNodeCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxStorageCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxStorageCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minCoreCountPerNode", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinCoreCountPerNode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minDataStorageInTBs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinDataStorageInTBs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minDbNodeStoragePerNodeInGBs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinDbNodeStoragePerNodeInGBs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minimumCoreCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinimumCoreCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minimumNodeCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinimumNodeCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minMemoryPerNodeInGBs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinMemoryPerNodeInGBs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minStorageCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinStorageCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("runtimeMinimumCoreCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RuntimeMinimumCoreCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shapeFamily", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShapeFamily = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shapeType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShapeType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DbSystemShapeSummaryUnmarshaller _instance = new DbSystemShapeSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DbSystemShapeSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}