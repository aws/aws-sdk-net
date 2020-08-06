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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// The result structure for the create a new deployment request.
    /// </summary>
    public partial class CreateDeploymentResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _fileUploadUrls = new Dictionary<string, string>();
        private string _jobId;
        private string _zipUploadUrl;

        /// <summary>
        /// Gets and sets the property FileUploadUrls. 
        /// <para>
        ///  When the <code>fileMap</code> argument is provided in the request, <code>fileUploadUrls</code>
        /// will contain a map of file names to upload URLs. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> FileUploadUrls
        {
            get { return this._fileUploadUrls; }
            set { this._fileUploadUrls = value; }
        }

        // Check to see if FileUploadUrls property is set
        internal bool IsSetFileUploadUrls()
        {
            return this._fileUploadUrls != null && this._fileUploadUrls.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        ///  The job ID for this deployment. will supply to start deployment api. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property ZipUploadUrl. 
        /// <para>
        ///  When the <code>fileMap</code> argument is not provided in the request, this <code>zipUploadUrl</code>
        /// is returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1000)]
        public string ZipUploadUrl
        {
            get { return this._zipUploadUrl; }
            set { this._zipUploadUrl = value; }
        }

        // Check to see if ZipUploadUrl property is set
        internal bool IsSetZipUploadUrl()
        {
            return this._zipUploadUrl != null;
        }

    }
}