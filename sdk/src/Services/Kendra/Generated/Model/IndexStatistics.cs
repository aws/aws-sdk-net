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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides information about the number of documents and the number of questions and
    /// answers in an index.
    /// </summary>
    public partial class IndexStatistics
    {
        private FaqStatistics _faqStatistics;
        private TextDocumentStatistics _textDocumentStatistics;

        /// <summary>
        /// Gets and sets the property FaqStatistics. 
        /// <para>
        /// The number of question and answer topics in the index.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FaqStatistics FaqStatistics
        {
            get { return this._faqStatistics; }
            set { this._faqStatistics = value; }
        }

        // Check to see if FaqStatistics property is set
        internal bool IsSetFaqStatistics()
        {
            return this._faqStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property TextDocumentStatistics. 
        /// <para>
        /// The number of text documents indexed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TextDocumentStatistics TextDocumentStatistics
        {
            get { return this._textDocumentStatistics; }
            set { this._textDocumentStatistics = value; }
        }

        // Check to see if TextDocumentStatistics property is set
        internal bool IsSetTextDocumentStatistics()
        {
            return this._textDocumentStatistics != null;
        }

    }
}