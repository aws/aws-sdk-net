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
    /// This is the response object from the CreateUploadUrl operation.
    /// </summary>
    public partial class CreateUploadUrlResponse : AmazonWebServiceResponse
    {
        private string _codeArtifactId;
        private Dictionary<string, string> _requestHeaders = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _s3Url;

        /// <summary>
        /// Gets and sets the property CodeArtifactId. 
        /// <para>
        /// The identifier for the uploaded code resource. Pass this to <c>CreateScan</c> to use
        /// the uploaded resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CodeArtifactId
        {
            get { return this._codeArtifactId; }
            set { this._codeArtifactId = value; }
        }

        // Check to see if CodeArtifactId property is set
        internal bool IsSetCodeArtifactId()
        {
            return this._codeArtifactId != null;
        }

        /// <summary>
        /// Gets and sets the property RequestHeaders. 
        /// <para>
        /// A set of key-value pairs that contain the required headers when uploading your resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public Dictionary<string, string> RequestHeaders
        {
            get { return this._requestHeaders; }
            set { this._requestHeaders = value; }
        }

        // Check to see if RequestHeaders property is set
        internal bool IsSetRequestHeaders()
        {
            return this._requestHeaders != null && (this._requestHeaders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3Url. 
        /// <para>
        /// A pre-signed S3 URL. You can upload the code file you want to scan with the required
        /// <c>requestHeaders</c> using any HTTP client.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1)]
        public string S3Url
        {
            get { return this._s3Url; }
            set { this._s3Url = value; }
        }

        // Check to see if S3Url property is set
        internal bool IsSetS3Url()
        {
            return this._s3Url != null;
        }

    }
}