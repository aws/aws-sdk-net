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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.TimestreamInfluxDB.Model
{
    /// <summary>
    /// This is the response object from the RestoreFromDbBackup operation.
    /// </summary>
    public partial class RestoreFromDbBackupResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// The deployment type of the restored resource.
        /// </para>
        /// </summary>
        public ResourceDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentType property is set.
        /// </summary>
        internal bool IsSetDeploymentType() => this.DeploymentType != null;

        /// <summary>
        /// Gets and sets the property EngineType. 
        /// <para>
        /// The engine type of the restored resource.
        /// </para>
        /// </summary>
        public EngineType EngineType { get; set; }

        /// <summary>
        /// Checks to see if the EngineType property is set.
        /// </summary>
        internal bool IsSetEngineType() => this.EngineType != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the restored resource. Valid values are DB_INSTANCE and DB_CLUSTER.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property RestoreStatus. 
        /// <para>
        /// The status of the restore operation.
        /// </para>
        /// </summary>
        public RestoreStatus RestoreStatus { get; set; }

        /// <summary>
        /// Checks to see if the RestoreStatus property is set.
        /// </summary>
        internal bool IsSetRestoreStatus() => this.RestoreStatus != null;

        /// <summary>
        /// Gets and sets the property RestoredDbResourceId. 
        /// <para>
        /// The identifier of the restored DB resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 64)]
        public string RestoredDbResourceId { get; set; }

        /// <summary>
        /// Checks to see if the RestoredDbResourceId property is set.
        /// </summary>
        internal bool IsSetRestoredDbResourceId() => this.RestoredDbResourceId != null;
    }
}
