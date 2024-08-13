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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// The time that a context is active. You can specify the time to live in seconds or
    /// in conversation turns.
    /// </summary>
    public partial class ActiveContextTimeToLive
    {
        private int? _timeToLiveInSeconds;
        private int? _turnsToLive;

        /// <summary>
        /// Gets and sets the property TimeToLiveInSeconds. 
        /// <para>
        /// The number of seconds that the context is active. You can specify between 5 and 86400
        /// seconds (24 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=86400)]
        public int? TimeToLiveInSeconds
        {
            get { return this._timeToLiveInSeconds; }
            set { this._timeToLiveInSeconds = value; }
        }

        // Check to see if TimeToLiveInSeconds property is set
        internal bool IsSetTimeToLiveInSeconds()
        {
            return this._timeToLiveInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TurnsToLive. 
        /// <para>
        /// The number of turns that the context is active. You can specify up to 20 turns. Each
        /// request and response from the bot is a turn.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public int? TurnsToLive
        {
            get { return this._turnsToLive; }
            set { this._turnsToLive = value; }
        }

        // Check to see if TurnsToLive property is set
        internal bool IsSetTurnsToLive()
        {
            return this._turnsToLive.HasValue; 
        }

    }
}