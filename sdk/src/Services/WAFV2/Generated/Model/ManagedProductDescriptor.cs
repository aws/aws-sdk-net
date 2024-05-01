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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The properties of a managed product, such as an Amazon Web Services Managed Rules
    /// rule group or an Amazon Web Services Marketplace managed rule group.
    /// </summary>
    public partial class ManagedProductDescriptor
    {
        private bool? _isAdvancedManagedRuleSet;
        private bool? _isVersioningSupported;
        private string _managedRuleSetName;
        private string _productDescription;
        private string _productId;
        private string _productLink;
        private string _productTitle;
        private string _snsTopicArn;
        private string _vendorName;

        /// <summary>
        /// Gets and sets the property IsAdvancedManagedRuleSet. 
        /// <para>
        /// Indicates whether the rule group provides an advanced set of protections, such as
        /// the the Amazon Web Services Managed Rules rule groups that are used for WAF intelligent
        /// threat mitigation. 
        /// </para>
        /// </summary>
        public bool? IsAdvancedManagedRuleSet
        {
            get { return this._isAdvancedManagedRuleSet; }
            set { this._isAdvancedManagedRuleSet = value; }
        }

        // Check to see if IsAdvancedManagedRuleSet property is set
        internal bool IsSetIsAdvancedManagedRuleSet()
        {
            return this._isAdvancedManagedRuleSet.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsVersioningSupported. 
        /// <para>
        /// Indicates whether the rule group is versioned. 
        /// </para>
        /// </summary>
        public bool? IsVersioningSupported
        {
            get { return this._isVersioningSupported; }
            set { this._isVersioningSupported = value; }
        }

        // Check to see if IsVersioningSupported property is set
        internal bool IsSetIsVersioningSupported()
        {
            return this._isVersioningSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManagedRuleSetName. 
        /// <para>
        /// The name of the managed rule group. For example, <c>AWSManagedRulesAnonymousIpList</c>
        /// or <c>AWSManagedRulesATPRuleSet</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ManagedRuleSetName
        {
            get { return this._managedRuleSetName; }
            set { this._managedRuleSetName = value; }
        }

        // Check to see if ManagedRuleSetName property is set
        internal bool IsSetManagedRuleSetName()
        {
            return this._managedRuleSetName != null;
        }

        /// <summary>
        /// Gets and sets the property ProductDescription. 
        /// <para>
        /// A short description of the managed rule group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ProductDescription
        {
            get { return this._productDescription; }
            set { this._productDescription = value; }
        }

        // Check to see if ProductDescription property is set
        internal bool IsSetProductDescription()
        {
            return this._productDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// A unique identifier for the rule group. This ID is returned in the responses to create
        /// and list commands. You provide it to operations like update and delete.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductLink. 
        /// <para>
        /// For Amazon Web Services Marketplace managed rule groups only, the link to the rule
        /// group product page. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ProductLink
        {
            get { return this._productLink; }
            set { this._productLink = value; }
        }

        // Check to see if ProductLink property is set
        internal bool IsSetProductLink()
        {
            return this._productLink != null;
        }

        /// <summary>
        /// Gets and sets the property ProductTitle. 
        /// <para>
        /// The display name for the managed rule group. For example, <c>Anonymous IP list</c>
        /// or <c>Account takeover prevention</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ProductTitle
        {
            get { return this._productTitle; }
            set { this._productTitle = value; }
        }

        // Check to see if ProductTitle property is set
        internal bool IsSetProductTitle()
        {
            return this._productTitle != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The Amazon resource name (ARN) of the Amazon Simple Notification Service SNS topic
        /// that's used to provide notification of changes to the managed rule group. You can
        /// subscribe to the SNS topic to receive notifications when the managed rule group is
        /// modified, such as for new versions and for version expiration. For more information,
        /// see the <a href="https://docs.aws.amazon.com/sns/latest/dg/welcome.html">Amazon Simple
        /// Notification Service Developer Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

        /// <summary>
        /// Gets and sets the property VendorName. 
        /// <para>
        /// The name of the managed rule group vendor. You use this, along with the rule group
        /// name, to identify a rule group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string VendorName
        {
            get { return this._vendorName; }
            set { this._vendorName = value; }
        }

        // Check to see if VendorName property is set
        internal bool IsSetVendorName()
        {
            return this._vendorName != null;
        }

    }
}