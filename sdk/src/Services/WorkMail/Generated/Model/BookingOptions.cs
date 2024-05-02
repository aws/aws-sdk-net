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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// At least one delegate must be associated to the resource to disable automatic replies
    /// from the resource.
    /// </summary>
    public partial class BookingOptions
    {
        private bool? _autoAcceptRequests;
        private bool? _autoDeclineConflictingRequests;
        private bool? _autoDeclineRecurringRequests;

        /// <summary>
        /// Gets and sets the property AutoAcceptRequests. 
        /// <para>
        /// The resource's ability to automatically reply to requests. If disabled, delegates
        /// must be associated to the resource.
        /// </para>
        /// </summary>
        public bool? AutoAcceptRequests
        {
            get { return this._autoAcceptRequests; }
            set { this._autoAcceptRequests = value; }
        }

        // Check to see if AutoAcceptRequests property is set
        internal bool IsSetAutoAcceptRequests()
        {
            return this._autoAcceptRequests.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoDeclineConflictingRequests. 
        /// <para>
        /// The resource's ability to automatically decline any conflicting requests.
        /// </para>
        /// </summary>
        public bool? AutoDeclineConflictingRequests
        {
            get { return this._autoDeclineConflictingRequests; }
            set { this._autoDeclineConflictingRequests = value; }
        }

        // Check to see if AutoDeclineConflictingRequests property is set
        internal bool IsSetAutoDeclineConflictingRequests()
        {
            return this._autoDeclineConflictingRequests.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoDeclineRecurringRequests. 
        /// <para>
        /// The resource's ability to automatically decline any recurring requests.
        /// </para>
        /// </summary>
        public bool? AutoDeclineRecurringRequests
        {
            get { return this._autoDeclineRecurringRequests; }
            set { this._autoDeclineRecurringRequests = value; }
        }

        // Check to see if AutoDeclineRecurringRequests property is set
        internal bool IsSetAutoDeclineRecurringRequests()
        {
            return this._autoDeclineRecurringRequests.HasValue; 
        }

    }
}