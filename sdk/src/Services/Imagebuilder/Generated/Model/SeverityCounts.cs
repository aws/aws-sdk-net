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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Includes counts by severity level for medium severity and higher level findings, plus
    /// a total for all of the findings for the specified filter.
    /// </summary>
    public partial class SeverityCounts
    {
        private long? _all;
        private long? _critical;
        private long? _high;
        private long? _medium;

        /// <summary>
        /// Gets and sets the property All. 
        /// <para>
        /// The total number of findings across all severity levels for the specified filter.
        /// </para>
        /// </summary>
        public long All
        {
            get { return this._all.GetValueOrDefault(); }
            set { this._all = value; }
        }

        // Check to see if All property is set
        internal bool IsSetAll()
        {
            return this._all.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Critical. 
        /// <para>
        /// The number of critical severity findings for the specified filter.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property High. 
        /// <para>
        /// The number of high severity findings for the specified filter.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Medium. 
        /// <para>
        /// The number of medium severity findings for the specified filter.
        /// </para>
        /// </summary>
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

    }
}