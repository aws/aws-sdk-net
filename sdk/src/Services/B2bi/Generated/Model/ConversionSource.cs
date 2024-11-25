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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Describes the input for an outbound transformation.
    /// </summary>
    public partial class ConversionSource
    {
        private ConversionSourceFormat _fileFormat;
        private InputFileSource _inputFile;

        /// <summary>
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// The format for the input file: either JSON or XML.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConversionSourceFormat FileFormat
        {
            get { return this._fileFormat; }
            set { this._fileFormat = value; }
        }

        // Check to see if FileFormat property is set
        internal bool IsSetFileFormat()
        {
            return this._fileFormat != null;
        }

        /// <summary>
        /// Gets and sets the property InputFile. 
        /// <para>
        /// File to be converted
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InputFileSource InputFile
        {
            get { return this._inputFile; }
            set { this._inputFile = value; }
        }

        // Check to see if InputFile property is set
        internal bool IsSetInputFile()
        {
            return this._inputFile != null;
        }

    }
}