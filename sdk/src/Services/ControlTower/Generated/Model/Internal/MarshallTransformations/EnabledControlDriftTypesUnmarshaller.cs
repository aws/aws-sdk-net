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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ControlTower.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ControlTower.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EnabledControlDriftTypes Object
    /// </summary>  
    public class EnabledControlDriftTypesUnmarshaller : IUnmarshaller<EnabledControlDriftTypes, XmlUnmarshallerContext>, IUnmarshaller<EnabledControlDriftTypes, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EnabledControlDriftTypes IUnmarshaller<EnabledControlDriftTypes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public EnabledControlDriftTypes Unmarshall(JsonUnmarshallerContext context)
        {
            EnabledControlDriftTypes unmarshalledObject = new EnabledControlDriftTypes();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("inheritance", targetDepth))
                {
                    var unmarshaller = EnabledControlInheritanceDriftUnmarshaller.Instance;
                    unmarshalledObject.Inheritance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resource", targetDepth))
                {
                    var unmarshaller = EnabledControlResourceDriftUnmarshaller.Instance;
                    unmarshalledObject.Resource = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EnabledControlDriftTypesUnmarshaller _instance = new EnabledControlDriftTypesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EnabledControlDriftTypesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}