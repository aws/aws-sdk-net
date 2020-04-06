/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Settings for content redaction within a transcription job.
    /// </summary>
    public partial class ContentRedaction
    {
        private RedactionOutput _redactionOutput;
        private RedactionType _redactionType;

        /// <summary>
        /// Gets and sets the property RedactionOutput. 
        /// <para>
        /// The output transcript file stored in either the default S3 bucket or in a bucket you
        /// specify.
        /// </para>
        ///  
        /// <para>
        /// When you choose <code>redacted</code> Amazon Transcribe outputs only the redacted
        /// transcript.
        /// </para>
        ///  
        /// <para>
        /// When you choose <code>redacted_and_unredacted</code> Amazon Transcribe outputs both
        /// the redacted and unredacted transcripts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RedactionOutput RedactionOutput
        {
            get { return this._redactionOutput; }
            set { this._redactionOutput = value; }
        }

        // Check to see if RedactionOutput property is set
        internal bool IsSetRedactionOutput()
        {
            return this._redactionOutput != null;
        }

        /// <summary>
        /// Gets and sets the property RedactionType. 
        /// <para>
        /// Request parameter that defines the entities to be redacted. The only accepted value
        /// is <code>PII</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RedactionType RedactionType
        {
            get { return this._redactionType; }
            set { this._redactionType = value; }
        }

        // Check to see if RedactionType property is set
        internal bool IsSetRedactionType()
        {
            return this._redactionType != null;
        }

    }
}