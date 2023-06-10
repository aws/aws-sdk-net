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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// This is the response object from the CreateUploadUrl operation.
    /// </summary>
    public partial class CreateUploadUrlResponse : AmazonWebServiceResponse
    {
        private string _importId;
        private string _uploadUrl;

        /// <summary>
        /// Gets and sets the property ImportId. 
        /// <para>
        /// An identifier for a unique import job. Use it when you call the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_StartImport.html">StartImport</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string ImportId
        {
            get { return this._importId; }
            set { this._importId = value; }
        }

        // Check to see if ImportId property is set
        internal bool IsSetImportId()
        {
            return this._importId != null;
        }

        /// <summary>
        /// Gets and sets the property UploadUrl. 
        /// <para>
        /// A pre-signed S3 write URL. Upload the zip archive file that contains the definition
        /// of your bot or bot locale.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string UploadUrl
        {
            get { return this._uploadUrl; }
            set { this._uploadUrl = value; }
        }

        // Check to see if UploadUrl property is set
        internal bool IsSetUploadUrl()
        {
            return this._uploadUrl != null;
        }

    }
}