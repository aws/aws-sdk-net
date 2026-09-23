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

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// Specifies the condition that streams must satisfy to be returned when you list streams
    /// (see the <c>ListStreams</c> API). A condition has a comparison operation and a value.
    /// Currently, you can specify only the <c>BEGINS_WITH</c> operator, which finds streams
    /// whose names start with a given prefix.
    /// </summary>
    public partial class StreamNameCondition
    {
        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// A comparison operator. Currently, you can specify only the <c>BEGINS_WITH</c> operator,
        /// which finds streams whose names start with a given prefix.
        /// </para>
        /// </summary>
        public ComparisonOperator ComparisonOperator { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonOperator property is set.
        /// </summary>
        internal bool IsSetComparisonOperator() => this.ComparisonOperator != null;

        /// <summary>
        /// Gets and sets the property ComparisonValue. 
        /// <para>
        /// A value to compare.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ComparisonValue { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonValue property is set.
        /// </summary>
        internal bool IsSetComparisonValue() => this.ComparisonValue != null;
    }
}
