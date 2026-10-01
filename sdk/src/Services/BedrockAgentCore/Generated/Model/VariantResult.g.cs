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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Statistical results for a treatment variant compared against the control.
    /// </summary>
    public partial class VariantResult
    {
        /// <summary>
        /// Gets and sets the property AbsoluteChange. 
        /// <para>
        /// The absolute change in mean score compared to the control variant.
        /// </para>
        /// </summary>
        public double? AbsoluteChange { get; set; }

        /// <summary>
        /// Checks to see if the AbsoluteChange property is set.
        /// </summary>
        internal bool IsSetAbsoluteChange() => this.AbsoluteChange.HasValue;

        /// <summary>
        /// Gets and sets the property ConfidenceInterval. 
        /// <para>
        /// The confidence interval for the observed difference.
        /// </para>
        /// </summary>
        public ConfidenceInterval ConfidenceInterval { get; set; }

        /// <summary>
        /// Checks to see if the ConfidenceInterval property is set.
        /// </summary>
        internal bool IsSetConfidenceInterval() => this.ConfidenceInterval != null;

        /// <summary>
        /// Gets and sets the property IsSignificant. 
        /// <para>
        /// Whether the observed difference is statistically significant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsSignificant { get; set; }

        /// <summary>
        /// Checks to see if the IsSignificant property is set.
        /// </summary>
        internal bool IsSetIsSignificant() => this.IsSignificant.HasValue;

        /// <summary>
        /// Gets and sets the property Mean. 
        /// <para>
        /// The mean evaluation score for this variant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? Mean { get; set; }

        /// <summary>
        /// Checks to see if the Mean property is set.
        /// </summary>
        internal bool IsSetMean() => this.Mean.HasValue;

        /// <summary>
        /// Gets and sets the property PValue. 
        /// <para>
        /// The p-value indicating the statistical significance of the observed difference.
        /// </para>
        /// </summary>
        public double? PValue { get; set; }

        /// <summary>
        /// Checks to see if the PValue property is set.
        /// </summary>
        internal bool IsSetPValue() => this.PValue.HasValue;

        /// <summary>
        /// Gets and sets the property PercentChange. 
        /// <para>
        /// The percentage change in mean score compared to the control variant.
        /// </para>
        /// </summary>
        public double? PercentChange { get; set; }

        /// <summary>
        /// Checks to see if the PercentChange property is set.
        /// </summary>
        internal bool IsSetPercentChange() => this.PercentChange.HasValue;

        /// <summary>
        /// Gets and sets the property SampleSize. 
        /// <para>
        /// The number of sessions evaluated for this variant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? SampleSize { get; set; }

        /// <summary>
        /// Checks to see if the SampleSize property is set.
        /// </summary>
        internal bool IsSetSampleSize() => this.SampleSize.HasValue;

        /// <summary>
        /// Gets and sets the property VariantName. 
        /// <para>
        /// The name of the treatment variant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VariantName { get; set; }

        /// <summary>
        /// Checks to see if the VariantName property is set.
        /// </summary>
        internal bool IsSetVariantName() => this.VariantName != null;
    }
}
