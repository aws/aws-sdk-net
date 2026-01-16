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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResourceExplorer2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ResourceExplorer2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ServiceView Object
    /// </summary>  
    public class ServiceViewUnmarshaller : IUnmarshaller<ServiceView, XmlUnmarshallerContext>, IUnmarshaller<ServiceView, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ServiceView IUnmarshaller<ServiceView, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ServiceView Unmarshall(JsonUnmarshallerContext context)
        {
            ServiceView unmarshalledObject = new ServiceView();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Filters", targetDepth))
                {
                    var unmarshaller = SearchFilterUnmarshaller.Instance;
                    unmarshalledObject.Filters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludedProperties", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<IncludedProperty, IncludedPropertyUnmarshaller>(IncludedPropertyUnmarshaller.Instance);
                    unmarshalledObject.IncludedProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScopeType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScopeType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceViewArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceViewArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceViewName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceViewName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StreamingAccessForService", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StreamingAccessForService = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ServiceViewUnmarshaller _instance = new ServiceViewUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServiceViewUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}