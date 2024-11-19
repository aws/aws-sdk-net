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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
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
namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// The tax registration document.
    /// </summary>
    public partial class TaxRegistrationDocFile
    {
        private MemoryStream _fileContent;
        private string _fileName;

        /// <summary>
        /// Gets and sets the property FileContent. 
        /// <para>
        /// The tax registration document content. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5242880)]
        public MemoryStream FileContent
        {
            get { return this._fileContent; }
            set { this._fileContent = value; }
        }

        // Check to see if FileContent property is set
        internal bool IsSetFileContent()
        {
            return this._fileContent != null;
        }

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The tax registration document name. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FileName
        {
            get { return this._fileName; }
            set { this._fileName = value; }
        }

        // Check to see if FileName property is set
        internal bool IsSetFileName()
        {
            return this._fileName != null;
        }

    }
}