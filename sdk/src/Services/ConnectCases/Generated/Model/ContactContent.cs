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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// An object that represents a content of an Amazon Connect contact object.
    /// </summary>
    public partial class ContactContent
    {
        private string _channel;
        private DateTime? _connectedToSystemTime;
        private string _contactArn;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// A list of channels to filter on for related items of type <c>Contact</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Channel
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
        /// Gets and sets the property ConnectedToSystemTime. 
        /// <para>
        /// The difference between the <c>InitiationTimestamp</c> and the <c>DisconnectTimestamp</c>
        /// of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ConnectedToSystemTime
        {
            get { return this._connectedToSystemTime; }
            set { this._connectedToSystemTime = value; }
        }

        // Check to see if ConnectedToSystemTime property is set
        internal bool IsSetConnectedToSystemTime()
        {
            return this._connectedToSystemTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContactArn. 
        /// <para>
        /// A unique identifier of a contact in Amazon Connect.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string ContactArn
        {
            get { return this._contactArn; }
            set { this._contactArn = value; }
        }

        // Check to see if ContactArn property is set
        internal bool IsSetContactArn()
        {
            return this._contactArn != null;
        }

    }
}