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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The time period that you want the usage and costs for.
    /// </summary>
    public partial class DateInterval
    {
        private string _end;
        private string _start;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The end of the time period that you want the usage and costs for. The end date is
        /// exclusive. For example, if <code>end</code> is <code>2017-05-01</code>, AWS retrieves
        /// cost and usage data from the start date up to, but not including, <code>2017-05-01</code>.
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
        /// The beginning of the time period that you want the usage and costs for. The start
        /// date is inclusive. For example, if <code>start</code> is <code>2017-01-01</code>,
        /// AWS retrieves cost and usage data starting at <code>2017-01-01</code> up to the end
        /// date.
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