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
    /// A value used in filter comparisons, supporting different data types.
    /// </summary>
    public partial class FilterValue
    {
        /// <summary>
        /// Gets and sets the property BooleanValue. 
        /// <para>
        /// A boolean value for true/false filtering conditions.
        /// </para>
        /// </summary>
        public bool? BooleanValue { get; set; }

        /// <summary>
        /// Checks to see if the BooleanValue property is set.
        /// </summary>
        internal bool IsSetBooleanValue() => this.BooleanValue.HasValue;

        /// <summary>
        /// Gets and sets the property DoubleValue. 
        /// <para>
        /// A numeric value for numerical filtering and comparisons.
        /// </para>
        /// </summary>
        public double? DoubleValue { get; set; }

        /// <summary>
        /// Checks to see if the DoubleValue property is set.
        /// </summary>
        internal bool IsSetDoubleValue() => this.DoubleValue.HasValue;

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// A string value for text-based filtering.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;
    }
}
