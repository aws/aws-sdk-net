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
    /// This is the response object from the TestParsing operation.
    /// </summary>
    public partial class TestParsingResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ParsedFileContent. 
        /// <para>
        /// Returns the contents of the input file being tested, parsed according to the specified
        /// EDI (electronic data interchange) type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ParsedFileContent { get; set; }

        /// <summary>
        /// Checks to see if the ParsedFileContent property is set.
        /// </summary>
        internal bool IsSetParsedFileContent() => this.ParsedFileContent != null;

        /// <summary>
        /// Gets and sets the property ParsedSplitFileContents. 
        /// <para>
        /// Returns an array of parsed file contents when the input file is split according to
        /// the specified split options. Each element in the array represents a separate split
        /// file's parsed content.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ParsedSplitFileContents { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ParsedSplitFileContents property is set.
        /// </summary>
        internal bool IsSetParsedSplitFileContents() => this.ParsedSplitFileContents != null && (this.ParsedSplitFileContents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ValidationMessages. 
        /// <para>
        /// Returns an array of validation messages generated during EDI validation. These messages
        /// provide detailed information about validation errors, warnings, or confirmations based
        /// on the configured X12 validation rules such as element length constraints, code list
        /// validations, and element requirement checks. This field is populated when the <c>TestParsing</c>
        /// API validates EDI documents.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ValidationMessages { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ValidationMessages property is set.
        /// </summary>
        internal bool IsSetValidationMessages() => this.ValidationMessages != null && (this.ValidationMessages.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
