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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private long? _critical;
        private long? _fatal;
        private long? _high;
        private long? _informational;
        private long? _low;
        private long? _medium;
        private long? _other;
        private long? _unknown;

        /// <summary>
        /// Gets and sets the property Critical. 
        /// <para>
        /// The count of findings with Critical severity level at this point in the trend timeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long Critical
        {
            get { return this._critical.GetValueOrDefault(); }
            set { this._critical = value; }
        }

        // Check to see if Critical property is set
        internal bool IsSetCritical()
        {
            return this._critical.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Fatal. 
        /// <para>
        /// The count of findings with Fatal severity level at this point in the trend timeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long Fatal
        {
            get { return this._fatal.GetValueOrDefault(); }
            set { this._fatal = value; }
        }

        // Check to see if Fatal property is set
        internal bool IsSetFatal()
        {
            return this._fatal.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property High. 
        /// <para>
        /// The count of findings with High severity level at this point in the trend timeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long High
        {
            get { return this._high.GetValueOrDefault(); }
            set { this._high = value; }
        }

        // Check to see if High property is set
        internal bool IsSetHigh()
        {
            return this._high.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Informational. 
        /// <para>
        /// The count of findings with Informational severity level at this point in the trend
        /// timeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long Informational
        {
            get { return this._informational.GetValueOrDefault(); }
            set { this._informational = value; }
        }

        // Check to see if Informational property is set
        internal bool IsSetInformational()
        {
            return this._informational.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Low. 
        /// <para>
        /// The count of findings with Low severity level at this point in the trend timeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long Low
        {
            get { return this._low.GetValueOrDefault(); }
            set { this._low = value; }
        }

        // Check to see if Low property is set
        internal bool IsSetLow()
        {
            return this._low.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Medium. 
        /// <para>
        /// The count of findings with Medium severity level at this point in the trend timeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long Medium
        {
            get { return this._medium.GetValueOrDefault(); }
            set { this._medium = value; }
        }

        // Check to see if Medium property is set
        internal bool IsSetMedium()
        {
            return this._medium.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Other. 
        /// <para>
        /// The count of findings with severity levels not fitting into the standard categories
        /// at this point in the trend timeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long Other
        {
            get { return this._other.GetValueOrDefault(); }
            set { this._other = value; }
        }

        // Check to see if Other property is set
        internal bool IsSetOther()
        {
            return this._other.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unknown. 
        /// <para>
        /// The count of findings with Unknown severity level at this point in the trend timeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long Unknown
        {
            get { return this._unknown.GetValueOrDefault(); }
            set { this._unknown = value; }
        }

        // Check to see if Unknown property is set
        internal bool IsSetUnknown()
        {
            return this._unknown.HasValue; 
        }

    }
}