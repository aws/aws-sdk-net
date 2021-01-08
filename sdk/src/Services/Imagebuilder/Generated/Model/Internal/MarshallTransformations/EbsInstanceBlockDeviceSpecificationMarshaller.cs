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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Imagebuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EbsInstanceBlockDeviceSpecification Marshaller
    /// </summary>       
    public class EbsInstanceBlockDeviceSpecificationMarshaller : IRequestMarshaller<EbsInstanceBlockDeviceSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EbsInstanceBlockDeviceSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDeleteOnTermination())
            {
                context.Writer.WritePropertyName("deleteOnTermination");
                context.Writer.Write(requestObject.DeleteOnTermination);
            }

            if(requestObject.IsSetEncrypted())
            {
                context.Writer.WritePropertyName("encrypted");
                context.Writer.Write(requestObject.Encrypted);
            }

            if(requestObject.IsSetIops())
            {
                context.Writer.WritePropertyName("iops");
                context.Writer.Write(requestObject.Iops);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("kmsKeyId");
                context.Writer.Write(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetSnapshotId())
            {
                context.Writer.WritePropertyName("snapshotId");
                context.Writer.Write(requestObject.SnapshotId);
            }

            if(requestObject.IsSetVolumeSize())
            {
                context.Writer.WritePropertyName("volumeSize");
                context.Writer.Write(requestObject.VolumeSize);
            }

            if(requestObject.IsSetVolumeType())
            {
                context.Writer.WritePropertyName("volumeType");
                context.Writer.Write(requestObject.VolumeType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static EbsInstanceBlockDeviceSpecificationMarshaller Instance = new EbsInstanceBlockDeviceSpecificationMarshaller();

    }
}