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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsDmsReplicationInstanceDetails Marshaller
    /// </summary>
    public class AwsDmsReplicationInstanceDetailsMarshaller : IRequestMarshaller<AwsDmsReplicationInstanceDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsDmsReplicationInstanceDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllocatedStorage())
            {
                context.Writer.WritePropertyName("AllocatedStorage");
                context.Writer.WriteNumberValue(requestObject.AllocatedStorage.Value);
            }

            if(requestObject.IsSetAutoMinorVersionUpgrade())
            {
                context.Writer.WritePropertyName("AutoMinorVersionUpgrade");
                context.Writer.WriteBooleanValue(requestObject.AutoMinorVersionUpgrade.Value);
            }

            if(requestObject.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("AvailabilityZone");
                context.Writer.WriteStringValue(requestObject.AvailabilityZone);
            }

            if(requestObject.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("EngineVersion");
                context.Writer.WriteStringValue(requestObject.EngineVersion);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetMultiAZ())
            {
                context.Writer.WritePropertyName("MultiAZ");
                context.Writer.WriteBooleanValue(requestObject.MultiAZ.Value);
            }

            if(requestObject.IsSetPreferredMaintenanceWindow())
            {
                context.Writer.WritePropertyName("PreferredMaintenanceWindow");
                context.Writer.WriteStringValue(requestObject.PreferredMaintenanceWindow);
            }

            if(requestObject.IsSetPubliclyAccessible())
            {
                context.Writer.WritePropertyName("PubliclyAccessible");
                context.Writer.WriteBooleanValue(requestObject.PubliclyAccessible.Value);
            }

            if(requestObject.IsSetReplicationInstanceClass())
            {
                context.Writer.WritePropertyName("ReplicationInstanceClass");
                context.Writer.WriteStringValue(requestObject.ReplicationInstanceClass);
            }

            if(requestObject.IsSetReplicationInstanceIdentifier())
            {
                context.Writer.WritePropertyName("ReplicationInstanceIdentifier");
                context.Writer.WriteStringValue(requestObject.ReplicationInstanceIdentifier);
            }

            if(requestObject.IsSetReplicationSubnetGroup())
            {
                context.Writer.WritePropertyName("ReplicationSubnetGroup");
                context.Writer.WriteStartObject();

                var marshaller = AwsDmsReplicationInstanceReplicationSubnetGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ReplicationSubnetGroup, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVpcSecurityGroups())
            {
                context.Writer.WritePropertyName("VpcSecurityGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVpcSecurityGroupsListValue in requestObject.VpcSecurityGroups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsDmsReplicationInstanceVpcSecurityGroupsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectVpcSecurityGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsDmsReplicationInstanceDetailsMarshaller Instance = new AwsDmsReplicationInstanceDetailsMarshaller();

    }
}