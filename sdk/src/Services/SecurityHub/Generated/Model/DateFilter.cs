/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A date filter for querying findings.
    /// </summary>
    public partial class DateFilter
    {
        private DateRange _dateRange;
        private string _end;
        private string _start;

        /// <summary>
        /// Gets and sets the property DateRange. 
        /// <para>
        /// A date range for the date filter.
        /// </para>
        /// </summary>
        public DateRange DateRange
        {
            get { return this._dateRange; }
            set { this._dateRange = value; }
        }

        // Check to see if DateRange property is set
        internal bool IsSetDateRange()
        {
            return this._dateRange != null;
        }

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// An end date for the date filter.
        /// </para>
        /// </summary>
        public string End
        {
            get { return this._end; }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end != null;
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// A start date for the date filter.
        /// </para>
        /// </summary>
        public string Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start != null;
        }

    }
}