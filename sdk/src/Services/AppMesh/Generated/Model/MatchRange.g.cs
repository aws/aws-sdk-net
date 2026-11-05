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

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents the range of values to match on. The first character of
    /// the range is included in the range, though the last character is not. For example,
    /// if the range specified were 1-100, only values 1-99 would be matched.
    /// </summary>
    public partial class MatchRange
    {
        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The end of the range.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? End { get; set; }

        /// <summary>
        /// Checks to see if the End property is set.
        /// </summary>
        internal bool IsSetEnd() => this.End.HasValue;

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// The start of the range.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? Start { get; set; }

        /// <summary>
        /// Checks to see if the Start property is set.
        /// </summary>
        internal bool IsSetStart() => this.Start.HasValue;
    }
}
