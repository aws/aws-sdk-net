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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Returns information about a cluster.
    /// </summary>
    public partial class Cluster
    {
        private string _activeOperationArn;
        private string _clusterArn;
        private string _clusterName;
        private ClusterType _clusterType;
        private DateTime? _creationTime;
        private string _currentVersion;
        private Provisioned _provisioned;
        private Serverless _serverless;
        private ClusterState _state;
        private StateInfo _stateInfo;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ActiveOperationArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies a cluster operation.
        /// </para>
        /// </summary>
        public string ActiveOperationArn
        {
            get { return this._activeOperationArn; }
            set { this._activeOperationArn = value; }
        }

        // Check to see if ActiveOperationArn property is set
        internal bool IsSetActiveOperationArn()
        {
            return this._activeOperationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the cluster.
        /// </para>
        /// </summary>
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName.             
        /// <para>
        /// The name of the cluster.
        /// </para>
        /// </summary>
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterType.             
        /// <para>
        /// Cluster Type.
        /// </para>
        /// </summary>
        public ClusterType ClusterType
        {
            get { return this._clusterType; }
            set { this._clusterType = value; }
        }

        // Check to see if ClusterType property is set
        internal bool IsSetClusterType()
        {
            return this._clusterType != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime.             
        /// <para>
        /// The time when the cluster was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentVersion.             
        /// <para>
        /// The current version of the MSK cluster.
        /// </para>
        /// </summary>
        public string CurrentVersion
        {
            get { return this._currentVersion; }
            set { this._currentVersion = value; }
        }

        // Check to see if CurrentVersion property is set
        internal bool IsSetCurrentVersion()
        {
            return this._currentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Provisioned.             
        /// <para>
        /// Information about the provisioned cluster.
        /// </para>
        /// </summary>
        public Provisioned Provisioned
        {
            get { return this._provisioned; }
            set { this._provisioned = value; }
        }

        // Check to see if Provisioned property is set
        internal bool IsSetProvisioned()
        {
            return this._provisioned != null;
        }

        /// <summary>
        /// Gets and sets the property Serverless.             
        /// <para>
        /// Information about the serverless cluster.
        /// </para>
        /// </summary>
        public Serverless Serverless
        {
            get { return this._serverless; }
            set { this._serverless = value; }
        }

        // Check to see if Serverless property is set
        internal bool IsSetServerless()
        {
            return this._serverless != null;
        }

        /// <summary>
        /// Gets and sets the property State.             
        /// <para>
        /// The state of the cluster. The possible states are ACTIVE, CREATING, DELETING, FAILED,
        /// HEALING, MAINTENANCE, REBOOTING_BROKER, and UPDATING.
        /// </para>
        /// </summary>
        public ClusterState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateInfo.             
        /// <para>
        /// State Info for the Amazon MSK cluster.
        /// </para>
        /// </summary>
        public StateInfo StateInfo
        {
            get { return this._stateInfo; }
            set { this._stateInfo = value; }
        }

        // Check to see if StateInfo property is set
        internal bool IsSetStateInfo()
        {
            return this._stateInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.             
        /// <para>
        /// Tags attached to the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}