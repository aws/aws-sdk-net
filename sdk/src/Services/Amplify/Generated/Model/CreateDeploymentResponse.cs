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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Amplify.Model
{
    /// <summary>
    /// The result structure for the create a new deployment request.
    /// </summary>
    public partial class CreateDeploymentResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _fileUploadUrls = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _jobId;
        private string _zipUploadUrl;

        /// <summary>
        /// Gets and sets the property FileUploadUrls. 
        /// <para>
        ///  When the <c>fileMap</c> argument is provided in the request, <c>fileUploadUrls</c>
        /// will contain a map of file names to upload URLs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._fileUploadUrls != null && (this._fileUploadUrls.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        ///  When the <c>fileMap</c> argument is not provided in the request, this <c>zipUploadUrl</c>
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