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

namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// A set of conditions that specify which recommended action qualify for implementation.
    /// When a rule is active and a recommended action matches these criteria, Compute Optimizer
    /// implements the action at the scheduled run time. You can specify up to 20 conditions
    /// per filter criteria and 20 values per condition.
    /// </summary>
    public partial class Criteria
    {
        /// <summary>
        /// Gets and sets the property EbsVolumeSizeInGib. 
        /// <para>
        /// Filter criteria for EBS volume sizes in gibibytes (GiB).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IntegerCriteriaCondition> EbsVolumeSizeInGib { get; set; } = AWSConfigs.InitializeCollections ? new List<IntegerCriteriaCondition>() : null;

        /// <summary>
        /// Checks to see if the EbsVolumeSizeInGib property is set.
        /// </summary>
        internal bool IsSetEbsVolumeSizeInGib() => this.EbsVolumeSizeInGib != null && (this.EbsVolumeSizeInGib.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EbsVolumeType. 
        /// <para>
        /// Filter criteria for EBS volume types, such as gp2, gp3, io1, io2, st1, or sc1.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringCriteriaCondition> EbsVolumeType { get; set; } = AWSConfigs.InitializeCollections ? new List<StringCriteriaCondition>() : null;

        /// <summary>
        /// Checks to see if the EbsVolumeType property is set.
        /// </summary>
        internal bool IsSetEbsVolumeType() => this.EbsVolumeType != null && (this.EbsVolumeType.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavings. 
        /// <para>
        /// Filter criteria for estimated monthly cost savings from the recommended action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DoubleCriteriaCondition> EstimatedMonthlySavings { get; set; } = AWSConfigs.InitializeCollections ? new List<DoubleCriteriaCondition>() : null;

        /// <summary>
        /// Checks to see if the EstimatedMonthlySavings property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlySavings() => this.EstimatedMonthlySavings != null && (this.EstimatedMonthlySavings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LookBackPeriodInDays. 
        /// <para>
        /// Filter criteria for the lookback period in days used to analyze resource utilization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IntegerCriteriaCondition> LookBackPeriodInDays { get; set; } = AWSConfigs.InitializeCollections ? new List<IntegerCriteriaCondition>() : null;

        /// <summary>
        /// Checks to see if the LookBackPeriodInDays property is set.
        /// </summary>
        internal bool IsSetLookBackPeriodInDays() => this.LookBackPeriodInDays != null && (this.LookBackPeriodInDays.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Filter criteria for Amazon Web Services regions where resources must be located.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringCriteriaCondition> Region { get; set; } = AWSConfigs.InitializeCollections ? new List<StringCriteriaCondition>() : null;

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null && (this.Region.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Filter criteria for specific resource ARNs to include or exclude.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringCriteriaCondition> ResourceArn { get; set; } = AWSConfigs.InitializeCollections ? new List<StringCriteriaCondition>() : null;

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null && (this.ResourceArn.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceTag. 
        /// <para>
        /// Filter criteria for resource tags, allowing filtering by tag key and value combinations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceTagsCriteriaCondition> ResourceTag { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceTagsCriteriaCondition>() : null;

        /// <summary>
        /// Checks to see if the ResourceTag property is set.
        /// </summary>
        internal bool IsSetResourceTag() => this.ResourceTag != null && (this.ResourceTag.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RestartNeeded. 
        /// <para>
        /// Filter criteria indicating whether the recommended action requires a resource restart.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StringCriteriaCondition> RestartNeeded { get; set; } = AWSConfigs.InitializeCollections ? new List<StringCriteriaCondition>() : null;

        /// <summary>
        /// Checks to see if the RestartNeeded property is set.
        /// </summary>
        internal bool IsSetRestartNeeded() => this.RestartNeeded != null && (this.RestartNeeded.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
