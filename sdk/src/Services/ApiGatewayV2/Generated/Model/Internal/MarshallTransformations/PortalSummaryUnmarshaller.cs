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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApiGatewayV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PortalSummary Object
    /// </summary>  
    public class PortalSummaryUnmarshaller : IUnmarshaller<PortalSummary, XmlUnmarshallerContext>, IUnmarshaller<PortalSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PortalSummary IUnmarshaller<PortalSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PortalSummary Unmarshall(JsonUnmarshallerContext context)
        {
            PortalSummary unmarshalledObject = new PortalSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("authorization", targetDepth))
                {
                    var unmarshaller = AuthorizationUnmarshaller.Instance;
                    unmarshalledObject.Authorization = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("endpointConfiguration", targetDepth))
                {
                    var unmarshaller = EndpointConfigurationResponseUnmarshaller.Instance;
                    unmarshalledObject.EndpointConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("includedPortalProductArns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.IncludedPortalProductArns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastModified", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModified = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastPublished", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastPublished = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastPublishedDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastPublishedDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portalArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PortalArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portalContent", targetDepth))
                {
                    var unmarshaller = PortalContentUnmarshaller.Instance;
                    unmarshalledObject.PortalContent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portalId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PortalId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("preview", targetDepth))
                {
                    var unmarshaller = PreviewUnmarshaller.Instance;
                    unmarshalledObject.Preview = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("publishStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PublishStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rumAppMonitorName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RumAppMonitorName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statusException", targetDepth))
                {
                    var unmarshaller = StatusExceptionUnmarshaller.Instance;
                    unmarshalledObject.StatusException = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PortalSummaryUnmarshaller _instance = new PortalSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PortalSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}