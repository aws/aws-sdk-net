/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// <para>Reports the estimated monthly savings and percentage of monthly savings determined by the Trusted Advisor check for your account.
    /// </para>
    /// </summary>
    public class TrustedAdvisorCostOptimizingSummary
    {
        
        private double? estimatedMonthlySavings;
        private double? estimatedPercentMonthlySavings;

        /// <summary>
        /// Reports the estimated monthly savings determined by the Trusted Advisor check for your account.
        ///  
        /// </summary>
        public double EstimatedMonthlySavings
        {
            get { return this.estimatedMonthlySavings ?? default(double); }
            set { this.estimatedMonthlySavings = value; }
        }

        /// <summary>
        /// Sets the EstimatedMonthlySavings property
        /// </summary>
        /// <param name="estimatedMonthlySavings">The value to set for the EstimatedMonthlySavings property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorCostOptimizingSummary WithEstimatedMonthlySavings(double estimatedMonthlySavings)
        {
            this.estimatedMonthlySavings = estimatedMonthlySavings;
            return this;
        }
            

        // Check to see if EstimatedMonthlySavings property is set
        internal bool IsSetEstimatedMonthlySavings()
        {
            return this.estimatedMonthlySavings.HasValue;
        }

        /// <summary>
        /// Reports the estimated percentage of savings determined for your account by the Trusted Advisor check.
        ///  
        /// </summary>
        public double EstimatedPercentMonthlySavings
        {
            get { return this.estimatedPercentMonthlySavings ?? default(double); }
            set { this.estimatedPercentMonthlySavings = value; }
        }

        /// <summary>
        /// Sets the EstimatedPercentMonthlySavings property
        /// </summary>
        /// <param name="estimatedPercentMonthlySavings">The value to set for the EstimatedPercentMonthlySavings property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TrustedAdvisorCostOptimizingSummary WithEstimatedPercentMonthlySavings(double estimatedPercentMonthlySavings)
        {
            this.estimatedPercentMonthlySavings = estimatedPercentMonthlySavings;
            return this;
        }
            

        // Check to see if EstimatedPercentMonthlySavings property is set
        internal bool IsSetEstimatedPercentMonthlySavings()
        {
            return this.estimatedPercentMonthlySavings.HasValue;
        }
    }
}
