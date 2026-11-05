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
    /// An object that contains the counts of aggregated finding per severity.
    /// </summary>
    public partial class SeverityCounts
    {
        /// <summary>
        /// Gets and sets the property All. 
        /// <para>
        /// The total count of findings from all severities.
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
        /// The total count of critical severity findings.
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
        /// The total count of high severity findings.
        /// </para>
        /// </summary>
        public long? High { get; set; }

        /// <summary>
        /// Checks to see if the High property is set.
        /// </summary>
        internal bool IsSetHigh() => this.High.HasValue;

        /// <summary>
        /// Gets and sets the property Informational. 
        /// <para>
        /// The total count of informational severity findings.
        /// </para>
        /// </summary>
        public long? Informational { get; set; }

        /// <summary>
        /// Checks to see if the Informational property is set.
        /// </summary>
        internal bool IsSetInformational() => this.Informational.HasValue;

        /// <summary>
        /// Gets and sets the property Low. 
        /// <para>
        /// The total count of low severity findings.
        /// </para>
        /// </summary>
        public long? Low { get; set; }

        /// <summary>
        /// Checks to see if the Low property is set.
        /// </summary>
        internal bool IsSetLow() => this.Low.HasValue;

        /// <summary>
        /// Gets and sets the property Medium. 
        /// <para>
        /// The total count of medium severity findings.
        /// </para>
        /// </summary>
        public long? Medium { get; set; }

        /// <summary>
        /// Checks to see if the Medium property is set.
        /// </summary>
        internal bool IsSetMedium() => this.Medium.HasValue;

        /// <summary>
        /// Gets and sets the property Untriaged. 
        /// <para>
        /// The total count of untriaged findings.
        /// </para>
        /// </summary>
        public long? Untriaged { get; set; }

        /// <summary>
        /// Checks to see if the Untriaged property is set.
        /// </summary>
        internal bool IsSetUntriaged() => this.Untriaged.HasValue;
    }
}
