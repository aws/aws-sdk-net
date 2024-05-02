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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// This is the response object from the UpdatePricingPlan operation.
    /// </summary>
    public partial class UpdatePricingPlanResponse : AmazonWebServiceResponse
    {
        private PricingPlan _currentPricingPlan;
        private PricingPlan _pendingPricingPlan;

        /// <summary>
        /// Gets and sets the property CurrentPricingPlan. 
        /// <para>
        /// Update the current pricing plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PricingPlan CurrentPricingPlan
        {
            get { return this._currentPricingPlan; }
            set { this._currentPricingPlan = value; }
        }

        // Check to see if CurrentPricingPlan property is set
        internal bool IsSetCurrentPricingPlan()
        {
            return this._currentPricingPlan != null;
        }

        /// <summary>
        /// Gets and sets the property PendingPricingPlan. 
        /// <para>
        /// Update the pending pricing plan.
        /// </para>
        /// </summary>
        public PricingPlan PendingPricingPlan
        {
            get { return this._pendingPricingPlan; }
            set { this._pendingPricingPlan = value; }
        }

        // Check to see if PendingPricingPlan property is set
        internal bool IsSetPendingPricingPlan()
        {
            return this._pendingPricingPlan != null;
        }

    }
}