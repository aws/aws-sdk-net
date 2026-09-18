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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains counts of findings grouped by severity level for trend analysis.
    /// </summary>
    public partial class SeverityTrendsCount
    {
        /// <summary>
        /// Gets and sets the property Critical. 
        /// <para>
        /// The count of findings with Critical severity level at this point in the trend timeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? Critical { get; set; }

        /// <summary>
        /// Checks to see if the Critical property is set.
        /// </summary>
        internal bool IsSetCritical() => this.Critical.HasValue;

        /// <summary>
        /// Gets and sets the property Fatal. 
        /// <para>
        /// The count of findings with Fatal severity level at this point in the trend timeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? Fatal { get; set; }

        /// <summary>
        /// Checks to see if the Fatal property is set.
        /// </summary>
        internal bool IsSetFatal() => this.Fatal.HasValue;

        /// <summary>
        /// Gets and sets the property High. 
        /// <para>
        /// The count of findings with High severity level at this point in the trend timeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? High { get; set; }

        /// <summary>
        /// Checks to see if the High property is set.
        /// </summary>
        internal bool IsSetHigh() => this.High.HasValue;

        /// <summary>
        /// Gets and sets the property Informational. 
        /// <para>
        /// The count of findings with Informational severity level at this point in the trend
        /// timeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? Informational { get; set; }

        /// <summary>
        /// Checks to see if the Informational property is set.
        /// </summary>
        internal bool IsSetInformational() => this.Informational.HasValue;

        /// <summary>
        /// Gets and sets the property Low. 
        /// <para>
        /// The count of findings with Low severity level at this point in the trend timeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? Low { get; set; }

        /// <summary>
        /// Checks to see if the Low property is set.
        /// </summary>
        internal bool IsSetLow() => this.Low.HasValue;

        /// <summary>
        /// Gets and sets the property Medium. 
        /// <para>
        /// The count of findings with Medium severity level at this point in the trend timeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? Medium { get; set; }

        /// <summary>
        /// Checks to see if the Medium property is set.
        /// </summary>
        internal bool IsSetMedium() => this.Medium.HasValue;

        /// <summary>
        /// Gets and sets the property Other. 
        /// <para>
        /// The count of findings with severity levels not fitting into the standard categories
        /// at this point in the trend timeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? Other { get; set; }

        /// <summary>
        /// Checks to see if the Other property is set.
        /// </summary>
        internal bool IsSetOther() => this.Other.HasValue;

        /// <summary>
        /// Gets and sets the property Unknown. 
        /// <para>
        /// The count of findings with Unknown severity level at this point in the trend timeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? Unknown { get; set; }

        /// <summary>
        /// Checks to see if the Unknown property is set.
        /// </summary>
        internal bool IsSetUnknown() => this.Unknown.HasValue;
    }
}
