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
    /// versioned managed rule group offerings for your customers. The APIs are <code>ListManagedRuleSets</code>,
    /// <code>GetManagedRuleSet</code>, <code>PutManagedRuleSetVersions</code>, and <code>UpdateManagedRuleSetVersionExpiryDate</code>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ManagedRuleSetVersion
    {
        private string _associatedRuleGroupArn;
        private long? _capacity;
        private DateTime? _expiryTimestamp;
        private int? _forecastedLifetime;
        private DateTime? _lastUpdateTimestamp;
        private DateTime? _publishTimestamp;

        /// <summary>
        /// Gets and sets the property AssociatedRuleGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vendor rule group that's used to define the
        /// published version of your managed rule group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string AssociatedRuleGroupArn
        {
            get { return this._associatedRuleGroupArn; }
            set { this._associatedRuleGroupArn = value; }
        }

        // Check to see if AssociatedRuleGroupArn property is set
        internal bool IsSetAssociatedRuleGroupArn()
        {
            return this._associatedRuleGroupArn != null;
        }

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
        [AWSProperty(Min=1)]
        public long Capacity
        {
            get { return this._capacity.GetValueOrDefault(); }
            set { this._capacity = value; }
        }

        // Check to see if Capacity property is set
        internal bool IsSetCapacity()
        {
            return this._capacity.HasValue; 
        }

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
        public DateTime ExpiryTimestamp
        {
            get { return this._expiryTimestamp.GetValueOrDefault(); }
            set { this._expiryTimestamp = value; }
        }

        // Check to see if ExpiryTimestamp property is set
        internal bool IsSetExpiryTimestamp()
        {
            return this._expiryTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForecastedLifetime. 
        /// <para>
        /// The amount of time you expect this version of your managed rule group to last, in
        /// days. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int ForecastedLifetime
        {
            get { return this._forecastedLifetime.GetValueOrDefault(); }
            set { this._forecastedLifetime = value; }
        }

        // Check to see if ForecastedLifetime property is set
        internal bool IsSetForecastedLifetime()
        {
            return this._forecastedLifetime.HasValue; 
        }

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
        public DateTime LastUpdateTimestamp
        {
            get { return this._lastUpdateTimestamp.GetValueOrDefault(); }
            set { this._lastUpdateTimestamp = value; }
        }

        // Check to see if LastUpdateTimestamp property is set
        internal bool IsSetLastUpdateTimestamp()
        {
            return this._lastUpdateTimestamp.HasValue; 
        }

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
        public DateTime PublishTimestamp
        {
            get { return this._publishTimestamp.GetValueOrDefault(); }
            set { this._publishTimestamp = value; }
        }

        // Check to see if PublishTimestamp property is set
        internal bool IsSetPublishTimestamp()
        {
            return this._publishTimestamp.HasValue; 
        }

    }
}