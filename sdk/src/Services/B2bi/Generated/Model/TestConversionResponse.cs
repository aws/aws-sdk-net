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
    /// This is the response object from the TestConversion operation.
    /// </summary>
    public partial class TestConversionResponse : AmazonWebServiceResponse
    {
        private string _convertedFileContent;
        private List<string> _validationMessages = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ConvertedFileContent. 
        /// <para>
        /// Returns the converted file content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConvertedFileContent
        {
            get { return this._convertedFileContent; }
            set { this._convertedFileContent = value; }
        }

        // Check to see if ConvertedFileContent property is set
        internal bool IsSetConvertedFileContent()
        {
            return this._convertedFileContent != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationMessages. 
        /// <para>
        /// Returns an array of strings, each containing a message that Amazon Web Services B2B
        /// Data Interchange generates during the conversion.
        /// </para>
        /// </summary>
        public List<string> ValidationMessages
        {
            get { return this._validationMessages; }
            set { this._validationMessages = value; }
        }

        // Check to see if ValidationMessages property is set
        internal bool IsSetValidationMessages()
        {
            return this._validationMessages != null && (this._validationMessages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}