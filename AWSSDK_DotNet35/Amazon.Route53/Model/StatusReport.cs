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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains information about the health check status for the current
    /// observation.
    /// </summary>
    public partial class StatusReport
    {
        private string _status;
        private DateTime? _checkedTime;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The observed health check status.
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
        /// The date and time the health check status was observed, in the format <code>YYYY-MM-DDThh:mm:ssZ</code>,
        /// as specified in the ISO 8601 standard (for example, 2009-11-19T19:37:58Z). The <code>Z</code>
        /// after the time indicates that the time is listed in Coordinated Universal Time (UTC),
        /// which is synonymous with Greenwich Mean Time in this context.
        /// </para>
        /// </summary>
        public DateTime CheckedTime
        {
            get { return this._checkedTime.GetValueOrDefault(); }
            set { this._checkedTime = value; }
        }

        // Check to see if CheckedTime property is set
        internal bool IsSetCheckedTime()
        {
            return this._checkedTime.HasValue; 
        }

    }
}