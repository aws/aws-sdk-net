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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the PutManagedInsightRules operation.
    /// Creates a managed Contributor Insights rule for a specified Amazon Web Services resource.
    /// When you enable a managed rule, you create a Contributor Insights rule that collects
    /// data from Amazon Web Services services. You cannot edit these rules with <code>PutInsightRule</code>.
    /// The rules can be enabled, disabled, and deleted using <code>EnableInsightRules</code>,
    /// <code>DisableInsightRules</code>, and <code>DeleteInsightRules</code>. If a previously
    /// created managed rule is currently disabled, a subsequent call to this API will re-enable
    /// it. Use <code>ListManagedInsightRules</code> to describe all available rules.
    /// </summary>
    public partial class PutManagedInsightRulesRequest : AmazonCloudWatchRequest
    {
        private List<ManagedRule> _managedRules = new List<ManagedRule>();

        /// <summary>
        /// Gets and sets the property ManagedRules. 
        /// <para>
        ///  A list of <code>ManagedRules</code> to enable. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ManagedRule> ManagedRules
        {
            get { return this._managedRules; }
            set { this._managedRules = value; }
        }

        // Check to see if ManagedRules property is set
        internal bool IsSetManagedRules()
        {
            return this._managedRules != null && this._managedRules.Count > 0; 
        }

    }
}