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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
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
namespace Amazon.QApps.Model
{
    /// <summary>
    /// The sharing configuration of an Amazon Q App data collection session.
    /// </summary>
    public partial class SessionSharingConfiguration
    {
        private bool? _acceptResponses;
        private bool? _enabled;
        private bool? _revealCards;

        /// <summary>
        /// Gets and sets the property AcceptResponses. 
        /// <para>
        /// Indicates whether an Q App session can accept responses from users.
        /// </para>
        /// </summary>
        public bool? AcceptResponses
        {
            get { return this._acceptResponses; }
            set { this._acceptResponses = value; }
        }

        // Check to see if AcceptResponses property is set
        internal bool IsSetAcceptResponses()
        {
            return this._acceptResponses.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether an Q App session is shareable with other users.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RevealCards. 
        /// <para>
        /// Indicates whether collected responses for an Q App session are revealed for all users.
        /// </para>
        /// </summary>
        public bool? RevealCards
        {
            get { return this._revealCards; }
            set { this._revealCards = value; }
        }

        // Check to see if RevealCards property is set
        internal bool IsSetRevealCards()
        {
            return this._revealCards.HasValue; 
        }

    }
}