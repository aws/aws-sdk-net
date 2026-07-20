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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// The pricing attributes that apply to your Amazon SES account, including the currently
    /// active pricing plan and any scheduled change for the next billing cycle.
    /// </summary>
    public partial class PricingAttributes
    {
        private PricingPlan _currentPlan;
        private PricingPlan _nextPlan;

        /// <summary>
        /// Gets and sets the property CurrentPlan. 
        /// <para>
        /// The pricing plan that is currently active on your Amazon SES account.
        /// </para>
        /// </summary>
        public PricingPlan CurrentPlan
        {
            get { return this._currentPlan; }
            set { this._currentPlan = value; }
        }

        // Check to see if CurrentPlan property is set
        internal bool IsSetCurrentPlan()
        {
            return this._currentPlan != null;
        }

        /// <summary>
        /// Gets and sets the property NextPlan. 
        /// <para>
        /// The pricing plan that will become active at the start of the next billing cycle, if
        /// a scheduled change has been requested. This field is empty when no scheduled change
        /// is pending.
        /// </para>
        /// </summary>
        public PricingPlan NextPlan
        {
            get { return this._nextPlan; }
            set { this._nextPlan = value; }
        }

        // Check to see if NextPlan property is set
        internal bool IsSetNextPlan()
        {
            return this._nextPlan != null;
        }

    }
}