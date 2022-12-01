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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// This is the response object from the CreateBuild operation.
    /// </summary>
    public partial class CreateBuildResponse : AmazonWebServiceResponse
    {
        private Build _build;
        private S3Location _storageLocation;
        private Credentials _uploadCredentials;

        /// <summary>
        /// Gets and sets the property Build. 
        /// <para>
        /// The newly created build resource, including a unique build IDs and status. 
        /// </para>
        /// </summary>
        public Build Build
        {
            get { return this._build; }
            set { this._build = value; }
        }

        // Check to see if Build property is set
        internal bool IsSetBuild()
        {
            return this._build != null;
        }

        /// <summary>
        /// Gets and sets the property StorageLocation. 
        /// <para>
        /// Amazon S3 location for your game build file, including bucket name and key.
        /// </para>
        /// </summary>
        public S3Location StorageLocation
        {
            get { return this._storageLocation; }
            set { this._storageLocation = value; }
        }

        // Check to see if StorageLocation property is set
        internal bool IsSetStorageLocation()
        {
            return this._storageLocation != null;
        }

        /// <summary>
        /// Gets and sets the property UploadCredentials. 
        /// <para>
        /// This element is returned only when the operation is called without a storage location.
        /// It contains credentials to use when you are uploading a build file to an Amazon S3
        /// bucket that is owned by Amazon GameLift. Credentials have a limited life span. To
        /// refresh these credentials, call <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_RequestUploadCredentials.html">RequestUploadCredentials</a>.
        /// 
        /// </para>
        /// </summary>
        public Credentials UploadCredentials
        {
            get { return this._uploadCredentials; }
            set { this._uploadCredentials = value; }
        }

        // Check to see if UploadCredentials property is set
        internal bool IsSetUploadCredentials()
        {
            return this._uploadCredentials != null;
        }

    }
}