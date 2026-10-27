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

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// An update that you can apply to your MemoryDB clusters.
    /// </summary>
    public partial class ServiceUpdate
    {
        /// <summary>
        /// Gets and sets the property AutoUpdateStartDate. 
        /// <para>
        /// The date at which the service update will be automatically applied
        /// </para>
        /// </summary>
        public DateTime? AutoUpdateStartDate { get; set; }

        /// <summary>
        /// Checks to see if the AutoUpdateStartDate property is set.
        /// </summary>
        internal bool IsSetAutoUpdateStartDate() => this.AutoUpdateStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster to which the service update applies
        /// </para>
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Provides details of the service update
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the engine for which a service update is available.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property NodesUpdated. 
        /// <para>
        /// A list of nodes updated by the service update
        /// </para>
        /// </summary>
        public string NodesUpdated { get; set; }

        /// <summary>
        /// Checks to see if the NodesUpdated property is set.
        /// </summary>
        internal bool IsSetNodesUpdated() => this.NodesUpdated != null;

        /// <summary>
        /// Gets and sets the property ReleaseDate. 
        /// <para>
        /// The date when the service update is initially available
        /// </para>
        /// </summary>
        public DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseDate property is set.
        /// </summary>
        internal bool IsSetReleaseDate() => this.ReleaseDate.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceUpdateName. 
        /// <para>
        /// The unique ID of the service update
        /// </para>
        /// </summary>
        public string ServiceUpdateName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUpdateName property is set.
        /// </summary>
        internal bool IsSetServiceUpdateName() => this.ServiceUpdateName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the service update
        /// </para>
        /// </summary>
        public ServiceUpdateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Reflects the nature of the service update
        /// </para>
        /// </summary>
        public ServiceUpdateType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
