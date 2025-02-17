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
    /// The exemption certificate.
    /// </summary>
    public partial class ExemptionCertificate
    {
        private MemoryStream _documentFile;
        private string _documentName;

        /// <summary>
        /// Gets and sets the property DocumentFile. 
        /// <para>
        /// The exemption certificate file content. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4194304)]
        public MemoryStream DocumentFile
        {
            get { return this._documentFile; }
            set { this._documentFile = value; }
        }

        // Check to see if DocumentFile property is set
        internal bool IsSetDocumentFile()
        {
            return this._documentFile != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The exemption certificate file name. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string DocumentName
        {
            get { return this._documentName; }
            set { this._documentName = value; }
        }

        // Check to see if DocumentName property is set
        internal bool IsSetDocumentName()
        {
            return this._documentName != null;
        }

    }
}