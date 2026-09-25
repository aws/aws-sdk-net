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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// A position in a policy.
    /// </summary>
    public partial class Position
    {
        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column of the position, starting from 0.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Column { get; set; }

        /// <summary>
        /// Checks to see if the Column property is set.
        /// </summary>
        internal bool IsSetColumn() => this.Column.HasValue;

        /// <summary>
        /// Gets and sets the property Line. 
        /// <para>
        /// The line of the position, starting from 1.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Line { get; set; }

        /// <summary>
        /// Checks to see if the Line property is set.
        /// </summary>
        internal bool IsSetLine() => this.Line.HasValue;

        /// <summary>
        /// Gets and sets the property Offset. 
        /// <para>
        /// The offset within the policy that corresponds to the position, starting from 0.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Offset { get; set; }

        /// <summary>
        /// Checks to see if the Offset property is set.
        /// </summary>
        internal bool IsSetOffset() => this.Offset.HasValue;
    }
}
