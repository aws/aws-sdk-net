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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Details of the input data used for automated question processing.
    /// </summary>
    public partial class EvaluationQuestionInputDetails
    {
        private EvaluationTranscriptType _transcriptType;

        /// <summary>
        /// Gets and sets the property TranscriptType. 
        /// <para>
        /// Transcript type.
        /// </para>
        /// </summary>
        public EvaluationTranscriptType TranscriptType
        {
            get { return this._transcriptType; }
            set { this._transcriptType = value; }
        }

        // Check to see if TranscriptType property is set
        internal bool IsSetTranscriptType()
        {
            return this._transcriptType != null;
        }

    }
}