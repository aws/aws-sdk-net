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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VolumeConfiguration Marshaller
    /// </summary>
    public class VolumeConfigurationMarshaller : IRequestMarshaller<VolumeConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VolumeConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEncrypted())
            {
                context.Writer.WritePropertyName("Encrypted");
                context.Writer.WriteBooleanValue(requestObject.Encrypted.Value);
            }

            if(requestObject.IsSetIops())
            {
                context.Writer.WritePropertyName("Iops");
                context.Writer.WriteNumberValue(requestObject.Iops.Value);
            }

            if(requestObject.IsSetMountPoint())
            {
                context.Writer.WritePropertyName("MountPoint");
                context.Writer.WriteStringValue(requestObject.MountPoint);
            }

            if(requestObject.IsSetNumberOfDisks())
            {
                context.Writer.WritePropertyName("NumberOfDisks");
                context.Writer.WriteNumberValue(requestObject.NumberOfDisks.Value);
            }

            if(requestObject.IsSetRaidLevel())
            {
                context.Writer.WritePropertyName("RaidLevel");
                context.Writer.WriteNumberValue(requestObject.RaidLevel.Value);
            }

            if(requestObject.IsSetSize())
            {
                context.Writer.WritePropertyName("Size");
                context.Writer.WriteNumberValue(requestObject.Size.Value);
            }

            if(requestObject.IsSetVolumeType())
            {
                context.Writer.WritePropertyName("VolumeType");
                context.Writer.WriteStringValue(requestObject.VolumeType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VolumeConfigurationMarshaller Instance = new VolumeConfigurationMarshaller();

    }
}