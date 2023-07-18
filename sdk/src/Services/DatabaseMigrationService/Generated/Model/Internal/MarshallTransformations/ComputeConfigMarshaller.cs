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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ComputeConfig Marshaller
    /// </summary>
    public class ComputeConfigMarshaller : IRequestMarshaller<ComputeConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ComputeConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("AvailabilityZone");
                context.Writer.Write(requestObject.AvailabilityZone);
            }

            if(requestObject.IsSetDnsNameServers())
            {
                context.Writer.WritePropertyName("DnsNameServers");
                context.Writer.Write(requestObject.DnsNameServers);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.Write(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetMaxCapacityUnits())
            {
                context.Writer.WritePropertyName("MaxCapacityUnits");
                context.Writer.Write(requestObject.MaxCapacityUnits);
            }

            if(requestObject.IsSetMinCapacityUnits())
            {
                context.Writer.WritePropertyName("MinCapacityUnits");
                context.Writer.Write(requestObject.MinCapacityUnits);
            }

            if(requestObject.IsSetMultiAZ())
            {
                context.Writer.WritePropertyName("MultiAZ");
                context.Writer.Write(requestObject.MultiAZ);
            }

            if(requestObject.IsSetPreferredMaintenanceWindow())
            {
                context.Writer.WritePropertyName("PreferredMaintenanceWindow");
                context.Writer.Write(requestObject.PreferredMaintenanceWindow);
            }

            if(requestObject.IsSetReplicationSubnetGroupId())
            {
                context.Writer.WritePropertyName("ReplicationSubnetGroupId");
                context.Writer.Write(requestObject.ReplicationSubnetGroupId);
            }

            if(requestObject.IsSetVpcSecurityGroupIds())
            {
                context.Writer.WritePropertyName("VpcSecurityGroupIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVpcSecurityGroupIdsListValue in requestObject.VpcSecurityGroupIds)
                {
                        context.Writer.Write(requestObjectVpcSecurityGroupIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ComputeConfigMarshaller Instance = new ComputeConfigMarshaller();

    }
}