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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
        private double? _absoluteChange;
        private ConfidenceInterval _confidenceInterval;
        private bool? _isSignificant;
        private double? _mean;
        private double? _percentChange;
        private double? _pValue;
        private int? _sampleSize;
        private string _variantName;

        /// <summary>
        /// Gets and sets the property AbsoluteChange. 
        /// <para>
        /// The absolute change in mean score compared to the control variant.
        /// </para>
        /// </summary>
        public double? AbsoluteChange
        {
            get { return this._absoluteChange; }
            set { this._absoluteChange = value; }
        }

        // Check to see if AbsoluteChange property is set
        internal bool IsSetAbsoluteChange()
        {
            return this._absoluteChange.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConfidenceInterval. 
        /// <para>
        /// The confidence interval for the observed difference.
        /// </para>
        /// </summary>
        public ConfidenceInterval ConfidenceInterval
        {
            get { return this._confidenceInterval; }
            set { this._confidenceInterval = value; }
        }

        // Check to see if ConfidenceInterval property is set
        internal bool IsSetConfidenceInterval()
        {
            return this._confidenceInterval != null;
        }

        /// <summary>
        /// Gets and sets the property IsSignificant. 
        /// <para>
        /// Whether the observed difference is statistically significant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsSignificant
        {
            get { return this._isSignificant; }
            set { this._isSignificant = value; }
        }

        // Check to see if IsSignificant property is set
        internal bool IsSetIsSignificant()
        {
            return this._isSignificant.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mean. 
        /// <para>
        /// The mean evaluation score for this variant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? Mean
        {
            get { return this._mean; }
            set { this._mean = value; }
        }

        // Check to see if Mean property is set
        internal bool IsSetMean()
        {
            return this._mean.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PercentChange. 
        /// <para>
        /// The percentage change in mean score compared to the control variant.
        /// </para>
        /// </summary>
        public double? PercentChange
        {
            get { return this._percentChange; }
            set { this._percentChange = value; }
        }

        // Check to see if PercentChange property is set
        internal bool IsSetPercentChange()
        {
            return this._percentChange.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PValue. 
        /// <para>
        /// The p-value indicating the statistical significance of the observed difference.
        /// </para>
        /// </summary>
        public double? PValue
        {
            get { return this._pValue; }
            set { this._pValue = value; }
        }

        // Check to see if PValue property is set
        internal bool IsSetPValue()
        {
            return this._pValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SampleSize. 
        /// <para>
        /// The number of sessions evaluated for this variant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? SampleSize
        {
            get { return this._sampleSize; }
            set { this._sampleSize = value; }
        }

        // Check to see if SampleSize property is set
        internal bool IsSetSampleSize()
        {
            return this._sampleSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VariantName. 
        /// <para>
        /// The name of the treatment variant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VariantName
        {
            get { return this._variantName; }
            set { this._variantName = value; }
        }

        // Check to see if VariantName property is set
        internal bool IsSetVariantName()
        {
            return this._variantName != null;
        }

    }
}