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
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
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
namespace Amazon.CodeGuruSecurity.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUploadUrl operation.
    /// Generates a pre-signed URL, request headers used to upload a code resource, and code
    /// artifact identifier for the uploaded resource.
    /// 
    ///  
    /// <para>
    /// You can upload your code resource to the URL with the request headers using any HTTP
    /// client.
    /// </para>
    /// </summary>
    public partial class CreateUploadUrlRequest : AmazonCodeGuruSecurityRequest
    {
        private string _scanName;

        /// <summary>
        /// Gets and sets the property ScanName. 
        /// <para>
        /// The name of the scan that will use the uploaded resource. CodeGuru Security uses the
        /// unique scan name to track revisions across multiple scans of the same resource. Use
        /// this <c>scanName</c> when you call <c>CreateScan</c> on the code resource you upload
        /// to this URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string ScanName
        {
            get { return this._scanName; }
            set { this._scanName = value; }
        }

        // Check to see if ScanName property is set
        internal bool IsSetScanName()
        {
            return this._scanName != null;
        }

    }
}