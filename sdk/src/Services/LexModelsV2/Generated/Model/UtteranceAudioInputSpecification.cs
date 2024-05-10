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
    /// Contains information about the audio for an utterance.
    /// </summary>
    public partial class UtteranceAudioInputSpecification
    {
        private string _audioFileS3Location;

        /// <summary>
        /// Gets and sets the property AudioFileS3Location. 
        /// <para>
        /// Amazon S3 file pointing to the audio.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string AudioFileS3Location
        {
            get { return this._audioFileS3Location; }
            set { this._audioFileS3Location = value; }
        }

        // Check to see if AudioFileS3Location property is set
        internal bool IsSetAudioFileS3Location()
        {
            return this._audioFileS3Location != null;
        }

    }
}