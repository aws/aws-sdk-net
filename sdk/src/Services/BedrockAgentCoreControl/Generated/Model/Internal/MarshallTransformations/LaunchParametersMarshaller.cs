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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCoreControl.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LaunchParameters Marshaller
    /// </summary>
    public class LaunchParametersMarshaller : IRequestMarshaller<LaunchParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LaunchParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCapacityReservationSpecification())
            {
                context.Writer.WritePropertyName("capacityReservationSpecification");
                context.Writer.WriteStartObject();

                var marshaller = CapacityReservationSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.CapacityReservationSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEphemeralVolumes())
            {
                context.Writer.WritePropertyName("ephemeralVolumes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEphemeralVolumesListValue in requestObject.EphemeralVolumes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EphemeralBlockDeviceMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectEphemeralVolumesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInstanceProfileArn())
            {
                context.Writer.WritePropertyName("instanceProfileArn");
                context.Writer.WriteStringValue(requestObject.InstanceProfileArn);
            }

            if(requestObject.IsSetInstanceRequirements())
            {
                context.Writer.WritePropertyName("instanceRequirements");
                context.Writer.WriteStartObject();

                var marshaller = InstanceRequirementsMarshaller.Instance;
                marshaller.Marshall(requestObject.InstanceRequirements, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLicenseSpecifications())
            {
                context.Writer.WritePropertyName("licenseSpecifications");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLicenseSpecificationsListValue in requestObject.LicenseSpecifications)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LicenseSpecificationMarshaller.Instance;
                    marshaller.Marshall(requestObjectLicenseSpecificationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMonitoring())
            {
                context.Writer.WritePropertyName("monitoring");
                context.Writer.WriteStringValue(requestObject.Monitoring);
            }

            if(requestObject.IsSetOperatingSystem())
            {
                context.Writer.WritePropertyName("operatingSystem");
                context.Writer.WriteStringValue(requestObject.OperatingSystem);
            }

            if(requestObject.IsSetPropagatedTags())
            {
                context.Writer.WritePropertyName("propagatedTags");
                context.Writer.WriteStartObject();
                foreach (var requestObjectPropagatedTagsKvp in requestObject.PropagatedTags)
                {
                    context.Writer.WritePropertyName(requestObjectPropagatedTagsKvp.Key);
                    var requestObjectPropagatedTagsValue = requestObjectPropagatedTagsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectPropagatedTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSshKeyName())
            {
                context.Writer.WritePropertyName("sshKeyName");
                context.Writer.WriteStringValue(requestObject.SshKeyName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LaunchParametersMarshaller Instance = new LaunchParametersMarshaller();

    }
}