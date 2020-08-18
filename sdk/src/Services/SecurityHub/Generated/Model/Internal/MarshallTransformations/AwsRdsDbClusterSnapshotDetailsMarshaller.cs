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
    /// AwsRdsDbClusterSnapshotDetails Marshaller
    /// </summary>       
    public class AwsRdsDbClusterSnapshotDetailsMarshaller : IRequestMarshaller<AwsRdsDbClusterSnapshotDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsRdsDbClusterSnapshotDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAllocatedStorage())
            {
                context.Writer.WritePropertyName("AllocatedStorage");
                context.Writer.Write(requestObject.AllocatedStorage);
            }

            if(requestObject.IsSetAvailabilityZones())
            {
                context.Writer.WritePropertyName("AvailabilityZones");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAvailabilityZonesListValue in requestObject.AvailabilityZones)
                {
                        context.Writer.Write(requestObjectAvailabilityZonesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetClusterCreateTime())
            {
                context.Writer.WritePropertyName("ClusterCreateTime");
                context.Writer.Write(requestObject.ClusterCreateTime);
            }

            if(requestObject.IsSetDbClusterIdentifier())
            {
                context.Writer.WritePropertyName("DbClusterIdentifier");
                context.Writer.Write(requestObject.DbClusterIdentifier);
            }

            if(requestObject.IsSetDbClusterSnapshotIdentifier())
            {
                context.Writer.WritePropertyName("DbClusterSnapshotIdentifier");
                context.Writer.Write(requestObject.DbClusterSnapshotIdentifier);
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

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.Write(requestObject.Status);
            }

            if(requestObject.IsSetStorageEncrypted())
            {
                context.Writer.WritePropertyName("StorageEncrypted");
                context.Writer.Write(requestObject.StorageEncrypted);
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
        public readonly static AwsRdsDbClusterSnapshotDetailsMarshaller Instance = new AwsRdsDbClusterSnapshotDetailsMarshaller();

    }
}