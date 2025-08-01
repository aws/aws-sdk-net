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
using System.Text;
using System.Xml.Serialization;

using Amazon.ARCRegionswitch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ARCRegionswitch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EksResourceScalingConfiguration Marshaller
    /// </summary>
    public class EksResourceScalingConfigurationMarshaller : IRequestMarshaller<EksResourceScalingConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EksResourceScalingConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCapacityMonitoringApproach())
            {
                context.Writer.WritePropertyName("capacityMonitoringApproach");
                context.Writer.Write(requestObject.CapacityMonitoringApproach);
            }

            if(requestObject.IsSetEksClusters())
            {
                context.Writer.WritePropertyName("eksClusters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEksClustersListValue in requestObject.EksClusters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EksClusterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEksClustersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetKubernetesResourceType())
            {
                context.Writer.WritePropertyName("kubernetesResourceType");
                context.Writer.WriteObjectStart();

                var marshaller = KubernetesResourceTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.KubernetesResourceType, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetScalingResources())
            {
                context.Writer.WritePropertyName("scalingResources");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectScalingResourcesListValue in requestObject.ScalingResources)
                {
                    context.Writer.WriteObjectStart();
                    foreach (var requestObjectScalingResourcesListValueKvp in requestObjectScalingResourcesListValue)
                    {
                        context.Writer.WritePropertyName(requestObjectScalingResourcesListValueKvp.Key);
                        var requestObjectScalingResourcesListValueValue = requestObjectScalingResourcesListValueKvp.Value;

                        context.Writer.WriteObjectStart();
                        foreach (var requestObjectScalingResourcesListValueValueKvp in requestObjectScalingResourcesListValueValue)
                        {
                            context.Writer.WritePropertyName(requestObjectScalingResourcesListValueValueKvp.Key);
                            var requestObjectScalingResourcesListValueValueValue = requestObjectScalingResourcesListValueValueKvp.Value;

                            context.Writer.WriteObjectStart();

                            var marshaller = KubernetesScalingResourceMarshaller.Instance;
                            marshaller.Marshall(requestObjectScalingResourcesListValueValueValue, context);

                            context.Writer.WriteObjectEnd();
                        }
                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTargetPercent())
            {
                context.Writer.WritePropertyName("targetPercent");
                context.Writer.Write(requestObject.TargetPercent);
            }

            if(requestObject.IsSetTimeoutMinutes())
            {
                context.Writer.WritePropertyName("timeoutMinutes");
                context.Writer.Write(requestObject.TimeoutMinutes);
            }

            if(requestObject.IsSetUngraceful())
            {
                context.Writer.WritePropertyName("ungraceful");
                context.Writer.WriteObjectStart();

                var marshaller = EksResourceScalingUngracefulMarshaller.Instance;
                marshaller.Marshall(requestObject.Ungraceful, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EksResourceScalingConfigurationMarshaller Instance = new EksResourceScalingConfigurationMarshaller();

    }
}