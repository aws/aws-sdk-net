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
    /// Settings for logging audio of conversations between Amazon Lex and a user. You specify
    /// whether to log audio and the Amazon S3 bucket where the audio file is stored.
    /// </summary>
    public partial class AudioLogSetting
    {
        private AudioLogDestination _destination;
        private bool? _enabled;
        private bool? _selectiveLoggingEnabled;

        /// <summary>
        /// Gets and sets the property Destination.
        /// </summary>
        [AWSProperty(Required=true)]
        public AudioLogDestination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Determines whether audio logging in enabled for the bot.
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
        /// Gets and sets the property SelectiveLoggingEnabled. 
        /// <para>
        /// The option to enable selective conversation log capture for audio.
        /// </para>
        /// </summary>
        public bool? SelectiveLoggingEnabled
        {
            get { return this._selectiveLoggingEnabled; }
            set { this._selectiveLoggingEnabled = value; }
        }

        // Check to see if SelectiveLoggingEnabled property is set
        internal bool IsSetSelectiveLoggingEnabled()
        {
            return this._selectiveLoggingEnabled.HasValue; 
        }

    }
}