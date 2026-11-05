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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.Imagebuilder.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Placement Marshaller
    /// </summary>
    public partial class PlacementMarshaller : IRequestMarshaller<Placement, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(Placement requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("availabilityZone");
                context.Writer.WriteStringValue(requestObject.AvailabilityZone);
            }

            if (requestObject.IsSetHostId())
            {
                context.Writer.WritePropertyName("hostId");
                context.Writer.WriteStringValue(requestObject.HostId);
            }

            if (requestObject.IsSetHostResourceGroupArn())
            {
                context.Writer.WritePropertyName("hostResourceGroupArn");
                context.Writer.WriteStringValue(requestObject.HostResourceGroupArn);
            }

            if (requestObject.IsSetTenancy())
            {
                context.Writer.WritePropertyName("tenancy");
                context.Writer.WriteStringValue(requestObject.Tenancy);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static PlacementMarshaller Instance = new PlacementMarshaller();
    }
}
