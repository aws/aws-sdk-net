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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WorkspaceProperties Marshaller
    /// </summary>
    public class WorkspacePropertiesMarshaller : IRequestMarshaller<WorkspaceProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WorkspaceProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComputeTypeName())
            {
                context.Writer.WritePropertyName("ComputeTypeName");
                context.Writer.WriteStringValue(requestObject.ComputeTypeName);
            }

            if(requestObject.IsSetGlobalAccelerator())
            {
                context.Writer.WritePropertyName("GlobalAccelerator");
                context.Writer.WriteStartObject();

                var marshaller = GlobalAcceleratorForWorkSpaceMarshaller.Instance;
                marshaller.Marshall(requestObject.GlobalAccelerator, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOperatingSystemName())
            {
                context.Writer.WritePropertyName("OperatingSystemName");
                context.Writer.WriteStringValue(requestObject.OperatingSystemName);
            }

            if(requestObject.IsSetProtocols())
            {
                context.Writer.WritePropertyName("Protocols");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProtocolsListValue in requestObject.Protocols)
                {
                        context.Writer.WriteStringValue(requestObjectProtocolsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRootVolumeSizeGib())
            {
                context.Writer.WritePropertyName("RootVolumeSizeGib");
                context.Writer.WriteNumberValue(requestObject.RootVolumeSizeGib.Value);
            }

            if(requestObject.IsSetRunningMode())
            {
                context.Writer.WritePropertyName("RunningMode");
                context.Writer.WriteStringValue(requestObject.RunningMode);
            }

            if(requestObject.IsSetRunningModeAutoStopTimeoutInMinutes())
            {
                context.Writer.WritePropertyName("RunningModeAutoStopTimeoutInMinutes");
                context.Writer.WriteNumberValue(requestObject.RunningModeAutoStopTimeoutInMinutes.Value);
            }

            if(requestObject.IsSetUserVolumeSizeGib())
            {
                context.Writer.WritePropertyName("UserVolumeSizeGib");
                context.Writer.WriteNumberValue(requestObject.UserVolumeSizeGib.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WorkspacePropertiesMarshaller Instance = new WorkspacePropertiesMarshaller();

    }
}