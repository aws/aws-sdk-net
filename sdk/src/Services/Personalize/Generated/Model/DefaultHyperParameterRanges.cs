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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Specifies the hyperparameters and their default ranges. Hyperparameters can be categorical,
    /// continuous, or integer-valued.
    /// </summary>
    public partial class DefaultHyperParameterRanges
    {
        private List<DefaultCategoricalHyperParameterRange> _categoricalHyperParameterRanges = new List<DefaultCategoricalHyperParameterRange>();
        private List<DefaultContinuousHyperParameterRange> _continuousHyperParameterRanges = new List<DefaultContinuousHyperParameterRange>();
        private List<DefaultIntegerHyperParameterRange> _integerHyperParameterRanges = new List<DefaultIntegerHyperParameterRange>();

        /// <summary>
        /// Gets and sets the property CategoricalHyperParameterRanges. 
        /// <para>
        /// The categorical hyperparameters and their default ranges.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<DefaultCategoricalHyperParameterRange> CategoricalHyperParameterRanges
        {
            get { return this._categoricalHyperParameterRanges; }
            set { this._categoricalHyperParameterRanges = value; }
        }

        // Check to see if CategoricalHyperParameterRanges property is set
        internal bool IsSetCategoricalHyperParameterRanges()
        {
            return this._categoricalHyperParameterRanges != null && this._categoricalHyperParameterRanges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ContinuousHyperParameterRanges. 
        /// <para>
        /// The continuous hyperparameters and their default ranges.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<DefaultContinuousHyperParameterRange> ContinuousHyperParameterRanges
        {
            get { return this._continuousHyperParameterRanges; }
            set { this._continuousHyperParameterRanges = value; }
        }

        // Check to see if ContinuousHyperParameterRanges property is set
        internal bool IsSetContinuousHyperParameterRanges()
        {
            return this._continuousHyperParameterRanges != null && this._continuousHyperParameterRanges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IntegerHyperParameterRanges. 
        /// <para>
        /// The integer-valued hyperparameters and their default ranges.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<DefaultIntegerHyperParameterRange> IntegerHyperParameterRanges
        {
            get { return this._integerHyperParameterRanges; }
            set { this._integerHyperParameterRanges = value; }
        }

        // Check to see if IntegerHyperParameterRanges property is set
        internal bool IsSetIntegerHyperParameterRanges()
        {
            return this._integerHyperParameterRanges != null && this._integerHyperParameterRanges.Count > 0; 
        }

    }
}