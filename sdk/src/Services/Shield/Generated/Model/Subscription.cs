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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Shield.Model
{
    /// <summary>
    /// Information about the AWS Shield Advanced subscription for an account.
    /// </summary>
    public partial class Subscription
    {
        private AutoRenew _autoRenew;
        private DateTime? _endTime;
        private List<Limit> _limits = new List<Limit>();
        private DateTime? _startTime;
        private long? _timeCommitmentInSeconds;

        /// <summary>
        /// Gets and sets the property AutoRenew. 
        /// <para>
        /// If <code>ENABLED</code>, the subscription will be automatically renewed at the end
        /// of the existing subscription period.
        /// </para>
        ///  
        /// <para>
        /// When you initally create a subscription, <code>AutoRenew</code> is set to <code>ENABLED</code>.
        /// You can change this by submitting an <code>UpdateSubscription</code> request. If the
        /// <code>UpdateSubscription</code> request does not included a value for <code>AutoRenew</code>,
        /// the existing value for <code>AutoRenew</code> remains unchanged.
        /// </para>
        /// </summary>
        public AutoRenew AutoRenew
        {
            get { return this._autoRenew; }
            set { this._autoRenew = value; }
        }

        // Check to see if AutoRenew property is set
        internal bool IsSetAutoRenew()
        {
            return this._autoRenew != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time your subscription will end.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Limits. 
        /// <para>
        /// Specifies how many protections of a given type you can create.
        /// </para>
        /// </summary>
        public List<Limit> Limits
        {
            get { return this._limits; }
            set { this._limits = value; }
        }

        // Check to see if Limits property is set
        internal bool IsSetLimits()
        {
            return this._limits != null && this._limits.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the subscription, in Unix time in seconds. For more information
        /// see <a href="http://docs.aws.amazon.com/cli/latest/userguide/cli-using-param.html#parameter-types">timestamp</a>.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeCommitmentInSeconds. 
        /// <para>
        /// The length, in seconds, of the AWS Shield Advanced subscription for the account.
        /// </para>
        /// </summary>
        public long TimeCommitmentInSeconds
        {
            get { return this._timeCommitmentInSeconds.GetValueOrDefault(); }
            set { this._timeCommitmentInSeconds = value; }
        }

        // Check to see if TimeCommitmentInSeconds property is set
        internal bool IsSetTimeCommitmentInSeconds()
        {
            return this._timeCommitmentInSeconds.HasValue; 
        }

    }
}