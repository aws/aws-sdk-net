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
    /// An Amazon EKS add-on. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-add-ons.html">Amazon
    /// EKS add-ons</a> in the <i>Amazon EKS User Guide</i>.
    /// </summary>
    public partial class Addon
    {
        private string _addonArn;
        private string _addonName;
        private string _addonVersion;
        private string _clusterName;
        private DateTime? _createdAt;
        private AddonHealth _health;
        private MarketplaceInformation _marketplaceInformation;
        private DateTime? _modifiedAt;
        private string _owner;
        private string _publisher;
        private string _serviceAccountRoleArn;
        private AddonStatus _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AddonArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the add-on.
        /// </para>
        /// </summary>
        public string AddonArn
        {
            get { return this._addonArn; }
            set { this._addonArn = value; }
        }

        // Check to see if AddonArn property is set
        internal bool IsSetAddonArn()
        {
            return this._addonArn != null;
        }

        /// <summary>
        /// Gets and sets the property AddonName. 
        /// <para>
        /// The name of the add-on.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property AddonVersion. 
        /// <para>
        /// The version of the add-on.
        /// </para>
        /// </summary>
        public string AddonVersion
        {
            get { return this._addonVersion; }
            set { this._addonVersion = value; }
        }

        // Check to see if AddonVersion property is set
        internal bool IsSetAddonVersion()
        {
            return this._addonVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the add-on was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Health. 
        /// <para>
        /// An object representing the health of the add-on.
        /// </para>
        /// </summary>
        public AddonHealth Health
        {
            get { return this._health; }
            set { this._health = value; }
        }

        // Check to see if Health property is set
        internal bool IsSetHealth()
        {
            return this._health != null;
        }

        /// <summary>
        /// Gets and sets the property MarketplaceInformation. 
        /// <para>
        /// Information about an Amazon EKS add-on from the Amazon Web Services Marketplace.
        /// </para>
        /// </summary>
        public MarketplaceInformation MarketplaceInformation
        {
            get { return this._marketplaceInformation; }
            set { this._marketplaceInformation = value; }
        }

        // Check to see if MarketplaceInformation property is set
        internal bool IsSetMarketplaceInformation()
        {
            return this._marketplaceInformation != null;
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The date and time that the add-on was last modified.
        /// </para>
        /// </summary>
        public DateTime ModifiedAt
        {
            get { return this._modifiedAt.GetValueOrDefault(); }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the add-on.
        /// </para>
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property Publisher. 
        /// <para>
        /// The publisher of the add-on.
        /// </para>
        /// </summary>
        public string Publisher
        {
            get { return this._publisher; }
            set { this._publisher = value; }
        }

        // Check to see if Publisher property is set
        internal bool IsSetPublisher()
        {
            return this._publisher != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccountRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that is bound to the Kubernetes service
        /// account used by the add-on.
        /// </para>
        /// </summary>
        public string ServiceAccountRoleArn
        {
            get { return this._serviceAccountRoleArn; }
            set { this._serviceAccountRoleArn = value; }
        }

        // Check to see if ServiceAccountRoleArn property is set
        internal bool IsSetServiceAccountRoleArn()
        {
            return this._serviceAccountRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the add-on.
        /// </para>
        /// </summary>
        public AddonStatus Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the add-on to assist with categorization and organization.
        /// Each tag consists of a key and an optional value. You define both. Add-on tags do
        /// not propagate to any other resources associated with the cluster. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}