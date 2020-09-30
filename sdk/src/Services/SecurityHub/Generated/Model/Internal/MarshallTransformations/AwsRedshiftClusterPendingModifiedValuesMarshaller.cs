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
    /// AwsRedshiftClusterPendingModifiedValues Marshaller
    /// </summary>       
    public class AwsRedshiftClusterPendingModifiedValuesMarshaller : IRequestMarshaller<AwsRedshiftClusterPendingModifiedValues, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsRedshiftClusterPendingModifiedValues requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAutomatedSnapshotRetentionPeriod())
            {
                context.Writer.WritePropertyName("AutomatedSnapshotRetentionPeriod");
                context.Writer.Write(requestObject.AutomatedSnapshotRetentionPeriod);
            }

            if(requestObject.IsSetClusterIdentifier())
            {
                context.Writer.WritePropertyName("ClusterIdentifier");
                context.Writer.Write(requestObject.ClusterIdentifier);
            }

            if(requestObject.IsSetClusterType())
            {
                context.Writer.WritePropertyName("ClusterType");
                context.Writer.Write(requestObject.ClusterType);
            }

            if(requestObject.IsSetClusterVersion())
            {
                context.Writer.WritePropertyName("ClusterVersion");
                context.Writer.Write(requestObject.ClusterVersion);
            }

            if(requestObject.IsSetEncryptionType())
            {
                context.Writer.WritePropertyName("EncryptionType");
                context.Writer.Write(requestObject.EncryptionType);
            }

            if(requestObject.IsSetEnhancedVpcRouting())
            {
                context.Writer.WritePropertyName("EnhancedVpcRouting");
                context.Writer.Write(requestObject.EnhancedVpcRouting);
            }

            if(requestObject.IsSetMaintenanceTrackName())
            {
                context.Writer.WritePropertyName("MaintenanceTrackName");
                context.Writer.Write(requestObject.MaintenanceTrackName);
            }

            if(requestObject.IsSetMasterUserPassword())
            {
                context.Writer.WritePropertyName("MasterUserPassword");
                context.Writer.Write(requestObject.MasterUserPassword);
            }

            if(requestObject.IsSetNodeType())
            {
                context.Writer.WritePropertyName("NodeType");
                context.Writer.Write(requestObject.NodeType);
            }

            if(requestObject.IsSetNumberOfNodes())
            {
                context.Writer.WritePropertyName("NumberOfNodes");
                context.Writer.Write(requestObject.NumberOfNodes);
            }

            if(requestObject.IsSetPubliclyAccessible())
            {
                context.Writer.WritePropertyName("PubliclyAccessible");
                context.Writer.Write(requestObject.PubliclyAccessible);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsRedshiftClusterPendingModifiedValuesMarshaller Instance = new AwsRedshiftClusterPendingModifiedValuesMarshaller();

    }
}