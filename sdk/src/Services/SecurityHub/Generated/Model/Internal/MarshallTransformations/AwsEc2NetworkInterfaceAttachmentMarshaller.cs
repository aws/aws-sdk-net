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
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEc2NetworkInterfaceAttachment Marshaller
    /// </summary>
    public class AwsEc2NetworkInterfaceAttachmentMarshaller : IRequestMarshaller<AwsEc2NetworkInterfaceAttachment, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2NetworkInterfaceAttachment requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttachmentId())
            {
                context.Writer.WritePropertyName("AttachmentId");
                context.Writer.WriteStringValue(requestObject.AttachmentId);
            }

            if(requestObject.IsSetAttachTime())
            {
                context.Writer.WritePropertyName("AttachTime");
                context.Writer.WriteStringValue(requestObject.AttachTime);
            }

            if(requestObject.IsSetDeleteOnTermination())
            {
                context.Writer.WritePropertyName("DeleteOnTermination");
                context.Writer.WriteBooleanValue(requestObject.DeleteOnTermination.Value);
            }

            if(requestObject.IsSetDeviceIndex())
            {
                context.Writer.WritePropertyName("DeviceIndex");
                context.Writer.WriteNumberValue(requestObject.DeviceIndex.Value);
            }

            if(requestObject.IsSetInstanceId())
            {
                context.Writer.WritePropertyName("InstanceId");
                context.Writer.WriteStringValue(requestObject.InstanceId);
            }

            if(requestObject.IsSetInstanceOwnerId())
            {
                context.Writer.WritePropertyName("InstanceOwnerId");
                context.Writer.WriteStringValue(requestObject.InstanceOwnerId);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2NetworkInterfaceAttachmentMarshaller Instance = new AwsEc2NetworkInterfaceAttachmentMarshaller();

    }
}