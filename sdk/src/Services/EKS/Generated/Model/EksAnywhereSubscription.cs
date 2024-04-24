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
    /// An EKS Anywhere subscription authorizing the customer to support for licensed clusters
    /// and access to EKS Anywhere Curated Packages.
    /// </summary>
    public partial class EksAnywhereSubscription
    {
        private string _arn;
        private bool? _autoRenew;
        private DateTime? _createdAt;
        private DateTime? _effectiveDate;
        private DateTime? _expirationDate;
        private string _id;
        private List<string> _licenseArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _licenseQuantity;
        private EksAnywhereSubscriptionLicenseType _licenseType;
        private string _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private EksAnywhereSubscriptionTerm _term;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the subscription.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AutoRenew. 
        /// <para>
        /// A boolean indicating whether or not a subscription will auto renew when it expires.
        /// </para>
        /// </summary>
        public bool AutoRenew
        {
            get { return this._autoRenew.GetValueOrDefault(); }
            set { this._autoRenew = value; }
        }

        // Check to see if AutoRenew property is set
        internal bool IsSetAutoRenew()
        {
            return this._autoRenew.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp in seconds for when the subscription was created.
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
        /// Gets and sets the property EffectiveDate. 
        /// <para>
        /// The Unix timestamp in seconds for when the subscription is effective.
        /// </para>
        /// </summary>
        public DateTime EffectiveDate
        {
            get { return this._effectiveDate.GetValueOrDefault(); }
            set { this._effectiveDate = value; }
        }

        // Check to see if EffectiveDate property is set
        internal bool IsSetEffectiveDate()
        {
            return this._effectiveDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The Unix timestamp in seconds for when the subscription will expire or auto renew,
        /// depending on the auto renew configuration of the subscription object.
        /// </para>
        /// </summary>
        public DateTime ExpirationDate
        {
            get { return this._expirationDate.GetValueOrDefault(); }
            set { this._expirationDate = value; }
        }

        // Check to see if ExpirationDate property is set
        internal bool IsSetExpirationDate()
        {
            return this._expirationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// UUID identifying a subscription.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseArns. 
        /// <para>
        /// Amazon Web Services License Manager ARN associated with the subscription.
        /// </para>
        /// </summary>
        public List<string> LicenseArns
        {
            get { return this._licenseArns; }
            set { this._licenseArns = value; }
        }

        // Check to see if LicenseArns property is set
        internal bool IsSetLicenseArns()
        {
            return this._licenseArns != null && (this._licenseArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LicenseQuantity. 
        /// <para>
        /// The number of licenses included in a subscription. Valid values are between 1 and
        /// 100.
        /// </para>
        /// </summary>
        public int LicenseQuantity
        {
            get { return this._licenseQuantity.GetValueOrDefault(); }
            set { this._licenseQuantity = value; }
        }

        // Check to see if LicenseQuantity property is set
        internal bool IsSetLicenseQuantity()
        {
            return this._licenseQuantity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LicenseType. 
        /// <para>
        /// The type of licenses included in the subscription. Valid value is CLUSTER. With the
        /// CLUSTER license type, each license covers support for a single EKS Anywhere cluster.
        /// </para>
        /// </summary>
        public EksAnywhereSubscriptionLicenseType LicenseType
        {
            get { return this._licenseType; }
            set { this._licenseType = value; }
        }

        // Check to see if LicenseType property is set
        internal bool IsSetLicenseType()
        {
            return this._licenseType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a subscription.
        /// </para>
        /// </summary>
        public string Status
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
        /// The metadata for a subscription to assist with categorization and organization. Each
        /// tag consists of a key and an optional value. Subscription tags do not propagate to
        /// any other resources associated with the subscription.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Term. 
        /// <para>
        /// An EksAnywhereSubscriptionTerm object. 
        /// </para>
        /// </summary>
        public EksAnywhereSubscriptionTerm Term
        {
            get { return this._term; }
            set { this._term = value; }
        }

        // Check to see if Term property is set
        internal bool IsSetTerm()
        {
            return this._term != null;
        }

    }
}