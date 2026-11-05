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

namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// A document to include in a message.
    /// </summary>
    public partial class DocumentBlock
    {
        /// <summary>
        /// Gets and sets the property Citations. 
        /// <para>
        /// Configuration settings that control how citations should be generated for this specific
        /// document.
        /// </para>
        /// </summary>
        public CitationsConfig Citations { get; set; }

        /// <summary>
        /// Checks to see if the Citations property is set.
        /// </summary>
        internal bool IsSetCitations() => this.Citations != null;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Contextual information about how the document should be processed or interpreted by
        /// the model when generating citations.
        /// </para>
        /// </summary>
        public string Context { get; set; }

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of a document, or its extension.
        /// </para>
        /// </summary>
        public DocumentFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the document. The name can only contain the following characters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Alphanumeric characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whitespace characters (no more than one in a row)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Hyphens
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Parentheses
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Square brackets
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// This field is vulnerable to prompt injections, because the model might inadvertently
        /// interpret it as instructions. Therefore, we recommend that you specify a neutral name.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Contains the content of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DocumentSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
