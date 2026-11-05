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
    /// This is the response object from the CreateBuild operation.
    /// </summary>
    public partial class CreateBuildResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Build. 
        /// <para>
        /// The newly created build resource, including a unique build ID and status. 
        /// </para>
        /// </summary>
        public Build Build { get; set; }

        /// <summary>
        /// Checks to see if the Build property is set.
        /// </summary>
        internal bool IsSetBuild() => this.Build != null;

        /// <summary>
        /// Gets and sets the property StorageLocation. 
        /// <para>
        /// Amazon S3 location for your game build file, including bucket name and key.
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
        /// This element is returned only when the operation is called without a storage location.
        /// It contains credentials to use when you are uploading a build file to an Amazon S3
        /// bucket that is owned by Amazon GameLift Servers. Credentials have a limited life span.
        /// To refresh these credentials, call <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_RequestUploadCredentials.html">RequestUploadCredentials</a>.
        /// 
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
