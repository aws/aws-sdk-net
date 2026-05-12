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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
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
namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// An object representing a redundant ingest credential.
    /// </summary>
    public partial class RedundantIngestCredential
    {
        private string _participantId;
        private string _streamKey;

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// ID of the participant within the stage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string ParticipantId
        {
            get { return this._participantId; }
            set { this._participantId = value; }
        }

        // Check to see if ParticipantId property is set
        internal bool IsSetParticipantId()
        {
            return this._participantId != null;
        }

        /// <summary>
        /// Gets and sets the property StreamKey. 
        /// <para>
        /// Ingest-key value.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string StreamKey
        {
            get { return this._streamKey; }
            set { this._streamKey = value; }
        }

        // Check to see if StreamKey property is set
        internal bool IsSetStreamKey()
        {
            return this._streamKey != null;
        }

    }
}