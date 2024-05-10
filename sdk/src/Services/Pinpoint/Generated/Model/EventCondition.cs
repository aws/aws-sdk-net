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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the conditions to evaluate for an event that applies to an activity in a
    /// journey.
    /// </summary>
    public partial class EventCondition
    {
        private EventDimensions _dimensions;
        private string _messageActivity;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimensions for the event filter to use for the activity.
        /// </para>
        /// </summary>
        public EventDimensions Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null;
        }

        /// <summary>
        /// Gets and sets the property MessageActivity. 
        /// <para>
        /// The message identifier (message_id) for the message to use when determining whether
        /// message events meet the condition.
        /// </para>
        /// </summary>
        public string MessageActivity
        {
            get { return this._messageActivity; }
            set { this._messageActivity = value; }
        }

        // Check to see if MessageActivity property is set
        internal bool IsSetMessageActivity()
        {
            return this._messageActivity != null;
        }

    }
}