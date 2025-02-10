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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OpenSearchIntegrationDetails Object
    /// </summary>  
    public class OpenSearchIntegrationDetailsUnmarshaller : IJsonUnmarshaller<OpenSearchIntegrationDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public OpenSearchIntegrationDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            OpenSearchIntegrationDetails unmarshalledObject = new OpenSearchIntegrationDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("accessPolicy", targetDepth))
                {
                    var unmarshaller = OpenSearchDataAccessPolicyUnmarshaller.Instance;
                    unmarshalledObject.AccessPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("application", targetDepth))
                {
                    var unmarshaller = OpenSearchApplicationUnmarshaller.Instance;
                    unmarshalledObject.Application = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("collection", targetDepth))
                {
                    var unmarshaller = OpenSearchCollectionUnmarshaller.Instance;
                    unmarshalledObject.Collection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataSource", targetDepth))
                {
                    var unmarshaller = OpenSearchDataSourceUnmarshaller.Instance;
                    unmarshalledObject.DataSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("encryptionPolicy", targetDepth))
                {
                    var unmarshaller = OpenSearchEncryptionPolicyUnmarshaller.Instance;
                    unmarshalledObject.EncryptionPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lifecyclePolicy", targetDepth))
                {
                    var unmarshaller = OpenSearchLifecyclePolicyUnmarshaller.Instance;
                    unmarshalledObject.LifecyclePolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("networkPolicy", targetDepth))
                {
                    var unmarshaller = OpenSearchNetworkPolicyUnmarshaller.Instance;
                    unmarshalledObject.NetworkPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("workspace", targetDepth))
                {
                    var unmarshaller = OpenSearchWorkspaceUnmarshaller.Instance;
                    unmarshalledObject.Workspace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OpenSearchIntegrationDetailsUnmarshaller _instance = new OpenSearchIntegrationDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OpenSearchIntegrationDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}