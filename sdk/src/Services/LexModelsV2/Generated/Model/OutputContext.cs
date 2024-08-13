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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Describes a session context that is activated when an intent is fulfilled.
    /// </summary>
    public partial class OutputContext
    {
        private string _name;
        private int? _timeToLiveInSeconds;
        private int? _turnsToLive;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the output context.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property TimeToLiveInSeconds. 
        /// <para>
        /// The amount of time, in seconds, that the output context should remain active. The
        /// time is figured from the first time the context is sent to the user.
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
        /// The number of conversation turns that the output context should remain active. The
        /// number of turns is counted from the first time that the context is sent to the user.
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