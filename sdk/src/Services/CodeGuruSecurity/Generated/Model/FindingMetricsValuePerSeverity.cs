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
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruSecurity.Model
{
    /// <summary>
    /// The severity of the issue in the code that generated a finding.
    /// </summary>
    public partial class FindingMetricsValuePerSeverity
    {
        private double? _critical;
        private double? _high;
        private double? _info;
        private double? _low;
        private double? _medium;

        /// <summary>
        /// Gets and sets the property Critical. 
        /// <para>
        /// The severity of the finding is critical and should be addressed immediately.
        /// </para>
        /// </summary>
        public double Critical
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
        /// Gets and sets the property High. 
        /// <para>
        /// The severity of the finding is high and should be addressed as a near-term priority.
        /// </para>
        /// </summary>
        public double High
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
        /// Gets and sets the property Info. 
        /// <para>
        /// The finding is related to quality or readability improvements and not considered actionable.
        /// </para>
        /// </summary>
        public double Info
        {
            get { return this._info.GetValueOrDefault(); }
            set { this._info = value; }
        }

        // Check to see if Info property is set
        internal bool IsSetInfo()
        {
            return this._info.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Low. 
        /// <para>
        /// The severity of the finding is low and does require action on its own.
        /// </para>
        /// </summary>
        public double Low
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
        /// The severity of the finding is medium and should be addressed as a mid-term priority.
        /// </para>
        /// </summary>
        public double Medium
        {
            get { return this._medium.GetValueOrDefault(); }
            set { this._medium = value; }
        }

        // Check to see if Medium property is set
        internal bool IsSetMedium()
        {
            return this._medium.HasValue; 
        }

    }
}