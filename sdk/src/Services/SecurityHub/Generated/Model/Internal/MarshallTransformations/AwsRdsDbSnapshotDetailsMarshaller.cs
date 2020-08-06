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
            if(requestObject.IsSetAllocatedStorage())
            {
                context.Writer.WritePropertyName("AllocatedStorage");
                context.Writer.Write(requestObject.AllocatedStorage);
            }

            if(requestObject.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("AvailabilityZone");
                context.Writer.Write(requestObject.AvailabilityZone);
            }

            if(requestObject.IsSetDbInstanceIdentifier())
            {
                context.Writer.WritePropertyName("DbInstanceIdentifier");
                context.Writer.Write(requestObject.DbInstanceIdentifier);
            }

            if(requestObject.IsSetDbiResourceId())
            {
                context.Writer.WritePropertyName("DbiResourceId");
                context.Writer.Write(requestObject.DbiResourceId);
            }

            if(requestObject.IsSetDbSnapshotIdentifier())
            {
                context.Writer.WritePropertyName("DbSnapshotIdentifier");
                context.Writer.Write(requestObject.DbSnapshotIdentifier);
            }

            if(requestObject.IsSetEncrypted())
            {
                context.Writer.WritePropertyName("Encrypted");
                context.Writer.Write(requestObject.Encrypted);
            }

            if(requestObject.IsSetEngine())
            {
                context.Writer.WritePropertyName("Engine");
                context.Writer.Write(requestObject.Engine);
            }

            if(requestObject.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("EngineVersion");
                context.Writer.Write(requestObject.EngineVersion);
            }

            if(requestObject.IsSetIamDatabaseAuthenticationEnabled())
            {
                context.Writer.WritePropertyName("IamDatabaseAuthenticationEnabled");
                context.Writer.Write(requestObject.IamDatabaseAuthenticationEnabled);
            }

            if(requestObject.IsSetInstanceCreateTime())
            {
                context.Writer.WritePropertyName("InstanceCreateTime");
                context.Writer.Write(requestObject.InstanceCreateTime);
            }

            if(requestObject.IsSetIops())
            {
                context.Writer.WritePropertyName("Iops");
                context.Writer.Write(requestObject.Iops);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.Write(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetLicenseModel())
            {
                context.Writer.WritePropertyName("LicenseModel");
                context.Writer.Write(requestObject.LicenseModel);
            }

            if(requestObject.IsSetMasterUsername())
            {
                context.Writer.WritePropertyName("MasterUsername");
                context.Writer.Write(requestObject.MasterUsername);
            }

            if(requestObject.IsSetOptionGroupName())
            {
                context.Writer.WritePropertyName("OptionGroupName");
                context.Writer.Write(requestObject.OptionGroupName);
            }

            if(requestObject.IsSetPercentProgress())
            {
                context.Writer.WritePropertyName("PercentProgress");
                context.Writer.Write(requestObject.PercentProgress);
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.Write(requestObject.Port);
            }

            if(requestObject.IsSetProcessorFeatures())
            {
                context.Writer.WritePropertyName("ProcessorFeatures");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectProcessorFeaturesListValue in requestObject.ProcessorFeatures)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsRdsDbProcessorFeatureMarshaller.Instance;
                    marshaller.Marshall(requestObjectProcessorFeaturesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSnapshotCreateTime())
            {
                context.Writer.WritePropertyName("SnapshotCreateTime");
                context.Writer.Write(requestObject.SnapshotCreateTime);
            }

            if(requestObject.IsSetSnapshotType())
            {
                context.Writer.WritePropertyName("SnapshotType");
                context.Writer.Write(requestObject.SnapshotType);
            }

            if(requestObject.IsSetSourceDbSnapshotIdentifier())
            {
                context.Writer.WritePropertyName("SourceDbSnapshotIdentifier");
                context.Writer.Write(requestObject.SourceDbSnapshotIdentifier);
            }

            if(requestObject.IsSetSourceRegion())
            {
                context.Writer.WritePropertyName("SourceRegion");
                context.Writer.Write(requestObject.SourceRegion);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.Write(requestObject.Status);
            }

            if(requestObject.IsSetStorageType())
            {
                context.Writer.WritePropertyName("StorageType");
                context.Writer.Write(requestObject.StorageType);
            }

            if(requestObject.IsSetTdeCredentialArn())
            {
                context.Writer.WritePropertyName("TdeCredentialArn");
                context.Writer.Write(requestObject.TdeCredentialArn);
            }

            if(requestObject.IsSetTimezone())
            {
                context.Writer.WritePropertyName("Timezone");
                context.Writer.Write(requestObject.Timezone);
            }

            if(requestObject.IsSetVpcId())
            {
                context.Writer.WritePropertyName("VpcId");
                context.Writer.Write(requestObject.VpcId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsRdsDbSnapshotDetailsMarshaller Instance = new AwsRdsDbSnapshotDetailsMarshaller();

    }
}