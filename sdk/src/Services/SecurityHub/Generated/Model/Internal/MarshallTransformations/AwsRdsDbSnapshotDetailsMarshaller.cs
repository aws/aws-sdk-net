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
    /// AwsRdsDbSnapshotDetails Marshaller
    /// </summary>
    public class AwsRdsDbSnapshotDetailsMarshaller : IRequestMarshaller<AwsRdsDbSnapshotDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsRdsDbSnapshotDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllocatedStorage())
            {
                context.Writer.WritePropertyName("AllocatedStorage");
                context.Writer.WriteNumberValue(requestObject.AllocatedStorage.Value);
            }

            if(requestObject.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("AvailabilityZone");
                context.Writer.WriteStringValue(requestObject.AvailabilityZone);
            }

            if(requestObject.IsSetDbInstanceIdentifier())
            {
                context.Writer.WritePropertyName("DbInstanceIdentifier");
                context.Writer.WriteStringValue(requestObject.DbInstanceIdentifier);
            }

            if(requestObject.IsSetDbiResourceId())
            {
                context.Writer.WritePropertyName("DbiResourceId");
                context.Writer.WriteStringValue(requestObject.DbiResourceId);
            }

            if(requestObject.IsSetDbSnapshotIdentifier())
            {
                context.Writer.WritePropertyName("DbSnapshotIdentifier");
                context.Writer.WriteStringValue(requestObject.DbSnapshotIdentifier);
            }

            if(requestObject.IsSetEncrypted())
            {
                context.Writer.WritePropertyName("Encrypted");
                context.Writer.WriteBooleanValue(requestObject.Encrypted.Value);
            }

            if(requestObject.IsSetEngine())
            {
                context.Writer.WritePropertyName("Engine");
                context.Writer.WriteStringValue(requestObject.Engine);
            }

            if(requestObject.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("EngineVersion");
                context.Writer.WriteStringValue(requestObject.EngineVersion);
            }

            if(requestObject.IsSetIamDatabaseAuthenticationEnabled())
            {
                context.Writer.WritePropertyName("IamDatabaseAuthenticationEnabled");
                context.Writer.WriteBooleanValue(requestObject.IamDatabaseAuthenticationEnabled.Value);
            }

            if(requestObject.IsSetInstanceCreateTime())
            {
                context.Writer.WritePropertyName("InstanceCreateTime");
                context.Writer.WriteStringValue(requestObject.InstanceCreateTime);
            }

            if(requestObject.IsSetIops())
            {
                context.Writer.WritePropertyName("Iops");
                context.Writer.WriteNumberValue(requestObject.Iops.Value);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetLicenseModel())
            {
                context.Writer.WritePropertyName("LicenseModel");
                context.Writer.WriteStringValue(requestObject.LicenseModel);
            }

            if(requestObject.IsSetMasterUsername())
            {
                context.Writer.WritePropertyName("MasterUsername");
                context.Writer.WriteStringValue(requestObject.MasterUsername);
            }

            if(requestObject.IsSetOptionGroupName())
            {
                context.Writer.WritePropertyName("OptionGroupName");
                context.Writer.WriteStringValue(requestObject.OptionGroupName);
            }

            if(requestObject.IsSetPercentProgress())
            {
                context.Writer.WritePropertyName("PercentProgress");
                context.Writer.WriteNumberValue(requestObject.PercentProgress.Value);
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.WriteNumberValue(requestObject.Port.Value);
            }

            if(requestObject.IsSetProcessorFeatures())
            {
                context.Writer.WritePropertyName("ProcessorFeatures");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProcessorFeaturesListValue in requestObject.ProcessorFeatures)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRdsDbProcessorFeatureMarshaller.Instance;
                    marshaller.Marshall(requestObjectProcessorFeaturesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSnapshotCreateTime())
            {
                context.Writer.WritePropertyName("SnapshotCreateTime");
                context.Writer.WriteStringValue(requestObject.SnapshotCreateTime);
            }

            if(requestObject.IsSetSnapshotType())
            {
                context.Writer.WritePropertyName("SnapshotType");
                context.Writer.WriteStringValue(requestObject.SnapshotType);
            }

            if(requestObject.IsSetSourceDbSnapshotIdentifier())
            {
                context.Writer.WritePropertyName("SourceDbSnapshotIdentifier");
                context.Writer.WriteStringValue(requestObject.SourceDbSnapshotIdentifier);
            }

            if(requestObject.IsSetSourceRegion())
            {
                context.Writer.WritePropertyName("SourceRegion");
                context.Writer.WriteStringValue(requestObject.SourceRegion);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

            if(requestObject.IsSetStorageType())
            {
                context.Writer.WritePropertyName("StorageType");
                context.Writer.WriteStringValue(requestObject.StorageType);
            }

            if(requestObject.IsSetTdeCredentialArn())
            {
                context.Writer.WritePropertyName("TdeCredentialArn");
                context.Writer.WriteStringValue(requestObject.TdeCredentialArn);
            }

            if(requestObject.IsSetTimezone())
            {
                context.Writer.WritePropertyName("Timezone");
                context.Writer.WriteStringValue(requestObject.Timezone);
            }

            if(requestObject.IsSetVpcId())
            {
                context.Writer.WritePropertyName("VpcId");
                context.Writer.WriteStringValue(requestObject.VpcId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsRdsDbSnapshotDetailsMarshaller Instance = new AwsRdsDbSnapshotDetailsMarshaller();

    }
}