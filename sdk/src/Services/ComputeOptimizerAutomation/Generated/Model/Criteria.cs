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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
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
        private List<IntegerCriteriaCondition> _ebsVolumeSizeInGib = AWSConfigs.InitializeCollections ? new List<IntegerCriteriaCondition>() : null;
        private List<StringCriteriaCondition> _ebsVolumeType = AWSConfigs.InitializeCollections ? new List<StringCriteriaCondition>() : null;
        private List<DoubleCriteriaCondition> _estimatedMonthlySavings = AWSConfigs.InitializeCollections ? new List<DoubleCriteriaCondition>() : null;
        private List<IntegerCriteriaCondition> _lookBackPeriodInDays = AWSConfigs.InitializeCollections ? new List<IntegerCriteriaCondition>() : null;
        private List<StringCriteriaCondition> _region = AWSConfigs.InitializeCollections ? new List<StringCriteriaCondition>() : null;
        private List<StringCriteriaCondition> _resourceArn = AWSConfigs.InitializeCollections ? new List<StringCriteriaCondition>() : null;
        private List<ResourceTagsCriteriaCondition> _resourceTag = AWSConfigs.InitializeCollections ? new List<ResourceTagsCriteriaCondition>() : null;
        private List<StringCriteriaCondition> _restartNeeded = AWSConfigs.InitializeCollections ? new List<StringCriteriaCondition>() : null;

        /// <summary>
        /// Gets and sets the property EbsVolumeSizeInGib. 
        /// <para>
        /// Filter criteria for EBS volume sizes in gibibytes (GiB).
        /// </para>
        /// </summary>
        public List<IntegerCriteriaCondition> EbsVolumeSizeInGib
        {
            get { return this._ebsVolumeSizeInGib; }
            set { this._ebsVolumeSizeInGib = value; }
        }

        // Check to see if EbsVolumeSizeInGib property is set
        internal bool IsSetEbsVolumeSizeInGib()
        {
            return this._ebsVolumeSizeInGib != null && (this._ebsVolumeSizeInGib.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EbsVolumeType. 
        /// <para>
        /// Filter criteria for EBS volume types, such as gp2, gp3, io1, io2, st1, or sc1.
        /// </para>
        /// </summary>
        public List<StringCriteriaCondition> EbsVolumeType
        {
            get { return this._ebsVolumeType; }
            set { this._ebsVolumeType = value; }
        }

        // Check to see if EbsVolumeType property is set
        internal bool IsSetEbsVolumeType()
        {
            return this._ebsVolumeType != null && (this._ebsVolumeType.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavings. 
        /// <para>
        /// Filter criteria for estimated monthly cost savings from the recommended action.
        /// </para>
        /// </summary>
        public List<DoubleCriteriaCondition> EstimatedMonthlySavings
        {
            get { return this._estimatedMonthlySavings; }
            set { this._estimatedMonthlySavings = value; }
        }

        // Check to see if EstimatedMonthlySavings property is set
        internal bool IsSetEstimatedMonthlySavings()
        {
            return this._estimatedMonthlySavings != null && (this._estimatedMonthlySavings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LookBackPeriodInDays. 
        /// <para>
        /// Filter criteria for the lookback period in days used to analyze resource utilization.
        /// </para>
        /// </summary>
        public List<IntegerCriteriaCondition> LookBackPeriodInDays
        {
            get { return this._lookBackPeriodInDays; }
            set { this._lookBackPeriodInDays = value; }
        }

        // Check to see if LookBackPeriodInDays property is set
        internal bool IsSetLookBackPeriodInDays()
        {
            return this._lookBackPeriodInDays != null && (this._lookBackPeriodInDays.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Filter criteria for Amazon Web Services regions where resources must be located.
        /// </para>
        /// </summary>
        public List<StringCriteriaCondition> Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null && (this._region.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Filter criteria for specific resource ARNs to include or exclude.
        /// </para>
        /// </summary>
        public List<StringCriteriaCondition> ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null && (this._resourceArn.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceTag. 
        /// <para>
        /// Filter criteria for resource tags, allowing filtering by tag key and value combinations.
        /// </para>
        /// </summary>
        public List<ResourceTagsCriteriaCondition> ResourceTag
        {
            get { return this._resourceTag; }
            set { this._resourceTag = value; }
        }

        // Check to see if ResourceTag property is set
        internal bool IsSetResourceTag()
        {
            return this._resourceTag != null && (this._resourceTag.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RestartNeeded. 
        /// <para>
        /// Filter criteria indicating whether the recommended action requires a resource restart.
        /// </para>
        /// </summary>
        public List<StringCriteriaCondition> RestartNeeded
        {
            get { return this._restartNeeded; }
            set { this._restartNeeded = value; }
        }

        // Check to see if RestartNeeded property is set
        internal bool IsSetRestartNeeded()
        {
            return this._restartNeeded != null && (this._restartNeeded.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}