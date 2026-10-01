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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// An EKS Anywhere subscription authorizing the customer to support for licensed clusters
    /// and access to EKS Anywhere Curated Packages.
    /// </summary>
    public partial class EksAnywhereSubscription
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the subscription.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AutoRenew. 
        /// <para>
        /// A boolean indicating whether or not a subscription will auto renew when it expires.
        /// </para>
        /// </summary>
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// Checks to see if the AutoRenew property is set.
        /// </summary>
        internal bool IsSetAutoRenew() => this.AutoRenew.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp in seconds for when the subscription was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EffectiveDate. 
        /// <para>
        /// The Unix timestamp in seconds for when the subscription is effective.
        /// </para>
        /// </summary>
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveDate property is set.
        /// </summary>
        internal bool IsSetEffectiveDate() => this.EffectiveDate.HasValue;

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The Unix timestamp in seconds for when the subscription will expire or auto renew,
        /// depending on the auto renew configuration of the subscription object.
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationDate property is set.
        /// </summary>
        internal bool IsSetExpirationDate() => this.ExpirationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// UUID identifying a subscription.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LicenseArns. 
        /// <para>
        /// Amazon Web Services License Manager ARN associated with the subscription.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LicenseArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LicenseArns property is set.
        /// </summary>
        internal bool IsSetLicenseArns() => this.LicenseArns != null && (this.LicenseArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LicenseQuantity. 
        /// <para>
        /// The number of licenses included in a subscription. Valid values are between 1 and
        /// 100.
        /// </para>
        /// </summary>
        public int? LicenseQuantity { get; set; }

        /// <summary>
        /// Checks to see if the LicenseQuantity property is set.
        /// </summary>
        internal bool IsSetLicenseQuantity() => this.LicenseQuantity.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseType. 
        /// <para>
        /// The type of licenses included in the subscription. Valid value is CLUSTER. With the
        /// CLUSTER license type, each license covers support for a single EKS Anywhere cluster.
        /// </para>
        /// </summary>
        public EksAnywhereSubscriptionLicenseType LicenseType { get; set; }

        /// <summary>
        /// Checks to see if the LicenseType property is set.
        /// </summary>
        internal bool IsSetLicenseType() => this.LicenseType != null;

        /// <summary>
        /// Gets and sets the property Licenses. 
        /// <para>
        /// Includes all of the claims in the license token necessary to validate the license
        /// for extended support.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<License> Licenses { get; set; } = AWSConfigs.InitializeCollections ? new List<License>() : null;

        /// <summary>
        /// Checks to see if the Licenses property is set.
        /// </summary>
        internal bool IsSetLicenses() => this.Licenses != null && (this.Licenses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a subscription.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata for a subscription to assist with categorization and organization. Each
        /// tag consists of a key and an optional value. Subscription tags do not propagate to
        /// any other resources associated with the subscription.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Term. 
        /// <para>
        /// An EksAnywhereSubscriptionTerm object. 
        /// </para>
        /// </summary>
        public EksAnywhereSubscriptionTerm Term { get; set; }

        /// <summary>
        /// Checks to see if the Term property is set.
        /// </summary>
        internal bool IsSetTerm() => this.Term != null;
    }
}
