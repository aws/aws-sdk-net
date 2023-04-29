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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PhysicalResource Object
    /// </summary>  
    public class PhysicalResourceUnmarshaller : IUnmarshaller<PhysicalResource, XmlUnmarshallerContext>, IUnmarshaller<PhysicalResource, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PhysicalResource IUnmarshaller<PhysicalResource, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PhysicalResource Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PhysicalResource unmarshalledObject = new PhysicalResource();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("additionalInfo", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<string>, StringUnmarshaller, ListUnmarshaller<string, StringUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance));
                    unmarshalledObject.AdditionalInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("appComponents", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AppComponent, AppComponentUnmarshaller>(AppComponentUnmarshaller.Instance);
                    unmarshalledObject.AppComponents = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("excluded", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Excluded = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logicalResourceId", targetDepth))
                {
                    var unmarshaller = LogicalResourceIdUnmarshaller.Instance;
                    unmarshalledObject.LogicalResourceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("physicalResourceId", targetDepth))
                {
                    var unmarshaller = PhysicalResourceIdUnmarshaller.Instance;
                    unmarshalledObject.PhysicalResourceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PhysicalResourceUnmarshaller _instance = new PhysicalResourceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PhysicalResourceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}