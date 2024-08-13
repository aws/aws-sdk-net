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
    /// Provides information about an event that occurred affecting the bot locale.
    /// </summary>
    public partial class BotLocaleHistoryEvent
    {
        private string _event;
        private DateTime? _eventDate;

        /// <summary>
        /// Gets and sets the property Event. 
        /// <para>
        /// A description of the event that occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Event
        {
            get { return this._event; }
            set { this._event = value; }
        }

        // Check to see if Event property is set
        internal bool IsSetEvent()
        {
            return this._event != null;
        }

        /// <summary>
        /// Gets and sets the property EventDate. 
        /// <para>
        /// A timestamp of the date and time that the event occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EventDate
        {
            get { return this._eventDate; }
            set { this._eventDate = value; }
        }

        // Check to see if EventDate property is set
        internal bool IsSetEventDate()
        {
            return this._eventDate.HasValue; 
        }

    }
}