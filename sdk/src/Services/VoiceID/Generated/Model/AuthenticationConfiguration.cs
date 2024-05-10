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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
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
namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// The configuration used to authenticate a speaker during a session.
    /// </summary>
    public partial class AuthenticationConfiguration
    {
        private int? _acceptanceThreshold;

        /// <summary>
        /// Gets and sets the property AcceptanceThreshold. 
        /// <para>
        /// The minimum threshold needed to successfully authenticate a speaker.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public int? AcceptanceThreshold
        {
            get { return this._acceptanceThreshold; }
            set { this._acceptanceThreshold = value; }
        }

        // Check to see if AcceptanceThreshold property is set
        internal bool IsSetAcceptanceThreshold()
        {
            return this._acceptanceThreshold.HasValue; 
        }

    }
}