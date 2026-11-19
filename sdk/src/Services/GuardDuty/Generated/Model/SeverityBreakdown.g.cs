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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains the number of findings at each severity level.
    /// </summary>
    public partial class SeverityBreakdown
    {
        /// <summary>
        /// Gets and sets the property Critical. 
        /// <para>
        /// The number of findings that have Critical severity.
        /// </para>
        /// </summary>
        public int? Critical { get; set; }

        /// <summary>
        /// Checks to see if the Critical property is set.
        /// </summary>
        internal bool IsSetCritical() => this.Critical.HasValue;

        /// <summary>
        /// Gets and sets the property High. 
        /// <para>
        /// The number of findings that have High severity.
        /// </para>
        /// </summary>
        public int? High { get; set; }

        /// <summary>
        /// Checks to see if the High property is set.
        /// </summary>
        internal bool IsSetHigh() => this.High.HasValue;

        /// <summary>
        /// Gets and sets the property Info. 
        /// <para>
        /// The number of findings that have Info severity.
        /// </para>
        /// </summary>
        public int? Info { get; set; }

        /// <summary>
        /// Checks to see if the Info property is set.
        /// </summary>
        internal bool IsSetInfo() => this.Info.HasValue;

        /// <summary>
        /// Gets and sets the property Low. 
        /// <para>
        /// The number of findings that have Low severity.
        /// </para>
        /// </summary>
        public int? Low { get; set; }

        /// <summary>
        /// Checks to see if the Low property is set.
        /// </summary>
        internal bool IsSetLow() => this.Low.HasValue;

        /// <summary>
        /// Gets and sets the property Medium. 
        /// <para>
        /// The number of findings that have Medium severity.
        /// </para>
        /// </summary>
        public int? Medium { get; set; }

        /// <summary>
        /// Checks to see if the Medium property is set.
        /// </summary>
        internal bool IsSetMedium() => this.Medium.HasValue;
    }
}
