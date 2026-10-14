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

namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Container for the parameters to the TestParsing operation. Parses the input EDI (electronic
    /// data interchange) file. The input file has a file size limit of 250 KB.
    /// </summary>
    public partial class TestParsingRequest : AmazonB2biRequest
    {
        /// <summary>
        /// Gets and sets the property AdvancedOptions. 
        /// <para>
        /// Specifies advanced options for parsing the input EDI file. These options allow for
        /// more granular control over the parsing process, including split options for X12 files.
        /// </para>
        /// </summary>
        public AdvancedOptions AdvancedOptions { get; set; }

        /// <summary>
        /// Checks to see if the AdvancedOptions property is set.
        /// </summary>
        internal bool IsSetAdvancedOptions() => this.AdvancedOptions != null;

        /// <summary>
        /// Gets and sets the property EdiType. 
        /// <para>
        /// Specifies the details for the EDI standard that is being used for the transformer.
        /// Currently, only X12 is supported. X12 is a set of standards and corresponding messages
        /// that define specific business documents.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EdiType EdiType { get; set; }

        /// <summary>
        /// Checks to see if the EdiType property is set.
        /// </summary>
        internal bool IsSetEdiType() => this.EdiType != null;

        /// <summary>
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// Specifies that the currently supported file formats for EDI transformations are <c>JSON</c>
        /// and <c>XML</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FileFormat FileFormat { get; set; }

        /// <summary>
        /// Checks to see if the FileFormat property is set.
        /// </summary>
        internal bool IsSetFileFormat() => this.FileFormat != null;

        /// <summary>
        /// Gets and sets the property InputFile. 
        /// <para>
        /// Specifies an <c>S3Location</c> object, which contains the Amazon S3 bucket and prefix
        /// for the location of the input file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3Location InputFile { get; set; }

        /// <summary>
        /// Checks to see if the InputFile property is set.
        /// </summary>
        internal bool IsSetInputFile() => this.InputFile != null;
    }
}
