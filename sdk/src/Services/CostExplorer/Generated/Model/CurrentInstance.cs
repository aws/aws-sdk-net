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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Context about the current instance.
    /// </summary>
    public partial class CurrentInstance
    {
        private string _currencyCode;
        private string _instanceName;
        private string _monthlyCost;
        private string _onDemandHoursInLookbackPeriod;
        private string _reservationCoveredHoursInLookbackPeriod;
        private ResourceDetails _resourceDetails;
        private string _resourceId;
        private ResourceUtilization _resourceUtilization;
        private string _savingsPlansCoveredHoursInLookbackPeriod;
        private List<TagValues> _tags = AWSConfigs.InitializeCollections ? new List<TagValues>() : null;
        private string _totalRunningHoursInLookbackPeriod;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code that Amazon Web Services used to calculate the costs for this instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name that you given an instance. This field shows as blank if you haven't given
        /// the instance a name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

        /// <summary>
        /// Gets and sets the property MonthlyCost. 
        /// <para>
        /// The current On-Demand cost of operating this instance on a monthly basis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string MonthlyCost
        {
            get { return this._monthlyCost; }
            set { this._monthlyCost = value; }
        }

        // Check to see if MonthlyCost property is set
        internal bool IsSetMonthlyCost()
        {
            return this._monthlyCost != null;
        }

        /// <summary>
        /// Gets and sets the property OnDemandHoursInLookbackPeriod. 
        /// <para>
        /// The number of hours during the lookback period that's billed at On-Demand rates.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string OnDemandHoursInLookbackPeriod
        {
            get { return this._onDemandHoursInLookbackPeriod; }
            set { this._onDemandHoursInLookbackPeriod = value; }
        }

        // Check to see if OnDemandHoursInLookbackPeriod property is set
        internal bool IsSetOnDemandHoursInLookbackPeriod()
        {
            return this._onDemandHoursInLookbackPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationCoveredHoursInLookbackPeriod. 
        /// <para>
        /// The number of hours during the lookback period that's covered by reservations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ReservationCoveredHoursInLookbackPeriod
        {
            get { return this._reservationCoveredHoursInLookbackPeriod; }
            set { this._reservationCoveredHoursInLookbackPeriod = value; }
        }

        // Check to see if ReservationCoveredHoursInLookbackPeriod property is set
        internal bool IsSetReservationCoveredHoursInLookbackPeriod()
        {
            return this._reservationCoveredHoursInLookbackPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceDetails. 
        /// <para>
        /// Details about the resource and utilization.
        /// </para>
        /// </summary>
        public ResourceDetails ResourceDetails
        {
            get { return this._resourceDetails; }
            set { this._resourceDetails = value; }
        }

        // Check to see if ResourceDetails property is set
        internal bool IsSetResourceDetails()
        {
            return this._resourceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// Resource ID of the current instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceUtilization. 
        /// <para>
        /// Utilization information of the current instance during the lookback period.
        /// </para>
        /// </summary>
        public ResourceUtilization ResourceUtilization
        {
            get { return this._resourceUtilization; }
            set { this._resourceUtilization = value; }
        }

        // Check to see if ResourceUtilization property is set
        internal bool IsSetResourceUtilization()
        {
            return this._resourceUtilization != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsPlansCoveredHoursInLookbackPeriod. 
        /// <para>
        /// The number of hours during the lookback period that's covered by Savings Plans.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SavingsPlansCoveredHoursInLookbackPeriod
        {
            get { return this._savingsPlansCoveredHoursInLookbackPeriod; }
            set { this._savingsPlansCoveredHoursInLookbackPeriod = value; }
        }

        // Check to see if SavingsPlansCoveredHoursInLookbackPeriod property is set
        internal bool IsSetSavingsPlansCoveredHoursInLookbackPeriod()
        {
            return this._savingsPlansCoveredHoursInLookbackPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Cost allocation resource tags that are applied to the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagValues> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalRunningHoursInLookbackPeriod. 
        /// <para>
        /// The total number of hours that the instance ran during the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string TotalRunningHoursInLookbackPeriod
        {
            get { return this._totalRunningHoursInLookbackPeriod; }
            set { this._totalRunningHoursInLookbackPeriod = value; }
        }

        // Check to see if TotalRunningHoursInLookbackPeriod property is set
        internal bool IsSetTotalRunningHoursInLookbackPeriod()
        {
            return this._totalRunningHoursInLookbackPeriod != null;
        }

    }
}