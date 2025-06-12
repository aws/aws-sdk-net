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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// An object representing the details of an update to a taints payload. For more information,
    /// see <a href="https://docs.aws.amazon.com/eks/latest/userguide/node-taints-managed-node-groups.html">Node
    /// taints on managed node groups</a> in the <i>Amazon EKS User Guide</i>.
    /// </summary>
    public partial class UpdateTaintsPayload
    {
        private List<Taint> _addOrUpdateTaints = AWSConfigs.InitializeCollections ? new List<Taint>() : null;
        private List<Taint> _removeTaints = AWSConfigs.InitializeCollections ? new List<Taint>() : null;

        /// <summary>
        /// Gets and sets the property AddOrUpdateTaints. 
        /// <para>
        /// Kubernetes taints to be added or updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Taint> AddOrUpdateTaints
        {
            get { return this._addOrUpdateTaints; }
            set { this._addOrUpdateTaints = value; }
        }

        // Check to see if AddOrUpdateTaints property is set
        internal bool IsSetAddOrUpdateTaints()
        {
            return this._addOrUpdateTaints != null && (this._addOrUpdateTaints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RemoveTaints. 
        /// <para>
        /// Kubernetes taints to remove.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Taint> RemoveTaints
        {
            get { return this._removeTaints; }
            set { this._removeTaints = value; }
        }

        // Check to see if RemoveTaints property is set
        internal bool IsSetRemoveTaints()
        {
            return this._removeTaints != null && (this._removeTaints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}