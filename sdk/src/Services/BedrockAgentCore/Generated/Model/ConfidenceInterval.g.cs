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
    /// A confidence interval for a statistical measurement.
    /// </summary>
    public partial class ConfidenceInterval
    {
        /// <summary>
        /// Gets and sets the property Lower. 
        /// <para>
        /// The lower bound of the confidence interval.
        /// </para>
        /// </summary>
        public double? Lower { get; set; }

        /// <summary>
        /// Checks to see if the Lower property is set.
        /// </summary>
        internal bool IsSetLower() => this.Lower.HasValue;

        /// <summary>
        /// Gets and sets the property Upper. 
        /// <para>
        /// The upper bound of the confidence interval.
        /// </para>
        /// </summary>
        public double? Upper { get; set; }

        /// <summary>
        /// Checks to see if the Upper property is set.
        /// </summary>
        internal bool IsSetUpper() => this.Upper.HasValue;
    }
}
