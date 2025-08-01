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
    /// EcsCapacityIncreaseConfiguration Marshaller
    /// </summary>
    public class EcsCapacityIncreaseConfigurationMarshaller : IRequestMarshaller<EcsCapacityIncreaseConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EcsCapacityIncreaseConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCapacityMonitoringApproach())
            {
                context.Writer.WritePropertyName("capacityMonitoringApproach");
                context.Writer.Write(requestObject.CapacityMonitoringApproach);
            }

            if(requestObject.IsSetServices())
            {
                context.Writer.WritePropertyName("services");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectServicesListValue in requestObject.Services)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ServiceMarshaller.Instance;
                    marshaller.Marshall(requestObjectServicesListValue, context);

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

                var marshaller = EcsUngracefulMarshaller.Instance;
                marshaller.Marshall(requestObject.Ungraceful, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EcsCapacityIncreaseConfigurationMarshaller Instance = new EcsCapacityIncreaseConfigurationMarshaller();

    }
}