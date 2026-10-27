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

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// Input structure for Cloud Removal Operation type
    /// </summary>
    public partial class CloudRemovalConfigInput
    {
        /// <summary>
        /// Gets and sets the property AlgorithmName. 
        /// <para>
        /// The name of the algorithm used for cloud removal.
        /// </para>
        /// </summary>
        public AlgorithmNameCloudRemoval AlgorithmName { get; set; }

        /// <summary>
        /// Checks to see if the AlgorithmName property is set.
        /// </summary>
        internal bool IsSetAlgorithmName() => this.AlgorithmName != null;

        /// <summary>
        /// Gets and sets the property InterpolationValue. 
        /// <para>
        /// The interpolation value you provide for cloud removal.
        /// </para>
        /// </summary>
        public string InterpolationValue { get; set; }

        /// <summary>
        /// Checks to see if the InterpolationValue property is set.
        /// </summary>
        internal bool IsSetInterpolationValue() => this.InterpolationValue != null;

        /// <summary>
        /// Gets and sets the property TargetBands. 
        /// <para>
        /// TargetBands to be returned in the output of CloudRemoval operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> TargetBands { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TargetBands property is set.
        /// </summary>
        internal bool IsSetTargetBands() => this.TargetBands != null && (this.TargetBands.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
