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
    /// Statistics for the control variant in an A/B test.
    /// </summary>
    public partial class ControlStats
    {
        private double? _mean;
        private int? _sampleSize;
        private string _variantName;

        /// <summary>
        /// Gets and sets the property Mean. 
        /// <para>
        /// The mean evaluation score for the control variant.
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
        /// Gets and sets the property SampleSize. 
        /// <para>
        /// The number of sessions evaluated for the control variant.
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
        /// The name of the control variant.
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