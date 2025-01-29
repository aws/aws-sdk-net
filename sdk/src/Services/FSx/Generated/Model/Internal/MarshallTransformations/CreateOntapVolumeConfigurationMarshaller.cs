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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FSx.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateOntapVolumeConfiguration Marshaller
    /// </summary>
    public class CreateOntapVolumeConfigurationMarshaller : IRequestMarshaller<CreateOntapVolumeConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateOntapVolumeConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAggregateConfiguration())
            {
                context.Writer.WritePropertyName("AggregateConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CreateAggregateConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AggregateConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCopyTagsToBackups())
            {
                context.Writer.WritePropertyName("CopyTagsToBackups");
                context.Writer.WriteBooleanValue(requestObject.CopyTagsToBackups.Value);
            }

            if(requestObject.IsSetJunctionPath())
            {
                context.Writer.WritePropertyName("JunctionPath");
                context.Writer.WriteStringValue(requestObject.JunctionPath);
            }

            if(requestObject.IsSetOntapVolumeType())
            {
                context.Writer.WritePropertyName("OntapVolumeType");
                context.Writer.WriteStringValue(requestObject.OntapVolumeType);
            }

            if(requestObject.IsSetSecurityStyle())
            {
                context.Writer.WritePropertyName("SecurityStyle");
                context.Writer.WriteStringValue(requestObject.SecurityStyle);
            }

            if(requestObject.IsSetSizeInBytes())
            {
                context.Writer.WritePropertyName("SizeInBytes");
                context.Writer.WriteNumberValue(requestObject.SizeInBytes.Value);
            }

            if(requestObject.IsSetSizeInMegabytes())
            {
                context.Writer.WritePropertyName("SizeInMegabytes");
                context.Writer.WriteNumberValue(requestObject.SizeInMegabytes.Value);
            }

            if(requestObject.IsSetSnaplockConfiguration())
            {
                context.Writer.WritePropertyName("SnaplockConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CreateSnaplockConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SnaplockConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSnapshotPolicy())
            {
                context.Writer.WritePropertyName("SnapshotPolicy");
                context.Writer.WriteStringValue(requestObject.SnapshotPolicy);
            }

            if(requestObject.IsSetStorageEfficiencyEnabled())
            {
                context.Writer.WritePropertyName("StorageEfficiencyEnabled");
                context.Writer.WriteBooleanValue(requestObject.StorageEfficiencyEnabled.Value);
            }

            if(requestObject.IsSetStorageVirtualMachineId())
            {
                context.Writer.WritePropertyName("StorageVirtualMachineId");
                context.Writer.WriteStringValue(requestObject.StorageVirtualMachineId);
            }

            if(requestObject.IsSetTieringPolicy())
            {
                context.Writer.WritePropertyName("TieringPolicy");
                context.Writer.WriteStartObject();

                var marshaller = TieringPolicyMarshaller.Instance;
                marshaller.Marshall(requestObject.TieringPolicy, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVolumeStyle())
            {
                context.Writer.WritePropertyName("VolumeStyle");
                context.Writer.WriteStringValue(requestObject.VolumeStyle);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateOntapVolumeConfigurationMarshaller Instance = new CreateOntapVolumeConfigurationMarshaller();

    }
}