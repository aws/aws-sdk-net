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
    /// AwsRdsDbPendingModifiedValues Marshaller
    /// </summary>       
    public class AwsRdsDbPendingModifiedValuesMarshaller : IRequestMarshaller<AwsRdsDbPendingModifiedValues, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsRdsDbPendingModifiedValues requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAllocatedStorage())
            {
                context.Writer.WritePropertyName("AllocatedStorage");
                context.Writer.Write(requestObject.AllocatedStorage);
            }

            if(requestObject.IsSetBackupRetentionPeriod())
            {
                context.Writer.WritePropertyName("BackupRetentionPeriod");
                context.Writer.Write(requestObject.BackupRetentionPeriod);
            }

            if(requestObject.IsSetCaCertificateIdentifier())
            {
                context.Writer.WritePropertyName("CaCertificateIdentifier");
                context.Writer.Write(requestObject.CaCertificateIdentifier);
            }

            if(requestObject.IsSetDbInstanceClass())
            {
                context.Writer.WritePropertyName("DbInstanceClass");
                context.Writer.Write(requestObject.DbInstanceClass);
            }

            if(requestObject.IsSetDbInstanceIdentifier())
            {
                context.Writer.WritePropertyName("DbInstanceIdentifier");
                context.Writer.Write(requestObject.DbInstanceIdentifier);
            }

            if(requestObject.IsSetDbSubnetGroupName())
            {
                context.Writer.WritePropertyName("DbSubnetGroupName");
                context.Writer.Write(requestObject.DbSubnetGroupName);
            }

            if(requestObject.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("EngineVersion");
                context.Writer.Write(requestObject.EngineVersion);
            }

            if(requestObject.IsSetIops())
            {
                context.Writer.WritePropertyName("Iops");
                context.Writer.Write(requestObject.Iops);
            }

            if(requestObject.IsSetLicenseModel())
            {
                context.Writer.WritePropertyName("LicenseModel");
                context.Writer.Write(requestObject.LicenseModel);
            }

            if(requestObject.IsSetMasterUserPassword())
            {
                context.Writer.WritePropertyName("MasterUserPassword");
                context.Writer.Write(requestObject.MasterUserPassword);
            }

            if(requestObject.IsSetMultiAZ())
            {
                context.Writer.WritePropertyName("MultiAZ");
                context.Writer.Write(requestObject.MultiAZ);
            }

            if(requestObject.IsSetPendingCloudWatchLogsExports())
            {
                context.Writer.WritePropertyName("PendingCloudWatchLogsExports");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRdsPendingCloudWatchLogsExportsMarshaller.Instance;
                marshaller.Marshall(requestObject.PendingCloudWatchLogsExports, context);

                context.Writer.WriteObjectEnd();
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

            if(requestObject.IsSetStorageType())
            {
                context.Writer.WritePropertyName("StorageType");
                context.Writer.Write(requestObject.StorageType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsRdsDbPendingModifiedValuesMarshaller Instance = new AwsRdsDbPendingModifiedValuesMarshaller();

    }
}