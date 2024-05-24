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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Private5G.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SitePlan Object
    /// </summary>  
    public class SitePlanUnmarshaller : IUnmarshaller<SitePlan, XmlUnmarshallerContext>, IUnmarshaller<SitePlan, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SitePlan IUnmarshaller<SitePlan, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SitePlan Unmarshall(JsonUnmarshallerContext context)
        {
            SitePlan unmarshalledObject = new SitePlan();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("options", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NameValuePair, NameValuePairUnmarshaller>(NameValuePairUnmarshaller.Instance);
                    unmarshalledObject.Options = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceDefinitions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NetworkResourceDefinition, NetworkResourceDefinitionUnmarshaller>(NetworkResourceDefinitionUnmarshaller.Instance);
                    unmarshalledObject.ResourceDefinitions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SitePlanUnmarshaller _instance = new SitePlanUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SitePlanUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}