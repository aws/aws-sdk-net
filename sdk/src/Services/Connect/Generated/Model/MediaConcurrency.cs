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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about which channels are supported, and how many contacts an
    /// agent can have on a channel simultaneously.
    /// </summary>
    public partial class MediaConcurrency
    {
        private Channel _channel;
        private int? _concurrency;
        private CrossChannelBehavior _crossChannelBehavior;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channels that agents can handle in the Contact Control Panel (CCP).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Channel Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property Concurrency. 
        /// <para>
        /// The number of contacts an agent can have on a channel simultaneously.
        /// </para>
        ///  
        /// <para>
        /// Valid Range for <c>VOICE</c>: Minimum value of 1. Maximum value of 1.
        /// </para>
        ///  
        /// <para>
        /// Valid Range for <c>CHAT</c>: Minimum value of 1. Maximum value of 10.
        /// </para>
        ///  
        /// <para>
        /// Valid Range for <c>TASK</c>: Minimum value of 1. Maximum value of 10.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public int? Concurrency
        {
            get { return this._concurrency; }
            set { this._concurrency = value; }
        }

        // Check to see if Concurrency property is set
        internal bool IsSetConcurrency()
        {
            return this._concurrency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CrossChannelBehavior. 
        /// <para>
        /// Defines the cross-channel routing behavior for each channel that is enabled for this
        /// Routing Profile. For example, this allows you to offer an agent a different contact
        /// from another channel when they are currently working with a contact from a Voice channel.
        /// </para>
        /// </summary>
        public CrossChannelBehavior CrossChannelBehavior
        {
            get { return this._crossChannelBehavior; }
            set { this._crossChannelBehavior = value; }
        }

        // Check to see if CrossChannelBehavior property is set
        internal bool IsSetCrossChannelBehavior()
        {
            return this._crossChannelBehavior != null;
        }

    }
}