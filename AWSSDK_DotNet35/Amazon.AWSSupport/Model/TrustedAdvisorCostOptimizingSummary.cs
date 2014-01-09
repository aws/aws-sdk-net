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
    /// <para>The estimated cost savings that might be realized if the recommended actions are taken.</para>
    /// </summary>
    public class TrustedAdvisorCostOptimizingSummary
    {
        
        private double? estimatedMonthlySavings;
        private double? estimatedPercentMonthlySavings;


        /// <summary>
        /// The estimated monthly savings that might be realized if the recommended actions are taken.
        ///  
        /// </summary>
        public double EstimatedMonthlySavings
        {
            get { return this.estimatedMonthlySavings ?? default(double); }
            set { this.estimatedMonthlySavings = value; }
        }

        // Check to see if EstimatedMonthlySavings property is set
        internal bool IsSetEstimatedMonthlySavings()
        {
            return this.estimatedMonthlySavings.HasValue;
        }

        /// <summary>
        /// The estimated percentage of savings that might be realized if the recommended actions are taken.
        ///  
        /// </summary>
        public double EstimatedPercentMonthlySavings
        {
            get { return this.estimatedPercentMonthlySavings ?? default(double); }
            set { this.estimatedPercentMonthlySavings = value; }
        }

        // Check to see if EstimatedPercentMonthlySavings property is set
        internal bool IsSetEstimatedPercentMonthlySavings()
        {
            return this.estimatedPercentMonthlySavings.HasValue;
        }
    }
}
