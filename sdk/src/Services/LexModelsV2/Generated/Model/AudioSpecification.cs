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
    /// Specifies the audio input specifications.
    /// </summary>
    public partial class AudioSpecification
    {
        private int? _endTimeoutMs;
        private int? _maxLengthMs;

        /// <summary>
        /// Gets and sets the property EndTimeoutMs. 
        /// <para>
        /// Time for which a bot waits after the customer stops speaking to assume the utterance
        /// is finished.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? EndTimeoutMs
        {
            get { return this._endTimeoutMs; }
            set { this._endTimeoutMs = value; }
        }

        // Check to see if EndTimeoutMs property is set
        internal bool IsSetEndTimeoutMs()
        {
            return this._endTimeoutMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxLengthMs. 
        /// <para>
        /// Time for how long Amazon Lex waits before speech input is truncated and the speech
        /// is returned to application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? MaxLengthMs
        {
            get { return this._maxLengthMs; }
            set { this._maxLengthMs = value; }
        }

        // Check to see if MaxLengthMs property is set
        internal bool IsSetMaxLengthMs()
        {
            return this._maxLengthMs.HasValue; 
        }

    }
}