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

namespace Amazon.TrustedAdvisor.Model
{
    /// <summary>
    /// Aggregation of Recommendation Resources
    /// </summary>
    public partial class RecommendationResourcesAggregates
    {
        /// <summary>
        /// Gets and sets the property ErrorCount. 
        /// <para>
        /// The number of AWS resources that were flagged to have errors according to the Trusted
        /// Advisor check
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ErrorCount { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCount property is set.
        /// </summary>
        internal bool IsSetErrorCount() => this.ErrorCount.HasValue;

        /// <summary>
        /// Gets and sets the property ExcludedCount. 
        /// <para>
        /// The number of AWS resources belonging to this Trusted Advisor check that were excluded
        /// by the customer
        /// </para>
        /// </summary>
        public long? ExcludedCount { get; set; }

        /// <summary>
        /// Checks to see if the ExcludedCount property is set.
        /// </summary>
        internal bool IsSetExcludedCount() => this.ExcludedCount.HasValue;

        /// <summary>
        /// Gets and sets the property OkCount. 
        /// <para>
        /// The number of AWS resources that were flagged to be OK according to the Trusted Advisor
        /// check
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? OkCount { get; set; }

        /// <summary>
        /// Checks to see if the OkCount property is set.
        /// </summary>
        internal bool IsSetOkCount() => this.OkCount.HasValue;

        /// <summary>
        /// Gets and sets the property WarningCount. 
        /// <para>
        /// The number of AWS resources that were flagged to have warning according to the Trusted
        /// Advisor check 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? WarningCount { get; set; }

        /// <summary>
        /// Checks to see if the WarningCount property is set.
        /// </summary>
        internal bool IsSetWarningCount() => this.WarningCount.HasValue;
    }
}
