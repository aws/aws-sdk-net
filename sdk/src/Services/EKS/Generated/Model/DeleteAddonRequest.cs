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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAddon operation.
    /// Delete an Amazon EKS add-on.
    /// 
    ///  
    /// <para>
    /// When you remove the add-on, it will also be deleted from the cluster. You can always
    /// manually start an add-on on the cluster using the Kubernetes API.
    /// </para>
    /// </summary>
    public partial class DeleteAddonRequest : AmazonEKSRequest
    {
        private string _addonName;
        private string _clusterName;
        private bool? _preserve;

        /// <summary>
        /// Gets and sets the property AddonName. 
        /// <para>
        /// The name of the add-on. The name must match one of the names returned by <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_ListAddons.html">
        /// <code>ListAddons</code> </a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AddonName
        {
            get { return this._addonName; }
            set { this._addonName = value; }
        }

        // Check to see if AddonName property is set
        internal bool IsSetAddonName()
        {
            return this._addonName != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster to delete the add-on from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property Preserve. 
        /// <para>
        /// Specifying this option preserves the add-on software on your cluster but Amazon EKS
        /// stops managing any settings for the add-on. If an IAM account is associated with the
        /// add-on, it isn't removed.
        /// </para>
        /// </summary>
        public bool Preserve
        {
            get { return this._preserve.GetValueOrDefault(); }
            set { this._preserve = value; }
        }

        // Check to see if Preserve property is set
        internal bool IsSetPreserve()
        {
            return this._preserve.HasValue; 
        }

    }
}