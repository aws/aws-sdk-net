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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// A code citation supporting a validation verdict.
    /// </summary>
    public partial class FindingEvidence
    {
        /// <summary>
        /// Gets and sets the property File. The file the evidence was found in.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string File { get; set; }

        /// <summary>
        /// Checks to see if the File property is set.
        /// </summary>
        internal bool IsSetFile() => this.File != null;

        /// <summary>
        /// Gets and sets the property Line. The 1-indexed line, when known.
        /// </summary>
        public int? Line { get; set; }

        /// <summary>
        /// Checks to see if the Line property is set.
        /// </summary>
        internal bool IsSetLine() => this.Line.HasValue;

        /// <summary>
        /// Gets and sets the property Snippet. The cited excerpt.
        /// </summary>
        [AWSProperty(Min = 1, Max = 32768)]
        public string Snippet { get; set; }

        /// <summary>
        /// Checks to see if the Snippet property is set.
        /// </summary>
        internal bool IsSetSnippet() => this.Snippet != null;
    }
}
