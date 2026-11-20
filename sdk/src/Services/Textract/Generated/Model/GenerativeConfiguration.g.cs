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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Controls the generative capabilities applied during a document insights job, such
    /// as summarization and figure captioning.
    /// </summary>
    public partial class GenerativeConfiguration
    {
        /// <summary>
        /// Gets and sets the property FigureCaption. 
        /// <para>
        /// Controls whether generative captions are produced for figures detected in the document.
        /// If you omit it, no figure captions are produced.
        /// </para>
        /// </summary>
        public FigureCaptionConfiguration FigureCaption { get; set; }

        /// <summary>
        /// Checks to see if the FigureCaption property is set.
        /// </summary>
        internal bool IsSetFigureCaption() => this.FigureCaption != null;

        /// <summary>
        /// Gets and sets the property Summarization. 
        /// <para>
        /// Controls whether a generative summary of the document is produced. If you omit it,
        /// no summary is produced.
        /// </para>
        /// </summary>
        public SummarizationConfiguration Summarization { get; set; }

        /// <summary>
        /// Checks to see if the Summarization property is set.
        /// </summary>
        internal bool IsSetSummarization() => this.Summarization != null;
    }
}
