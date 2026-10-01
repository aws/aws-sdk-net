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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A union that identifies the location to instrument. Specify a <c>CodeLocation</c>
    /// for code-level instrumentation.
    /// </summary>
    public partial class Location
    {
        /// <summary>
        /// Gets and sets the property CodeLocation. 
        /// <para>
        /// A code location for code-level instrumentation, including language, code unit, class,
        /// method, file path, and optional line number.
        /// </para>
        /// </summary>
        public CodeLocation CodeLocation { get; set; }

        /// <summary>
        /// Checks to see if the CodeLocation property is set.
        /// </summary>
        internal bool IsSetCodeLocation() => this.CodeLocation != null;
    }
}
