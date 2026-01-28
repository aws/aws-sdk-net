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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
namespace Amazon.Wickr.Model
{
    /// <summary>
    /// This is the response object from the GetUsersCount operation.
    /// </summary>
    public partial class GetUsersCountResponse : AmazonWebServiceResponse
    {
        private int? _active;
        private int? _pending;
        private int? _rejected;
        private int? _remaining;
        private int? _total;

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// The number of users with active status in the network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Active
        {
            get { return this._active; }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Pending. 
        /// <para>
        /// The number of users with pending status (invited but not yet accepted).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Pending
        {
            get { return this._pending; }
            set { this._pending = value; }
        }

        // Check to see if Pending property is set
        internal bool IsSetPending()
        {
            return this._pending.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Rejected. 
        /// <para>
        /// The number of users who have rejected network invitations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Rejected
        {
            get { return this._rejected; }
            set { this._rejected = value; }
        }

        // Check to see if Rejected property is set
        internal bool IsSetRejected()
        {
            return this._rejected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Remaining. 
        /// <para>
        /// The number of additional users that can be added to the network while maintaining
        /// premium free trial eligibility.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Remaining
        {
            get { return this._remaining; }
            set { this._remaining = value; }
        }

        // Check to see if Remaining property is set
        internal bool IsSetRemaining()
        {
            return this._remaining.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total number of users in the network (active and pending combined).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

    }
}