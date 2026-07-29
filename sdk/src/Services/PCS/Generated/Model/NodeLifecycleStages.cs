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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
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
namespace Amazon.PCS.Model
{
    /// <summary>
    /// The stages of a compute node's lifecycle where you can configure scripts to run.
    /// </summary>
    public partial class NodeLifecycleStages
    {
        private List<NodeLifecycleScript> _nodeBootstrapped = AWSConfigs.InitializeCollections ? new List<NodeLifecycleScript>() : null;
        private List<NodeLifecycleScript> _nodeReady = AWSConfigs.InitializeCollections ? new List<NodeLifecycleScript>() : null;

        /// <summary>
        /// Gets and sets the property NodeBootstrapped. 
        /// <para>
        /// The scripts to run after PCS finishes setting up the compute node and before the Slurm
        /// daemon (<c>slurmd</c>) starts. Use this stage for tasks that must complete before
        /// the node accepts jobs, such as mounting shared storage, configuring networking, or
        /// installing software packages.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<NodeLifecycleScript> NodeBootstrapped
        {
            get { return this._nodeBootstrapped; }
            set { this._nodeBootstrapped = value; }
        }

        // Check to see if NodeBootstrapped property is set
        internal bool IsSetNodeBootstrapped()
        {
            return this._nodeBootstrapped != null && (this._nodeBootstrapped.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodeReady. 
        /// <para>
        /// The scripts to run after the Slurm daemon (<c>slurmd</c>) starts and the compute node
        /// registers with the Slurm controller. Use this stage for tasks that require Slurm to
        /// be running, such as running Slurm commands.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<NodeLifecycleScript> NodeReady
        {
            get { return this._nodeReady; }
            set { this._nodeReady = value; }
        }

        // Check to see if NodeReady property is set
        internal bool IsSetNodeReady()
        {
            return this._nodeReady != null && (this._nodeReady.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}