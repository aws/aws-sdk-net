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

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// The threshold used with a non-aggregate check expression. The non-aggregate check
    /// expression will be applied to each row in a specific column. Then the threshold will
    /// be used to determine whether the validation succeeds.
    /// </summary>
    public partial class Threshold
    {
        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of a threshold. Used for comparison of an actual count of rows that satisfy
        /// the rule to the threshold value.
        /// </para>
        /// </summary>
        public ThresholdType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// Unit of threshold value. Can be either a COUNT or PERCENTAGE of the full sample size
        /// used for validation.
        /// </para>
        /// </summary>
        public ThresholdUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of a threshold.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public double? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
