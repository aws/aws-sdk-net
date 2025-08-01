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
#pragma warning disable CS0612,CS0618
namespace Amazon.ARCRegionswitch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Route53HealthCheckConfiguration Marshaller
    /// </summary>
    public class Route53HealthCheckConfigurationMarshaller : IRequestMarshaller<Route53HealthCheckConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Route53HealthCheckConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCrossAccountRole())
            {
                context.Writer.WritePropertyName("crossAccountRole");
                context.Writer.WriteStringValue(requestObject.CrossAccountRole);
            }

            if(requestObject.IsSetExternalId())
            {
                context.Writer.WritePropertyName("externalId");
                context.Writer.WriteStringValue(requestObject.ExternalId);
            }

            if(requestObject.IsSetHostedZoneId())
            {
                context.Writer.WritePropertyName("hostedZoneId");
                context.Writer.WriteStringValue(requestObject.HostedZoneId);
            }

            if(requestObject.IsSetRecordName())
            {
                context.Writer.WritePropertyName("recordName");
                context.Writer.WriteStringValue(requestObject.RecordName);
            }

            if(requestObject.IsSetRecordSets())
            {
                context.Writer.WritePropertyName("recordSets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRecordSetsListValue in requestObject.RecordSets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = Route53ResourceRecordSetMarshaller.Instance;
                    marshaller.Marshall(requestObjectRecordSetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTimeoutMinutes())
            {
                context.Writer.WritePropertyName("timeoutMinutes");
                context.Writer.WriteNumberValue(requestObject.TimeoutMinutes.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static Route53HealthCheckConfigurationMarshaller Instance = new Route53HealthCheckConfigurationMarshaller();

    }
}