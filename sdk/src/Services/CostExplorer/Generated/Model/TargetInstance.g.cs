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
    /// Details on recommended instance.
    /// </summary>
    public partial class TargetInstance
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
        /// Gets and sets the property DefaultTargetInstance. 
        /// <para>
        /// Determines whether this recommendation is the defaulted Amazon Web Services recommendation.
        /// </para>
        /// </summary>
        public bool? DefaultTargetInstance { get; set; }

        /// <summary>
        /// Checks to see if the DefaultTargetInstance property is set.
        /// </summary>
        internal bool IsSetDefaultTargetInstance() => this.DefaultTargetInstance.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlyCost. 
        /// <para>
        /// The expected cost to operate this instance type on a monthly basis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedMonthlyCost { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMonthlyCost property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlyCost() => this.EstimatedMonthlyCost != null;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavings. 
        /// <para>
        /// The estimated savings that result from modification, on a monthly basis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedMonthlySavings { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMonthlySavings property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlySavings() => this.EstimatedMonthlySavings != null;

        /// <summary>
        /// Gets and sets the property ExpectedResourceUtilization. 
        /// <para>
        /// The expected utilization metrics for target instance type.
        /// </para>
        /// </summary>
        public ResourceUtilization ExpectedResourceUtilization { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedResourceUtilization property is set.
        /// </summary>
        internal bool IsSetExpectedResourceUtilization() => this.ExpectedResourceUtilization != null;

        /// <summary>
        /// Gets and sets the property PlatformDifferences. 
        /// <para>
        /// Explains the actions that you might need to take to successfully migrate your workloads
        /// from the current instance type to the recommended instance type. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PlatformDifferences { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PlatformDifferences property is set.
        /// </summary>
        internal bool IsSetPlatformDifferences() => this.PlatformDifferences != null && (this.PlatformDifferences.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceDetails. 
        /// <para>
        /// Details on the target instance type. 
        /// </para>
        /// </summary>
        public ResourceDetails ResourceDetails { get; set; }

        /// <summary>
        /// Checks to see if the ResourceDetails property is set.
        /// </summary>
        internal bool IsSetResourceDetails() => this.ResourceDetails != null;
    }
}
