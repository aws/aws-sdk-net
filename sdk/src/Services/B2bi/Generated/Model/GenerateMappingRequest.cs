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
    /// Container for the parameters to the GenerateMapping operation.
    /// Takes sample input and output documents and uses Amazon Bedrock to generate a mapping
    /// automatically. Depending on the accuracy and other factors, you can then edit the
    /// mapping for your needs.
    /// 
    ///  <note> 
    /// <para>
    /// Before you can use the AI-assisted feature for Amazon Web Services B2B Data Interchange
    /// you must enable models in Amazon Bedrock. For details, see <a href="https://docs.aws.amazon.com/b2bi/latest/userguide/ai-assisted-mapping.html#ai-assist-prereq">AI-assisted
    /// template mapping prerequisites</a> in the <i>Amazon Web Services B2B Data Interchange
    /// User guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GenerateMappingRequest : AmazonB2biRequest
    {
        private string _inputFileContent;
        private MappingType _mappingType;
        private string _outputFileContent;

        /// <summary>
        /// Gets and sets the property InputFileContent. 
        /// <para>
        /// Provide the contents of a sample X12 EDI file (for inbound EDI) or JSON/XML file (for
        /// outbound EDI) to use as a starting point for the mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=5000000)]
        public string InputFileContent
        {
            get { return this._inputFileContent; }
            set { this._inputFileContent = value; }
        }

        // Check to see if InputFileContent property is set
        internal bool IsSetInputFileContent()
        {
            return this._inputFileContent != null;
        }

        /// <summary>
        /// Gets and sets the property MappingType. 
        /// <para>
        /// Specify the mapping type: either <c>JSONATA</c> or <c>XSLT.</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MappingType MappingType
        {
            get { return this._mappingType; }
            set { this._mappingType = value; }
        }

        // Check to see if MappingType property is set
        internal bool IsSetMappingType()
        {
            return this._mappingType != null;
        }

        /// <summary>
        /// Gets and sets the property OutputFileContent. 
        /// <para>
        /// Provide the contents of a sample X12 EDI file (for outbound EDI) or JSON/XML file
        /// (for inbound EDI) to use as a target for the mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=5000000)]
        public string OutputFileContent
        {
            get { return this._outputFileContent; }
            set { this._outputFileContent = value; }
        }

        // Check to see if OutputFileContent property is set
        internal bool IsSetOutputFileContent()
        {
            return this._outputFileContent != null;
        }

    }
}