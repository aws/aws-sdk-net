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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// The filter that specifies the billing groups and pricing plans to retrieve billing
    /// group information.
    /// </summary>
    public partial class ListBillingGroupsFilter
    {
        private List<string> _arns = new List<string>();
        private string _pricingPlan;
        private List<string> _statuses = new List<string>();

        /// <summary>
        /// Gets and sets the property Arns. 
        /// <para>
        /// The list of billing group Amazon Resource Names (ARNs) to retrieve information. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> Arns
        {
            get { return this._arns; }
            set { this._arns = value; }
        }

        // Check to see if Arns property is set
        internal bool IsSetArns()
        {
            return this._arns != null && this._arns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PricingPlan. 
        /// <para>
        /// The pricing plan Amazon Resource Names (ARNs) to retrieve information. 
        /// </para>
        /// </summary>
        public string PricingPlan
        {
            get { return this._pricingPlan; }
            set { this._pricingPlan = value; }
        }

        // Check to see if PricingPlan property is set
        internal bool IsSetPricingPlan()
        {
            return this._pricingPlan != null;
        }

        /// <summary>
        /// Gets and sets the property Statuses. 
        /// <para>
        ///  A list of billing groups to retrieve their current status for a specific time range
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> Statuses
        {
            get { return this._statuses; }
            set { this._statuses = value; }
        }

        // Check to see if Statuses property is set
        internal bool IsSetStatuses()
        {
            return this._statuses != null && this._statuses.Count > 0; 
        }

    }
}