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
    /// This is the response object from the TestParsing operation.
    /// </summary>
    public partial class TestParsingResponse : AmazonWebServiceResponse
    {
        private string _parsedFileContent;

        /// <summary>
        /// Gets and sets the property ParsedFileContent. 
        /// <para>
        /// Returns the contents of the input file being tested, parsed according to the specified
        /// EDI (electronic data interchange) type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ParsedFileContent
        {
            get { return this._parsedFileContent; }
            set { this._parsedFileContent = value; }
        }

        // Check to see if ParsedFileContent property is set
        internal bool IsSetParsedFileContent()
        {
            return this._parsedFileContent != null;
        }

    }
}