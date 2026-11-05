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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The status counts.
    /// </summary>
    public partial class StatusCounts
    {
        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// The number of checks that failed.
        /// </para>
        /// </summary>
        public int? Failed { get; set; }

        /// <summary>
        /// Checks to see if the Failed property is set.
        /// </summary>
        internal bool IsSetFailed() => this.Failed.HasValue;

        /// <summary>
        /// Gets and sets the property Passed. 
        /// <para>
        /// The number of checks that passed.
        /// </para>
        /// </summary>
        public int? Passed { get; set; }

        /// <summary>
        /// Checks to see if the Passed property is set.
        /// </summary>
        internal bool IsSetPassed() => this.Passed.HasValue;

        /// <summary>
        /// Gets and sets the property Skipped. 
        /// <para>
        /// The number of checks that were skipped.
        /// </para>
        /// </summary>
        public int? Skipped { get; set; }

        /// <summary>
        /// Checks to see if the Skipped property is set.
        /// </summary>
        internal bool IsSetSkipped() => this.Skipped.HasValue;
    }
}
