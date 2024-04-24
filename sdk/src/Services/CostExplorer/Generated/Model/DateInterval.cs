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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The time period of the request.
    /// </summary>
    public partial class DateInterval
    {
        private string _end;
        private string _start;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The end of the time period. The end date is exclusive. For example, if <c>end</c>
        /// is <c>2017-05-01</c>, Amazon Web Services retrieves cost and usage data from the start
        /// date up to, but not including, <c>2017-05-01</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=40)]
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
        /// The beginning of the time period. The start date is inclusive. For example, if <c>start</c>
        /// is <c>2017-01-01</c>, Amazon Web Services retrieves cost and usage data starting at
        /// <c>2017-01-01</c> up to the end date. The start date must be equal to or no later
        /// than the current date to avoid a validation error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=40)]
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