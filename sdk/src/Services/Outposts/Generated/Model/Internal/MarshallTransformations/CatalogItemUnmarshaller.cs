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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Outposts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CatalogItem Object
    /// </summary>  
    public class CatalogItemUnmarshaller : IUnmarshaller<CatalogItem, XmlUnmarshallerContext>, IUnmarshaller<CatalogItem, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CatalogItem IUnmarshaller<CatalogItem, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CatalogItem Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CatalogItem unmarshalledObject = new CatalogItem();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CatalogItemId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CatalogItemId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EC2Capacities", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EC2Capacity, EC2CapacityUnmarshaller>(EC2CapacityUnmarshaller.Instance);
                    unmarshalledObject.EC2Capacities = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ItemStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ItemStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PowerKva", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.PowerKva = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SupportedStorage", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SupportedStorage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SupportedUplinkGbps", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.SupportedUplinkGbps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WeightLbs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.WeightLbs = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CatalogItemUnmarshaller _instance = new CatalogItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CatalogItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}