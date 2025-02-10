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
    /// UpdateOntapVolumeConfiguration Marshaller
    /// </summary>
    public class UpdateOntapVolumeConfigurationMarshaller : IRequestMarshaller<UpdateOntapVolumeConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateOntapVolumeConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
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

                var marshaller = UpdateSnaplockConfigurationMarshaller.Instance;
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

            if(requestObject.IsSetTieringPolicy())
            {
                context.Writer.WritePropertyName("TieringPolicy");
                context.Writer.WriteStartObject();

                var marshaller = TieringPolicyMarshaller.Instance;
                marshaller.Marshall(requestObject.TieringPolicy, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateOntapVolumeConfigurationMarshaller Instance = new UpdateOntapVolumeConfigurationMarshaller();

    }
}