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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
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
namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Configuration object that contains the most recent account settings update, visible
    /// only if settings have been updated previously.
    /// </summary>
    public partial class LastUpdate
    {
        private LastUpdateStatus _status;
        private string _statusMessage;
        private int? _targetQueryTCU;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the last update. Can be either <c>PENDING</c>, <c>FAILED</c>, or <c>SUCCEEDED</c>.
        /// </para>
        /// </summary>
        public LastUpdateStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Error message describing the last account settings update status, visible only if
        /// an error occurred.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property TargetQueryTCU. 
        /// <para>
        /// The number of TimeStream Compute Units (TCUs) requested in the last account settings
        /// update.
        /// </para>
        /// </summary>
        public int? TargetQueryTCU
        {
            get { return this._targetQueryTCU; }
            set { this._targetQueryTCU = value; }
        }

        // Check to see if TargetQueryTCU property is set
        internal bool IsSetTargetQueryTCU()
        {
            return this._targetQueryTCU.HasValue; 
        }

    }
}