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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Information for a single version of a managed rule set. 
    /// 
    ///  <note> 
    /// <para>
    /// This is intended for use only by vendors of managed rule sets. Vendors are Amazon
    /// Web Services and Amazon Web Services Marketplace sellers. 
    /// </para>
    ///  
    /// <para>
    /// Vendors, you can use the managed rule set APIs to provide controlled rollout of your
    /// versioned managed rule group offerings for your customers. The APIs are <c>ListManagedRuleSets</c>,
    /// <c>GetManagedRuleSet</c>, <c>PutManagedRuleSetVersions</c>, and <c>UpdateManagedRuleSetVersionExpiryDate</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ManagedRuleSetVersion
    {
        /// <summary>
        /// Gets and sets the property AssociatedRuleGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vendor rule group that's used to define the
        /// published version of your managed rule group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string AssociatedRuleGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedRuleGroupArn property is set.
        /// </summary>
        internal bool IsSetAssociatedRuleGroupArn() => this.AssociatedRuleGroupArn != null;

        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The web ACL capacity units (WCUs) required for this rule group.
        /// </para>
        ///  
        /// <para>
        /// WAF uses WCUs to calculate and control the operating resources that are used to run
        /// your rules, rule groups, and web ACLs. WAF calculates capacity differently for each
        /// rule type, to reflect the relative cost of each rule. Simple rules that cost little
        /// to run use fewer WCUs than more complex rules that use more processing power. Rule
        /// group capacity is fixed at creation, which helps users plan their web ACL WCU usage
        /// when they use a rule group. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/aws-waf-capacity-units.html">WAF
        /// web ACL capacity units (WCU)</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? Capacity { get; set; }

        /// <summary>
        /// Checks to see if the Capacity property is set.
        /// </summary>
        internal bool IsSetCapacity() => this.Capacity.HasValue;

        /// <summary>
        /// Gets and sets the property ExpiryTimestamp. 
        /// <para>
        /// The time that this version is set to expire.
        /// </para>
        ///  
        /// <para>
        /// Times are in Coordinated Universal Time (UTC) format. UTC format includes the special
        /// designator, Z. For example, "2016-09-27T14:50Z". 
        /// </para>
        /// </summary>
        public DateTime? ExpiryTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ExpiryTimestamp property is set.
        /// </summary>
        internal bool IsSetExpiryTimestamp() => this.ExpiryTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ForecastedLifetime. 
        /// <para>
        /// The amount of time you expect this version of your managed rule group to last, in
        /// days. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? ForecastedLifetime { get; set; }

        /// <summary>
        /// Checks to see if the ForecastedLifetime property is set.
        /// </summary>
        internal bool IsSetForecastedLifetime() => this.ForecastedLifetime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdateTimestamp. 
        /// <para>
        /// The last time that you updated this version. 
        /// </para>
        ///  
        /// <para>
        /// Times are in Coordinated Universal Time (UTC) format. UTC format includes the special
        /// designator, Z. For example, "2016-09-27T14:50Z". 
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdateTimestamp() => this.LastUpdateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property PublishTimestamp. 
        /// <para>
        /// The time that you first published this version. 
        /// </para>
        ///  
        /// <para>
        /// Times are in Coordinated Universal Time (UTC) format. UTC format includes the special
        /// designator, Z. For example, "2016-09-27T14:50Z". 
        /// </para>
        /// </summary>
        public DateTime? PublishTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the PublishTimestamp property is set.
        /// </summary>
        internal bool IsSetPublishTimestamp() => this.PublishTimestamp.HasValue;
    }
}
