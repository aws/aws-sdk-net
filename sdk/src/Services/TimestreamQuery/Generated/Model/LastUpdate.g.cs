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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the last update. Can be either <c>PENDING</c>, <c>FAILED</c>, or <c>SUCCEEDED</c>.
        /// </para>
        /// </summary>
        public LastUpdateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Error message describing the last account settings update status, visible only if
        /// an error occurred.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property TargetQueryTCU. 
        /// <para>
        /// The number of TimeStream Compute Units (TCUs) requested in the last account settings
        /// update.
        /// </para>
        /// </summary>
        public int? TargetQueryTCU { get; set; }

        /// <summary>
        /// Checks to see if the TargetQueryTCU property is set.
        /// </summary>
        internal bool IsSetTargetQueryTCU() => this.TargetQueryTCU.HasValue;
    }
}
