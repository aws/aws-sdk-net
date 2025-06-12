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
    /// An object representing a Kubernetes <c>label</c> change for a managed node group.
    /// </summary>
    public partial class UpdateLabelsPayload
    {
        private Dictionary<string, string> _addOrUpdateLabels = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _removeLabels = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AddOrUpdateLabels. 
        /// <para>
        /// The Kubernetes <c>labels</c> to add or update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AddOrUpdateLabels
        {
            get { return this._addOrUpdateLabels; }
            set { this._addOrUpdateLabels = value; }
        }

        // Check to see if AddOrUpdateLabels property is set
        internal bool IsSetAddOrUpdateLabels()
        {
            return this._addOrUpdateLabels != null && (this._addOrUpdateLabels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RemoveLabels. 
        /// <para>
        /// The Kubernetes <c>labels</c> to remove.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveLabels
        {
            get { return this._removeLabels; }
            set { this._removeLabels = value; }
        }

        // Check to see if RemoveLabels property is set
        internal bool IsSetRemoveLabels()
        {
            return this._removeLabels != null && (this._removeLabels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}