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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Makes it possible to redact or flag specified personally identifiable information
    /// (PII) in your transcript. If you use <code>ContentRedaction</code>, you must also
    /// include the sub-parameters: <code>PiiEntityTypes</code>, <code>RedactionOutput</code>,
    /// and <code>RedactionType</code>.
    /// </summary>
    public partial class ContentRedaction
    {
        private List<string> _piiEntityTypes = new List<string>();
        private RedactionOutput _redactionOutput;
        private RedactionType _redactionType;

        /// <summary>
        /// Gets and sets the property PiiEntityTypes. 
        /// <para>
        /// Specify which types of personally identifiable information (PII) you want to redact
        /// in your transcript. You can include as many types as you'd like, or you can select
        /// <code>ALL</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=11)]
        public List<string> PiiEntityTypes
        {
            get { return this._piiEntityTypes; }
            set { this._piiEntityTypes = value; }
        }

        // Check to see if PiiEntityTypes property is set
        internal bool IsSetPiiEntityTypes()
        {
            return this._piiEntityTypes != null && this._piiEntityTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RedactionOutput. 
        /// <para>
        /// Specify if you want only a redacted transcript, or if you want a redacted and an unredacted
        /// transcript.
        /// </para>
        ///  
        /// <para>
        /// When you choose <code>redacted</code> Amazon Transcribe creates only a redacted transcript.
        /// </para>
        ///  
        /// <para>
        /// When you choose <code>redacted_and_unredacted</code> Amazon Transcribe creates a redacted
        /// and an unredacted transcript (as two separate files).
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
        /// Specify the category of information you want to redact; <code>PII</code> (personally
        /// identifiable information) is the only valid value. You can use <code>PiiEntityTypes</code>
        /// to choose which types of PII you want to redact.
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