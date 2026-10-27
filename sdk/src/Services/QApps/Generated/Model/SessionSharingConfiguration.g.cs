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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AcceptResponses. 
        /// <para>
        /// Indicates whether an Q App session can accept responses from users.
        /// </para>
        /// </summary>
        public bool? AcceptResponses { get; set; }

        /// <summary>
        /// Checks to see if the AcceptResponses property is set.
        /// </summary>
        internal bool IsSetAcceptResponses() => this.AcceptResponses.HasValue;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether an Q App session is shareable with other users.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property RevealCards. 
        /// <para>
        /// Indicates whether collected responses for an Q App session are revealed for all users.
        /// </para>
        /// </summary>
        public bool? RevealCards { get; set; }

        /// <summary>
        /// Checks to see if the RevealCards property is set.
        /// </summary>
        internal bool IsSetRevealCards() => this.RevealCards.HasValue;
    }
}
