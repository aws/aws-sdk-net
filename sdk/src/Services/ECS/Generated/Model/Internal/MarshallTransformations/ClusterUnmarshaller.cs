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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Cluster Object
    /// </summary>  
    public class ClusterUnmarshaller : IJsonUnmarshaller<Cluster, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Cluster Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Cluster unmarshalledObject = new Cluster();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("activeServicesCount", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ActiveServicesCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("attachments", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Attachment, AttachmentUnmarshaller>(AttachmentUnmarshaller.Instance);
                    unmarshalledObject.Attachments = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("attachmentsStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AttachmentsStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("capacityProviders", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.CapacityProviders = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("clusterArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("clusterName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("configuration", targetDepth))
                {
                    var unmarshaller = ClusterConfigurationUnmarshaller.Instance;
                    unmarshalledObject.Configuration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("defaultCapacityProviderStrategy", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<CapacityProviderStrategyItem, CapacityProviderStrategyItemUnmarshaller>(CapacityProviderStrategyItemUnmarshaller.Instance);
                    unmarshalledObject.DefaultCapacityProviderStrategy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pendingTasksCount", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.PendingTasksCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("registeredContainerInstancesCount", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.RegisteredContainerInstancesCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("runningTasksCount", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.RunningTasksCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceConnectDefaults", targetDepth))
                {
                    var unmarshaller = ClusterServiceConnectDefaultsUnmarshaller.Instance;
                    unmarshalledObject.ServiceConnectDefaults = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("settings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ClusterSetting, ClusterSettingUnmarshaller>(ClusterSettingUnmarshaller.Instance);
                    unmarshalledObject.Settings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("statistics", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<KeyValuePair, KeyValuePairUnmarshaller>(KeyValuePairUnmarshaller.Instance);
                    unmarshalledObject.Statistics = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ClusterUnmarshaller _instance = new ClusterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ClusterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}