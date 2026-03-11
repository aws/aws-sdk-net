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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ARCRegionswitch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ARCRegionswitch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EksResourceScalingConfiguration Object
    /// </summary>  
    public class EksResourceScalingConfigurationUnmarshaller : IJsonUnmarshaller<EksResourceScalingConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public EksResourceScalingConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            EksResourceScalingConfiguration unmarshalledObject = new EksResourceScalingConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("capacityMonitoringApproach", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CapacityMonitoringApproach = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("eksClusters", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<EksCluster, EksClusterUnmarshaller>(EksClusterUnmarshaller.Instance);
                    unmarshalledObject.EksClusters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("kubernetesResourceType", targetDepth))
                {
                    var unmarshaller = KubernetesResourceTypeUnmarshaller.Instance;
                    unmarshalledObject.KubernetesResourceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scalingResources", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Dictionary<string, Dictionary<string, KubernetesScalingResource>>, JsonDictionaryUnmarshaller<string, Dictionary<string, KubernetesScalingResource>, StringUnmarshaller, JsonDictionaryUnmarshaller<string, KubernetesScalingResource, StringUnmarshaller, KubernetesScalingResourceUnmarshaller>>>(new JsonDictionaryUnmarshaller<string, Dictionary<string, KubernetesScalingResource>, StringUnmarshaller, JsonDictionaryUnmarshaller<string, KubernetesScalingResource, StringUnmarshaller, KubernetesScalingResourceUnmarshaller>>(StringUnmarshaller.Instance, new JsonDictionaryUnmarshaller<string, KubernetesScalingResource, StringUnmarshaller, KubernetesScalingResourceUnmarshaller>(StringUnmarshaller.Instance, KubernetesScalingResourceUnmarshaller.Instance)));
                    unmarshalledObject.ScalingResources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("targetPercent", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.TargetPercent = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timeoutMinutes", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.TimeoutMinutes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ungraceful", targetDepth))
                {
                    var unmarshaller = EksResourceScalingUngracefulUnmarshaller.Instance;
                    unmarshalledObject.Ungraceful = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EksResourceScalingConfigurationUnmarshaller _instance = new EksResourceScalingConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EksResourceScalingConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}