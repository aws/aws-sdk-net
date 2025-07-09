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
    /// A comprehensive distribution of security findings by severity level for Amazon Web
    /// Services resources.
    /// </summary>
    public partial class ResourceSeverityBreakdown
    {
        private int? _critical;
        private int? _fatal;
        private int? _high;
        private int? _informational;
        private int? _low;
        private int? _medium;
        private int? _other;
        private int? _unknown;

        /// <summary>
        /// Gets and sets the property Critical. 
        /// <para>
        /// The number of findings with a severity level of critical.
        /// </para>
        /// </summary>
        public int? Critical
        {
            get { return this._critical; }
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
        /// The number of findings with a severity level of fatal.
        /// </para>
        /// </summary>
        public int? Fatal
        {
            get { return this._fatal; }
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
        /// The number of findings with a severity level of high.
        /// </para>
        /// </summary>
        public int? High
        {
            get { return this._high; }
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
        /// The number of findings that provide security-related information.
        /// </para>
        /// </summary>
        public int? Informational
        {
            get { return this._informational; }
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
        /// The number of findings with a severity level of low.
        /// </para>
        /// </summary>
        public int? Low
        {
            get { return this._low; }
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
        /// The number of findings with a severity level of medium.
        /// </para>
        /// </summary>
        public int? Medium
        {
            get { return this._medium; }
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
        /// The number of findings not in any of the severity categories.
        /// </para>
        /// </summary>
        public int? Other
        {
            get { return this._other; }
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
        /// The number of findings with a severity level cannot be determined.
        /// </para>
        /// </summary>
        public int? Unknown
        {
            get { return this._unknown; }
            set { this._unknown = value; }
        }

        // Check to see if Unknown property is set
        internal bool IsSetUnknown()
        {
            return this._unknown.HasValue; 
        }

    }
}