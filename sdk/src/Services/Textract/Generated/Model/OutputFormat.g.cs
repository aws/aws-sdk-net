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
    /// Controls the format of the extraction output, including the text format and any additional
    /// file formats.
    /// </summary>
    public partial class OutputFormat
    {
        /// <summary>
        /// Gets and sets the property AdditionalFileFormat. 
        /// <para>
        /// Controls whether an additional file format is produced alongside the primary output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputAdditionalFileFormat AdditionalFileFormat { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalFileFormat property is set.
        /// </summary>
        internal bool IsSetAdditionalFileFormat() => this.AdditionalFileFormat != null;

        /// <summary>
        /// Gets and sets the property TextFormat. 
        /// <para>
        /// Controls the text formats produced in the extraction output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputTextFormat TextFormat { get; set; }

        /// <summary>
        /// Checks to see if the TextFormat property is set.
        /// </summary>
        internal bool IsSetTextFormat() => this.TextFormat != null;
    }
}
