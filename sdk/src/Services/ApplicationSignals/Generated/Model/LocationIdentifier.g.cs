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
    /// Union type for identifying an instrumentation configuration by code location or locationHash.
    /// Used in Get/Delete/GetStatus operations to allow flexible identification.
    /// </summary>
    public partial class LocationIdentifier
    {
        /// <summary>
        /// Gets and sets the property CodeLocation. The full code location specification (will
        /// be hashed internally)
        /// </summary>
        public CodeLocation CodeLocation { get; set; }

        /// <summary>
        /// Checks to see if the CodeLocation property is set.
        /// </summary>
        internal bool IsSetCodeLocation() => this.CodeLocation != null;

        /// <summary>
        /// Gets and sets the property LocationHash. The pre-computed location hash (16-character
        /// hex string)
        /// </summary>
        [AWSProperty(Min = 16, Max = 16)]
        public string LocationHash { get; set; }

        /// <summary>
        /// Checks to see if the LocationHash property is set.
        /// </summary>
        internal bool IsSetLocationHash() => this.LocationHash != null;
    }
}
