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
    /// This is the response object from the RequestUploadCredentials operation.
    /// </summary>
    public partial class RequestUploadCredentialsResponse : AmazonWebServiceResponse
    {
        private S3Location _storageLocation;
        private Credentials _uploadCredentials;

        /// <summary>
        /// Gets and sets the property StorageLocation. 
        /// <para>
        /// Amazon S3 path and key, identifying where the game build files are stored.
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
        /// Amazon Web Services credentials required when uploading a game build to the storage
        /// location. These credentials have a limited lifespan and are valid only for the build
        /// they were issued for.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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