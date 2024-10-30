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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ChannelNamespace Object
    /// </summary>  
    public class ChannelNamespaceUnmarshaller : IUnmarshaller<ChannelNamespace, XmlUnmarshallerContext>, IUnmarshaller<ChannelNamespace, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ChannelNamespace IUnmarshaller<ChannelNamespace, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ChannelNamespace Unmarshall(JsonUnmarshallerContext context)
        {
            ChannelNamespace unmarshalledObject = new ChannelNamespace();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("apiId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApiId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("channelNamespaceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChannelNamespaceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("codeHandlers", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CodeHandlers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("created", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.Created = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastModified", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModified = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("publishAuthModes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AuthMode, AuthModeUnmarshaller>(AuthModeUnmarshaller.Instance);
                    unmarshalledObject.PublishAuthModes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("subscribeAuthModes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AuthMode, AuthModeUnmarshaller>(AuthModeUnmarshaller.Instance);
                    unmarshalledObject.SubscribeAuthModes = unmarshaller.Unmarshall(context);
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


        private static ChannelNamespaceUnmarshaller _instance = new ChannelNamespaceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ChannelNamespaceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}