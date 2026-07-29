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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkspacesInstances.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Placement Marshaller
    /// </summary>
    public class PlacementMarshaller : IRequestMarshaller<Placement, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Placement requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetAffinity())
            {
                context.Writer.WriteTextString("Affinity");
                context.Writer.WriteTextString(requestObject.Affinity);
            }
            if (requestObject.IsSetAvailabilityZone())
            {
                context.Writer.WriteTextString("AvailabilityZone");
                context.Writer.WriteTextString(requestObject.AvailabilityZone);
            }
            if (requestObject.IsSetGroupId())
            {
                context.Writer.WriteTextString("GroupId");
                context.Writer.WriteTextString(requestObject.GroupId);
            }
            if (requestObject.IsSetGroupName())
            {
                context.Writer.WriteTextString("GroupName");
                context.Writer.WriteTextString(requestObject.GroupName);
            }
            if (requestObject.IsSetHostId())
            {
                context.Writer.WriteTextString("HostId");
                context.Writer.WriteTextString(requestObject.HostId);
            }
            if (requestObject.IsSetHostResourceGroupArn())
            {
                context.Writer.WriteTextString("HostResourceGroupArn");
                context.Writer.WriteTextString(requestObject.HostResourceGroupArn);
            }
            if (requestObject.IsSetPartitionNumber())
            {
                context.Writer.WriteTextString("PartitionNumber");
                context.Writer.WriteInt32(requestObject.PartitionNumber.Value);
            }
            if (requestObject.IsSetTenancy())
            {
                context.Writer.WriteTextString("Tenancy");
                context.Writer.WriteTextString(requestObject.Tenancy);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PlacementMarshaller Instance = new PlacementMarshaller();

    }
}