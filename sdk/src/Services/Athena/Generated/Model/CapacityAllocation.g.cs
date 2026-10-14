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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Contains the submission time of a single allocation request for a capacity reservation
    /// and the most recent status of the attempted allocation.
    /// </summary>
    public partial class CapacityAllocation
    {
        /// <summary>
        /// Gets and sets the property RequestCompletionTime. 
        /// <para>
        /// The time when the capacity allocation request was completed.
        /// </para>
        /// </summary>
        public DateTime? RequestCompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the RequestCompletionTime property is set.
        /// </summary>
        internal bool IsSetRequestCompletionTime() => this.RequestCompletionTime.HasValue;

        /// <summary>
        /// Gets and sets the property RequestTime. 
        /// <para>
        /// The time when the capacity allocation was requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? RequestTime { get; set; }

        /// <summary>
        /// Checks to see if the RequestTime property is set.
        /// </summary>
        internal bool IsSetRequestTime() => this.RequestTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the capacity allocation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CapacityAllocationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message of the capacity allocation.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
