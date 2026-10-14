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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Specifies the hyperparameters and their default ranges. Hyperparameters can be categorical,
    /// continuous, or integer-valued.
    /// </summary>
    public partial class DefaultHyperParameterRanges
    {
        /// <summary>
        /// Gets and sets the property CategoricalHyperParameterRanges. 
        /// <para>
        /// The categorical hyperparameters and their default ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<DefaultCategoricalHyperParameterRange> CategoricalHyperParameterRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<DefaultCategoricalHyperParameterRange>() : null;

        /// <summary>
        /// Checks to see if the CategoricalHyperParameterRanges property is set.
        /// </summary>
        internal bool IsSetCategoricalHyperParameterRanges() => this.CategoricalHyperParameterRanges != null && (this.CategoricalHyperParameterRanges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContinuousHyperParameterRanges. 
        /// <para>
        /// The continuous hyperparameters and their default ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<DefaultContinuousHyperParameterRange> ContinuousHyperParameterRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<DefaultContinuousHyperParameterRange>() : null;

        /// <summary>
        /// Checks to see if the ContinuousHyperParameterRanges property is set.
        /// </summary>
        internal bool IsSetContinuousHyperParameterRanges() => this.ContinuousHyperParameterRanges != null && (this.ContinuousHyperParameterRanges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntegerHyperParameterRanges. 
        /// <para>
        /// The integer-valued hyperparameters and their default ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<DefaultIntegerHyperParameterRange> IntegerHyperParameterRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<DefaultIntegerHyperParameterRange>() : null;

        /// <summary>
        /// Checks to see if the IntegerHyperParameterRanges property is set.
        /// </summary>
        internal bool IsSetIntegerHyperParameterRanges() => this.IntegerHyperParameterRanges != null && (this.IntegerHyperParameterRanges.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
