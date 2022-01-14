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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEc2VolumeDetails Marshaller
    /// </summary>
    public class AwsEc2VolumeDetailsMarshaller : IRequestMarshaller<AwsEc2VolumeDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2VolumeDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAttachments())
            {
                context.Writer.WritePropertyName("Attachments");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAttachmentsListValue in requestObject.Attachments)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEc2VolumeAttachmentMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttachmentsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCreateTime())
            {
                context.Writer.WritePropertyName("CreateTime");
                context.Writer.Write(requestObject.CreateTime);
            }

            if(requestObject.IsSetEncrypted())
            {
                context.Writer.WritePropertyName("Encrypted");
                context.Writer.Write(requestObject.Encrypted);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.Write(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetSize())
            {
                context.Writer.WritePropertyName("Size");
                context.Writer.Write(requestObject.Size);
            }

            if(requestObject.IsSetSnapshotId())
            {
                context.Writer.WritePropertyName("SnapshotId");
                context.Writer.Write(requestObject.SnapshotId);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.Write(requestObject.Status);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2VolumeDetailsMarshaller Instance = new AwsEc2VolumeDetailsMarshaller();

    }
}