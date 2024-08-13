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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
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
namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// The point-in-time recovery status of the specified table.
    /// </summary>
    public partial class PointInTimeRecoverySummary
    {
        private DateTime? _earliestRestorableTimestamp;
        private PointInTimeRecoveryStatus _status;

        /// <summary>
        /// Gets and sets the property EarliestRestorableTimestamp. 
        /// <para>
        /// Specifies the earliest possible restore point of the table in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? EarliestRestorableTimestamp
        {
            get { return this._earliestRestorableTimestamp; }
            set { this._earliestRestorableTimestamp = value; }
        }

        // Check to see if EarliestRestorableTimestamp property is set
        internal bool IsSetEarliestRestorableTimestamp()
        {
            return this._earliestRestorableTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Shows if point-in-time recovery is enabled or disabled for the specified table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PointInTimeRecoveryStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}