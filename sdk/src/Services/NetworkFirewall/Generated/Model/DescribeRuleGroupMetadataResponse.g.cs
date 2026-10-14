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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// This is the response object from the DescribeRuleGroupMetadata operation.
    /// </summary>
    public partial class DescribeRuleGroupMetadataResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The maximum operating resources that this rule group can use. Rule group capacity
        /// is fixed at creation. When you update a rule group, you are limited to this capacity.
        /// When you reference a rule group from a firewall policy, Network Firewall reserves
        /// this capacity for the rule group. 
        /// </para>
        ///  
        /// <para>
        /// You can retrieve the capacity that would be required for a rule group before you create
        /// the rule group by calling <a>CreateRuleGroup</a> with <c>DryRun</c> set to <c>TRUE</c>.
        /// 
        /// </para>
        /// </summary>
        public int? Capacity { get; set; }

        /// <summary>
        /// Checks to see if the Capacity property is set.
        /// </summary>
        internal bool IsSetCapacity() => this.Capacity.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Returns the metadata objects for the specified rule group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp indicating when the rule group was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ListingName. 
        /// <para>
        /// The display name of the product listing for this rule group.
        /// </para>
        /// </summary>
        public string ListingName { get; set; }

        /// <summary>
        /// Checks to see if the ListingName property is set.
        /// </summary>
        internal bool IsSetListingName() => this.ListingName != null;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The unique identifier for the product listing associated with this rule group.
        /// </para>
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;

        /// <summary>
        /// Gets and sets the property RuleGroupArn. 
        /// <para>
        /// The descriptive name of the rule group. You can't change the name of a rule group
        /// after you create it.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string RuleGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the RuleGroupArn property is set.
        /// </summary>
        internal bool IsSetRuleGroupArn() => this.RuleGroupArn != null;

        /// <summary>
        /// Gets and sets the property RuleGroupName. 
        /// <para>
        /// The descriptive name of the rule group. You can't change the name of a rule group
        /// after you create it.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string RuleGroupName { get; set; }

        /// <summary>
        /// Checks to see if the RuleGroupName property is set.
        /// </summary>
        internal bool IsSetRuleGroupName() => this.RuleGroupName != null;

        /// <summary>
        /// Gets and sets the property StatefulRuleOptions.
        /// </summary>
        public StatefulRuleOptions StatefulRuleOptions { get; set; }

        /// <summary>
        /// Checks to see if the StatefulRuleOptions property is set.
        /// </summary>
        internal bool IsSetStatefulRuleOptions() => this.StatefulRuleOptions != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Indicates whether the rule group is stateless or stateful. If the rule group is stateless,
        /// it contains stateless rules. If it is stateful, it contains stateful rules. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This setting is required for requests that do not include the <c>RuleGroupARN</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public RuleGroupType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VendorName. 
        /// <para>
        /// The name of the Amazon Web Services Marketplace vendor that provides this rule group.
        /// </para>
        /// </summary>
        public string VendorName { get; set; }

        /// <summary>
        /// Checks to see if the VendorName property is set.
        /// </summary>
        internal bool IsSetVendorName() => this.VendorName != null;
    }
}
