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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// The filter that specifies the billing groups and pricing plans to retrieve billing
    /// group information.
    /// </summary>
    public partial class ListBillingGroupsFilter
    {
        private List<string> _arns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _autoAssociate;
        private List<string> _billingGroupTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<StringSearch> _names = AWSConfigs.InitializeCollections ? new List<StringSearch>() : null;
        private string _pricingPlan;
        private List<string> _primaryAccountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _responsibilityTransferArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _statuses = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Arns. 
        /// <para>
        /// The list of billing group Amazon Resource Names (ARNs) to retrieve information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._arns != null && (this._arns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutoAssociate. 
        /// <para>
        /// Specifies if this billing group will automatically associate newly added Amazon Web
        /// Services accounts that join your consolidated billing family.
        /// </para>
        /// </summary>
        public bool? AutoAssociate
        {
            get { return this._autoAssociate; }
            set { this._autoAssociate = value; }
        }

        // Check to see if AutoAssociate property is set
        internal bool IsSetAutoAssociate()
        {
            return this._autoAssociate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BillingGroupTypes. 
        /// <para>
        ///  Filter billing groups by their type. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> BillingGroupTypes
        {
            get { return this._billingGroupTypes; }
            set { this._billingGroupTypes = value; }
        }

        // Check to see if BillingGroupTypes property is set
        internal bool IsSetBillingGroupTypes()
        {
            return this._billingGroupTypes != null && (this._billingGroupTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        ///  Filter billing groups by their names. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<StringSearch> Names
        {
            get { return this._names; }
            set { this._names = value; }
        }

        // Check to see if Names property is set
        internal bool IsSetNames()
        {
            return this._names != null && (this._names.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property PrimaryAccountIds. 
        /// <para>
        ///  A list of primary account IDs to filter the billing groups. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> PrimaryAccountIds
        {
            get { return this._primaryAccountIds; }
            set { this._primaryAccountIds = value; }
        }

        // Check to see if PrimaryAccountIds property is set
        internal bool IsSetPrimaryAccountIds()
        {
            return this._primaryAccountIds != null && (this._primaryAccountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResponsibilityTransferArns. 
        /// <para>
        ///  Filter billing groups by their responsibility transfer ARNs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public List<string> ResponsibilityTransferArns
        {
            get { return this._responsibilityTransferArns; }
            set { this._responsibilityTransferArns = value; }
        }

        // Check to see if ResponsibilityTransferArns property is set
        internal bool IsSetResponsibilityTransferArns()
        {
            return this._responsibilityTransferArns != null && (this._responsibilityTransferArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Statuses. 
        /// <para>
        ///  A list of billing groups to retrieve their current status for a specific time range
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._statuses != null && (this._statuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}