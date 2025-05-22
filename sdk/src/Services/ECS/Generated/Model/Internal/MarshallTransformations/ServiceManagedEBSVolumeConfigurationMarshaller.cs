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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ServiceManagedEBSVolumeConfiguration Marshaller
    /// </summary>
    public class ServiceManagedEBSVolumeConfigurationMarshaller : IRequestMarshaller<ServiceManagedEBSVolumeConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ServiceManagedEBSVolumeConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEncrypted())
            {
                context.Writer.WritePropertyName("encrypted");
                context.Writer.WriteBooleanValue(requestObject.Encrypted.Value);
            }

            if(requestObject.IsSetFilesystemType())
            {
                context.Writer.WritePropertyName("filesystemType");
                context.Writer.WriteStringValue(requestObject.FilesystemType);
            }

            if(requestObject.IsSetIops())
            {
                context.Writer.WritePropertyName("iops");
                context.Writer.WriteNumberValue(requestObject.Iops.Value);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("kmsKeyId");
                context.Writer.WriteStringValue(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetSizeInGiB())
            {
                context.Writer.WritePropertyName("sizeInGiB");
                context.Writer.WriteNumberValue(requestObject.SizeInGiB.Value);
            }

            if(requestObject.IsSetSnapshotId())
            {
                context.Writer.WritePropertyName("snapshotId");
                context.Writer.WriteStringValue(requestObject.SnapshotId);
            }

            if(requestObject.IsSetTagSpecifications())
            {
                context.Writer.WritePropertyName("tagSpecifications");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTagSpecificationsListValue in requestObject.TagSpecifications)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EBSTagSpecificationMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagSpecificationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetThroughput())
            {
                context.Writer.WritePropertyName("throughput");
                context.Writer.WriteNumberValue(requestObject.Throughput.Value);
            }

            if(requestObject.IsSetVolumeInitializationRate())
            {
                context.Writer.WritePropertyName("volumeInitializationRate");
                context.Writer.WriteNumberValue(requestObject.VolumeInitializationRate.Value);
            }

            if(requestObject.IsSetVolumeType())
            {
                context.Writer.WritePropertyName("volumeType");
                context.Writer.WriteStringValue(requestObject.VolumeType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ServiceManagedEBSVolumeConfigurationMarshaller Instance = new ServiceManagedEBSVolumeConfigurationMarshaller();

    }
}