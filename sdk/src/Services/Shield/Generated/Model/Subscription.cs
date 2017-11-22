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
        private DateTime? _startTime;
        private long? _timeCommitmentInSeconds;

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