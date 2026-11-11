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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// This is the response object from the RequestUploadCredentials operation.
    /// </summary>
    public partial class RequestUploadCredentialsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property StorageLocation. 
        /// <para>
        /// Amazon S3 path and key, identifying where the game build files are stored.
        /// </para>
        /// </summary>
        public S3Location StorageLocation { get; set; }

        /// <summary>
        /// Checks to see if the StorageLocation property is set.
        /// </summary>
        internal bool IsSetStorageLocation() => this.StorageLocation != null;

        /// <summary>
        /// Gets and sets the property UploadCredentials. 
        /// <para>
        /// Amazon Web Services credentials required when uploading a game build to the storage
        /// location. These credentials have a limited lifespan and are valid only for the build
        /// they were issued for.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Credentials UploadCredentials { get; set; }

        /// <summary>
        /// Checks to see if the UploadCredentials property is set.
        /// </summary>
        internal bool IsSetUploadCredentials() => this.UploadCredentials != null;
    }
}
