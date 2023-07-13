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
    /// Response Unmarshaller for NetAppONTAPSVM Object
    /// </summary>  
    public class NetAppONTAPSVMUnmarshaller : IUnmarshaller<NetAppONTAPSVM, XmlUnmarshallerContext>, IUnmarshaller<NetAppONTAPSVM, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NetAppONTAPSVM IUnmarshaller<NetAppONTAPSVM, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NetAppONTAPSVM Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            NetAppONTAPSVM unmarshalledObject = new NetAppONTAPSVM();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CifsShareCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.CifsShareCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterUuid", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterUuid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnabledProtocols", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.EnabledProtocols = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("SvmName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SvmName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalCapacityProvisioned", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TotalCapacityProvisioned = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalCapacityUsed", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TotalCapacityUsed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalLogicalCapacityUsed", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TotalLogicalCapacityUsed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalSnapshotCapacityUsed", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TotalSnapshotCapacityUsed = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static NetAppONTAPSVMUnmarshaller _instance = new NetAppONTAPSVMUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetAppONTAPSVMUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}