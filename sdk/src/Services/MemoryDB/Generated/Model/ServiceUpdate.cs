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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
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
namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// An update that you can apply to your MemoryDB clusters.
    /// </summary>
    public partial class ServiceUpdate
    {
        private DateTime? _autoUpdateStartDate;
        private string _clusterName;
        private string _description;
        private string _engine;
        private string _nodesUpdated;
        private DateTime? _releaseDate;
        private string _serviceUpdateName;
        private ServiceUpdateStatus _status;
        private ServiceUpdateType _type;

        /// <summary>
        /// Gets and sets the property AutoUpdateStartDate. 
        /// <para>
        /// The date at which the service update will be automatically applied
        /// </para>
        /// </summary>
        public DateTime? AutoUpdateStartDate
        {
            get { return this._autoUpdateStartDate; }
            set { this._autoUpdateStartDate = value; }
        }

        // Check to see if AutoUpdateStartDate property is set
        internal bool IsSetAutoUpdateStartDate()
        {
            return this._autoUpdateStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster to which the service update applies
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
        /// Gets and sets the property Description. 
        /// <para>
        /// Provides details of the service update
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the engine for which a service update is available.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property NodesUpdated. 
        /// <para>
        /// A list of nodes updated by the service update
        /// </para>
        /// </summary>
        public string NodesUpdated
        {
            get { return this._nodesUpdated; }
            set { this._nodesUpdated = value; }
        }

        // Check to see if NodesUpdated property is set
        internal bool IsSetNodesUpdated()
        {
            return this._nodesUpdated != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseDate. 
        /// <para>
        /// The date when the service update is initially available
        /// </para>
        /// </summary>
        public DateTime? ReleaseDate
        {
            get { return this._releaseDate; }
            set { this._releaseDate = value; }
        }

        // Check to see if ReleaseDate property is set
        internal bool IsSetReleaseDate()
        {
            return this._releaseDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdateName. 
        /// <para>
        /// The unique ID of the service update
        /// </para>
        /// </summary>
        public string ServiceUpdateName
        {
            get { return this._serviceUpdateName; }
            set { this._serviceUpdateName = value; }
        }

        // Check to see if ServiceUpdateName property is set
        internal bool IsSetServiceUpdateName()
        {
            return this._serviceUpdateName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the service update
        /// </para>
        /// </summary>
        public ServiceUpdateStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Reflects the nature of the service update
        /// </para>
        /// </summary>
        public ServiceUpdateType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}