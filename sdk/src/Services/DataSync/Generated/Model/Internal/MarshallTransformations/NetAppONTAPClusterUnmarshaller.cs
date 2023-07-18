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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NetAppONTAPCluster Object
    /// </summary>  
    public class NetAppONTAPClusterUnmarshaller : IUnmarshaller<NetAppONTAPCluster, XmlUnmarshallerContext>, IUnmarshaller<NetAppONTAPCluster, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NetAppONTAPCluster IUnmarshaller<NetAppONTAPCluster, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NetAppONTAPCluster Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            NetAppONTAPCluster unmarshalledObject = new NetAppONTAPCluster();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CifsShareCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.CifsShareCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterBlockStorageLogicalUsed", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ClusterBlockStorageLogicalUsed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterBlockStorageSize", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ClusterBlockStorageSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterBlockStorageUsed", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ClusterBlockStorageUsed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LunCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.LunCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxP95Performance", targetDepth))
                {
                    var unmarshaller = MaxP95PerformanceUnmarshaller.Instance;
                    unmarshalledObject.MaxP95Performance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NfsExportedVolumes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NfsExportedVolumes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Recommendations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Recommendation, RecommendationUnmarshaller>(RecommendationUnmarshaller.Instance);
                    unmarshalledObject.Recommendations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecommendationStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecommendationStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static NetAppONTAPClusterUnmarshaller _instance = new NetAppONTAPClusterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetAppONTAPClusterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}