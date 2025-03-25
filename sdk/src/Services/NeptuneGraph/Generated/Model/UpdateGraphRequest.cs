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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
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
namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGraph operation.
    /// Updates the configuration of a specified Neptune Analytics graph
    /// </summary>
    public partial class UpdateGraphRequest : AmazonNeptuneGraphRequest
    {
        private bool? _deletionProtection;
        private string _graphIdentifier;
        private int? _provisionedMemory;
        private bool? _publicConnectivity;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// A value that indicates whether the graph has deletion protection enabled. The graph
        /// can't be deleted when deletion protection is enabled.
        /// </para>
        /// </summary>
        public bool? DeletionProtection
        {
            get { return this._deletionProtection; }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GraphIdentifier. 
        /// <para>
        /// The unique identifier of the Neptune Analytics graph.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GraphIdentifier
        {
            get { return this._graphIdentifier; }
            set { this._graphIdentifier = value; }
        }

        // Check to see if GraphIdentifier property is set
        internal bool IsSetGraphIdentifier()
        {
            return this._graphIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedMemory. 
        /// <para>
        /// The provisioned memory-optimized Neptune Capacity Units (m-NCUs) to use for the graph.
        /// </para>
        ///  
        /// <para>
        /// Min = 16
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=24576)]
        public int? ProvisionedMemory
        {
            get { return this._provisionedMemory; }
            set { this._provisionedMemory = value; }
        }

        // Check to see if ProvisionedMemory property is set
        internal bool IsSetProvisionedMemory()
        {
            return this._provisionedMemory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PublicConnectivity. 
        /// <para>
        /// Specifies whether or not the graph can be reachable over the internet. All access
        /// to graphs is IAM authenticated. (<c>true</c> to enable, or <c>false</c> to disable.
        /// </para>
        /// </summary>
        public bool? PublicConnectivity
        {
            get { return this._publicConnectivity; }
            set { this._publicConnectivity = value; }
        }

        // Check to see if PublicConnectivity property is set
        internal bool IsSetPublicConnectivity()
        {
            return this._publicConnectivity.HasValue; 
        }

    }
}