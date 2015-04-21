/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EbsBlockDevice Marshaller
    /// </summary>       
    public class EbsBlockDeviceMarshaller : IRequestMarshaller<EbsBlockDevice, JsonMarshallerContext> 
    {
        public void Marshall(EbsBlockDevice requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDeleteOnTermination())
            {
                context.Writer.WritePropertyName("DeleteOnTermination");
                context.Writer.Write(requestObject.DeleteOnTermination);
            }

            if(requestObject.IsSetIops())
            {
                context.Writer.WritePropertyName("Iops");
                context.Writer.Write(requestObject.Iops);
            }

            if(requestObject.IsSetSnapshotId())
            {
                context.Writer.WritePropertyName("SnapshotId");
                context.Writer.Write(requestObject.SnapshotId);
            }

            if(requestObject.IsSetVolumeSize())
            {
                context.Writer.WritePropertyName("VolumeSize");
                context.Writer.Write(requestObject.VolumeSize);
            }

            if(requestObject.IsSetVolumeType())
            {
                context.Writer.WritePropertyName("VolumeType");
                context.Writer.Write(requestObject.VolumeType);
            }

        }

        public readonly static EbsBlockDeviceMarshaller Instance = new EbsBlockDeviceMarshaller();

    }
}