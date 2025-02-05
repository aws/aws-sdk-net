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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Private5G.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Private5G.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NetworkResource Object
    /// </summary>  
    public class NetworkResourceUnmarshaller : IJsonUnmarshaller<NetworkResource, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public NetworkResource Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            NetworkResource unmarshalledObject = new NetworkResource();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("attributes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<NameValuePair, NameValuePairUnmarshaller>(NameValuePairUnmarshaller.Instance);
                    unmarshalledObject.Attributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("commitmentInformation", targetDepth))
                {
                    var unmarshaller = CommitmentInformationUnmarshaller.Instance;
                    unmarshalledObject.CommitmentInformation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("health", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Health = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("model", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Model = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("networkArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NetworkArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("networkResourceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NetworkResourceArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("networkSiteArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NetworkSiteArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("orderArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OrderArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("position", targetDepth))
                {
                    var unmarshaller = PositionUnmarshaller.Instance;
                    unmarshalledObject.Position = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("returnInformation", targetDepth))
                {
                    var unmarshaller = ReturnInformationUnmarshaller.Instance;
                    unmarshalledObject.ReturnInformation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serialNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SerialNumber = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("statusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusReason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("vendor", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Vendor = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static NetworkResourceUnmarshaller _instance = new NetworkResourceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetworkResourceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}