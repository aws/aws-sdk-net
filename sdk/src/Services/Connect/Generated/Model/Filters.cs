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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// The filter, either channel or queues, to apply to the metric results retrieved.
    /// </summary>
    public partial class Filters
    {
        private List<string> _channels = new List<string>();
        private List<string> _queues = new List<string>();

        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        /// The Channel to use as a filter for the metrics returned. Only VOICE is supported.
        /// </para>
        /// </summary>
        public List<string> Channels
        {
            get { return this._channels; }
            set { this._channels = value; }
        }

        // Check to see if Channels property is set
        internal bool IsSetChannels()
        {
            return this._channels != null && this._channels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Queues. 
        /// <para>
        /// A list of up to 100 queue IDs or queue ARNs to use to filter the metrics retrieved.
        /// You can include both IDs and ARNs in a request.
        /// </para>
        /// </summary>
        public List<string> Queues
        {
            get { return this._queues; }
            set { this._queues = value; }
        }

        // Check to see if Queues property is set
        internal bool IsSetQueues()
        {
            return this._queues != null && this._queues.Count > 0; 
        }

    }
}