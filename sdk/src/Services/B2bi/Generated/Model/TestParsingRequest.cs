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
    /// Container for the parameters to the TestParsing operation.
    /// Parses the input EDI (electronic data interchange) file. The input file has a file
    /// size limit of 250 KB.
    /// </summary>
    public partial class TestParsingRequest : AmazonB2biRequest
    {
        private AdvancedOptions _advancedOptions;
        private EdiType _ediType;
        private FileFormat _fileFormat;
        private S3Location _inputFile;

        /// <summary>
        /// Gets and sets the property AdvancedOptions. 
        /// <para>
        /// Specifies advanced options for parsing the input EDI file. These options allow for
        /// more granular control over the parsing process, including split options for X12 files.
        /// </para>
        /// </summary>
        public AdvancedOptions AdvancedOptions
        {
            get { return this._advancedOptions; }
            set { this._advancedOptions = value; }
        }

        // Check to see if AdvancedOptions property is set
        internal bool IsSetAdvancedOptions()
        {
            return this._advancedOptions != null;
        }

        /// <summary>
        /// Gets and sets the property EdiType. 
        /// <para>
        /// Specifies the details for the EDI standard that is being used for the transformer.
        /// Currently, only X12 is supported. X12 is a set of standards and corresponding messages
        /// that define specific business documents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EdiType EdiType
        {
            get { return this._ediType; }
            set { this._ediType = value; }
        }

        // Check to see if EdiType property is set
        internal bool IsSetEdiType()
        {
            return this._ediType != null;
        }

        /// <summary>
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// Specifies that the currently supported file formats for EDI transformations are <c>JSON</c>
        /// and <c>XML</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FileFormat FileFormat
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
        /// Specifies an <c>S3Location</c> object, which contains the Amazon S3 bucket and prefix
        /// for the location of the input file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Location InputFile
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