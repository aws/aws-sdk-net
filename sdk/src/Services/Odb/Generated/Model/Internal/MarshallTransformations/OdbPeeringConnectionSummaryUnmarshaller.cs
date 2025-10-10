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
    /// Response Unmarshaller for OdbPeeringConnectionSummary Object
    /// </summary>  
    public class OdbPeeringConnectionSummaryUnmarshaller : IUnmarshaller<OdbPeeringConnectionSummary, XmlUnmarshallerContext>, IUnmarshaller<OdbPeeringConnectionSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OdbPeeringConnectionSummary IUnmarshaller<OdbPeeringConnectionSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public OdbPeeringConnectionSummary Unmarshall(JsonUnmarshallerContext context)
        {
            OdbPeeringConnectionSummary unmarshalledObject = new OdbPeeringConnectionSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("displayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DisplayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("odbNetworkArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OdbNetworkArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("odbPeeringConnectionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OdbPeeringConnectionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("odbPeeringConnectionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OdbPeeringConnectionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("odbPeeringConnectionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OdbPeeringConnectionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("peerNetworkArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PeerNetworkArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("peerNetworkCidrs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.PeerNetworkCidrs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("percentProgress", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.PercentProgress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusReason = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OdbPeeringConnectionSummaryUnmarshaller _instance = new OdbPeeringConnectionSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OdbPeeringConnectionSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}