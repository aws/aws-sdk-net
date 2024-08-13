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
    /// High-level information about a managed rule group, returned by <a>ListAvailableManagedRuleGroups</a>.
    /// This provides information like the name and vendor name, that you provide when you
    /// add a <a>ManagedRuleGroupStatement</a> to a web ACL. Managed rule groups include Amazon
    /// Web Services Managed Rules rule groups and Amazon Web Services Marketplace managed
    /// rule groups. To use any Amazon Web Services Marketplace managed rule group, first
    /// subscribe to the rule group through Amazon Web Services Marketplace.
    /// </summary>
    public partial class ManagedRuleGroupSummary
    {
        private string _description;
        private string _name;
        private string _vendorName;
        private bool? _versioningSupported;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the managed rule group, provided by Amazon Web Services Managed
        /// Rules or the Amazon Web Services Marketplace seller who manages it.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the managed rule group. You use this, along with the vendor name, to identify
        /// the rule group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property VersioningSupported. 
        /// <para>
        /// Indicates whether the managed rule group is versioned. If it is, you can retrieve
        /// the versions list by calling <a>ListAvailableManagedRuleGroupVersions</a>. 
        /// </para>
        /// </summary>
        public bool? VersioningSupported
        {
            get { return this._versioningSupported; }
            set { this._versioningSupported = value; }
        }

        // Check to see if VersioningSupported property is set
        internal bool IsSetVersioningSupported()
        {
            return this._versioningSupported.HasValue; 
        }

    }
}