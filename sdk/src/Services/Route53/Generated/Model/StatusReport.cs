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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains the status that one Amazon Route 53 health checker reports
    /// and the time of the health check.
    /// </summary>
    public partial class StatusReport
    {
        private string _status;
        private DateTime? _checkedTime;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A description of the status of the health check endpoint as reported by one of the
        /// Amazon Route 53 health checkers.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property CheckedTime. 
        /// <para>
        /// The date and time that the health checker performed the health check in <a href="https://en.wikipedia.org/wiki/ISO_8601">ISO
        /// 8601 format</a> and Coordinated Universal Time (UTC). For example, the value <c>2017-03-27T17:48:16.751Z</c>
        /// represents March 27, 2017 at 17:48:16.751 UTC.
        /// </para>
        /// </summary>
        public DateTime? CheckedTime
        {
            get { return this._checkedTime; }
            set { this._checkedTime = value; }
        }

        // Check to see if CheckedTime property is set
        internal bool IsSetCheckedTime()
        {
            return this._checkedTime.HasValue; 
        }

    }
}