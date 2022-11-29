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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetCopyTagsToBackups())
            {
                context.Writer.WritePropertyName("CopyTagsToBackups");
                context.Writer.Write(requestObject.CopyTagsToBackups);
            }

            if(requestObject.IsSetJunctionPath())
            {
                context.Writer.WritePropertyName("JunctionPath");
                context.Writer.Write(requestObject.JunctionPath);
            }

            if(requestObject.IsSetSecurityStyle())
            {
                context.Writer.WritePropertyName("SecurityStyle");
                context.Writer.Write(requestObject.SecurityStyle);
            }

            if(requestObject.IsSetSizeInMegabytes())
            {
                context.Writer.WritePropertyName("SizeInMegabytes");
                context.Writer.Write(requestObject.SizeInMegabytes);
            }

            if(requestObject.IsSetSnapshotPolicy())
            {
                context.Writer.WritePropertyName("SnapshotPolicy");
                context.Writer.Write(requestObject.SnapshotPolicy);
            }

            if(requestObject.IsSetStorageEfficiencyEnabled())
            {
                context.Writer.WritePropertyName("StorageEfficiencyEnabled");
                context.Writer.Write(requestObject.StorageEfficiencyEnabled);
            }

            if(requestObject.IsSetTieringPolicy())
            {
                context.Writer.WritePropertyName("TieringPolicy");
                context.Writer.WriteObjectStart();

                var marshaller = TieringPolicyMarshaller.Instance;
                marshaller.Marshall(requestObject.TieringPolicy, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateOntapVolumeConfigurationMarshaller Instance = new UpdateOntapVolumeConfigurationMarshaller();

    }
}