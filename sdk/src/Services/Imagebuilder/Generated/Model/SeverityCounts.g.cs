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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Includes counts by severity level for medium severity and higher level findings, plus
    /// a total for all of the findings for the specified filter.
    /// </summary>
    public partial class SeverityCounts
    {
        /// <summary>
        /// Gets and sets the property All. 
        /// <para>
        /// The total number of findings across all severity levels for the specified filter.
        /// </para>
        /// </summary>
        public long? All { get; set; }

        /// <summary>
        /// Checks to see if the All property is set.
        /// </summary>
        internal bool IsSetAll() => this.All.HasValue;

        /// <summary>
        /// Gets and sets the property Critical. 
        /// <para>
        /// The number of critical severity findings for the specified filter.
        /// </para>
        /// </summary>
        public long? Critical { get; set; }

        /// <summary>
        /// Checks to see if the Critical property is set.
        /// </summary>
        internal bool IsSetCritical() => this.Critical.HasValue;

        /// <summary>
        /// Gets and sets the property High. 
        /// <para>
        /// The number of high severity findings for the specified filter.
        /// </para>
        /// </summary>
        public long? High { get; set; }

        /// <summary>
        /// Checks to see if the High property is set.
        /// </summary>
        internal bool IsSetHigh() => this.High.HasValue;

        /// <summary>
        /// Gets and sets the property Medium. 
        /// <para>
        /// The number of medium severity findings for the specified filter.
        /// </para>
        /// </summary>
        public long? Medium { get; set; }

        /// <summary>
        /// Checks to see if the Medium property is set.
        /// </summary>
        internal bool IsSetMedium() => this.Medium.HasValue;
    }
}
