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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkspacesInstances.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkspacesInstances.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Placement Marshaller
    /// </summary>
    public class PlacementMarshaller : IRequestMarshaller<Placement, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Placement requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAffinity())
            {
                context.Writer.WritePropertyName("Affinity");
                context.Writer.WriteStringValue(requestObject.Affinity);
            }

            if(requestObject.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("AvailabilityZone");
                context.Writer.WriteStringValue(requestObject.AvailabilityZone);
            }

            if(requestObject.IsSetGroupId())
            {
                context.Writer.WritePropertyName("GroupId");
                context.Writer.WriteStringValue(requestObject.GroupId);
            }

            if(requestObject.IsSetGroupName())
            {
                context.Writer.WritePropertyName("GroupName");
                context.Writer.WriteStringValue(requestObject.GroupName);
            }

            if(requestObject.IsSetHostId())
            {
                context.Writer.WritePropertyName("HostId");
                context.Writer.WriteStringValue(requestObject.HostId);
            }

            if(requestObject.IsSetHostResourceGroupArn())
            {
                context.Writer.WritePropertyName("HostResourceGroupArn");
                context.Writer.WriteStringValue(requestObject.HostResourceGroupArn);
            }

            if(requestObject.IsSetPartitionNumber())
            {
                context.Writer.WritePropertyName("PartitionNumber");
                context.Writer.WriteNumberValue(requestObject.PartitionNumber.Value);
            }

            if(requestObject.IsSetTenancy())
            {
                context.Writer.WritePropertyName("Tenancy");
                context.Writer.WriteStringValue(requestObject.Tenancy);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PlacementMarshaller Instance = new PlacementMarshaller();

    }
}