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
    /// Specifies the audio and DTMF input specification.
    /// </summary>
    public partial class AudioAndDTMFInputSpecification
    {
        private AudioSpecification _audioSpecification;
        private DTMFSpecification _dtmfSpecification;
        private int? _startTimeoutMs;

        /// <summary>
        /// Gets and sets the property AudioSpecification. 
        /// <para>
        /// Specifies the settings on audio input.
        /// </para>
        /// </summary>
        public AudioSpecification AudioSpecification
        {
            get { return this._audioSpecification; }
            set { this._audioSpecification = value; }
        }

        // Check to see if AudioSpecification property is set
        internal bool IsSetAudioSpecification()
        {
            return this._audioSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property DtmfSpecification. 
        /// <para>
        /// Specifies the settings on DTMF input.
        /// </para>
        /// </summary>
        public DTMFSpecification DtmfSpecification
        {
            get { return this._dtmfSpecification; }
            set { this._dtmfSpecification = value; }
        }

        // Check to see if DtmfSpecification property is set
        internal bool IsSetDtmfSpecification()
        {
            return this._dtmfSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimeoutMs. 
        /// <para>
        /// Time for which a bot waits before assuming that the customer isn't going to speak
        /// or press a key. This timeout is shared between Audio and DTMF inputs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? StartTimeoutMs
        {
            get { return this._startTimeoutMs; }
            set { this._startTimeoutMs = value; }
        }

        // Check to see if StartTimeoutMs property is set
        internal bool IsSetStartTimeoutMs()
        {
            return this._startTimeoutMs.HasValue; 
        }

    }
}