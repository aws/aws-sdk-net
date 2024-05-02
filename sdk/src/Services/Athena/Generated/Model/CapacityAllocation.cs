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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
        private DateTime? _requestCompletionTime;
        private DateTime? _requestTime;
        private CapacityAllocationStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property RequestCompletionTime. 
        /// <para>
        /// The time when the capacity allocation request was completed.
        /// </para>
        /// </summary>
        public DateTime? RequestCompletionTime
        {
            get { return this._requestCompletionTime; }
            set { this._requestCompletionTime = value; }
        }

        // Check to see if RequestCompletionTime property is set
        internal bool IsSetRequestCompletionTime()
        {
            return this._requestCompletionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestTime. 
        /// <para>
        /// The time when the capacity allocation was requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? RequestTime
        {
            get { return this._requestTime; }
            set { this._requestTime = value; }
        }

        // Check to see if RequestTime property is set
        internal bool IsSetRequestTime()
        {
            return this._requestTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the capacity allocation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapacityAllocationStatus Status
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
        /// The status message of the capacity allocation.
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

    }
}