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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Range of area under curve (auc) expected from the model. A range greater than 0.1
    /// indicates higher model uncertainity. A range is the difference between upper and lower
    /// bound of auc.
    /// </summary>
    public partial class UncertaintyRange
    {
        /// <summary>
        /// Gets and sets the property LowerBoundValue. 
        /// <para>
        ///  The lower bound value of the area under curve (auc). 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public float? LowerBoundValue { get; set; }

        /// <summary>
        /// Checks to see if the LowerBoundValue property is set.
        /// </summary>
        internal bool IsSetLowerBoundValue() => this.LowerBoundValue.HasValue;

        /// <summary>
        /// Gets and sets the property UpperBoundValue. 
        /// <para>
        ///  The upper bound value of the area under curve (auc). 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public float? UpperBoundValue { get; set; }

        /// <summary>
        /// Checks to see if the UpperBoundValue property is set.
        /// </summary>
        internal bool IsSetUpperBoundValue() => this.UpperBoundValue.HasValue;
    }
}
