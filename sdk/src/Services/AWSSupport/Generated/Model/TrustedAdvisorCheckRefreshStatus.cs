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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// The refresh status of a Trusted Advisor check.
    /// </summary>
    public partial class TrustedAdvisorCheckRefreshStatus
    {
        private string _checkId;
        private long? _millisUntilNextRefreshable;
        private string _status;

        /// <summary>
        /// Gets and sets the property CheckId. 
        /// <para>
        /// The unique identifier for the Trusted Advisor check.
        /// </para>
        /// </summary>
        public string CheckId
        {
            get { return this._checkId; }
            set { this._checkId = value; }
        }

        // Check to see if CheckId property is set
        internal bool IsSetCheckId()
        {
            return this._checkId != null;
        }

        /// <summary>
        /// Gets and sets the property MillisUntilNextRefreshable. 
        /// <para>
        /// The amount of time, in milliseconds, until the Trusted Advisor check is eligible for
        /// refresh.
        /// </para>
        /// </summary>
        public long MillisUntilNextRefreshable
        {
            get { return this._millisUntilNextRefreshable.GetValueOrDefault(); }
            set { this._millisUntilNextRefreshable = value; }
        }

        // Check to see if MillisUntilNextRefreshable property is set
        internal bool IsSetMillisUntilNextRefreshable()
        {
            return this._millisUntilNextRefreshable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Trusted Advisor check for which a refresh has been requested: "none",
        /// "enqueued", "processing", "success", or "abandoned".
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

    }
}