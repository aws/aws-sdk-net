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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GraphqlApi Object
    /// </summary>  
    public class GraphqlApiUnmarshaller : IJsonUnmarshaller<GraphqlApi, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public GraphqlApi Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            GraphqlApi unmarshalledObject = new GraphqlApi();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("additionalAuthenticationProviders", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AdditionalAuthenticationProvider, AdditionalAuthenticationProviderUnmarshaller>(AdditionalAuthenticationProviderUnmarshaller.Instance);
                    unmarshalledObject.AdditionalAuthenticationProviders = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("apiId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApiId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("apiType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApiType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("authenticationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AuthenticationType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dns", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Dns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("enhancedMetricsConfig", targetDepth))
                {
                    var unmarshaller = EnhancedMetricsConfigUnmarshaller.Instance;
                    unmarshalledObject.EnhancedMetricsConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("introspectionConfig", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IntrospectionConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambdaAuthorizerConfig", targetDepth))
                {
                    var unmarshaller = LambdaAuthorizerConfigUnmarshaller.Instance;
                    unmarshalledObject.LambdaAuthorizerConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("logConfig", targetDepth))
                {
                    var unmarshaller = LogConfigUnmarshaller.Instance;
                    unmarshalledObject.LogConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mergedApiExecutionRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MergedApiExecutionRoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("openIDConnectConfig", targetDepth))
                {
                    var unmarshaller = OpenIDConnectConfigUnmarshaller.Instance;
                    unmarshalledObject.OpenIDConnectConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("owner", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Owner = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ownerContact", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OwnerContact = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("queryDepthLimit", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.QueryDepthLimit = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resolverCountLimit", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ResolverCountLimit = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("uris", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Uris = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("userPoolConfig", targetDepth))
                {
                    var unmarshaller = UserPoolConfigUnmarshaller.Instance;
                    unmarshalledObject.UserPoolConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("visibility", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Visibility = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("wafWebAclArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WafWebAclArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("xrayEnabled", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.XrayEnabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static GraphqlApiUnmarshaller _instance = new GraphqlApiUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GraphqlApiUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}