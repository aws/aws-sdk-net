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
    /// A version of the named managed rule group, that the rule group's vendor publishes
    /// for use by customers. 
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
    public partial class VersionToPublish
    {
        private string _associatedRuleGroupArn;
        private int? _forecastedLifetime;

        /// <summary>
        /// Gets and sets the property AssociatedRuleGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vendor's rule group that's used in the published
        /// managed rule group version. 
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
        /// Gets and sets the property ForecastedLifetime. 
        /// <para>
        /// The amount of time the vendor expects this version of the managed rule group to last,
        /// in days. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? ForecastedLifetime
        {
            get { return this._forecastedLifetime; }
            set { this._forecastedLifetime = value; }
        }

        // Check to see if ForecastedLifetime property is set
        internal bool IsSetForecastedLifetime()
        {
            return this._forecastedLifetime.HasValue; 
        }

    }
}