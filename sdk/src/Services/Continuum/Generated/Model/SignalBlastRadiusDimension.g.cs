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
    /// The assessed blast-radius dimension with the basis behind it.
    /// </summary>
    public partial class SignalBlastRadiusDimension
    {
        /// <summary>
        /// Gets and sets the property Basis. Where the producer's determination came from.
        /// </summary>
        public SignalBasis Basis { get; set; }

        /// <summary>
        /// Checks to see if the Basis property is set.
        /// </summary>
        internal bool IsSetBasis() => this.Basis != null;

        /// <summary>
        /// Gets and sets the property MissingInfo. What the producer could not determine, when
        /// anything was missing.
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string MissingInfo { get; set; }

        /// <summary>
        /// Checks to see if the MissingInfo property is set.
        /// </summary>
        internal bool IsSetMissingInfo() => this.MissingInfo != null;

        /// <summary>
        /// Gets and sets the property Reason. The producer's explanation.
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property Value. How far the consequences reach. Absent when the
        /// producer reported a value with no mapping yet.
        /// </summary>
        public SignalBlastRadius Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
