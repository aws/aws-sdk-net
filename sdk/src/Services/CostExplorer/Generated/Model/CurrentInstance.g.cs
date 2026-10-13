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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code that Amazon Web Services used to calculate the costs for this instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name that you given an instance. This field shows as blank if you haven't given
        /// the instance a name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceName property is set.
        /// </summary>
        internal bool IsSetInstanceName() => this.InstanceName != null;

        /// <summary>
        /// Gets and sets the property MonthlyCost. 
        /// <para>
        /// The current On-Demand cost of operating this instance on a monthly basis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string MonthlyCost { get; set; }

        /// <summary>
        /// Checks to see if the MonthlyCost property is set.
        /// </summary>
        internal bool IsSetMonthlyCost() => this.MonthlyCost != null;

        /// <summary>
        /// Gets and sets the property OnDemandHoursInLookbackPeriod. 
        /// <para>
        /// The number of hours during the lookback period that's billed at On-Demand rates.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string OnDemandHoursInLookbackPeriod { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandHoursInLookbackPeriod property is set.
        /// </summary>
        internal bool IsSetOnDemandHoursInLookbackPeriod() => this.OnDemandHoursInLookbackPeriod != null;

        /// <summary>
        /// Gets and sets the property ReservationCoveredHoursInLookbackPeriod. 
        /// <para>
        /// The number of hours during the lookback period that's covered by reservations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ReservationCoveredHoursInLookbackPeriod { get; set; }

        /// <summary>
        /// Checks to see if the ReservationCoveredHoursInLookbackPeriod property is set.
        /// </summary>
        internal bool IsSetReservationCoveredHoursInLookbackPeriod() => this.ReservationCoveredHoursInLookbackPeriod != null;

        /// <summary>
        /// Gets and sets the property ResourceDetails. 
        /// <para>
        /// Details about the resource and utilization.
        /// </para>
        /// </summary>
        public ResourceDetails ResourceDetails { get; set; }

        /// <summary>
        /// Checks to see if the ResourceDetails property is set.
        /// </summary>
        internal bool IsSetResourceDetails() => this.ResourceDetails != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// Resource ID of the current instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceUtilization. 
        /// <para>
        /// Utilization information of the current instance during the lookback period.
        /// </para>
        /// </summary>
        public ResourceUtilization ResourceUtilization { get; set; }

        /// <summary>
        /// Checks to see if the ResourceUtilization property is set.
        /// </summary>
        internal bool IsSetResourceUtilization() => this.ResourceUtilization != null;

        /// <summary>
        /// Gets and sets the property SavingsPlansCoveredHoursInLookbackPeriod. 
        /// <para>
        /// The number of hours during the lookback period that's covered by Savings Plans.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string SavingsPlansCoveredHoursInLookbackPeriod { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlansCoveredHoursInLookbackPeriod property is set.
        /// </summary>
        internal bool IsSetSavingsPlansCoveredHoursInLookbackPeriod() => this.SavingsPlansCoveredHoursInLookbackPeriod != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Cost allocation resource tags that are applied to the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagValues> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<TagValues>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalRunningHoursInLookbackPeriod. 
        /// <para>
        /// The total number of hours that the instance ran during the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TotalRunningHoursInLookbackPeriod { get; set; }

        /// <summary>
        /// Checks to see if the TotalRunningHoursInLookbackPeriod property is set.
        /// </summary>
        internal bool IsSetTotalRunningHoursInLookbackPeriod() => this.TotalRunningHoursInLookbackPeriod != null;
    }
}
