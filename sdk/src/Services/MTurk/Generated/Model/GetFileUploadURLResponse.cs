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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
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
namespace Amazon.MTurk.Model
{
    /// <summary>
    /// This is the response object from the GetFileUploadURL operation.
    /// </summary>
    public partial class GetFileUploadURLResponse : AmazonWebServiceResponse
    {
        private string _fileUploadURL;

        /// <summary>
        /// Gets and sets the property FileUploadURL. 
        /// <para>
        ///  A temporary URL for the file that the Worker uploaded for the answer. 
        /// </para>
        /// </summary>
        public string FileUploadURL
        {
            get { return this._fileUploadURL; }
            set { this._fileUploadURL = value; }
        }

        // Check to see if FileUploadURL property is set
        internal bool IsSetFileUploadURL()
        {
            return this._fileUploadURL != null;
        }

    }
}