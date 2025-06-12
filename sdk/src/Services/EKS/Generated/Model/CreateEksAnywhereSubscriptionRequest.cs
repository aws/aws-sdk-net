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
    /// Container for the parameters to the CreateEksAnywhereSubscription operation.
    /// Creates an EKS Anywhere subscription. When a subscription is created, it is a contract
    /// agreement for the length of the term specified in the request. Licenses that are used
    /// to validate support are provisioned in Amazon Web Services License Manager and the
    /// caller account is granted access to EKS Anywhere Curated Packages.
    /// </summary>
    public partial class CreateEksAnywhereSubscriptionRequest : AmazonEKSRequest
    {
        private bool? _autoRenew;
        private string _clientRequestToken;
        private int? _licenseQuantity;
        private EksAnywhereSubscriptionLicenseType _licenseType;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private EksAnywhereSubscriptionTerm _term;

        /// <summary>
        /// Gets and sets the property AutoRenew. 
        /// <para>
        /// A boolean indicating whether the subscription auto renews at the end of the term.
        /// </para>
        /// </summary>
        public bool? AutoRenew
        {
            get { return this._autoRenew; }
            set { this._autoRenew = value; }
        }

        // Check to see if AutoRenew property is set
        internal bool IsSetAutoRenew()
        {
            return this._autoRenew.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseQuantity. 
        /// <para>
        /// The number of licenses to purchase with the subscription. Valid values are between
        /// 1 and 100. This value can't be changed after creating the subscription.
        /// </para>
        /// </summary>
        public int? LicenseQuantity
        {
            get { return this._licenseQuantity; }
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
        /// The license type for all licenses in the subscription. Valid value is CLUSTER. With
        /// the CLUSTER license type, each license covers support for a single EKS Anywhere cluster.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name for your subscription. It must be unique in your Amazon Web Services
        /// account in the Amazon Web Services Region you're creating the subscription in. The
        /// name can contain only alphanumeric characters (case-sensitive), hyphens, and underscores.
        /// It must start with an alphabetic character and can't be longer than 100 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata for a subscription to assist with categorization and organization. Each
        /// tag consists of a key and an optional value. Subscription tags don't propagate to
        /// any other resources associated with the subscription.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// An object representing the term duration and term unit type of your subscription.
        /// This determines the term length of your subscription. Valid values are MONTHS for
        /// term unit and 12 or 36 for term duration, indicating a 12 month or 36 month subscription.
        /// This value cannot be changed after creating the subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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