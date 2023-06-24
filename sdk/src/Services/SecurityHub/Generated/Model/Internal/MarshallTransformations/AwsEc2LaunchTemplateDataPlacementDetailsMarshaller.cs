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
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEc2LaunchTemplateDataPlacementDetails Marshaller
    /// </summary>
    public class AwsEc2LaunchTemplateDataPlacementDetailsMarshaller : IRequestMarshaller<AwsEc2LaunchTemplateDataPlacementDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2LaunchTemplateDataPlacementDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAffinity())
            {
                context.Writer.WritePropertyName("Affinity");
                context.Writer.Write(requestObject.Affinity);
            }

            if(requestObject.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("AvailabilityZone");
                context.Writer.Write(requestObject.AvailabilityZone);
            }

            if(requestObject.IsSetGroupName())
            {
                context.Writer.WritePropertyName("GroupName");
                context.Writer.Write(requestObject.GroupName);
            }

            if(requestObject.IsSetHostId())
            {
                context.Writer.WritePropertyName("HostId");
                context.Writer.Write(requestObject.HostId);
            }

            if(requestObject.IsSetHostResourceGroupArn())
            {
                context.Writer.WritePropertyName("HostResourceGroupArn");
                context.Writer.Write(requestObject.HostResourceGroupArn);
            }

            if(requestObject.IsSetPartitionNumber())
            {
                context.Writer.WritePropertyName("PartitionNumber");
                context.Writer.Write(requestObject.PartitionNumber);
            }

            if(requestObject.IsSetSpreadDomain())
            {
                context.Writer.WritePropertyName("SpreadDomain");
                context.Writer.Write(requestObject.SpreadDomain);
            }

            if(requestObject.IsSetTenancy())
            {
                context.Writer.WritePropertyName("Tenancy");
                context.Writer.Write(requestObject.Tenancy);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2LaunchTemplateDataPlacementDetailsMarshaller Instance = new AwsEc2LaunchTemplateDataPlacementDetailsMarshaller();

    }
}