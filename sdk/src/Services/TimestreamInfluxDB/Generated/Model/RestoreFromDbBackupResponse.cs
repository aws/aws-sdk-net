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
 * Do not modify this file. This file is generated from the timestream-influxdb-2023-01-27.normal.json service model.
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
        private ResourceDeploymentType _deploymentType;
        private EngineType _engineType;
        private ResourceType _resourceType;
        private string _restoredDbResourceId;
        private RestoreStatus _restoreStatus;

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// The deployment type of the restored resource.
        /// </para>
        /// </summary>
        public ResourceDeploymentType DeploymentType
        {
            get { return this._deploymentType; }
            set { this._deploymentType = value; }
        }

        // Check to see if DeploymentType property is set
        internal bool IsSetDeploymentType()
        {
            return this._deploymentType != null;
        }

        /// <summary>
        /// Gets and sets the property EngineType. 
        /// <para>
        /// The engine type of the restored resource.
        /// </para>
        /// </summary>
        public EngineType EngineType
        {
            get { return this._engineType; }
            set { this._engineType = value; }
        }

        // Check to see if EngineType property is set
        internal bool IsSetEngineType()
        {
            return this._engineType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the restored resource. Valid values are DB_INSTANCE and DB_CLUSTER.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property RestoredDbResourceId. 
        /// <para>
        /// The identifier of the restored DB resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=64)]
        public string RestoredDbResourceId
        {
            get { return this._restoredDbResourceId; }
            set { this._restoredDbResourceId = value; }
        }

        // Check to see if RestoredDbResourceId property is set
        internal bool IsSetRestoredDbResourceId()
        {
            return this._restoredDbResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreStatus. 
        /// <para>
        /// The status of the restore operation.
        /// </para>
        /// </summary>
        public RestoreStatus RestoreStatus
        {
            get { return this._restoreStatus; }
            set { this._restoreStatus = value; }
        }

        // Check to see if RestoreStatus property is set
        internal bool IsSetRestoreStatus()
        {
            return this._restoreStatus != null;
        }

    }
}