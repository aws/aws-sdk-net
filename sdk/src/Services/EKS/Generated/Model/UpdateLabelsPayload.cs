/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// An object representing a Kubernetes label change for a managed node group.
    /// </summary>
    public partial class UpdateLabelsPayload
    {
        private Dictionary<string, string> _addOrUpdateLabels = new Dictionary<string, string>();
        private List<string> _removeLabels = new List<string>();

        /// <summary>
        /// Gets and sets the property AddOrUpdateLabels. 
        /// <para>
        /// Kubernetes labels to be added or updated.
        /// </para>
        /// </summary>
        public Dictionary<string, string> AddOrUpdateLabels
        {
            get { return this._addOrUpdateLabels; }
            set { this._addOrUpdateLabels = value; }
        }

        // Check to see if AddOrUpdateLabels property is set
        internal bool IsSetAddOrUpdateLabels()
        {
            return this._addOrUpdateLabels != null && this._addOrUpdateLabels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RemoveLabels. 
        /// <para>
        /// Kubernetes labels to be removed.
        /// </para>
        /// </summary>
        public List<string> RemoveLabels
        {
            get { return this._removeLabels; }
            set { this._removeLabels = value; }
        }

        // Check to see if RemoveLabels property is set
        internal bool IsSetRemoveLabels()
        {
            return this._removeLabels != null && this._removeLabels.Count > 0; 
        }

    }
}