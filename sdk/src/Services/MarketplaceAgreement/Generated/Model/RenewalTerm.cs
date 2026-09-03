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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Defines that on graceful expiration of the agreement (when the agreement ends on its
    /// pre-defined end date), a new agreement will be created using the accepted terms on
    /// the existing agreement. In other words, the agreement will be renewed. Presence of
    /// <c>RenewalTerm</c> in the offer document means that auto-renewal is allowed. The acceptor
    /// will have the option to accept or decline auto-renewal at the offer acceptance/agreement
    /// creation. The acceptor can also change this flag from <c>True</c> to <c>False</c>
    /// or <c>False</c> to <c>True</c>, within the limits set by <c>LockoutPeriod</c> and
    /// <c>MaxRenewals</c>. Setting the flag to <c>True</c> doesn't by itself guarantee that
    /// the agreement renews, because the proposer can also opt out.
    /// </summary>
    public partial class RenewalTerm
    {
        private string _adjustmentDeadline;
        private RenewalTermConfiguration _configuration;
        private string _id;
        private string _lockoutPeriod;
        private int? _maxRenewals;
        private PriceIncrease _priceIncrease;
        private List<TermTemplate> _termTemplates = AWSConfigs.InitializeCollections ? new List<TermTemplate>() : null;
        private string _type;

        /// <summary>
        /// Gets and sets the property AdjustmentDeadline. 
        /// <para>
        /// The date by which the proposer must finalize the price increase for the next renewal,
        /// measured back from the end date of the agreement. The duration is represented in the
        /// ISO 8601 format in whole days (for example, <c>P30D</c> for 30 days or <c>P60D</c>
        /// for 60 days).
        /// </para>
        ///  
        /// <para>
        /// This field applies only when <c>PriceIncrease</c> is a <c>PercentageRange</c>. The
        /// field is <c>null</c> when <c>PriceIncrease</c> is a <c>FixedPercentage</c>, because
        /// the price increase is already fixed and there is nothing for the proposer to finalize.
        /// If the proposer doesn't finalize a value by the adjustment deadline, the <c>DefaultValue</c>
        /// of the range applies.
        /// </para>
        ///  
        /// <para>
        ///  <c>AdjustmentDeadline</c> must be greater than <c>LockoutPeriod</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=9)]
        public string AdjustmentDeadline
        {
            get { return this._adjustmentDeadline; }
            set { this._adjustmentDeadline = value; }
        }

        // Check to see if AdjustmentDeadline property is set
        internal bool IsSetAdjustmentDeadline()
        {
            return this._adjustmentDeadline != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Additional parameters specified by the acceptor while accepting the term.
        /// </para>
        /// </summary>
        public RenewalTermConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the term.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LockoutPeriod. 
        /// <para>
        /// The renewal decision deadline, measured back from the end date of the agreement. This
        /// is the last day either party can opt in to or opt out of the renewal. The duration
        /// is represented in the ISO 8601 format in whole days (for example, <c>P30D</c> for
        /// 30 days or <c>P60D</c> for 60 days).
        /// </para>
        ///  
        /// <para>
        /// The field is <c>null</c> when no renewal decision deadline is set. In that case, either
        /// party can change the auto-renewal decision up to the end date of the agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=9)]
        public string LockoutPeriod
        {
            get { return this._lockoutPeriod; }
            set { this._lockoutPeriod = value; }
        }

        // Check to see if LockoutPeriod property is set
        internal bool IsSetLockoutPeriod()
        {
            return this._lockoutPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRenewals. 
        /// <para>
        /// The maximum number of times the agreement can be renewed. The field is <c>null</c>
        /// when the number of renewals is unlimited.
        /// </para>
        ///  
        /// <para>
        /// After the agreement reaches this limit, it expires on its end date instead of renewing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxRenewals
        {
            get { return this._maxRenewals; }
            set { this._maxRenewals = value; }
        }

        // Check to see if MaxRenewals property is set
        internal bool IsSetMaxRenewals()
        {
            return this._maxRenewals.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PriceIncrease. 
        /// <para>
        /// The price increase that is applied each time the agreement renews. The field is <c>null</c>
        /// when the price doesn't change at renewal.
        /// </para>
        /// </summary>
        public PriceIncrease PriceIncrease
        {
            get { return this._priceIncrease; }
            set { this._priceIncrease = value; }
        }

        // Check to see if PriceIncrease property is set
        internal bool IsSetPriceIncrease()
        {
            return this._priceIncrease != null;
        }

        /// <summary>
        /// Gets and sets the property TermTemplates. 
        /// <para>
        /// Defines how specific terms change each time the agreement renews. The field is <c>null</c>
        /// when no terms change at renewal.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<TermTemplate> TermTemplates
        {
            get { return this._termTemplates; }
            set { this._termTemplates = value; }
        }

        // Check to see if TermTemplates property is set
        internal bool IsSetTermTemplates()
        {
            return this._termTemplates != null && (this._termTemplates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Category of the term being updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}