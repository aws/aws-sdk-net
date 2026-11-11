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

using Amazon.WorkSpaces.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WorkspaceProperties Marshaller
    /// </summary>
    public partial class WorkspacePropertiesMarshaller : IRequestMarshaller<WorkspaceProperties, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(WorkspaceProperties requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetComputeTypeName())
            {
                context.Writer.WriteTextString("ComputeTypeName");
                context.Writer.WriteTextString(requestObject.ComputeTypeName);
            }

            if (requestObject.IsSetGlobalAccelerator())
            {
                context.Writer.WriteTextString("GlobalAccelerator");
                context.Writer.WriteStartMap(null);

                var marshaller = GlobalAcceleratorForWorkSpaceMarshaller.Instance;
                marshaller.Marshall(requestObject.GlobalAccelerator, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetNestedVirtualizationEnabled())
            {
                context.Writer.WriteTextString("NestedVirtualizationEnabled");
                context.Writer.WriteBoolean(requestObject.NestedVirtualizationEnabled.Value);
            }

            if (requestObject.IsSetOperatingSystemName())
            {
                context.Writer.WriteTextString("OperatingSystemName");
                context.Writer.WriteTextString(requestObject.OperatingSystemName);
            }

            if (requestObject.IsSetProtocols())
            {
                context.Writer.WriteTextString("Protocols");
                context.Writer.WriteStartArray(requestObject.Protocols.Count);
                foreach (var requestObjectProtocolsListValue in requestObject.Protocols)
                {
                    context.Writer.WriteTextString(requestObjectProtocolsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetRootVolumeSizeGib())
            {
                context.Writer.WriteTextString("RootVolumeSizeGib");
                context.Writer.WriteInt32(requestObject.RootVolumeSizeGib.Value);
            }

            if (requestObject.IsSetRunningMode())
            {
                context.Writer.WriteTextString("RunningMode");
                context.Writer.WriteTextString(requestObject.RunningMode);
            }

            if (requestObject.IsSetRunningModeAutoStopTimeoutInMinutes())
            {
                context.Writer.WriteTextString("RunningModeAutoStopTimeoutInMinutes");
                context.Writer.WriteInt32(requestObject.RunningModeAutoStopTimeoutInMinutes.Value);
            }

            if (requestObject.IsSetUserVolumeSizeGib())
            {
                context.Writer.WriteTextString("UserVolumeSizeGib");
                context.Writer.WriteInt32(requestObject.UserVolumeSizeGib.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static WorkspacePropertiesMarshaller Instance = new WorkspacePropertiesMarshaller();
    }
}
