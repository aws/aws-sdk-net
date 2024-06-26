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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MainframeModernization.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MainframeModernization.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VsamDetailAttributes Object
    /// </summary>  
    public class VsamDetailAttributesUnmarshaller : IUnmarshaller<VsamDetailAttributes, XmlUnmarshallerContext>, IUnmarshaller<VsamDetailAttributes, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        VsamDetailAttributes IUnmarshaller<VsamDetailAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public VsamDetailAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            VsamDetailAttributes unmarshalledObject = new VsamDetailAttributes();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("alternateKeys", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AlternateKey, AlternateKeyUnmarshaller>(AlternateKeyUnmarshaller.Instance);
                    unmarshalledObject.AlternateKeys = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cacheAtStartup", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CacheAtStartup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("compressed", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Compressed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("encoding", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Encoding = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("primaryKey", targetDepth))
                {
                    var unmarshaller = PrimaryKeyUnmarshaller.Instance;
                    unmarshalledObject.PrimaryKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("recordFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecordFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static VsamDetailAttributesUnmarshaller _instance = new VsamDetailAttributesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VsamDetailAttributesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}