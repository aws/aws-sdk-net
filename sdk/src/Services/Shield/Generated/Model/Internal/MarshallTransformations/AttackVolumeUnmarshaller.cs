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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Shield.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Shield.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AttackVolume Object
    /// </summary>  
    public class AttackVolumeUnmarshaller : IUnmarshaller<AttackVolume, XmlUnmarshallerContext>, IUnmarshaller<AttackVolume, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AttackVolume IUnmarshaller<AttackVolume, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AttackVolume Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AttackVolume unmarshalledObject = new AttackVolume();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BitsPerSecond", targetDepth))
                {
                    var unmarshaller = AttackVolumeStatisticsUnmarshaller.Instance;
                    unmarshalledObject.BitsPerSecond = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PacketsPerSecond", targetDepth))
                {
                    var unmarshaller = AttackVolumeStatisticsUnmarshaller.Instance;
                    unmarshalledObject.PacketsPerSecond = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequestsPerSecond", targetDepth))
                {
                    var unmarshaller = AttackVolumeStatisticsUnmarshaller.Instance;
                    unmarshalledObject.RequestsPerSecond = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AttackVolumeUnmarshaller _instance = new AttackVolumeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AttackVolumeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}