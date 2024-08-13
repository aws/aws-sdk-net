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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
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
namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// The estimated cost savings that might be realized if the recommended operations are
    /// taken.
    /// </summary>
    public partial class TrustedAdvisorCostOptimizingSummary
    {
        private double? _estimatedMonthlySavings;
        private double? _estimatedPercentMonthlySavings;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavings. 
        /// <para>
        /// The estimated monthly savings that might be realized if the recommended operations
        /// are taken.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? EstimatedMonthlySavings
        {
            get { return this._estimatedMonthlySavings; }
            set { this._estimatedMonthlySavings = value; }
        }

        // Check to see if EstimatedMonthlySavings property is set
        internal bool IsSetEstimatedMonthlySavings()
        {
            return this._estimatedMonthlySavings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedPercentMonthlySavings. 
        /// <para>
        /// The estimated percentage of savings that might be realized if the recommended operations
        /// are taken.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? EstimatedPercentMonthlySavings
        {
            get { return this._estimatedPercentMonthlySavings; }
            set { this._estimatedPercentMonthlySavings = value; }
        }

        // Check to see if EstimatedPercentMonthlySavings property is set
        internal bool IsSetEstimatedPercentMonthlySavings()
        {
            return this._estimatedPercentMonthlySavings.HasValue; 
        }

    }
}