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

namespace Amazon.XRay.Model
{
    /// <summary>
    /// The indexing rule configuration for probabilistic sampling.
    /// </summary>
    public partial class ProbabilisticRuleValue
    {
        /// <summary>
        /// Gets and sets the property ActualSamplingPercentage. 
        /// <para>
        ///  Applied sampling percentage of traceIds. 
        /// </para>
        /// </summary>
        public double? ActualSamplingPercentage { get; set; }

        /// <summary>
        /// Checks to see if the ActualSamplingPercentage property is set.
        /// </summary>
        internal bool IsSetActualSamplingPercentage() => this.ActualSamplingPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property DesiredSamplingPercentage. 
        /// <para>
        ///  Configured sampling percentage of traceIds. Note that sampling can be subject to
        /// limits to ensure completeness of data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? DesiredSamplingPercentage { get; set; }

        /// <summary>
        /// Checks to see if the DesiredSamplingPercentage property is set.
        /// </summary>
        internal bool IsSetDesiredSamplingPercentage() => this.DesiredSamplingPercentage.HasValue;
    }
}
