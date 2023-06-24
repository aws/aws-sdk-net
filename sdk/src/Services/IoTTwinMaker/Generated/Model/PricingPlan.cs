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

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// The pricing plan.
    /// </summary>
    public partial class PricingPlan
    {
        private long? _billableEntityCount;
        private BundleInformation _bundleInformation;
        private DateTime? _effectiveDateTime;
        private PricingMode _pricingMode;
        private DateTime? _updateDateTime;
        private UpdateReason _updateReason;

        /// <summary>
        /// Gets and sets the property BillableEntityCount. 
        /// <para>
        /// The billable entity count.
        /// </para>
        /// </summary>
        public long BillableEntityCount
        {
            get { return this._billableEntityCount.GetValueOrDefault(); }
            set { this._billableEntityCount = value; }
        }

        // Check to see if BillableEntityCount property is set
        internal bool IsSetBillableEntityCount()
        {
            return this._billableEntityCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BundleInformation. 
        /// <para>
        /// The pricing plan's bundle information.
        /// </para>
        /// </summary>
        public BundleInformation BundleInformation
        {
            get { return this._bundleInformation; }
            set { this._bundleInformation = value; }
        }

        // Check to see if BundleInformation property is set
        internal bool IsSetBundleInformation()
        {
            return this._bundleInformation != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveDateTime. 
        /// <para>
        /// The effective date and time of the pricing plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EffectiveDateTime
        {
            get { return this._effectiveDateTime.GetValueOrDefault(); }
            set { this._effectiveDateTime = value; }
        }

        // Check to see if EffectiveDateTime property is set
        internal bool IsSetEffectiveDateTime()
        {
            return this._effectiveDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PricingMode. 
        /// <para>
        /// The pricing mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PricingMode PricingMode
        {
            get { return this._pricingMode; }
            set { this._pricingMode = value; }
        }

        // Check to see if PricingMode property is set
        internal bool IsSetPricingMode()
        {
            return this._pricingMode != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateDateTime. 
        /// <para>
        /// The set date and time for updating a pricing plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdateDateTime
        {
            get { return this._updateDateTime.GetValueOrDefault(); }
            set { this._updateDateTime = value; }
        }

        // Check to see if UpdateDateTime property is set
        internal bool IsSetUpdateDateTime()
        {
            return this._updateDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdateReason. 
        /// <para>
        /// The update reason for changing a pricing plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateReason UpdateReason
        {
            get { return this._updateReason; }
            set { this._updateReason = value; }
        }

        // Check to see if UpdateReason property is set
        internal bool IsSetUpdateReason()
        {
            return this._updateReason != null;
        }

    }
}