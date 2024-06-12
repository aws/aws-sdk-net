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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppTest.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppTest.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceAction Object
    /// </summary>  
    public class ResourceActionUnmarshaller : IUnmarshaller<ResourceAction, XmlUnmarshallerContext>, IUnmarshaller<ResourceAction, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ResourceAction IUnmarshaller<ResourceAction, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ResourceAction Unmarshall(JsonUnmarshallerContext context)
        {
            ResourceAction unmarshalledObject = new ResourceAction();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("cloudFormationAction", targetDepth))
                {
                    var unmarshaller = CloudFormationActionUnmarshaller.Instance;
                    unmarshalledObject.CloudFormationAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("m2ManagedApplicationAction", targetDepth))
                {
                    var unmarshaller = M2ManagedApplicationActionUnmarshaller.Instance;
                    unmarshalledObject.M2ManagedApplicationAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("m2NonManagedApplicationAction", targetDepth))
                {
                    var unmarshaller = M2NonManagedApplicationActionUnmarshaller.Instance;
                    unmarshalledObject.M2NonManagedApplicationAction = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ResourceActionUnmarshaller _instance = new ResourceActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResourceActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}