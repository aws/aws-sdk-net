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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Transfer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribedWebApp Object
    /// </summary>  
    public class DescribedWebAppUnmarshaller : IUnmarshaller<DescribedWebApp, XmlUnmarshallerContext>, IUnmarshaller<DescribedWebApp, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DescribedWebApp IUnmarshaller<DescribedWebApp, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DescribedWebApp Unmarshall(JsonUnmarshallerContext context)
        {
            DescribedWebApp unmarshalledObject = new DescribedWebApp();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccessEndpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccessEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DescribedEndpointDetails", targetDepth))
                {
                    var unmarshaller = DescribedWebAppEndpointDetailsUnmarshaller.Instance;
                    unmarshalledObject.DescribedEndpointDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DescribedIdentityProviderDetails", targetDepth))
                {
                    var unmarshaller = DescribedWebAppIdentityProviderDetailsUnmarshaller.Instance;
                    unmarshalledObject.DescribedIdentityProviderDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndpointType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EndpointType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WebAppEndpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WebAppEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WebAppEndpointPolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WebAppEndpointPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WebAppId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WebAppId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WebAppUnits", targetDepth))
                {
                    var unmarshaller = WebAppUnitsUnmarshaller.Instance;
                    unmarshalledObject.WebAppUnits = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DescribedWebAppUnmarshaller _instance = new DescribedWebAppUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribedWebAppUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}