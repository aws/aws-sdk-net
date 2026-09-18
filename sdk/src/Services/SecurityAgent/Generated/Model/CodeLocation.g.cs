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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Represents a location in source code associated with a security finding.
    /// </summary>
    public partial class CodeLocation
    {
        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The absolute path to the file containing the code location.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FilePath { get; set; }

        /// <summary>
        /// Checks to see if the FilePath property is set.
        /// </summary>
        internal bool IsSetFilePath() => this.FilePath != null;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The role of this location in the vulnerability, such as source or sink.
        /// </para>
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property LineEnd. 
        /// <para>
        /// The ending line number of the code location.
        /// </para>
        /// </summary>
        public int? LineEnd { get; set; }

        /// <summary>
        /// Checks to see if the LineEnd property is set.
        /// </summary>
        internal bool IsSetLineEnd() => this.LineEnd.HasValue;

        /// <summary>
        /// Gets and sets the property LineStart. 
        /// <para>
        /// The starting line number of the code location.
        /// </para>
        /// </summary>
        public int? LineStart { get; set; }

        /// <summary>
        /// Checks to see if the LineStart property is set.
        /// </summary>
        internal bool IsSetLineStart() => this.LineStart.HasValue;
    }
}
